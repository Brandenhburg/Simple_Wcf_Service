using CustomerService.Data;
using System.Linq;

namespace CustomerService.ManageAccounts
{
    public class SavingsAccountManager : IAccountManager
    {
        public void Deposit(int customerId, decimal funds)
        {
            //Database.MockCustomers.FirstOrDefault(c => c.Id == customerId).SavingsBalance += funds;

            using (BankDatabaseContainer context = new BankDatabaseContainer())
                context.spBankDatabase_DepositToSavingsAccount(customerId, funds);
        }
        public void Withdraw(int customerId, decimal requestedFunds)
        {
            //Database.MockCustomers.FirstOrDefault(c => c.Id == customerId).SavingsBalance -= requestedFunds;

            using (BankDatabaseContainer context = new BankDatabaseContainer())
                context.spBankDatabase_WithdrawalFromSavingsAccount(customerId, requestedFunds);
        }
        public bool EnoughFunds(int customerId, decimal requestedFunds)
        {
            bool isEnough = false;

            //isEnough = Database.MockCustomers.FirstOrDefault(c => c.Id == customerId).SavingsBalance >= requestedFunds ? true : false;

            using (BankDatabaseContainer context = new BankDatabaseContainer())
                isEnough = context.Customers.FirstOrDefault(c => c.Id == customerId).SavingsAccount.SavingsBalance > requestedFunds ? true : false;

            return isEnough;
        }
    }
}
