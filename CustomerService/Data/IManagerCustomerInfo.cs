using System;
using System.Collections.Generic;

namespace CustomerService.Data
{
    public interface IManagerCustomerInfo
    {
        CustomerInfo GetUpdatedInfo(int customerId);
        List<CustomerInfo> GetAllCustomers();
        List<CustomerInfo> FilterCustomers(string column, string substrinValue);




        void AddNewCustomer(string firstName, string lastName, string email, string DateOfJoin, decimal currentFunds = 0, decimal savingsFunds = 0);
        void DeleteCustomer(int customerId);
        //Tuple<bool, bool> CheckAccFunds(int customerid, decimal requestedFunds);
    }
}