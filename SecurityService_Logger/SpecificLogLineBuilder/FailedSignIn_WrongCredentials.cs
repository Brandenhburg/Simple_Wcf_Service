namespace SecurityService_Logger.SpecificLogLineBuilder
{
    public class FailedSignIn_WrongCredentials : LogLineBuilder
    {
        public override void SetLogLineLevel()
        {
            LogLine.LogLevel = new LogLevel { LogLvl = "[INFO]: " };
        }

        public override void SetLogLineMessage(string id, string username)
        {
            LogLine.LogMessage = new LogMessage
            {
                Subject = "Wrong Username or Password. ",
                Summary = $"Failed Sign-In Attempt - Username: {username}. "
            };
        }
    }
}
