using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityService_LogWriter
{
    public class ConsoleLogWriter : ILogWriter
    {
        public void Write(string logLine) => Console.WriteLine(logLine);
    }
}
