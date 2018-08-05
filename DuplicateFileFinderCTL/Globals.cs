using System;
using System.Data;

namespace DuplicateFileFinderCTL
{
    public static class Globals
    {

        private static DataTable _dtFiles;

        public static string SearchType { get; set; } = "";

        public static DataTable dtFiles
        {
            get
            {
                if (_dtFiles == null)
                {
                    _dtFiles = new DataTable();
                    _dtFiles.Columns.Add("FileName", typeof(string));
                    _dtFiles.Columns.Add("FileName2", typeof(string));
                    _dtFiles.Columns.Add("FileSize", typeof(double));
                    _dtFiles.Columns.Add("FileType", typeof(string));
                    _dtFiles.Columns.Add("CreateDate", typeof(DateTime));
                    _dtFiles.Columns.Add("UID", typeof(string));
                    _dtFiles.Columns.Add("FilePath", typeof(string));
                }
                return _dtFiles;
            }
        }

        internal static void AddNewRow(string FileName, double FileSize, string FileType, DateTime CreateDate, decimal UID, string FilePath)
        {
            DataRow dr = dtFiles.NewRow();
            dr["FileName"] = FileName;
            dr["FileName2"] = FileName;
            dr["FileSize"] = FileSize;
            dr["FileType"] = FileType;
            dr["CreateDate"] = CreateDate;
            dr["UID"] = UID;
            dr["FilePath"] = FilePath;
            _dtFiles.Rows.Add(dr);
        }


    }

}