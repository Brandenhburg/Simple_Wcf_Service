namespace SecurityService_Logger
{
    public class Logger
    {
        public LogLine CreateLog(LogLineBuilder logLineBuilder, string id, string username)
        {
            logLineBuilder.CreaLogLine();
            logLineBuilder.SetLogLineLevel();
            logLineBuilder.SetLogLineMessage(id, username);

            return logLineBuilder.LogLine;
        }
    }
}
