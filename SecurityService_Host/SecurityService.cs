using SecurityService_Host.Data;
using System.Threading.Tasks;
using System.ServiceModel;
using System;

using SecurityService_LogWriter;
using SecurityService_Logger;
using SecurityService_Logger.SpecificLogLineBuilder;

namespace SecurityService_Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class SecurityService : ISecurity_Service
    {
        Logger logger;
        LogLine logLine;    
        ILogWriter logWriter;
        ActiveEmployees ActiveEmployees;

        public SecurityService()
        {
            ActiveEmployees =  ActiveEmployees.GetIntance();
            logWriter = new ConsoleLogWriter();
            logger = new Logger();
        }

        public async Task<bool> SignUp(string username, string email, string password) => await Task.Factory.StartNew(() => EmployeesMockDatabase.IsNewEmployeeCreated(username, email, password));

        public async Task<Employee> SignIn(string userName, string password)
        {
            Employee worker = await Task.Factory.StartNew(() => EmployeesMockDatabase.GetEmployee(userName, password));
            if (worker == null)
            {
                logLine = logger.CreateLog(new FailedSignIn_WrongCredentials(), "", userName);
                logWriter.Write(logLine.ToString());
                throw new FaultException(logLine.LogMessage.Subject);
            }
                              
            if (ActiveEmployees.SignedInEmployees.Exists(w => w.Id == worker.Id))
            {
                LogLine logLine = logger.CreateLog(new FailedSignIn_OnUserSignedIn(), worker.Id.ToString(), worker.Username);
                string log = logLine.ToString();
                logWriter.Write(log);

                throw new FaultException(logLine.LogMessage.Subject);
            }

            ActiveEmployees.SignedInEmployees.Add(worker);
            logLine = logger.CreateLog(new SignIn(), worker.Id.ToString(), worker.Username);
            logWriter.Write(logLine.ToString());
            return worker;
                  
        }
        public async Task SignOut(string id, string userName)
        {
            await Task.Factory.StartNew(() =>
            {
                Employee signedInEmp = ActiveEmployees.SignedInEmployees.Find(emp => emp.Username == userName);
                ActiveEmployees.SignedInEmployees.Remove(signedInEmp);
                logLine = logger.CreateLog(new SignOut(), id, userName);
                logWriter.Write(logLine.ToString());          
            });          
        }


        ///
        /// Retrieving System MAC Address.
        /// 
        /// 
        ///public static string GetMACAddress()
        ///{
        ///    ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
        ///    ManagementObjectCollection moc = mc.GetInstances();
        ///    string MACAddress = String.Empty;
        ///    foreach (ManagementObject mo in moc)
        ///    {
        ///        if (MACAddress == String.Empty)
        ///        {
        ///            if ((bool)mo["IPEnabled"] == true) MACAddress = mo["MacAddress"].ToString();
        ///        }
        ///        mo.Dispose();
        ///    }
        ///
        ///    MACAddress = MACAddress.Replace(":", "");
        ///    return MACAddress;
        ///}
        ///
    }
}
