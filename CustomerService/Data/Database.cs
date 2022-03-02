using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    public class Database
    {
        public static List<CustomerInfo> MockCustomers { get => SeedMockDb(); }

        public static void SeedDB()
        {
            using (BankDatabaseContainer context = new BankDatabaseContainer())
            {
                if (context.Customers.Count() == 0)
                {
                    context.spBankDatabase_AddNewCustomer("Duke", "Ellington", "DukeEllington@email.com", DateTime.Now.ToString(), 123, 321);
                    context.spBankDatabase_AddNewCustomer("Candy", "Dulfer", "CandyDulfer@email.com", DateTime.Now.ToString(), 456, 654);
                    context.spBankDatabase_AddNewCustomer("Marvin", "Gaye", "MarvinGaye@email.com", DateTime.Now.ToString(), 789, 987);
                    context.spBankDatabase_AddNewCustomer("Norah", "Jones", "NorahJones@email.com", DateTime.Now.ToString(), 147, 741);
                    context.spBankDatabase_AddNewCustomer("Eydis", "Evensen", "EydisEvensen@email.com", DateTime.Now.ToString(), 258, 369);
                    context.spBankDatabase_AddNewCustomer("Herbie", "Hancock", "HerbieHancock@email.com", DateTime.Now.ToString(), 369, 963);
                    context.spBankDatabase_AddNewCustomer("Miles", "Davis", "MilesDavis@email.com", DateTime.Now.ToString(), 258, 369);
                }                
            }
        }

        private static List<CustomerInfo> SeedMockDb()
        {
            List<CustomerInfo> mockDb = new List<CustomerInfo>();

            if (mockDb.Count == 0)
            {
                mockDb.Add(new CustomerInfo { Id = 1, FirstName = "Duke", LastName = "Ellington", Email = "DukeEllington@email.com", JoinedOnDate = DateTime.Now.ToString(), CurrentBalance = 123, SavingsBalance = 321 });
                mockDb.Add(new CustomerInfo { Id = 1, FirstName = "Candy", LastName = "Dulfer", Email = "CandyDulfer@email.com", JoinedOnDate = DateTime.Now.ToString(), CurrentBalance = 456, SavingsBalance = 654 });
                mockDb.Add(new CustomerInfo { Id = 1, FirstName = "Marvin", LastName = "Gaye", Email = "MarvinGaye@email.com", JoinedOnDate = DateTime.Now.ToString(), CurrentBalance = 789, SavingsBalance = 987 });
                mockDb.Add(new CustomerInfo { Id = 1, FirstName = "Norah", LastName = "Jones", Email = "NorahJones@email.com", JoinedOnDate = DateTime.Now.ToString(), CurrentBalance = 147, SavingsBalance = 741 });
                mockDb.Add(new CustomerInfo { Id = 1, FirstName = "Eydis", LastName = "Evensen", Email = "EydisEvensen@email.com", JoinedOnDate = DateTime.Now.ToString(), CurrentBalance = 245, SavingsBalance = 369 });
                mockDb.Add(new CustomerInfo { Id = 1, FirstName = "Herbie", LastName = "Hancock", Email = "HerbieHancock@email.com", JoinedOnDate = DateTime.Now.ToString(), CurrentBalance = 369, SavingsBalance = 963 });
                mockDb.Add(new CustomerInfo { Id = 1, FirstName = "Miles", LastName = "Davis", Email = "MilesDavis@email.com", JoinedOnDate = DateTime.Now.ToString(), CurrentBalance = 258, SavingsBalance = 369 });
            }
            return mockDb;
        }
    }
}
