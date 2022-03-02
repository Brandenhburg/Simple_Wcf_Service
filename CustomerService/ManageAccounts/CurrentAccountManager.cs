using CustomerService.Data;
using System.Linq;
using System;

namespace CustomerService.ManageAccounts
{
    public class CurrentAccountManager : IAccountManager
    {
        public void Deposit(int customerId, decimal funds)
        {

            //Database.MockCustomers.FirstOrDefault(c => c.Id == customerId).CurrentBalance += funds;

            using (BankDatabaseContainer context = new BankDatabaseContainer())
                context.spBankDatabase_DepositToCurrentAccount(customerId, funds);   
        }
        public void Withdraw(int customerId, decimal requestedFunds)
        {
            //Database.MockCustomers.FirstOrDefault(c => c.Id == customerId).CurrentBalance -= requestedFunds;

            using (BankDatabaseContainer context = new BankDatabaseContainer())
                context.spBankDatabase_WithdrawalFromCurrentAccount(customerId, requestedFunds);
        }
        public bool EnoughFunds(int customerId, decimal requestedFunds)
        {
            bool isEnough = false;

            //isEnough = Database.MockCustomers.FirstOrDefault(c => c.Id == customerId).CurrentBalance >= requestedFunds ? true : false;

            using (BankDatabaseContainer context = new BankDatabaseContainer())
                isEnough = context.Customers.FirstOrDefault(c => c.Id == customerId).CurrentAccount.CurrentBalance >= requestedFunds ? true : false;
                
            return isEnough;
        }
    }
}
