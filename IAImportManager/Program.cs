using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace IAImportManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //string holdingpath = Path.GetDirectoryName(Application)
            string location = Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location, "Processing");
            if (!Directory.Exists(location)) Directory.CreateDirectory(location);

            DirectoryInfo di = new DirectoryInfo(location);
            FileSystemInfo[] csvFiles = di.GetFileSystemInfos("*.csv");
            List<string> processed = new List<string>();
            using (StagingDataContext stage = new StagingDataContext())
            {
                foreach (FileSystemInfo currentFile in csvFiles.OrderBy(f => f.Name))
                {
                    string filename = currentFile.Name;
                }

            }


            
            Console.ReadLine(); //stop closing of console.
        }
    }
}
