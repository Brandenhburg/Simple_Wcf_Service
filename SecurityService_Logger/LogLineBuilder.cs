namespace SecurityService_Logger
{
    public abstract class LogLineBuilder
    {
        public LogLine LogLine { get; private set; }

        public void CreaLogLine()
        {
            LogLine = new LogLine();
        }

        public abstract void SetLogLineLevel();
        public abstract void SetLogLineMessage(string id, string username);
    }
}
