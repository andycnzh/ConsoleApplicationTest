using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTest
{
    class MyLog
    {
        private string logFileName = @"MyLog.txt";
        private string logFileFullName = "";

        public MyLog()
        {
            //if the user my documents folder exist
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)))
            {
                logFileFullName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + logFileName;

                //if the file is not exist
                //then create it
                if (!File.Exists(logFileFullName))
                {
                    using (StreamWriter sw = File.CreateText(logFileFullName))
                    {
                        sw.WriteLine(string.Format("[{0}] create the file.", DateTime.Now));
                    }
                }

            }
            else
            {
                //TODO
                //create one folder
                //then create one file in this folder
            }

        }

        public void Log(string message)
        {
            using (StreamWriter sw = File.AppendText(logFileFullName))
            {
                StackTrace st = new StackTrace(new StackFrame(true));
                StackFrame sf = st.GetFrame(0);
                //sw.WriteLine(string.Format("[{0}][{1}][{2}][{3}]: <{4}>", DateTime.Now, sf.GetFileName(),sf.GetMethod().Name,sf.GetFileLineNumber(),message));
                sw.WriteLine(string.Format("[{0}][{1}][{2}]: {3}", DateTime.Now, sf.GetMethod().Name, sf.GetFileLineNumber(), message));
            }
        }
    }
}
