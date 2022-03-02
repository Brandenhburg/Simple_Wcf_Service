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
                Console.WriteLine("Service Host started");
                
                Console.ReadLine();
            }
        }

        
    }
}
