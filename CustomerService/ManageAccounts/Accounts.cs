using System.Collections.Generic;
using System.Linq;

namespace CustomerService.ManageAccounts
{
    public class Accounts
    {
        Dictionary<string, IAccountManager> accounts;

            //  Dictionary<Type, IAccountManager>  typeOfAccounts;

        public Accounts()
        {
            accounts = new Dictionary<string, IAccountManager>();
            AddExistentAccTypes();
        }


        private void AddExistentAccTypes()
        {
            accounts.Add("Current Account", new CurrentAccountManager());
            accounts.Add("Savings Account", new SavingsAccountManager());


            //  typeOfAccounts.Add(typeof(CurrentAccount), new CurrentAccountManager());
            //  typeOfAccounts.Add(typeof(SavingsAccount), new SavingsAccManager());
        }


        public IAccountManager GetAccessToTheAccount(string accName) => accounts.FirstOrDefault(acc => acc.Key == accName).Value;

            //  public IAccountManager AccessToAccount(Type accType) => typeOfAccounts.FirstOrDefault(acc => acc.Key.GetType() == accType).Value;
    }
}
