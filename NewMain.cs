using System;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text;
using DuplicateFileFinderCTL;
using Globals = DuplicateFileFinderCTL.Globals;

namespace DuplicateFileFinder
{
    public partial class NewMain
    {

        public NewMain()
        {
            InitializeComponent();
        }

        private Logic b;
        private ArrayList chkItems = new ArrayList();
        private ArrayList arFiles = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = My.MyApplication.Application.Info.Title + " v" + My.MyApplication.Application.AppInfo;

            ResetForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.UltraGrid1.DataSource = null;

            Globals.SearchType = this.rbBinarySearch.Checked ? "Byte" : "Filename";

            if (string.IsNullOrEmpty(this.inPath.Text.Trim()))
            {
                MessageBox.Show("Please select a start location.", "Invalid start location", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (System.IO.Directory.Exists(this.inPath.Text.Trim()) == false)
            {
                MessageBox.Show("It appears that the start location does not exist. Please select another location and try again.", "Bad Start Location", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (this.BackgroundWorker1.IsBusy == false)
            {
                GetAllCheckedBoxes();

                if (this.chkItems.Count > 0)
                {
                    Globals.dtFiles.Clear();
                    FrmProcessing frm = new FrmProcessing(this.inPath.Text.Trim(), this.chkSubDirectories.Checked, this.chkItems);
                    frm.LoadData += LoadData;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select file types to search for.", "Missing File Types", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

        }

        private delegate void LoadDataCallback();
        private void LoadData()
        {
            if (this.UltraGrid1.InvokeRequired == true)
            {
                LoadDataCallback aDelegate = new LoadDataCallback(LoadData);
                Invoke(aDelegate);
            }
            else
            {
                this.UltraGrid1.DataSource = Globals.dtFiles;

                if (Globals.dtFiles.Rows.Count == 0)
                {
                    MessageBox.Show("No duplicates where found during the search.", "No Duplicates Found", MessageBoxButtons.OK);
                }

                if (Globals.SearchType == "Byte")
                {
                    this.UltraGrid1.DisplayLayout.Bands[0].SortedColumns.Add("UID", false, true);
                }
                else
                {
                    this.UltraGrid1.DisplayLayout.Bands[0].SortedColumns.Add("FileName2", false, true);
                }

                this.UltraGrid1.DisplayLayout.Bands[0].Override.GroupByRowDescriptionMask = "This group contains [count] duplicate files";
                ExpandGrid();
            }
        }

        private void EnableControls()
        {
            this.btnExpand.Enabled = true;
            this.btnBrowse.Enabled = true;
            this.inPath.Text = "";
            this.inPath.Enabled = true;
            this.btnSearch.Enabled = true;
            this.GroupBox1.Enabled = true;
            this.TabControl1.Enabled = true;

            if (TheProDev.clsRegistration.Registered == false)
            {
                this.btnAudioDeselect.Enabled = false;
                this.btnAudioSelect.Enabled = false;
                this.btnDocDeselect.Enabled = false;
                this.btnDocSelect.Enabled = false;
                this.btnImageDeselect.Enabled = false;
                this.btnImageSelect.Enabled = false;
                this.btnVideoDeselect.Enabled = false;
                this.btnVideoSelect.Enabled = false;
            }
            else
            {
                this.btnAudioDeselect.Enabled = true;
                this.btnAudioSelect.Enabled = true;
                this.btnDocDeselect.Enabled = true;
                this.btnDocSelect.Enabled = true;
                this.btnImageDeselect.Enabled = true;
                this.btnImageSelect.Enabled = true;
                this.btnVideoDeselect.Enabled = true;
                this.btnVideoSelect.Enabled = true;
            }
        }

        private void ResetForm()
        {
            EnableControls();
            CheckAllCheckBoxes();
        }

        private void btnImageSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.cblImageTypes.Items.Count; i++)
            {
                if (this.cblImageTypes.GetItemChecked(i) == false)
                {
                    this.cblImageTypes.SetItemChecked(i, true);
                }
            }
        }

        private void btnImageDeselect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.cblImageTypes.Items.Count; i++)
            {
                if (this.cblImageTypes.GetItemChecked(i) == true)
                {
                    this.cblImageTypes.SetItemChecked(i, false);
                }
            }
        }

        private void btnDocDeselect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.clbDocTypes.Items.Count; i++)
            {
                if (this.clbDocTypes.GetItemChecked(i) == true)
                {
                    this.clbDocTypes.SetItemChecked(i, false);
                }
            }
        }

