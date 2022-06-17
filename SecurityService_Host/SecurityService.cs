using SecurityService_Host.Data;
using System;
using SecurityService_Host.SecurityServices;

namespace SecurityService_Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class SecurityService : ISecurity_Service
    {
        public void GetAccessToSystem(string username, string email, string unhashed) => WorkersMockDatabase.AddNewWorker(username, email, unhashed);

        public bool Login(string userName, string password)
        {
            if (WorkersMockDatabase.Workers.Exists(w => w.Username == userName))
                return SecurityManager.CheckUsersPassword(userName, password);

            return false;
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

    }
}
