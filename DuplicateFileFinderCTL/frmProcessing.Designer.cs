using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace DuplicateFileFinderCTL
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class FrmProcessing : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProcessing));
			this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.lblMessage = new System.Windows.Forms.Label();
			this.btnStopSearch = new System.Windows.Forms.Button();
			this.lblDirectories = new System.Windows.Forms.Label();
			this.lblFiles = new System.Windows.Forms.Label();
			this.lblCurrentDir = new System.Windows.Forms.Label();
			this.lblCurrentFile = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//ProgressBar1
			//
			this.ProgressBar1.Location = new System.Drawing.Point(14, 102);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(603, 27);
			this.ProgressBar1.TabIndex = 0;
			//
			//lblMessage
			//
			this.lblMessage.AutoSize = true;
			this.lblMessage.Location = new System.Drawing.Point(14, 10);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(58, 15);
			this.lblMessage.TabIndex = 1;
			this.lblMessage.Text = "Message";
			//
			//btnStopSearch
			//
			this.btnStopSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStopSearch.Location = new System.Drawing.Point(493, 135);
			this.btnStopSearch.Name = "btnStopSearch";
			this.btnStopSearch.Size = new System.Drawing.Size(126, 27);
			this.btnStopSearch.TabIndex = 2;
			this.btnStopSearch.Text = "Stop Search   ";
			this.btnStopSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnStopSearch.UseVisualStyleBackColor = true;
			//
			//lblDirectories
			//
			this.lblDirectories.AutoSize = true;
			this.lblDirectories.Location = new System.Drawing.Point(14, 39);
			this.lblDirectories.Name = "lblDirectories";
			this.lblDirectories.Size = new System.Drawing.Size(69, 15);
			this.lblDirectories.TabIndex = 3;
			this.lblDirectories.Text = "Directories:";
			//
			//lblFiles
			//
			this.lblFiles.AutoSize = true;
			this.lblFiles.Location = new System.Drawing.Point(14, 68);
			this.lblFiles.Name = "lblFiles";
			this.lblFiles.Size = new System.Drawing.Size(36, 15);
			this.lblFiles.TabIndex = 4;
			this.lblFiles.Text = "Files:";
			//
			//lblCurrentDir
			//
			this.lblCurrentDir.AutoSize = true;
			this.lblCurrentDir.Location = new System.Drawing.Point(199, 39);
			this.lblCurrentDir.Name = "lblCurrentDir";
			this.lblCurrentDir.Size = new System.Drawing.Size(62, 15);
			this.lblCurrentDir.TabIndex = 6;
			this.lblCurrentDir.Text = "Currnt Dir:";
			//
			//lblCurrentFile
			//
			this.lblCurrentFile.AutoSize = true;
			this.lblCurrentFile.Location = new System.Drawing.Point(199, 68);
			this.lblCurrentFile.Name = "lblCurrentFile";
			this.lblCurrentFile.Size = new System.Drawing.Size(73, 15);
			this.lblCurrentFile.TabIndex = 7;
			this.lblCurrentFile.Text = "Current File:";
			//
			//frmProcessing
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7.0F, 15.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 175);
			this.Controls.Add(this.lblCurrentFile);
			this.Controls.Add(this.lblCurrentDir);
			this.Controls.Add(this.lblFiles);
			this.Controls.Add(this.lblDirectories);
			this.Controls.Add(this.btnStopSearch);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.ProgressBar1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmProcessing";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Searching for duplicate files....";
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			btnStopSearch.Click += new System.EventHandler(btnStopSearch_Click);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frmProcessing_FormClosing);
		}
		internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
		internal System.Windows.Forms.ProgressBar ProgressBar1;
		internal System.Windows.Forms.Label lblMessage;
		internal System.Windows.Forms.Button btnStopSearch;
		internal System.Windows.Forms.Label lblDirectories;
		internal System.Windows.Forms.Label lblFiles;
		internal System.Windows.Forms.Label lblCurrentDir;
		internal System.Windows.Forms.Label lblCurrentFile;
	}

}