        private void btnDocSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.clbDocTypes.Items.Count; i++)
            {
                if (this.clbDocTypes.GetItemChecked(i) == false)
                {
                    this.clbDocTypes.SetItemChecked(i, true);
                }
            }
        }

        private void btnVideoDeselect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.cblVideoTypes.Items.Count; i++)
            {
                if (this.cblVideoTypes.GetItemChecked(i) == true)
                {
                    this.cblVideoTypes.SetItemChecked(i, false);
                }
            }
        }

        private void btnVideoSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.cblVideoTypes.Items.Count; i++)
            {
                if (this.cblVideoTypes.GetItemChecked(i) == false)
                {
                    this.cblVideoTypes.SetItemChecked(i, true);
                }
            }
        }

        private void btnAudioDeselect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.cblAudioTypes.Items.Count; i++)
            {
                if (this.cblAudioTypes.GetItemChecked(i) == true)
                {
                    this.cblAudioTypes.SetItemChecked(i, false);
                }
            }
        }

        private void btnAudioSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.cblAudioTypes.Items.Count; i++)
            {
                if (this.cblAudioTypes.GetItemChecked(i) == false)
                {
                    this.cblAudioTypes.SetItemChecked(i, true);
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutThisProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (About about = new About())
            {
                about.ShowDialog();
            }
        }

        private void CheckForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CheckForUpdate update = new CheckForUpdate())
            {
                update.ShowDialog();
            }
        }

        private void MakeASuggesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Suggestion suggestion = new Suggestion())
            {
                suggestion.ShowDialog();
            }
        }

        private void UnlockThisProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistration frm = new frmRegistration();
            frm.ShowDialog();
        }

        private void VisitOurWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(My.MyApplication.Application.GetSiteLink("Menu"));
        }


        private void CheckAllCheckBoxes()
        {

            if (TheProDev.clsRegistration.Registered == true)
            {
                for (int i = 0; i < this.cblImageTypes.Items.Count; i++)
                {
                    this.cblImageTypes.SetItemChecked(i, true);
                    this.chkItems.Add(this.cblImageTypes.Items[i].ToString());
                }

                for (int i = 0; i < this.clbDocTypes.Items.Count; i++)
                {
                    this.clbDocTypes.SetItemChecked(i, true);
                    this.chkItems.Add(this.clbDocTypes.Items[i].ToString());
                }

                for (int i = 0; i < this.cblVideoTypes.Items.Count; i++)
                {
                    this.cblVideoTypes.SetItemChecked(i, true);
                    this.chkItems.Add(this.cblVideoTypes.Items[i].ToString());
                }

                for (int i = 0; i < this.cblAudioTypes.Items.Count; i++)
                {
                    this.cblAudioTypes.SetItemChecked(i, true);
                    this.chkItems.Add(this.cblAudioTypes.Items[i].ToString());
                }
            }
            else
            {

                for (int i = 0; i < this.cblImageTypes.Items.Count; i++)
                {
                    if (this.cblImageTypes.Items[i].ToString() == ".JPG")
                    {
                        this.cblImageTypes.SetItemChecked(i, true);
                        this.chkItems.Add(this.cblImageTypes.Items[i].ToString());
                    }
                }

                for (int i = 0; i < this.clbDocTypes.Items.Count; i++)
                {
                    if (this.clbDocTypes.Items[i].ToString() == ".DOC")
                    {
                        this.clbDocTypes.SetItemChecked(i, true);
                        this.chkItems.Add(this.clbDocTypes.Items[i].ToString());
                    }
                }

                for (int i = 0; i < this.cblVideoTypes.Items.Count; i++)
                {
                    if (this.cblVideoTypes.Items[i].ToString() == ".AVI")
                    {
                        this.cblVideoTypes.SetItemChecked(i, true);
                        this.chkItems.Add(this.cblVideoTypes.Items[i].ToString());
                    }
                }

                for (int i = 0; i < this.cblAudioTypes.Items.Count; i++)
                {
                    if (this.cblAudioTypes.Items[i].ToString() == ".WMA")
                    {
                        this.cblAudioTypes.SetItemChecked(i, true);
                        this.chkItems.Add(this.cblAudioTypes.Items[i].ToString());
                    }
                }

                this.cblImageTypes.Enabled = false;
                this.clbDocTypes.Enabled = false;
                this.cblAudioTypes.Enabled = false;
                this.cblVideoTypes.Enabled = false;
            }

            GetAllCheckedBoxes();

        }

        private void GetAllCheckedBoxes()
        {
            this.chkItems.Clear();

            for (int i = 0; i < this.cblImageTypes.Items.Count; i++)
            {
                if (this.cblImageTypes.GetItemChecked(i) == true)
                {
                    this.chkItems.Add(this.cblImageTypes.Items[i].ToString());
                }
            }

            for (int i = 0; i < this.clbDocTypes.Items.Count; i++)
            {
                if (this.clbDocTypes.GetItemChecked(i) == true)
                {
                    this.chkItems.Add(this.clbDocTypes.Items[i].ToString());
                }
            }

            for (int i = 0; i < this.cblVideoTypes.Items.Count; i++)
            {
                if (this.cblVideoTypes.GetItemChecked(i) == true)
                {
                    this.chkItems.Add(this.cblVideoTypes.Items[i].ToString());
                }
            }

            for (int i = 0; i < this.cblAudioTypes.Items.Count; i++)
            {
                if (this.cblAudioTypes.GetItemChecked(i) == true)
                {
                    this.chkItems.Add(this.cblAudioTypes.Items[i].ToString());
                }
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.FolderBrowserDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                this.inPath.Text = this.FolderBrowserDialog1.SelectedPath;
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            ExpandGrid();
        }

        private void ExpandGrid()
        {
            if (this.btnExpand.Text == "Expand Groups")
            {
                //this.btnExpand.Image = Properties.ig_treeMsdn_minus;
                Cursor = Cursors.WaitCursor;
                this.UltraGrid1.Rows.ExpandAll(true);
                this.btnExpand.Text = "Collapse Groups";
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                //this.btnExpand.Image = Properties.ig_treeMsdn_plus;
                this.UltraGrid1.Rows.CollapseAll(true);
                this.btnExpand.Text = "Expand Groups";
                Cursor = Cursors.Default;
            }
        }

        private void UltraGrid1_DoubleClickCell(object sender, Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs e)
        {
            if (e.Cell.Column.Key == "FilePath")
            {
                Process.Start(e.Cell.Row.Cells["FilePath"].Value.ToString());
            }
        }

        private void UltraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            e.Layout.Bands[0].Columns.Add("Delete", "Delete");
            e.Layout.Bands[0].Columns["Delete"].DataType = Type.GetType("System.Boolean");
            e.Layout.Bands[0].Columns["Delete"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
            e.Layout.Bands[0].Columns["Delete"].Header.VisiblePosition = 0;

            var tempVar = e.Layout.Bands[0];

            if (Globals.SearchType == "Name")
            {
                tempVar.Columns["UID"].Hidden = true;
            }
            else
            {
                tempVar.Columns["FileName2"].Hidden = true;
            }

            tempVar.Columns["FileName"].Header.Caption = "File Name";
            tempVar.Columns["FileName"].Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Left;
            tempVar.Columns["FileName"].CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            tempVar.Columns["FileName"].Header.VisiblePosition = 1;

            tempVar.Columns["FileSize"].Header.Caption = "Size(KB)";
            tempVar.Columns["FileSize"].Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Left;
            tempVar.Columns["FileSize"].CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            tempVar.Columns["FileSize"].Header.VisiblePosition = 2;

            tempVar.Columns["FileType"].Header.Caption = "File Type";
            tempVar.Columns["FileType"].Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Left;
            tempVar.Columns["FileType"].CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            tempVar.Columns["FileType"].Header.VisiblePosition = 3;

            tempVar.Columns["CreateDate"].Header.Caption = "Create Date";
            tempVar.Columns["CreateDate"].Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Left;
            tempVar.Columns["CreateDate"].CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            tempVar.Columns["CreateDate"].Header.VisiblePosition = 4;

            tempVar.Columns["FilePath"].Header.Caption = "File Path";
            tempVar.Columns["FilePath"].Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Left;
            tempVar.Columns["FilePath"].CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            tempVar.Columns["FilePath"].Header.VisiblePosition = 5;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {

            DialogResult mdr = MessageBox.Show("All selected files will be moved to a holding folder on your desktop. Do you want to continue?", "Moving...", MessageBoxButtons.YesNo);
            ArrayList arMove = new ArrayList();

            if (mdr != DialogResult.Yes)
            {
                return;
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Duplicate File Hold";

            if (System.IO.Directory.Exists(path) == false)
            {
                System.IO.Directory.CreateDirectory(path);
            }

            int moved = 0;
            int notMoved = 0;

            // Loop through groups
            foreach (Infragistics.Win.UltraWinGrid.UltraGridGroupByRow gr in this.UltraGrid1.Rows.All)
            {
                // Get rows in group
                Infragistics.Win.UltraWinGrid.RowsCollection r = gr.Rows;

                // Loop through rows
                foreach (Infragistics.Win.UltraWinGrid.UltraGridRow ir in r)
                {

                    // Check the value of the delete cell.
                    if (Convert.ToBoolean(ir.Cells["Delete"].Value))
                    {

                        try
                        {
                            // move the file from directory structure
                            arMove.Add(ir.Cells["FilePath"].Value);
                            System.IO.File.Move(ir.Cells["FilePath"].Value.ToString(), path + "\\" + ir.Cells["FileName"].Value);

                            moved += 1;

                        }
                        catch (UnauthorizedAccessException uaex)
                        {

                            try
                            {
                                // Deletion of file failed so try to remove readonly attributes
                                System.IO.File.SetAttributes(ir.Cells["FilePath"].Value.ToString(), System.IO.FileAttributes.Normal);
                                System.IO.File.Move(ir.Cells["FilePath"].Value.ToString(), path + "\\" + ir.Cells["FileName"].Value);
                                arMove.Add(ir.Cells["FilePath"].Value);
                                moved += 1;

                            }
                            catch (UnauthorizedAccessException uaex1)
                            {
                                // Deletion failed so add to list of failed files
                                this.arFiles.Add(ir.Cells["FilePath"].Value);
                                notMoved += 1;
                            }
                            catch (System.IO.FileNotFoundException fnfex)
                            {
                                // Deletion failed so add to list of failed files
                                this.arFiles.Add(ir.Cells["FilePath"].Value);
                                notMoved += 1;
                            }
                        }
                        catch (System.IO.FileNotFoundException ex)
                        {
                            // Deletion failed so add to list of failed files
                            this.arFiles.Add(ir.Cells["FilePath"].Value);
                            notMoved += 1;
                        }

                    }

                }

            }

            // Remove file from underlying datatable
            // Moved logic outside next loops to prevent infragistics exception when row was removed
            for (int j = Globals.dtFiles.Rows.Count - 1; j >= 0; j--)
            {
                foreach (string s in arMove)
                {
                    if (string.Compare(Globals.dtFiles.Rows[j]["FilePath"].ToString(), s, StringComparison.Ordinal) == 0)
                    {
                        Globals.dtFiles.Rows.RemoveAt(j);
                    }
                }
            }

            LoadData();

            StringBuilder sb = new StringBuilder();
            sb.Append(moved);
            sb.Append(" file(s) moved successfully");

            if (notMoved > 0)
            {
                sb.Append(Environment.NewLine);
                sb.Append(notMoved);
                sb.Append(" file(s) not moved due to access permissions");
            }

            MessageBox.Show(sb.ToString(), "Moved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult mbr = MessageBox.Show("Are you sure you want to delete the selected file(s)?", "Delete?", MessageBoxButtons.YesNo);

            if (mbr == DialogResult.Yes)
            {
                int fileCount = 0;
                ArrayList arDelete = new ArrayList();

                // Loop through groups
                foreach (Infragistics.Win.UltraWinGrid.UltraGridGroupByRow gr in this.UltraGrid1.Rows.All)
                {
                    // Get rows in group
                    Infragistics.Win.UltraWinGrid.RowsCollection r = gr.Rows;

                    // Loop through rows
                    foreach (Infragistics.Win.UltraWinGrid.UltraGridRow ir in r)
                    {

                        // Check the value of the delete cell.
                        if (Convert.ToBoolean(ir.Cells["Delete"].Value))
                        {

                            try
                            {
                                // Delete the file from directory structure
                                System.IO.File.Delete(ir.Cells["FilePath"].Value.ToString());
                                arDelete.Add(ir.Cells["FilePath"].Value);
                                fileCount += 1;

                            }
                            catch (UnauthorizedAccessException uaex)
                            {

                                try
                                {
                                    // Deletion of file failed so try to remove readonly attributes
                                    System.IO.File.SetAttributes(ir.Cells["FilePath"].Value.ToString(), System.IO.FileAttributes.Normal);
                                    System.IO.File.Delete(ir.Cells["FilePath"].Value.ToString());
                                    arDelete.Add(ir.Cells["FilePath"].Value);
                                    fileCount += 1;

                                }
                                catch (UnauthorizedAccessException uaex1)
                                {
                                    // Deletion failed so add to list of failed files
                                    this.arFiles.Add(ir.Cells["FilePath"].Value);
                                }
                                catch (System.IO.FileNotFoundException fnfex)
                                {
                                    // Deletion failed so add to list of failed files
                                    this.arFiles.Add(ir.Cells["FilePath"].Value);
                                }
                            }
                            catch (System.IO.FileNotFoundException ex)
                            {
                                // Deletion failed so add to list of failed files
                                this.arFiles.Add(ir.Cells["FilePath"].Value);
                            }

                        }
                    }

                }

                // Remove file from underlying datatable
                // Moved logic outside next loops to prevent infragistics exception when row was removed
                for (int j = Globals.dtFiles.Rows.Count - 1; j >= 0; j--)
                {
                    foreach (string s in arDelete)
                    {
                        if (string.Compare(Globals.dtFiles.Rows[j]["FilePath"].ToString(), s, StringComparison.Ordinal) == 0)
                        {
                            Globals.dtFiles.Rows.RemoveAt(j);
                        }
                    }
                }

                LoadData();

                string msg = string.Empty;

                if (fileCount > 0)
                {
                    msg = fileCount + " Files Deleted";
                }
                else
                {
                    msg = "0 Files Deleted";
                }

                if (this.arFiles.Count > 0)
                {
                    msg += Environment.NewLine + Environment.NewLine + this.arFiles.Count + " files were not able to be deleted due to file access permissions";
                }

                MessageBox.Show(msg, "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.SaveFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                this.UltraGrid1.Rows.ExpandAll(true);
                this.UltraGridExcelExporter1.Export(this.UltraGrid1, this.SaveFileDialog1.FileName);
                MessageBox.Show("Exported to Excel at: " + this.SaveFileDialog1.FileName, "Data Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



    }
}