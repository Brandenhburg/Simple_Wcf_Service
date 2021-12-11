using BankUI.BankCustomers;
using System.ServiceModel;

namespace BankUI.Operations
{
    public class WithdrawalOperation : IOperationType
    {
        private readonly BankCustomer_ServiceClient serviceClient;

        public WithdrawalOperation(BankCustomer_ServiceClient serviceClient)
        {
            this.serviceClient = serviceClient;
        }

        public void ProcessOperation(int customerId, decimal amount, string fromAccount = null, string toAccount = null)
        {
            serviceClient.Withdraw(customerId, amount, fromAccount);
        }
    }
}
