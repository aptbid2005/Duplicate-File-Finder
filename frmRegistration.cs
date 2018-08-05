using System;
using System.Windows.Forms;

namespace DuplicateFileFinder
{
	internal partial class frmRegistration
	{

		public frmRegistration()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(Object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

	}
}