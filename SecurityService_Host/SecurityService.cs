using SecurityService_Host.Data;
using System.Threading.Tasks;
using System.ServiceModel;
using System;
using System.Threading;

namespace SecurityService_Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class SecurityService : ISecurity_Service
    {
        public async Task<bool> SignUp(string username, string email, string password) =>
                await Task.Factory.StartNew(() => EmployeesMockDatabase.IsNewEmployeeCreated(username, email, password));

        public async Task<Employee> SignIn(string userName, string password)
        {
            Employee worker = await Task.Factory.StartNew(() => EmployeesMockDatabase.GetEployee(userName, password));
            if (worker == null)
                throw new FaultException("Wrong Username or Password");
            else
                return worker;
        }    
    }
}
