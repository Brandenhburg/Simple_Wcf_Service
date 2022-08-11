namespace SecurityService_Logger.SpecificLogLineBuilder
{
    public class SignIn : LogLineBuilder
    {
        public override void SetLogLineLevel()
        {
            LogLine.LogLevel = new LogLevel { LogLvl = "[INFO]: " };
        }

        public override void SetLogLineMessage(string id, string username)
        {
            LogLine.LogMessage = new LogMessage
            {
                Subject = "Sign-In Attempt Confirmed. ",
                Summary = $"Employee ID: {id}, Username: {username}. "
            };
        }
    }
}
