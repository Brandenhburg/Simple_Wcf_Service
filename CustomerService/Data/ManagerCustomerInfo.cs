using System;
using System.Collections.Generic;
using System.Linq;
using CustomerService;
using CustomerService.Exceptions;

namespace CustomerService.Data
{
    public class ManagerCustomerInfo : IManagerCustomerInfo
    {
        public CustomerInfo GetUpdatedInfo(int id)
        {
            CustomerInfo customerInfo = new CustomerInfo();
            using (BankDatabaseContainer context = new BankDatabaseContainer())
            {

                var customer = context.Customers.FirstOrDefault(c => c.Id == id);

                if (customer == null)
                {
                    customerInfo = null;
                    throw new CustomerException("No customer has been found");
                }

                customerInfo.Id = customer.Id;
                customerInfo.FirstName = customer.Firstname;
                customerInfo.LastName = customer.Lastname;
                customerInfo.Email = customer.Email;
                customerInfo.JoinedOnDate = customer.JoinedOnDate;
                customerInfo.CurrentBalance = customer.CurrentAccount.CurrentBalance;
                customerInfo.SavingsBalance = customer.SavingsAccount.SavingsBalance;
            }
            return customerInfo;
        }
        public IEnumerable<CustomerInfo> GetAllCustomers()
        {
            List<CustomerInfo> allCustomers = new List<CustomerInfo>();

            using (BankDatabaseContainer context = new BankDatabaseContainer())
            {
                if (context.Customers.Count() > 0)
                {
                    context.Customers.AsParallel().ForAll(c =>
                    {
                        allCustomers.Add(new CustomerInfo { Id = c.Id, FirstName = c.Firstname, LastName = c.Lastname, Email = c.Email, JoinedOnDate = c.JoinedOnDate });
                    });

                    context.CurrentAccounts.AsParallel().ForAll(ca =>
                    {
                        allCustomers.FirstOrDefault(c => c.Email == ca.CustomerEmail).CurrentBalance = ca.CurrentBalance;
                    });

                    context.SavingsAccounts.AsParallel().ForAll(sa =>
                    {
                        allCustomers.FirstOrDefault(c => c.Email == sa.CustomerEmail).SavingsBalance = sa.SavingsBalance;
                    });
                }
                else
                    throw new CustomerException("No registerd customers");
            }
            return allCustomers;
        }
        public void AddNewCustomer(string firstName, string lastName, string email, string DateOfJoin, decimal currentFunds = 0, decimal savingsFunds = 0)
        {
            using (BankDatabaseContainer context = new BankDatabaseContainer())
            {
                context.spBankDatabase_AddNewCustomer(firstName, lastName, email, DateOfJoin, currentFunds, savingsFunds);
                if (context.Customers.FirstOrDefault(c => c.Email == email) == null)
                    throw new CustomerException("Something went wrong, try again later");
            }              
        }
        public void DeleteCustomer(int customerId)
        {

            using (BankDatabaseContainer context = new BankDatabaseContainer())
            {
                if (context.Customers.FirstOrDefault(c => c.Id == customerId) == null)
                    throw new CustomerException("No customer has been found");

                context.spBankDatabase_DeleteCustomer(customerId);

                if (context.Customers.FirstOrDefault(c => c.Id == customerId) != null)
                    throw new CustomerException("Something went wrong, try again later");
            }    
        }
    }
}
