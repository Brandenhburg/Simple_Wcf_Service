using CustomerService.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Data
{
    public class ManageMockCustomerInfo : IManagerCustomerInfo
    {
        public void AddNewCustomer(string firstName, string lastName, string email, string DateOfJoin, decimal currentFunds = 0, decimal savingsFunds = 0)
        {
            CustomerInfo newCustomer = new CustomerInfo()
            {
                Id = Database.MockCustomers.Last().Id + 1,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                JoinedOnDate = DateOfJoin,
                CurrentBalance = currentFunds,
                SavingsBalance = savingsFunds
            };

            Database.MockCustomers.Add(newCustomer);
        }

        public void DeleteCustomer(int customerId)
        {
            Database.MockCustomers.Remove(new CustomerInfo { Id = customerId });
        }

        public List<CustomerInfo> FilterCustomers(string column, string substringParam)
        {
            throw new NotImplementedException();
        }

        public List<CustomerInfo> FilterCustomers()
        {
            throw new NotImplementedException();
        }

        public List<CustomerInfo> GetAllCustomers() => Database.MockCustomers;

        public CustomerInfo GetUpdatedInfo(int customerid)
        {
            CustomerInfo mockCustomer = Database.MockCustomers.FirstOrDefault(c => c.Id == customerid);
            if (mockCustomer == null)
                throw new CustomerException("No customer has been found");

            return mockCustomer;
        }
    }
}
