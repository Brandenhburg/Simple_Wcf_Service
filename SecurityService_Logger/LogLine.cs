using System;
using System.Text;

namespace SecurityService_Logger
{
    public class LogLine
    {
        public LogLevel LogLevel { get; set; }
        public LogMessage LogMessage { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(LogLevel.LogLvl);
            sb.Append(LogMessage.Subject);
            sb.Append(LogMessage.Summary);

            sb.Append($"Date: {DateTime.Now.ToShortDateString()}, Time: {DateTime.Now.ToShortTimeString()}.");

            return sb.ToString();
        }
    }
}
