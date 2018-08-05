using System.Collections;

namespace DuplicateFileFinderCTL
{
	public partial class FrmProcessing
	{

		public delegate void LoadDataEventHandler();
		public event LoadDataEventHandler LoadData;

		private readonly Logic b;
		private readonly System.Threading.Thread thread;

		public FrmProcessing(string path, bool subDirectories, ArrayList fileTypes)
		{
			InitializeComponent();
		    this.b = new Logic(path, fileTypes, subDirectories);
		    this.b.DisplayMessage += DisplayMessage;
		    this.b.UpdateProgress += UpdateProgress;
		    this.b.UpdateDirectories += UpdateDirectories;
		    this.b.UpdateFiles += UpdateFiles;
		    this.b.CurrentDirectory += CurrentDirectory;
		    this.b.CurrentFile += CurrentFile;
		    this.b.LoadData += Finished;

		    this.thread = new System.Threading.Thread(this.b.StartScan);
		    this.thread.SetApartmentState(System.Threading.ApartmentState.STA);
		    this.thread.Start();

		}

		public void Finished()
		{
		    LoadData?.Invoke();
		    this.b.Dispose();
		}

		private delegate void DisplayMessageCallback(string message);
	    public void DisplayMessage(string message)
		{
			if (this.lblMessage.InvokeRequired == true)
			{
				DisplayMessageCallback aDelegate = DisplayMessage;
				Invoke(aDelegate, message);
			}
			else
			{
			    this.lblMessage.Text = message;
			}
		}

		private delegate void UpdateProgressCallback(int value);
	    public void UpdateProgress(int value)
		{
			if (this.ProgressBar1.InvokeRequired == true)
			{
				UpdateProgressCallback aDelegate = UpdateProgress;
				Invoke(aDelegate, value);
			}
			else
			{
			    this.ProgressBar1.Value = value;
			}
		}

		private delegate void UpdateDirectoriesCallback(string message);
	    public void UpdateDirectories(string message)
		{
			if (this.lblDirectories.InvokeRequired == true)
			{
				UpdateDirectoriesCallback aDelegate = UpdateDirectories;
				Invoke(aDelegate, message);
			}
			else
			{
			    this.lblDirectories.Text = "Directories: " + message;
			}
		}

		private delegate void UpdateFilesCallback(string message);
	    public void UpdateFiles(string message)
		{
			if (this.lblFiles.InvokeRequired == true)
			{
				UpdateFilesCallback aDelegate = UpdateFiles;
				Invoke(aDelegate, message);
			}
			else
			{
			    this.lblFiles.Text = "Files: " + message;
			}
		}

		private delegate void CurrentDirectoryCallBack(string dir);
	    public void CurrentDirectory(string dir)
		{
			if (this.lblCurrentDir.InvokeRequired == true)
			{
				CurrentDirectoryCallBack aDelegate = CurrentDirectory;
				Invoke(aDelegate, dir);
			}
			else
			{
				if (dir.Length > 32)
				{
					int len = dir.Length;
				    this.lblCurrentDir.Text = "Current Dir: ..." + dir.Substring(len - 32);
				}
				else
				{
				    this.lblCurrentDir.Text = "Current Dir: " + dir;
				}
			}
		}

		private delegate void CurrentFileCallback(string file);
	    public void CurrentFile(string file)
		{
			if (this.lblCurrentFile.InvokeRequired == true)
			{
				CurrentFileCallback aDelegate = CurrentFile;
				Invoke(aDelegate, file);
			}
			else
			{
				if (file.Length > 32)
				{
					int len = file.Length;
				    this.lblCurrentFile.Text = "Current File: ..." + file.Substring(len - 32);
				}
				else
				{
				    this.lblCurrentFile.Text = "Current File: " + file;
				}
			}
		}

		private void btnStopSearch_Click(object sender, System.EventArgs e)
		{
			if (this.thread.IsAlive)
			{
			    this.thread.Abort();
				Close();
			}
		}

		private void frmProcessing_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			if (this.thread.IsAlive)
			{
			    this.thread.Abort();
			}
		}

	}
}