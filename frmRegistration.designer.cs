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
	internal partial class frmRegistration : System.Windows.Forms.Form
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
			this.Label2 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnUnlock = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.inEmailAddress = new System.Windows.Forms.TextBox();
			this.inOrderNumber = new System.Windows.Forms.TextBox();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			//
			//Label2
			//
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label2.Location = new System.Drawing.Point(12, 9);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(344, 112);
			this.Label2.TabIndex = 1;
			this.Label2.Text = resources.GetString("Label2.Text");
			//
			//btnCancel
			//
			this.btnCancel.Location = new System.Drawing.Point(284, 190);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			//
			//btnUnlock
			//
			this.btnUnlock.Location = new System.Drawing.Point(203, 190);
			this.btnUnlock.Name = "btnUnlock";
			this.btnUnlock.Size = new System.Drawing.Size(75, 23);
			this.btnUnlock.TabIndex = 2;
			this.btnUnlock.Text = "Unlock";
			this.btnUnlock.UseVisualStyleBackColor = true;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(14, 140);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(76, 13);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Email Address:";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(14, 167);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(76, 13);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Order Number:";
			//
			//inEmailAddress
			//
			this.inEmailAddress.Location = new System.Drawing.Point(96, 137);
			this.inEmailAddress.Name = "inEmailAddress";
			this.inEmailAddress.Size = new System.Drawing.Size(263, 20);
			this.inEmailAddress.TabIndex = 0;
			this.ToolTip1.SetToolTip(this.inEmailAddress, "This is the email address you used when purchasing this program");
			//
			//inOrderNumber
			//
			this.inOrderNumber.Location = new System.Drawing.Point(96, 164);
			this.inOrderNumber.Name = "inOrderNumber";
			this.inOrderNumber.Size = new System.Drawing.Size(263, 20);
			this.inOrderNumber.TabIndex = 1;
			this.ToolTip1.SetToolTip(this.inOrderNumber, "The order number that you have received when purchasing this program.");
			//
			//ToolTip1
			//
			this.ToolTip1.IsBalloon = true;
			this.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.ToolTip1.ToolTipTitle = "Screen Shot Pro";
			//
			//frmRegistration
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 232);
			this.Controls.Add(this.inOrderNumber);
			this.Controls.Add(this.inEmailAddress);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.btnUnlock);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.Label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "frmRegistration";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Unlock This Program";
			this.ResumeLayout(false);
			this.PerformLayout();

			btnCancel.Click += new System.EventHandler(btnCancel_Click);
		}
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button btnCancel;
		internal System.Windows.Forms.Button btnUnlock;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox inEmailAddress;
		internal System.Windows.Forms.TextBox inOrderNumber;
		internal System.Windows.Forms.ToolTip ToolTip1;
	}

}