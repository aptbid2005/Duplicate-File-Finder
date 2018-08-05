//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace DuplicateFileFinder
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class CheckForUpdate : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckForUpdate));
			this.Label1 = new System.Windows.Forms.Label();
			this.btnCheckForUpdate = new System.Windows.Forms.Button();
			this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
			this.Label2 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label1.Location = new System.Drawing.Point(14, 9);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(493, 56);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Clicking 'Check For Update' will automatically check to make sure you have the mo" +
				"st current version of this program. Make sure your internet connection is on and" +
				" active.";
			//
			//btnCheckForUpdate
			//
			this.btnCheckForUpdate.Location = new System.Drawing.Point(97, 86);
			this.btnCheckForUpdate.Name = "btnCheckForUpdate";
			this.btnCheckForUpdate.Size = new System.Drawing.Size(168, 23);
			this.btnCheckForUpdate.TabIndex = 1;
			this.btnCheckForUpdate.Text = "Check For Update";
			this.btnCheckForUpdate.UseVisualStyleBackColor = true;
			//
			//LinkLabel1
			//
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.Location = new System.Drawing.Point(105, 52);
			this.LinkLabel1.Name = "LinkLabel1";
			this.LinkLabel1.Size = new System.Drawing.Size(334, 13);
			this.LinkLabel1.TabIndex = 2;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "A newer version is available. Please click here to update.";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(17, 52);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(490, 31);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "No update is available at this time.";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(271, 86);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(155, 23);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "Close Window";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//CheckForUpdate
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 121);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.LinkLabel1);
			this.Controls.Add(this.btnCheckForUpdate);
			this.Controls.Add(this.Label1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CheckForUpdate";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Check For Update";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

			this.Load += new System.EventHandler(frmCheckForUpdate_Load);
			LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
			Button1.Click += new System.EventHandler(Button1_Click);
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button btnCheckForUpdate;
		internal System.Windows.Forms.LinkLabel LinkLabel1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button Button1;
	}

}