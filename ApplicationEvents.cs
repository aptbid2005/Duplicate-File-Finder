using System;
using System.Windows.Forms;

namespace DuplicateFileFinder
{
	namespace My
	{
	    internal partial class MyApplication
	    {

	        #region  Variables 

	        private static string mKeyCode = string.Empty;
	        private static string sUpdatePath = string.Empty;

	        #endregion

	        #region  Properties 

	        internal string RegKey => "Software\\TPD\\DFF";

	        internal string AppInfo => My.MyApplication.Application.Info.Version.Major + "." +
	                                   My.MyApplication.Application.Info.Version.Minor + "." +
	                                   My.MyApplication.Application.Info.Version.Build;

	        internal int AppVer => My.MyApplication.Application.Info.Version.Major +
	                                  My.MyApplication.Application.Info.Version.Minor +
	                                  My.MyApplication.Application.Info.Version.Build;

	        internal Int16 ProgramID => 13;

	        #endregion

	        internal string GetSiteLink(string Location)
	        {
	            return "http://www.theprodev.com/13/DuplicateFileFinder.aspx?ref=" + Location + "&Ver=" +
	                   My.MyApplication.Application.AppVer;
	        }


	        private void MyApplication_UnhandledException(object sender,
	            Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
	        {
	            if (e.Exception != null)
	            {
	                e.ExitApplication = false;
	                DataError.DefaultInstance.DataErrorRenamed = e.Exception;
	                DataError.DefaultInstance.ShowDialog();
	            }
	        }


	        private void DownloadDataCompleted(object sender, System.Net.DownloadDataCompletedEventArgs e)
	        {
	            System.IO.File.WriteAllBytes(sUpdatePath, e.Result);
	            MessageBox.Show("Your download is complete. Unzip and double click the install file to update.",
	                "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
	        }


	        private static MyApplication MyApp;
	        internal static MyApplication Application => MyApp;

	        [STAThread]
	        static void Main(string[] args)
	        {
	            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
	            MyApp = new MyApplication();
	            MyApp.Run(args);
	        }

	    }
	}
}