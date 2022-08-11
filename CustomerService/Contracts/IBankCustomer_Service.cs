using System.Collections.Generic;
using System.ServiceModel;

namespace CustomerService.Contracts
{
    [ServiceContract(CallbackContract  = typeof(ICustomerService_DuplexCallBack), SessionMode = SessionMode.Required)]
    public interface IBankCustomer_Service
    {
        [OperationContract(IsOneWay = true)]
        void CreateCustomer(string firstName, string lastName, string email, string createdOnDate, decimal currentFunds = 0, decimal savingsFunds = 0);

        [OperationContract(IsOneWay = true)]
        void DeleteCustomer(int id);

        [OperationContract(IsOneWay = true)]
        void GetCustomerInfo(int id);

        [OperationContract(IsOneWay = true)]
        void Withdraw(int customerId, decimal amount, string fromAccountType);

        [OperationContract(IsOneWay = true)]
        void Deposit(int customerId, decimal amount, string toAccountType);

        [OperationContract(IsOneWay = true)]
        void InnerTransfer(int customerId, decimal amount, string fromAccountType, string toAccountType);

        [OperationContract(IsOneWay = true)]
        void GetAllCustomers();

        [OperationContract(IsOneWay = true)]
        void FilterCustomers(string column, string substringValue);
        
    }

    public interface ICustomerService_DuplexCallBack
    {
        [OperationContract(IsOneWay = true)]
        void SendCustomerInfo(CustomerInfo cust);

        [OperationContract(IsOneWay = true)]
        void OperationResult(string result);

        [OperationContract(IsOneWay = true)]
        void SendAllCustomers(IEnumerable<CustomerInfo> customers);
    }
}
