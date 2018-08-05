//INSTANT C# NOTE: Formerly VB project-level imports:

namespace DuplicateFileFinder
{
	public sealed partial class About
	{

		public About()
		{
			InitializeComponent();
		}

		private void About_Load(System.Object sender, System.EventArgs e)
		{
			// Set the title of the form.
			string ApplicationTitle = null;
			if (!string.IsNullOrEmpty(My.MyApplication.Application.Info.Title))
			{
				ApplicationTitle = My.MyApplication.Application.Info.Title;
			}
			else
			{
				ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.MyApplication.Application.Info.AssemblyName);
			}
			this.Text = string.Format("About {0}", ApplicationTitle);
			// Initialize all of the text displayed on the About Box.
			// TODO: Customize the application's assembly information in the "Application" pane of the project 
			//    properties dialog (under the "Project" menu).
			this.LabelProductName.Text = My.MyApplication.Application.Info.ProductName;
			this.lblVersion.Text = string.Format("Version {0}", My.MyApplication.Application.Info.Version.ToString());
			this.LabelCopyright.Text = My.MyApplication.Application.Info.Copyright;
			this.LabelCompanyName.Text = My.MyApplication.Application.Info.CompanyName;
			this.TextBoxDescription.Text = My.MyApplication.Application.Info.Description;
		}

		private void OKButton_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}

	}

}