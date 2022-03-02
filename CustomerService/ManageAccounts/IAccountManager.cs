namespace CustomerService.ManageAccounts
{
    public interface IAccountManager
    {
        void Deposit(int customerId, decimal funds);
        void Withdraw(int customerId, decimal funds);
        bool EnoughFunds(int customerId, decimal requestedFunds);
    }
}