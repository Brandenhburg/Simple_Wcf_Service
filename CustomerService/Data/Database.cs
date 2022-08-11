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

        public static void SeedDB() => Seed();


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

        private static void Seed()
        {
            using (BankDatabaseContainer context = new BankDatabaseContainer())
            {
                for (int i = 0; i < 40; i++)
                {
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("John", "Coltrane", "JohnColtrane@email.com", DateTime.Now.ToString(), 4575, 5545);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Duke", "Ellington", "DukeEllington@email.com", DateTime.Now.ToString(), 123, 321);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Candy", "Dulfer", "CandyDulfer@email.com", DateTime.Now.ToString(), 456, 654);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Marvin", "Gaye", "MarvinGaye@email.com", DateTime.Now.ToString(), 789, 987);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Norah", "Jones", "NorahJones@email.com", DateTime.Now.ToString(), 147, 741);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Eydis", "Evensen", "EydisEvensen@email.com", DateTime.Now.ToString(), 258, 369);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Herbie", "Hancock", "HerbieHancock@email.com", DateTime.Now.ToString(), 369, 963);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Miles", "Davis", "MilesDavis@email.com", DateTime.Now.ToString(), 258, 369);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Adriano", "Celentatno", "AdrianoCelentano@email.com", DateTime.Now.ToString(), 258, 369);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Hans", "Zimmer", "HansZimmer@email.com", DateTime.Now.ToString(), 258, 1250);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Wolfgang Amadeus", "Mozzart", "WolfgangAmadeusMozzart@email.com", DateTime.Now.ToString(), 1577, 369);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Ludwig", "van Beethoven", "LudwigvanBeethoven@email.com", DateTime.Now.ToString(), 5858, 3545);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Johannes", "Brahms", "JohannesBrahms@email.com", DateTime.Now.ToString(), 784, 745);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Franz", "Schubert", "FranzSchubert@email.com", DateTime.Now.ToString(), 2536, 1452);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Giuseppe", "Verdi", "GiuseppeVerdi@email.com", DateTime.Now.ToString(), 5847, 8584);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Richard", "Wagner", "RichardWagner@email.com", DateTime.Now.ToString(), 8547, 3565);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Franz", "Liszt", "FranzLiszt@email.com", DateTime.Now.ToString(), 1437, 2789);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Claude", "Debussy", "ClaudeDebussy@email.com", DateTime.Now.ToString(), 4531, 3565);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Johann Sebastian", "Bach", "JohannSebastianBach@email.com", DateTime.Now.ToString(), 5858, 3595);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Antonio", "Vivaldi", "AntonioVivaldi@email.com", DateTime.Now.ToString(), 8851, 1457);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Maurice", "Ravel", "MauriceRavel@email.com", DateTime.Now.ToString(), 1185, 4771);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Peter", "Tchaikovsky", "PeterTchaikovsky@email.com", DateTime.Now.ToString(), 5236, 3565);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Khatia", "Bunitiashvili", "KhatiaBunitiashvili@email.com", DateTime.Now.ToString(), 7721, 1111);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Johann", "Strauss", "JohannStrauss@email.com", DateTime.Now.ToString(), 8512, 9635);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Hector", "Berlioz", "HectorBerlioz@email.com", DateTime.Now.ToString(), 7856, 7854);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Dmitrii", "Shostakovich", "DmitriiShostakovich@email.com", DateTime.Now.ToString(), 5858, 7859);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Aaron", "Copland", "AaronCopland@email.com", DateTime.Now.ToString(), 7453, 7452);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Gustav", "Mahler", "GustavMahler@email.com", DateTime.Now.ToString(), 7455, 3565);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Frederic", "Shopin", "FredericShopin@email.com", DateTime.Now.ToString(), 8582, 4521);
                    context.spBankDatabase_CreateNewCustomer_AllowDuplicates("Joseph", "Haydn", "JosephHaydn@email.com", DateTime.Now.ToString(), 4554, 787);
                }
            }
            
        }
    }
}
