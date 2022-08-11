using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityService_LogWriter
{
    public class TxtLogWriter : ILogWriter
    {
        public void Write(string logLine)
        {
            using (StreamWriter sw = File.AppendText($@"{Environment.CurrentDirectory}\SecurityService_Logs.txt"))
                sw.WriteLine(logLine);
        }
    }
}
