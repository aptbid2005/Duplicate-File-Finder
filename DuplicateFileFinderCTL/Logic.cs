using System;
using System.Collections;
using System.Data;

namespace DuplicateFileFinderCTL
{
	public class Logic : IDisposable
	{
#region  Variables 

		private int analyseDirectoryCount;
		private int scanDirectoryCount;
		private int analyseFileCount;
		private int scanFileCount;
		private readonly string startLocation;
		private readonly ArrayList itemsList;
        private readonly bool scanSubDir;

		internal delegate void UpdateProgressEventHandler(int value);
		internal event UpdateProgressEventHandler UpdateProgress;
		internal delegate void UpdateDirectoriesEventHandler(string count);
		internal event UpdateDirectoriesEventHandler UpdateDirectories;
		internal delegate void UpdateFilesEventHandler(string count);
		internal event UpdateFilesEventHandler UpdateFiles;
		internal delegate void DisplayMessageEventHandler(string message);
		internal event DisplayMessageEventHandler DisplayMessage;
		internal delegate void CurrentDirectoryEventHandler(string dir);
		internal event CurrentDirectoryEventHandler CurrentDirectory;
		internal delegate void CurrentFileEventHandler(string file);
		internal event CurrentFileEventHandler CurrentFile;
		internal delegate void LoadDataEventHandler();
		internal event LoadDataEventHandler LoadData;

#endregion

#region  Enumerations 

		private enum ScanMode
		{
			AnalyseDirectoryStructure,
			PerformScan
		}

        #endregion

        #region  Properties 

        public dsFileInfo FileInfo { get; }

        #endregion

        public Logic(string startLocation, ArrayList checkedItems, bool scanSubDirs)
		{
			this.startLocation = startLocation;
			this.itemsList = checkedItems;
			this.scanSubDir = scanSubDirs;

			if (FileInfo == null)
			{
				FileInfo = new dsFileInfo();
			}
		}

		public void StartScan()
		{
			// Step 1 - Analyse the directory structure
		    DisplayMessage?.Invoke("Step 1 of 3 - Collecting information about the structure of " + this.startLocation + ".");
		    if (this.scanSubDir)
			{
				GetDirectoryStructure(this.startLocation, ScanMode.AnalyseDirectoryStructure);
			}
			else
			{
				GetFiles(this.startLocation, ScanMode.AnalyseDirectoryStructure);
			}

			// Step 2 - Perform Scan
		    DisplayMessage?.Invoke("Step 2 of 3 - Searching for duplicate files. When this process is complete data will be analyze and displayed.");
		    if (this.scanSubDir)
			{
				GetDirectoryStructure(this.startLocation, ScanMode.PerformScan);
			}
			else
			{
				GetFiles(this.startLocation, ScanMode.PerformScan);
			}

			// Step 3 - Analyse the data
		    DisplayMessage?.Invoke("Step 3 of 3 - Analyzing file data and preparing for display.");
		    Analyzedata();

		}

		private void GetDirectoryStructure(string path, ScanMode mode)
		{
			try
			{
				foreach (string d in System.IO.Directory.GetDirectories(path))
				{
				    CurrentDirectory?.Invoke(path);
				    if (mode == ScanMode.AnalyseDirectoryStructure)
					{
						this.analyseDirectoryCount += 1;
					    UpdateDirectories?.Invoke(this.analyseDirectoryCount.ToString());
					}
					else
					{
						this.scanDirectoryCount += 1;
					    UpdateDirectories?.Invoke(this.scanDirectoryCount + " of " + this.analyseDirectoryCount);
					}

					GetFiles(d, mode);
					GetDirectoryStructure(d, mode);
				}
			}
			catch (UnauthorizedAccessException ex)
			{

			}
		}

