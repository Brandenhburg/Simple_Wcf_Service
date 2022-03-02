using BankUI.Operations;

namespace BankUI
{
    public class CheckSelectedItems
    {
        public bool CheckSelectedAccounts(IOperationType operationType, int fromAccIndex = -1, int toAccIndex = -1)
        {

            if (operationType is DepositOperation && toAccIndex != -1)
                return true;

            if (operationType is WithdrawalOperation && fromAccIndex != -1)
                return true;

            if (operationType is InnerTransferOperation)
            {
                if (fromAccIndex != toAccIndex && fromAccIndex != -1 && toAccIndex != -1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
