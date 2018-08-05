using System;
using System.Windows.Forms;

namespace DuplicateFileFinder
{
	public partial class CheckForUpdate
	{

		public CheckForUpdate()
		{
			InitializeComponent();
		}

		private string sUpdatePath = string.Empty;

		private void frmCheckForUpdate_Load(object sender, EventArgs e)
		{
		    this.LinkLabel1.Visible = false;
		    this.Label2.Visible = false;
		}


		private void LinkLabel1_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();

			fbd.ShowNewFolderButton = true;
			fbd.Tag = "Select the folder you wish to save this update too.";

			DialogResult dr = fbd.ShowDialog();

			if (dr == DialogResult.OK)
			{
				try
				{

					if (dr == DialogResult.OK)
					{
					    this.sUpdatePath = fbd.SelectedPath + "/Duplicate File Finder Update.zip";
						Uri uri = new Uri("http://www.theprodev.com/files/trials/DFF-00.zip");
						System.Net.WebClient wc = new System.Net.WebClient();
						wc.DownloadDataCompleted += DownloadDataCompleted;
						wc.DownloadDataAsync(uri);
					}

				}
				catch (System.Net.WebException ex)
				{
					MessageBox.Show("Sorry, but we were unable to contact the download server. Please browse to http://www.theprodev.com and download the new Free Version", "Could not connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}

		}

		private void DownloadDataCompleted(object sender, System.Net.DownloadDataCompletedEventArgs e)
		{
			System.IO.File.WriteAllBytes(this.sUpdatePath, e.Result);
			MessageBox.Show("Your download is complete. Unzip and double click the install file to update.", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void Button1_Click(Object sender, EventArgs e)
		{
			Close();
		}

	}
}