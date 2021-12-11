using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUI.Operations
{
    public interface IOperationType
    {
        void ProcessOperation(int customerId, decimal amount, string fromAccount = null, string toAccount = null);
    }
}
