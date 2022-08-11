using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityService_LogWriter
{
    public interface ILogWriter
    {
        void Write(string logLine);
    }
}
