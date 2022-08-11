namespace SecurityService_Logger.SpecificLogLineBuilder
{
    public class SignOut : LogLineBuilder
    {
        public override void SetLogLineLevel()
        {
            LogLine.LogLevel = new LogLevel { LogLvl = "[INFO]: " };
        }

        public override void SetLogLineMessage(string id, string username)
        {
            LogLine.LogMessage = new LogMessage
            {
                Subject = "Employee Signed-Out. ",
                Summary = $"Employee ID: {id}, Username: {username}. "
            };
        }
    }
}
