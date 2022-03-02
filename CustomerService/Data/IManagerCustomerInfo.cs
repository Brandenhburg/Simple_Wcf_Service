using System;
using System.Collections.Generic;

namespace CustomerService.Data
{
    public interface IManagerCustomerInfo
    {
        void AddNewCustomer(string firstName, string lastName, string email, string DateOfJoin, decimal currentFunds = 0, decimal savingsFunds = 0);
        void DeleteCustomer(int customerId);
        IEnumerable<CustomerInfo> GetAllCustomers();
        CustomerInfo GetUpdatedInfo(int customerId);
        //Tuple<bool, bool> CheckAccFunds(int customerid, decimal requestedFunds);
    }
}