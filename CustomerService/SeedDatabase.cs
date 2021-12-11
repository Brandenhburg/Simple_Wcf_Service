using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    public static class SeedDatabase
    {
        public static void Seed()
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
    }
}
