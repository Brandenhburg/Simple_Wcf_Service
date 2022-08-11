namespace SecurityService_Logger.SpecificLogLineBuilder
{
    public class FailedSignIn_OnUserSignedIn : LogLineBuilder
    {
        public override void SetLogLineLevel()
        {
            LogLine.LogLevel = new LogLevel { LogLvl = "[WARNING]: "};
        }

        public override void SetLogLineMessage(string id, string username)
        {
            LogLine.LogMessage = new LogMessage 
            {
                Subject = "Failed Sign-In Attempt. ",
                Summary = $"Employee is Signed-In. Employee ID: {id}, Username: {username}. "
            };
        }
    }
}
