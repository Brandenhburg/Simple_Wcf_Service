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

                //CustomerInfo customerInfo = new CustomerInfo();
                //Customer customer;
                //BankCustomer_Service service = new BankCustomer_Service();


                //using (BankDatabaseContainer context = new BankDatabaseContainer())
                //{

                //    customer = context.Customers.Find(25);
                //    customerInfo.CurrentBalance = customer.CurrentAccount.CurrentBalance;
                //    customerInfo.SavingsBalance = customer.SavingsAccount.SavingsBalance;
                //    customerInfo.Id = customer.Id;
                //    customerInfo.FirstName = customer.Firstname;
                //    customerInfo.LastName = customer.Lastname;
                //    customerInfo.Email = customer.Email;
                //    customerInfo.JoinedOnDate = customer.JoinedOnDate;

                //}


                //Console.WriteLine($"{customerInfo.Id}, {customerInfo.FirstName}, {customerInfo.LastName}, {customerInfo.SavingsBalance}, {customerInfo.CurrentBalance}, {customerInfo.Email}");

                //service.InnerTransfer(25, 100, "Savings Account", "Current Account");

                //using (BankDatabaseContainer context = new BankDatabaseContainer())
                //{

                //    customer = context.Customers.Find(25);
                //    customerInfo.CurrentBalance = customer.CurrentAccount.CurrentBalance;
                //    customerInfo.SavingsBalance = customer.SavingsAccount.SavingsBalance;
                //    customerInfo.Id = customer.Id;
                //    customerInfo.FirstName = customer.Firstname;
                //    customerInfo.LastName = customer.Lastname;
                //    customerInfo.Email = customer.Email;
                //    customerInfo.JoinedOnDate = customer.JoinedOnDate;

                //}
                //foreach (var item in service.getCustomersFromDb())
                //{
                //    Console.WriteLine($" {item.Id}, {item.FirstName}, { item.LastName},{ item.Email},{ item.JoinedOnDate},{ item.CurrentBalance},{ item.SavingsBalance}");
                //}

                Console.ReadLine();
            }
        }
    }
}
