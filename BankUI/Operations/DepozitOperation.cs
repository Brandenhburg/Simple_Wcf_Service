using BankUI.BankCustomers;

namespace BankUI.Operations
{
    public class DepozitOperation : IOperationType
    {
        private readonly BankCustomer_ServiceClient serviceCLient;
        public DepozitOperation(BankCustomer_ServiceClient serviceCLient)
        {
            this.serviceCLient = serviceCLient;
        }
        public void ProcessOperation(int customerId, decimal amount, string fromAccount = null, string toAccount = null)
        {
            serviceCLient.Depozit(customerId, amount, toAccount);
        }
    }
}
