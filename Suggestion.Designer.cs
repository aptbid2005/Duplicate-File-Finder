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
	public partial class Suggestion : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suggestion));
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.inName = new System.Windows.Forms.TextBox();
			this.inSuggestion = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.inEmail = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(14, 50);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(75, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Your Name:";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(14, 105);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(75, 13);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Suggestion:";
			//
			//inName
			//
			this.inName.Location = new System.Drawing.Point(95, 47);
			this.inName.Name = "inName";
			this.inName.Size = new System.Drawing.Size(419, 21);
			this.inName.TabIndex = 0;
			//
			//inSuggestion
			//
			this.inSuggestion.AcceptsReturn = true;
			this.inSuggestion.AcceptsTab = true;
			this.inSuggestion.Location = new System.Drawing.Point(94, 102);
			this.inSuggestion.Multiline = true;
			this.inSuggestion.Name = "inSuggestion";
			this.inSuggestion.Size = new System.Drawing.Size(419, 132);
			this.inSuggestion.TabIndex = 2;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(94, 240);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(201, 23);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "Submit Your Suggestion";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(302, 240);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(142, 23);
			this.Button2.TabIndex = 4;
			this.Button2.Text = "Close Window";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Label3
			//
			this.Label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label3.Location = new System.Drawing.Point(14, 9);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(500, 35);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "The information you enter into this window will be sent to The Professional Devel" +
				"oper. Make sure your internet connection is on and active.";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(17, 79);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(73, 13);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "Your Email:";
			//
			//inEmail
			//
			this.inEmail.Location = new System.Drawing.Point(94, 76);
			this.inEmail.Name = "inEmail";
			this.inEmail.Size = new System.Drawing.Size(352, 21);
			this.inEmail.TabIndex = 1;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(452, 79);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(64, 13);
			this.Label5.TabIndex = 9;
			this.Label5.Text = "(Optional)";
			//
			//Suggestion
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 278);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.inEmail);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.inSuggestion);
			this.Controls.Add(this.inName);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Label3);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Suggestion";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Make A Suggestion";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

			Button2.Click += new System.EventHandler(Button2_Click);
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox inName;
		internal System.Windows.Forms.TextBox inSuggestion;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox inEmail;
		internal System.Windows.Forms.Label Label5;

		private static Suggestion _DefaultInstance;
		public static Suggestion DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null || _DefaultInstance.IsDisposed)
					_DefaultInstance = new Suggestion();

				return _DefaultInstance;
			}
		}
	}

}