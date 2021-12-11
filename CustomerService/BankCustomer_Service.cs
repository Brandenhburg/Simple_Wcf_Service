using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading;

namespace CustomerService
{
    //[ServiceBehavior(TransactionIsolationLevel = IsolationLevel.ReadCommitted, TransactionTimeout = "00:00:45")]

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Single)]
    public class BankCustomer_Service : IBankCustomer_Service
    {
        public void CreateCustomer(string firstName, string lastName, string email, string createdOnDate, decimal currentFunds = 0, decimal savingsFunds = 0)
        {
            using (BankDatabaseContainer context = new BankDatabaseContainer())
            {
                context.spBankDatabase_AddNewCustomer(firstName, lastName, email, createdOnDate, currentFunds, savingsFunds);
                context.SaveChanges();

                if (context.Customers.FirstOrDefault(e => e.Email == email) == null)
                {
                    OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Something went wrong. Try again");
                }
                else
                {
                    OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Customer Created");
                }
            }
        }

        public void DeleteCustomer(int id)
        {
            using (BankDatabaseContainer context = new BankDatabaseContainer())
            {
                if (context.Customers.FirstOrDefault(c => c.Id == id) == null)
                {
                    OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Customer with such Id not found");
                }
                else
                {
                    context.spBankDatabase_DeleteCustomer(id);
                    context.SaveChanges();
                    OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Customer deleted");
                }
                    
            }
        }

        public void  GetCustomerInfo(int id)
        {

            CustomerInfo customer = getUpdatedInfo(id);

            if (customer is null)
            {
                //throw new FaultException("Customer with such Id not found");
                OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Customer with such Id not found");
                return;
            }
            OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().SendCustomerInfo(getUpdatedInfo(id));

            Console.WriteLine($"{OperationContext.Current.SessionId}, {Thread.CurrentThread.ManagedThreadId}");
        }

        public void Depozit(int customerId, decimal fundsTodepozit, string toAccountType)
        {
            using (BankDatabaseContainer context = new BankDatabaseContainer())
            {
                if (toAccountType == "Current Account")
                {
                    context.CurrentAccounts.FirstOrDefault(c => c.Customer.Id == customerId).CurrentBalance += fundsTodepozit;
                    context.SaveChanges();
                    OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().SendCustomerInfo(getUpdatedInfo(customerId));
                    OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Operation Succeded");
                }
                else
                {
                    context.SavingsAccounts.FirstOrDefault(c => c.Customer.Id == customerId).SavingsBalance += fundsTodepozit;
                    context.SaveChanges();
                    OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().SendCustomerInfo(getUpdatedInfo(customerId));
                    OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Operation Succeded");
                }
            }
        }

        public void Withdraw(int customerId, decimal amount, string fromAccountType)
        {
            using (BankDatabaseContainer context = new BankDatabaseContainer())
            {
                if (fromAccountType == "Current Account")
                {
                    if (context.CurrentAccounts.FirstOrDefault(c => c.Customer.Id == customerId).CurrentBalance < amount)
                    {
                        OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Not enough funds to perform operation");
                    }  
                    else
                    {
                        context.CurrentAccounts.FirstOrDefault(a => a.Customer.Id == customerId).CurrentBalance -= amount;
                        context.SaveChanges();
                        OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().SendCustomerInfo(getUpdatedInfo(customerId));
                        OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Operation succeded");
                    }
                }
                else
                {
                    if (context.SavingsAccounts.FirstOrDefault(c => c.Customer.Id == customerId).SavingsBalance < amount)
                    {
                        OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Not enough funds to perform operation");
                        return;
                    }               
                    else
                    {
                        context.SavingsAccounts.FirstOrDefault(c => c.Customer.Id == customerId).SavingsBalance -= amount;
                        context.SaveChanges();
                        OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().SendCustomerInfo(getUpdatedInfo(customerId));
                        OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Operation succeded");
                    }
                }
            }
        }

        public void InnerTransfer(int customerId, decimal amount, string fromAccountType, string toAccountType)
        {
            using (BankDatabaseContainer context = new BankDatabaseContainer())
            {
                if (fromAccountType == "Current Account")
                {
                    if (context.CurrentAccounts.FirstOrDefault(a => a.Customer.Id == customerId).CurrentBalance < amount)
                    {
                        OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Not enough funds to perform operation");
                    }
                    else
                    {
                        context.CurrentAccounts.FirstOrDefault(a => a.Customer.Id == customerId).CurrentBalance -= amount;
                        context.SavingsAccounts.FirstOrDefault(a => a.Customer.Id == customerId).SavingsBalance += amount;

                        context.SaveChanges();
                        OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().SendCustomerInfo(getUpdatedInfo(customerId));
                        OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Operation Succeded");

                    }
     
                }
                else
                {
                    if (context.SavingsAccounts.FirstOrDefault(a => a.Customer.Id == customerId).SavingsBalance < amount)
                    {
                        OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Not enough funds to perform operation");
                    }
                    else
                    {
                        context.SavingsAccounts.FirstOrDefault(a => a.Customer.Id == customerId).SavingsBalance -= amount;
                        context.CurrentAccounts.FirstOrDefault(a => a.Customer.Id == customerId).CurrentBalance += amount;

                        context.SaveChanges();
                        OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().SendCustomerInfo(getUpdatedInfo(customerId));
                        OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Operation Succeded");
                    }    
                }
            }
            
        }

        public void GetAllCustomers()
        {
            OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().SendAllCustomers(getCustomersFromDb());
        }



        private CustomerInfo getUpdatedInfo(int customerId)
        {
            CustomerInfo customerInfo = new CustomerInfo();

            using (BankDatabaseContainer context = new BankDatabaseContainer())
            {
                Customer cust = context.Customers.FirstOrDefault(c => c.Id == customerId);

                if (cust == null)
                {
                    customerInfo = null;
                    return customerInfo;
                }

                customerInfo.Id = cust.Id;
                customerInfo.FirstName = cust.Firstname;
                customerInfo.LastName = cust.Lastname;
                customerInfo.Email = cust.Email;
                customerInfo.JoinedOnDate = cust.JoinedOnDate;
                customerInfo.CurrentBalance = cust.CurrentAccount.CurrentBalance;
                customerInfo.SavingsBalance = cust.SavingsAccount.SavingsBalance;

            }

            return customerInfo;
        }
        private IEnumerable<CustomerInfo> getCustomersFromDb()
        {
            List<CustomerInfo> customerInfos = new List<CustomerInfo>();

            using (BankDatabaseContainer context = new BankDatabaseContainer())
            {
                context.Customers.AsParallel().ForAll(c =>
                {
                    customerInfos.Add(new CustomerInfo { Id = c.Id, FirstName = c.Firstname, LastName = c.Lastname, Email = c.Email, JoinedOnDate = c.JoinedOnDate });
                });

                context.CurrentAccounts.AsParallel().ForAll(ca => 
                {
                    customerInfos.FirstOrDefault(c => c.Email == ca.CustomerEmail).CurrentBalance = ca.CurrentBalance;
                });

                context.SavingsAccounts.AsParallel().ForAll(sa =>
                {
                    customerInfos.FirstOrDefault(c => c.Email == sa.CustomerEmail).SavingsBalance = sa.SavingsBalance;
                });
            }

            return customerInfos;
        }
    }
}
