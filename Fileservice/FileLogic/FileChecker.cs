using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLogic
{
    class FileChecker
    {
        string _path="";
        string _MovePath = "";
        public FileChecker(string path)
        {
            try
            {
                _path = path;
                _MovePath = _path + @"\moved\";
                if (Directory.Exists(_path) == false)
                    Directory.CreateDirectory(_path);

                if (Directory.Exists(_MovePath) == false)
                    Directory.CreateDirectory(_MovePath);
            }
            catch (Exception ex)
            {
                //ToDo: Logga till loggfil eller eventlog
                Console.WriteLine(ex.Message);
            }

        }

        //ToDo: Logga till loggfil
        public void MoveFilesFromFolder()
        {
            DirectoryInfo myFileList = new DirectoryInfo(_path);
            FileInfo[] filer =  myFileList.GetFiles();
            if (filer.Length == 0)
                Console.WriteLine("No files found");
                
            
            foreach (FileInfo item in filer)
            {
                var filinnehåll = item.OpenText();
                string text = filinnehåll.ReadToEnd();

                
                item.MoveTo(_MovePath + item.Name);
                Console.WriteLine(item.Name + " moved to: " + _MovePath);
            }
        }
    }
}
