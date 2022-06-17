using System;
using System.Collections.Generic;
using SecurityService_Host.SecurityServices;

namespace SecurityService_Host.Data
{
    public static  class WorkersMockDatabase
    {
        //private static List<Worker> workers = new List<Worker>();


        public static List<Worker> Workers { get; private set; } = new List<Worker>();

        //public static List<Worker> Workers { get => workers; }

        public static  void AddNewWorker(string userName, string email,  string password)
        {
            if (!Workers.Exists(w => w.Username == userName) && !Workers.Exists(w => w.EMail == email))
            {
                Guid id = Guid.NewGuid();
                string hashedPassword = SecurityManager.Hash(id, password);
                Workers.Add(new Worker { Id = id, Username = userName, EMail = email, Password = hashedPassword });

            }
        }
    }
}
