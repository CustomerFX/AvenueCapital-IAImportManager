using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Text.RegularExpressions;

namespace IAImportManager
{
    class IAFileReader
    {
        private const string OLE_CONN_STRING  = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"{0}\";Extended Properties=\"text;IMEX=1;HDR=YES;FMT=Delimited\";";
        private OleDbConnection _conn;
        private OleDbCommand _cmd;
        private OleDbDataReader _rdr;
        private FileSystemInfo _file;

        public string FileName
        {
            get { return _file.Name; }
        }
        private string targetFile;
        public string DataType { get; set; }
        public DateTime FileDate { get; set; }
        public IAFileReader(FileSystemInfo file, Match nameMatch)
        {
            _file = file;
        }
    }
}
