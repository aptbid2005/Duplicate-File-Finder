//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Windows.Forms;

namespace DuplicateFileFinder
{
	public partial class DataError
	{

		public DataError()
		{
			InitializeComponent();
		}

	    public Exception DataErrorRenamed { get; set; }


	    private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}

	}
}