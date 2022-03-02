using BankUI.BankCustomers;

namespace BankUI.Operations
{
    public class DepositOperation : IOperationType
    {
        private readonly BankCustomer_ServiceClient serviceCLient;
        public DepositOperation(BankCustomer_ServiceClient serviceCLient)
        {
            this.serviceCLient = serviceCLient;
        }
        public void ProcessOperation(int customerId, decimal amount, string fromAccount = null, string toAccount = null)
        {
            serviceCLient.Deposit(customerId, amount, toAccount);
        }
    }
}
