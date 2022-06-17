using System;
using System.ServiceModel;

namespace CustomerService
{
    class Program
    {
        static void  Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(BankCustomer_Service)))
            {
                host.Open();
                Console.WriteLine(host.BaseAddresses[0].ToString());
                //Console.WriteLine(host.BaseAddresses[1].ToString());
                Console.WriteLine("Service Host started...");
                
                Console.ReadLine();
            }
        }

        
    }
}