		private void GetFiles(string filePath, ScanMode mode)
		{
			try
			{
				foreach (string str in System.IO.Directory.GetFiles(filePath))
				{
					System.IO.FileInfo fi = new System.IO.FileInfo(str);

				    if (!this.itemsList.Contains(fi.Extension.ToUpper())) continue;
				    if (mode == ScanMode.AnalyseDirectoryStructure)
				    {
				        this.analyseFileCount += 1;
				        UpdateFiles?.Invoke(this.analyseFileCount.ToString());
				    }
				    else
				    {
				        this.scanFileCount += 1;
				        UpdateFiles?.Invoke(this.scanFileCount + " of " + this.analyseFileCount);
				        UpdateProgress?.Invoke(Convert.ToInt32((this.scanFileCount / (double)this.analyseFileCount) * 100));
				        ScanFile(str);
				    }
				}
			}
			catch (UnauthorizedAccessException ex)
			{

			}
		}

		private void ScanFile(string filePath)
		{
			try
			{
				// Added this so if a setattributes fails it won't add it to the list
				bool addFile = true;
				System.IO.FileInfo fi = new System.IO.FileInfo(filePath);
			    CurrentFile?.Invoke(fi.Name);

			    decimal byteValue = 0.0M;
				Int64 tally = 0;

				if (Globals.SearchType == "Byte")
				{
					try
					{
						System.IO.File.SetAttributes(filePath, System.IO.FileAttributes.Normal);
						using (System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Open))
						{
							for (int i = 0; i < fs.Length; i++)
							{
								tally += fs.ReadByte();
							}
							byteValue = Convert.ToDecimal(tally / (double)(fs.Length - 1));
							fs.Close();
						}
					}
					catch (UnauthorizedAccessException ex)
					{
						// Skip file as it won't uncheck readonly
						addFile = false;
					}
				}

				string filename = fi.Name.ToLower();

				if (filename.StartsWith("copy"))
				{
					filename = filename.Replace("copy of ", "");
				}

				if (addFile)
				{
					FileInfo.FileInfo.AddFileInfoRow(filename, fi.Length, fi.Extension.ToLower(), fi.CreationTime, byteValue, filePath, 0);
				}
			}
			catch (System.IO.IOException ex)
			{

			}
		}

		private void Analyzedata()
		{
			DataView dv = new DataView(FileInfo.Tables[0]);

			int j = 0;
			int i;
			string test;
			string control = string.Empty;

			switch (Globals.SearchType)
			{
				case "Byte":
					dv.Sort = "UID Asc";

					for (i = 1; i < dv.Count; i++)
					{
					    if (Convert.ToDecimal(dv[i]["UID"]) != Convert.ToDecimal(dv[i - 1]["UID"])) continue;
					    test = Convert.ToString(dv[i - 1]["UID"]);

					    if (test != control)
					    {
					        control = test;
					        j += 1;
					    }

					    dv[i]["Duplicate"] = j;
					    dv[i - 1]["Duplicate"] = j;
					}


					break;
				case "Name":
					dv.Sort = "Name Desc";

					for (i = 1; i < dv.Count; i++)
					{
					    if (dv[i]["Name"].ToString().ToLower() != dv[i - 1]["Name"].ToString().ToLower()) continue;
					    test = dv[i - 1]["Name"].ToString().ToLower();

					    if (test != control)
					    {
					        control = test;
					        j += 1;
					    }

					    dv[i]["Duplicate"] = j;
					    dv[i - 1]["Duplicate"] = j;
					}

					break;
			}

			for (int k = 0; k < dv.Count; k++)
			{
				if (Convert.ToInt32(dv[k]["Duplicate"]) != 0)
				{
					Globals.AddNewRow(dv[k]["Name"].ToString(), Math.Round((double)dv[k]["Size"], 2), dv[k]["Type"].ToString(), Convert.ToDateTime(dv[k]["CreateDate"]), Convert.ToDecimal(dv[k]["UID"]), dv[k]["Path"].ToString());
				}
			}

		    LoadData?.Invoke(); //j, i + 1

		}

#region  IDisposable Support 

		private bool disposedValue; // To detect redundant calls

		// IDisposable
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
				if (disposing)
				{
					FileInfo.Dispose();
				}

				// TODO: free your own state (unmanaged objects).
				// TODO: set large fields to null.
			}
			this.disposedValue = true;
		}

		// This code added by Visual Basic to correctly implement the disposable pattern.
		public void Dispose()
		{
			// Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
			Dispose(true);
			GC.SuppressFinalize(this);
		}
#endregion

	}
}