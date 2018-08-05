using System.Text;

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
	public partial class NewMain : System.Windows.Forms.Form
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
			Infragistics.Win.Appearance Appearance1 = new Infragistics.Win.Appearance();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMain));
			this.inPath = new System.Windows.Forms.TextBox();
			this.chkSubDirectories = new System.Windows.Forms.CheckBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.rbBinarySearch = new System.Windows.Forms.RadioButton();
			this.UltraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.btnExpand = new System.Windows.Forms.Button();
			this.btnBackup = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.tbImageFileTypes = new System.Windows.Forms.TabPage();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.btnImageSelect = new System.Windows.Forms.Button();
			this.btnImageDeselect = new System.Windows.Forms.Button();
			this.cblImageTypes = new System.Windows.Forms.CheckedListBox();
			this.tbDocumentTypes = new System.Windows.Forms.TabPage();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.btnDocSelect = new System.Windows.Forms.Button();
			this.btnDocDeselect = new System.Windows.Forms.Button();
			this.clbDocTypes = new System.Windows.Forms.CheckedListBox();
			this.tbVideoTypes = new System.Windows.Forms.TabPage();
			this.GroupBox8 = new System.Windows.Forms.GroupBox();
			this.btnVideoSelect = new System.Windows.Forms.Button();
			this.btnVideoDeselect = new System.Windows.Forms.Button();
			this.cblVideoTypes = new System.Windows.Forms.CheckedListBox();
			this.tbAudio = new System.Windows.Forms.TabPage();
			this.GroupBox9 = new System.Windows.Forms.GroupBox();
			this.btnAudioSelect = new System.Windows.Forms.Button();
			this.btnAudioDeselect = new System.Windows.Forms.Button();
			this.cblAudioTypes = new System.Windows.Forms.CheckedListBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.UltraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
			this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblHelp = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblSearchType = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutThisProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MakeASuggestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CheckForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.VisitOurWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UnlockThisProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.UltraGrid1).BeginInit();
			this.GroupBox2.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.tbImageFileTypes.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.tbDocumentTypes.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.tbVideoTypes.SuspendLayout();
			this.GroupBox8.SuspendLayout();
			this.tbAudio.SuspendLayout();
			this.GroupBox9.SuspendLayout();
			this.MenuStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//inPath
			//
			this.inPath.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.inPath.Location = new System.Drawing.Point(14, 72);
			this.inPath.Name = "inPath";
			this.inPath.Size = new System.Drawing.Size(692, 21);
			this.inPath.TabIndex = 0;
			//
			//chkSubDirectories
			//
			this.chkSubDirectories.AutoSize = true;
			this.chkSubDirectories.Checked = true;
			this.chkSubDirectories.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSubDirectories.Location = new System.Drawing.Point(12, 22);
			this.chkSubDirectories.Name = "chkSubDirectories";
			this.chkSubDirectories.Size = new System.Drawing.Size(152, 19);
			this.chkSubDirectories.TabIndex = 2;
			this.chkSubDirectories.Text = "Search Sub Directories";
			this.chkSubDirectories.UseVisualStyleBackColor = true;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.RadioButton2);
			this.GroupBox1.Controls.Add(this.rbBinarySearch);
			this.GroupBox1.Controls.Add(this.chkSubDirectories);
			this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.GroupBox1.Location = new System.Drawing.Point(14, 106);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(246, 108);
			this.GroupBox1.TabIndex = 3;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Search Options";
			//
			//RadioButton2
			//
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Location = new System.Drawing.Point(12, 75);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(166, 19);
			this.RadioButton2.TabIndex = 4;
			this.RadioButton2.Text = "Perform Filename Search";
			this.RadioButton2.UseVisualStyleBackColor = true;
			//
			//rbBinarySearch
			//
			this.rbBinarySearch.AutoSize = true;
			this.rbBinarySearch.Checked = true;
			this.rbBinarySearch.Location = new System.Drawing.Point(12, 48);
			this.rbBinarySearch.Name = "rbBinarySearch";
			this.rbBinarySearch.Size = new System.Drawing.Size(148, 19);
			this.rbBinarySearch.TabIndex = 3;
			this.rbBinarySearch.TabStop = true;
			this.rbBinarySearch.Text = "Perform Binary Search";
			this.rbBinarySearch.UseVisualStyleBackColor = true;
			//
			//UltraGrid1
			//
			this.UltraGrid1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.UltraGrid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
			this.UltraGrid1.DisplayLayout.GroupByBox.Hidden = true;
			this.UltraGrid1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
			this.UltraGrid1.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow;
			Appearance1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance1;
			this.UltraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard;
			this.UltraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
			this.UltraGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.UltraGrid1.Location = new System.Drawing.Point(7, 48);
			this.UltraGrid1.Name = "UltraGrid1";
			this.UltraGrid1.Size = new System.Drawing.Size(590, 407);
			this.UltraGrid1.TabIndex = 5;
			//
			//GroupBox2
			//
			this.GroupBox2.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.GroupBox2.Controls.Add(this.btnExpand);
			this.GroupBox2.Controls.Add(this.btnBackup);
			this.GroupBox2.Controls.Add(this.btnDelete);
			this.GroupBox2.Controls.Add(this.btnExport);
			this.GroupBox2.Controls.Add(this.UltraGrid1);
			this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.GroupBox2.Location = new System.Drawing.Point(267, 106);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(604, 496);
			this.GroupBox2.TabIndex = 6;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Search Results";
			//
			//btnExpand
			//
			this.btnExpand.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			//this.btnExpand.Image = DuplicateFileFinder.Properties.Resources.ig_treeMsdn_plus;
			this.btnExpand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExpand.Location = new System.Drawing.Point(447, 15);
			this.btnExpand.Name = "btnExpand";
			this.btnExpand.Size = new System.Drawing.Size(150, 27);
			this.btnExpand.TabIndex = 11;
			this.btnExpand.Text = "Expand Groups";
			this.btnExpand.UseVisualStyleBackColor = true;
			//
			//btnBackup
			//
			this.btnBackup.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			//this.btnBackup.Image = DuplicateFileFinder.Properties.Resources.MoveFolder;
			this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBackup.Location = new System.Drawing.Point(104, 463);
			this.btnBackup.Name = "btnBackup";
			this.btnBackup.Size = new System.Drawing.Size(162, 27);
			this.btnBackup.TabIndex = 8;
			this.btnBackup.Text = "Move Checked Items   ";
			this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBackup.UseVisualStyleBackColor = true;
			//
			//btnDelete
			//
			this.btnDelete.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnDelete.Image = (System.Drawing.Image)resources.GetObject("btnDelete.Image");
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(420, 463);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(177, 27);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Delete all Checked Items  ";
			this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDelete.UseVisualStyleBackColor = true;
			//
			//btnExport
			//
			this.btnExport.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			//this.btnExport.Image = DuplicateFileFinder.Properties.Resources._16_excel;
			this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExport.Location = new System.Drawing.Point(272, 463);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(142, 27);
			this.btnExport.TabIndex = 6;
			this.btnExport.Text = "Export list to Excel  ";
			this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExport.UseVisualStyleBackColor = true;
			//
			//TabControl1
			//
			this.TabControl1.Controls.Add(this.tbImageFileTypes);
			this.TabControl1.Controls.Add(this.tbDocumentTypes);
			this.TabControl1.Controls.Add(this.tbVideoTypes);
			this.TabControl1.Controls.Add(this.tbAudio);
			this.TabControl1.Location = new System.Drawing.Point(14, 222);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(246, 324);
			this.TabControl1.TabIndex = 4;
			//
			//tbImageFileTypes
			//
			this.tbImageFileTypes.BackColor = System.Drawing.SystemColors.Control;
			this.tbImageFileTypes.Controls.Add(this.GroupBox3);
			this.tbImageFileTypes.Location = new System.Drawing.Point(4, 24);
			this.tbImageFileTypes.Name = "tbImageFileTypes";
			this.tbImageFileTypes.Padding = new System.Windows.Forms.Padding(3);
			this.tbImageFileTypes.Size = new System.Drawing.Size(238, 296);
			this.tbImageFileTypes.TabIndex = 0;
			this.tbImageFileTypes.Text = "Images";
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.btnImageSelect);
			this.GroupBox3.Controls.Add(this.btnImageDeselect);
			this.GroupBox3.Controls.Add(this.cblImageTypes);
			this.GroupBox3.ForeColor = System.Drawing.Color.Black;
			this.GroupBox3.Location = new System.Drawing.Point(9, 10);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(218, 277);
			this.GroupBox3.TabIndex = 10;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Image Files Formats";
			//
			//btnImageSelect
			//
			this.btnImageSelect.Location = new System.Drawing.Point(113, 241);
			this.btnImageSelect.Name = "btnImageSelect";
			this.btnImageSelect.Size = new System.Drawing.Size(98, 27);
			this.btnImageSelect.TabIndex = 28;
			this.btnImageSelect.Text = "Select All";
			this.btnImageSelect.UseVisualStyleBackColor = true;
			//
			//btnImageDeselect
			//
			this.btnImageDeselect.Location = new System.Drawing.Point(7, 241);
			this.btnImageDeselect.Name = "btnImageDeselect";
			this.btnImageDeselect.Size = new System.Drawing.Size(99, 27);
			this.btnImageDeselect.TabIndex = 27;
			this.btnImageDeselect.Text = "Deselect All";
			this.btnImageDeselect.UseVisualStyleBackColor = true;
			//
			//cblImageTypes
			//
			this.cblImageTypes.CheckOnClick = true;
			this.cblImageTypes.ColumnWidth = 63;
			this.cblImageTypes.FormattingEnabled = true;
			this.cblImageTypes.Items.AddRange(new object[] {".AI", ".BMP", ".CDR", ".CPT", ".DXF", ".EMF", ".EPS", ".EXIF", ".FH", ".FLA", ".GIF", ".ICO", ".JPG", ".ODG", ".PNG", ".PS", ".PSD", ".SVG", ".SWF", ".TIF", ".WMF"});
			this.cblImageTypes.Location = new System.Drawing.Point(7, 22);
			this.cblImageTypes.MultiColumn = true;
			this.cblImageTypes.Name = "cblImageTypes";
			this.cblImageTypes.Size = new System.Drawing.Size(203, 212);
			this.cblImageTypes.Sorted = true;
			this.cblImageTypes.TabIndex = 26;
			//
			//tbDocumentTypes
			//
			this.tbDocumentTypes.BackColor = System.Drawing.SystemColors.Control;
			this.tbDocumentTypes.Controls.Add(this.GroupBox4);
			this.tbDocumentTypes.Location = new System.Drawing.Point(4, 24);
			this.tbDocumentTypes.Name = "tbDocumentTypes";
			this.tbDocumentTypes.Padding = new System.Windows.Forms.Padding(3);
			this.tbDocumentTypes.Size = new System.Drawing.Size(238, 296);
			this.tbDocumentTypes.TabIndex = 1;
			this.tbDocumentTypes.Text = "Documents";
			//
			//GroupBox4
			//
			this.GroupBox4.Controls.Add(this.btnDocSelect);
			this.GroupBox4.Controls.Add(this.btnDocDeselect);
			this.GroupBox4.Controls.Add(this.clbDocTypes);
			this.GroupBox4.ForeColor = System.Drawing.Color.Black;
			this.GroupBox4.Location = new System.Drawing.Point(9, 10);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(218, 277);
			this.GroupBox4.TabIndex = 11;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Document File Formats";
			//
			//btnDocSelect
			//
			this.btnDocSelect.Location = new System.Drawing.Point(113, 241);
			this.btnDocSelect.Name = "btnDocSelect";
			this.btnDocSelect.Size = new System.Drawing.Size(98, 27);
			this.btnDocSelect.TabIndex = 30;
			this.btnDocSelect.Text = "Select All";
			this.btnDocSelect.UseVisualStyleBackColor = true;
			//
			//btnDocDeselect
			//
			this.btnDocDeselect.Location = new System.Drawing.Point(7, 241);
			this.btnDocDeselect.Name = "btnDocDeselect";
			this.btnDocDeselect.Size = new System.Drawing.Size(99, 27);
			this.btnDocDeselect.TabIndex = 29;
			this.btnDocDeselect.Text = "Deselect All";
			this.btnDocDeselect.UseVisualStyleBackColor = true;
			//
			//clbDocTypes
			//
			this.clbDocTypes.CheckOnClick = true;
			this.clbDocTypes.ColumnWidth = 63;
			this.clbDocTypes.FormattingEnabled = true;
			this.clbDocTypes.Items.AddRange(new object[] {".CSV", ".DOC", ".DOCX", ".ODP", ".ODS", ".ODT", ".PDF", ".PPS", ".PPT", ".PPTX", ".RPT", ".RTF", ".SQL", ".TXT", ".WKS", ".XLS", ".XLSX", ".XML"});
			this.clbDocTypes.Location = new System.Drawing.Point(7, 22);
			this.clbDocTypes.MultiColumn = true;
			this.clbDocTypes.Name = "clbDocTypes";
			this.clbDocTypes.Size = new System.Drawing.Size(203, 212);
			this.clbDocTypes.Sorted = true;
			this.clbDocTypes.TabIndex = 4;
			//
			//tbVideoTypes
			//
			this.tbVideoTypes.BackColor = System.Drawing.SystemColors.Control;
			this.tbVideoTypes.Controls.Add(this.GroupBox8);
			this.tbVideoTypes.Location = new System.Drawing.Point(4, 24);
			this.tbVideoTypes.Name = "tbVideoTypes";
			this.tbVideoTypes.Padding = new System.Windows.Forms.Padding(3);
			this.tbVideoTypes.Size = new System.Drawing.Size(238, 296);
			this.tbVideoTypes.TabIndex = 2;
			this.tbVideoTypes.Text = "Videos";
			//
			//GroupBox8
			//
			this.GroupBox8.Controls.Add(this.btnVideoSelect);
			this.GroupBox8.Controls.Add(this.btnVideoDeselect);
			this.GroupBox8.Controls.Add(this.cblVideoTypes);
			this.GroupBox8.ForeColor = System.Drawing.Color.Black;
			this.GroupBox8.Location = new System.Drawing.Point(9, 10);
			this.GroupBox8.Name = "GroupBox8";
			this.GroupBox8.Size = new System.Drawing.Size(218, 277);
			this.GroupBox8.TabIndex = 0;
			this.GroupBox8.TabStop = false;
			this.GroupBox8.Text = "Video File Formats";
			//
			//btnVideoSelect
			//
			this.btnVideoSelect.Location = new System.Drawing.Point(113, 241);
			this.btnVideoSelect.Name = "btnVideoSelect";
			this.btnVideoSelect.Size = new System.Drawing.Size(98, 27);
			this.btnVideoSelect.TabIndex = 32;
			this.btnVideoSelect.Text = "Select All";
			this.btnVideoSelect.UseVisualStyleBackColor = true;
			//
			//btnVideoDeselect
			//
			this.btnVideoDeselect.Location = new System.Drawing.Point(7, 241);
			this.btnVideoDeselect.Name = "btnVideoDeselect";
			this.btnVideoDeselect.Size = new System.Drawing.Size(99, 27);
			this.btnVideoDeselect.TabIndex = 31;
			this.btnVideoDeselect.Text = "Deselect All";
			this.btnVideoDeselect.UseVisualStyleBackColor = true;
			//
			//cblVideoTypes
			//
			this.cblVideoTypes.CheckOnClick = true;
			this.cblVideoTypes.ColumnWidth = 68;
			this.cblVideoTypes.FormattingEnabled = true;
			this.cblVideoTypes.Items.AddRange(new object[] {".3GP", ".ASF", ".ASX", ".AVI", ".DIVX", ".MOV", ".MP4", ".MPG", ".QT", ".RM", ".SWF", ".WMV"});
			this.cblVideoTypes.Location = new System.Drawing.Point(7, 22);
			this.cblVideoTypes.MultiColumn = true;
			this.cblVideoTypes.Name = "cblVideoTypes";
			this.cblVideoTypes.Size = new System.Drawing.Size(203, 212);
			this.cblVideoTypes.TabIndex = 0;
			//
			//tbAudio
			//
			this.tbAudio.BackColor = System.Drawing.SystemColors.Control;
			this.tbAudio.Controls.Add(this.GroupBox9);
			this.tbAudio.Location = new System.Drawing.Point(4, 24);
			this.tbAudio.Name = "tbAudio";
			this.tbAudio.Size = new System.Drawing.Size(238, 296);
			this.tbAudio.TabIndex = 3;
			this.tbAudio.Text = "Audios";
			//
			//GroupBox9
			//
			this.GroupBox9.Controls.Add(this.btnAudioSelect);
			this.GroupBox9.Controls.Add(this.btnAudioDeselect);
			this.GroupBox9.Controls.Add(this.cblAudioTypes);
			this.GroupBox9.ForeColor = System.Drawing.Color.Black;
			this.GroupBox9.Location = new System.Drawing.Point(9, 10);
			this.GroupBox9.Name = "GroupBox9";
			this.GroupBox9.Size = new System.Drawing.Size(218, 277);
			this.GroupBox9.TabIndex = 1;
			this.GroupBox9.TabStop = false;
			this.GroupBox9.Text = "Audio File Formats";
			//
			//btnAudioSelect
			//
			this.btnAudioSelect.Location = new System.Drawing.Point(113, 241);
			this.btnAudioSelect.Name = "btnAudioSelect";
			this.btnAudioSelect.Size = new System.Drawing.Size(98, 27);
			this.btnAudioSelect.TabIndex = 34;
			this.btnAudioSelect.Text = "Select All";
			this.btnAudioSelect.UseVisualStyleBackColor = true;
			//
			//btnAudioDeselect
			//
			this.btnAudioDeselect.Location = new System.Drawing.Point(7, 241);
			this.btnAudioDeselect.Name = "btnAudioDeselect";
			this.btnAudioDeselect.Size = new System.Drawing.Size(99, 27);
			this.btnAudioDeselect.TabIndex = 33;
			this.btnAudioDeselect.Text = "Deselect All";
			this.btnAudioDeselect.UseVisualStyleBackColor = true;
			//
			//cblAudioTypes
			//
			this.cblAudioTypes.ColumnWidth = 63;
			this.cblAudioTypes.FormattingEnabled = true;
			this.cblAudioTypes.Items.AddRange(new object[] {".AAC", ".AIF", ".CDA", ".CDR", ".DCM", ".M4A", ".M4B", ".M4P", ".MID", ".MP3", ".MPA", ".OGG", ".RA", ".RAM", ".WAV", ".WMA"});
			this.cblAudioTypes.Location = new System.Drawing.Point(7, 22);
			this.cblAudioTypes.MultiColumn = true;
			this.cblAudioTypes.Name = "cblAudioTypes";
			this.cblAudioTypes.Size = new System.Drawing.Size(203, 212);
			this.cblAudioTypes.TabIndex = 0;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label1.Location = new System.Drawing.Point(15, 50);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(277, 15);
			this.Label1.TabIndex = 9;
			this.Label1.Text = "Locate the folder you wish to search for duplicates";
			//
			//FolderBrowserDialog1
			//
			this.FolderBrowserDialog1.Description = "Select the folder you wish to search for duplicates";
			this.FolderBrowserDialog1.ShowNewFolderButton = false;
			//
			//SaveFileDialog1
			//
			this.SaveFileDialog1.DefaultExt = "xls";
			this.SaveFileDialog1.Filter = "Excel Workbook (*.xls)|*.xls";
			this.SaveFileDialog1.Tag = "Where do you want to save your list of duplicates?";
			this.SaveFileDialog1.Title = "Saving your list of duplicates";
			//
			//StatusStrip1
			//
			this.StatusStrip1.Location = new System.Drawing.Point(0, 609);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
			this.StatusStrip1.Size = new System.Drawing.Size(885, 22);
			this.StatusStrip1.TabIndex = 11;
			this.StatusStrip1.Text = "StatusStrip1";
			//
			//lblHelp
			//
			this.lblHelp.Name = "lblHelp";
			this.lblHelp.Size = new System.Drawing.Size(32, 17);
			this.lblHelp.Text = "Help";
			//
			//lblSearchType
			//
			this.lblSearchType.Name = "lblSearchType";
			this.lblSearchType.Size = new System.Drawing.Size(71, 17);
			this.lblSearchType.Text = "Search Type";
			//
			//ToolStripStatusLabel1
			//
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new System.Drawing.Size(641, 17);
			this.ToolStripStatusLabel1.Spring = true;
			//
			//RadioButton1
			//
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Checked = true;
			this.RadioButton1.Location = new System.Drawing.Point(10, 42);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(130, 17);
			this.RadioButton1.TabIndex = 3;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "Perform Binary Search";
			this.RadioButton1.UseVisualStyleBackColor = true;
			//
			//MenuStrip1
			//
			this.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.FileToolStripMenuItem, this.HelpToolStripMenuItem, this.UnlockThisProgramToolStripMenuItem});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.MenuStrip1.Size = new System.Drawing.Size(885, 24);
			this.MenuStrip1.TabIndex = 12;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//FileToolStripMenuItem
			//
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ExitToolStripMenuItem});
			this.FileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.0F);
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.FileToolStripMenuItem.Text = "File";
			//
			//ExitToolStripMenuItem
			//
			this.ExitToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ExitToolStripMenuItem.Image");
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
			this.ExitToolStripMenuItem.Text = "Exit";
			//
			//HelpToolStripMenuItem
			//
			this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AboutThisProgramToolStripMenuItem, this.ToolStripSeparator1, this.MakeASuggestionToolStripMenuItem, this.CheckForUpdatesToolStripMenuItem, this.ToolStripSeparator2, this.VisitOurWebsiteToolStripMenuItem});
			this.HelpToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.0F);
			this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
			this.HelpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.HelpToolStripMenuItem.Text = "Help";
			//
			//AboutThisProgramToolStripMenuItem
			//
			this.AboutThisProgramToolStripMenuItem.Image = DuplicateFileFinder.Properties.Resources.root;
			this.AboutThisProgramToolStripMenuItem.Name = "AboutThisProgramToolStripMenuItem";
			this.AboutThisProgramToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.AboutThisProgramToolStripMenuItem.Text = "About This Program";
			//
			//ToolStripSeparator1
			//
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			this.ToolStripSeparator1.Size = new System.Drawing.Size(179, 6);
			//
			//MakeASuggestionToolStripMenuItem
			//
			this.MakeASuggestionToolStripMenuItem.Name = "MakeASuggestionToolStripMenuItem";
			this.MakeASuggestionToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.MakeASuggestionToolStripMenuItem.Text = "Make a Suggestion";
			//
			//CheckForUpdatesToolStripMenuItem
			//
			this.CheckForUpdatesToolStripMenuItem.Image = DuplicateFileFinder.Properties.Resources.check;
			this.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem";
			this.CheckForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.CheckForUpdatesToolStripMenuItem.Text = "Check For Updates";
			//
			//ToolStripSeparator2
			//
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			this.ToolStripSeparator2.Size = new System.Drawing.Size(179, 6);
			//
			//VisitOurWebsiteToolStripMenuItem
			//
			this.VisitOurWebsiteToolStripMenuItem.Image = DuplicateFileFinder.Properties.Resources.ie;
			this.VisitOurWebsiteToolStripMenuItem.Name = "VisitOurWebsiteToolStripMenuItem";
			this.VisitOurWebsiteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.VisitOurWebsiteToolStripMenuItem.Text = "Visit Our Website";
			//
			//UnlockThisProgramToolStripMenuItem
			//
			this.UnlockThisProgramToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.0F);
			this.UnlockThisProgramToolStripMenuItem.Name = "UnlockThisProgramToolStripMenuItem";
			this.UnlockThisProgramToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
			this.UnlockThisProgramToolStripMenuItem.Text = "Unlock This Program";
			//
			//btnSearch
			//
			//this.btnSearch.Image = DuplicateFileFinder.Properties.Resources.play;
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearch.Location = new System.Drawing.Point(14, 553);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(246, 27);
			this.btnSearch.TabIndex = 5;
			this.btnSearch.Text = "Start Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			//
			//btnBrowse
			//
			this.btnBrowse.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnBrowse.Image = DuplicateFileFinder.Properties.Resources.folderopen;
			this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.btnBrowse.Location = new System.Drawing.Point(714, 69);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(150, 27);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "Browse For Folder   ";
			this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBrowse.UseVisualStyleBackColor = true;
			//
			//NewMain
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7.0F, 15.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(885, 631);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.inPath);
			this.Controls.Add(this.StatusStrip1);
			this.Controls.Add(this.MenuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MainMenuStrip = this.MenuStrip1;
			this.Name = "NewMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.UltraGrid1).EndInit();
			this.GroupBox2.ResumeLayout(false);
			this.TabControl1.ResumeLayout(false);
			this.tbImageFileTypes.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.tbDocumentTypes.ResumeLayout(false);
			this.GroupBox4.ResumeLayout(false);
			this.tbVideoTypes.ResumeLayout(false);
			this.GroupBox8.ResumeLayout(false);
			this.tbAudio.ResumeLayout(false);
			this.GroupBox9.ResumeLayout(false);
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			this.Load += new System.EventHandler(Form1_Load);
			btnSearch.Click += new System.EventHandler(btnSearch_Click);
			btnImageSelect.Click += new System.EventHandler(btnImageSelect_Click);
			btnImageDeselect.Click += new System.EventHandler(btnImageDeselect_Click);
			btnDocDeselect.Click += new System.EventHandler(btnDocDeselect_Click);
			btnDocSelect.Click += new System.EventHandler(btnDocSelect_Click);
			btnVideoDeselect.Click += new System.EventHandler(btnVideoDeselect_Click);
			btnVideoSelect.Click += new System.EventHandler(btnVideoSelect_Click);
			btnAudioDeselect.Click += new System.EventHandler(btnAudioDeselect_Click);
			btnAudioSelect.Click += new System.EventHandler(btnAudioSelect_Click);
			ExitToolStripMenuItem.Click += new System.EventHandler(ExitToolStripMenuItem_Click);
			AboutThisProgramToolStripMenuItem.Click += new System.EventHandler(AboutThisProgramToolStripMenuItem_Click);
			CheckForUpdatesToolStripMenuItem.Click += new System.EventHandler(CheckForUpdatesToolStripMenuItem_Click);
			MakeASuggestionToolStripMenuItem.Click += new System.EventHandler(MakeASuggesionToolStripMenuItem_Click);
			UnlockThisProgramToolStripMenuItem.Click += new System.EventHandler(UnlockThisProgramToolStripMenuItem_Click);
			VisitOurWebsiteToolStripMenuItem.Click += new System.EventHandler(VisitOurWebsiteToolStripMenuItem_Click);
			btnBrowse.Click += new System.EventHandler(btnBrowse_Click);
			btnExpand.Click += new System.EventHandler(btnExpand_Click);
			UltraGrid1.DoubleClickCell += new Infragistics.Win.UltraWinGrid.DoubleClickCellEventHandler(UltraGrid1_DoubleClickCell);
			UltraGrid1.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(UltraGrid1_InitializeLayout);
			btnBackup.Click += new System.EventHandler(btnBackup_Click);
			btnDelete.Click += new System.EventHandler(btnDelete_Click);
			btnExport.Click += new System.EventHandler(btnExport_Click);
		}
		internal System.Windows.Forms.TextBox inPath;
		internal System.Windows.Forms.Button btnBrowse;
		internal System.Windows.Forms.CheckBox chkSubDirectories;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.RadioButton RadioButton2;
		internal System.Windows.Forms.RadioButton rbBinarySearch;
		internal System.Windows.Forms.Button btnSearch;
		internal Infragistics.Win.UltraWinGrid.UltraGrid UltraGrid1;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage tbImageFileTypes;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Button btnImageSelect;
		internal System.Windows.Forms.Button btnImageDeselect;
		internal System.Windows.Forms.CheckedListBox cblImageTypes;
		internal System.Windows.Forms.TabPage tbDocumentTypes;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.Button btnDocSelect;
		internal System.Windows.Forms.Button btnDocDeselect;
		internal System.Windows.Forms.CheckedListBox clbDocTypes;
		internal System.Windows.Forms.TabPage tbVideoTypes;
		internal System.Windows.Forms.GroupBox GroupBox8;
		internal System.Windows.Forms.Button btnVideoSelect;
		internal System.Windows.Forms.Button btnVideoDeselect;
		internal System.Windows.Forms.CheckedListBox cblVideoTypes;
		internal System.Windows.Forms.TabPage tbAudio;
		internal System.Windows.Forms.GroupBox GroupBox9;
		internal System.Windows.Forms.Button btnAudioSelect;
		internal System.Windows.Forms.Button btnAudioDeselect;
		internal System.Windows.Forms.CheckedListBox cblAudioTypes;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
		internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
		internal System.Windows.Forms.Button btnBackup;
		internal System.Windows.Forms.Button btnDelete;
		internal System.Windows.Forms.Button btnExport;
		internal System.Windows.Forms.Button btnExpand;
		internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
		internal Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter UltraGridExcelExporter1;
		internal System.Windows.Forms.StatusStrip StatusStrip1;
		internal System.Windows.Forms.ToolStripStatusLabel lblHelp;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
		internal System.Windows.Forms.ToolStripStatusLabel lblSearchType;
		internal System.Windows.Forms.RadioButton RadioButton1;
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AboutThisProgramToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
		internal System.Windows.Forms.ToolStripMenuItem MakeASuggestionToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem CheckForUpdatesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
		internal System.Windows.Forms.ToolStripMenuItem VisitOurWebsiteToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem UnlockThisProgramToolStripMenuItem;

		private static NewMain _DefaultInstance;
		public static NewMain DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null || _DefaultInstance.IsDisposed)
					_DefaultInstance = new NewMain();

				return _DefaultInstance;
			}
		}
	}

}