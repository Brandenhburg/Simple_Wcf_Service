using BankUI.BankCustomers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BankUI.Operations
{
    public class InnerTransferOperation : IOperationType
    {
        BankCustomer_ServiceClient serviceClient;
        public InnerTransferOperation(BankCustomer_ServiceClient serviceClient)
        {
            this.serviceClient = serviceClient;
        }

        public void ProcessOperation(int customerId, decimal amount, string fromAccount = null, string toAccount = null)
        {
            serviceClient.InnerTransfer(customerId, amount, fromAccount, toAccount);
        }
    }
}
