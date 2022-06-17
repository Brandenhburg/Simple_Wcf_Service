using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using SecurityService_Host.Data;

namespace SecurityService_Host
{
    internal class Program
    {
        static  void Main(string[] args)
        {

            using (ServiceHost host = new ServiceHost(typeof(SecurityService)))
            {
                WorkersMockDatabase.AddNewWorker( "user",  "user" , "user");
                host.Open();
                Console.WriteLine(host.BaseAddresses[0].ToString()); 
                Console.WriteLine("Service Host started");
                Console.ReadLine();
            }

        }
    }
}
