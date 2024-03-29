﻿using System;
using System.Collections.Generic;
using System.ServiceModel;
using CustomerService.Data;
using CustomerService.ManageAccounts;
using CustomerService.Exceptions;
using CustomerService.Contracts;
using System.ServiceModel.Channels;

namespace CustomerService
{

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Single)]
    public class BankCustomer_Service : IBankCustomer_Service
    {
        private Accounts accounts;
        private IManagerCustomerInfo manageCustomerInfo;
        private IAccountManager accountManager;
        public BankCustomer_Service()
        {
            //manageCustomerInfo = new ManageMockCustomerInfo();
            manageCustomerInfo = new ManagerCustomerInfo();
            accounts = new Accounts();
        }


        public void CreateCustomer(string firstName, string lastName, string email, string createdOnDate, decimal currentFunds = 0, decimal savingsFunds = 0)
        {
            try
            {
                manageCustomerInfo.AddNewCustomer(firstName, lastName, email, createdOnDate, currentFunds, savingsFunds);
                OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Customer was successfully created");
            }
            catch (CustomerException ex)
            {
                OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult(ex.Message);
            }    
        }
        public void DeleteCustomer(int customerId)
        {
            try
            {
                manageCustomerInfo.DeleteCustomer(customerId);
                OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Customer was deleted from database");
            }
            catch (CustomerException ex)
            {
                OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult(ex.Message);
            }

        }


        #region [Get Customer INFO]
        public void GetCustomerInfo(int id)
        {
            try
            {
                CustomerInfo customerInfo = manageCustomerInfo.GetUpdatedInfo(id);
                OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().SendCustomerInfo(customerInfo);
            }          
            catch (CustomerException ex)
            {
                OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult(ex.Message);
            }
        }
        public void GetAllCustomers()
        {
            try
            {
                //OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().SendAllCustomers(Database.MockCustomers);
                
                List<CustomerInfo> customers = manageCustomerInfo.GetAllCustomers();

                Console.WriteLine($"Session ID {OperationContext.Current.SessionId}");
                
                for (int i = 0; i < customers.Count; i++)
                    OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().SendCustomerInfo(customers[i]);

            }
            catch (CustomerException ex)
            {
                OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult(ex.Message);     
            }
        }
        public void FilterCustomers(string column, string substringValue)
        {
            try
            {
                List<CustomerInfo> customers = manageCustomerInfo.FilterCustomers(column, substringValue);
                for (int i = 0; i < customers.Count; i++)
                    OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().SendCustomerInfo(customers[i]);
            }
            catch (Exception ex)
            {
                OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult(ex.Message);
            }         
        }
        #endregion

        #region [Operations]
        public void Deposit(int customerId, decimal amount, string toAccountType)
        {
            accountManager = accounts.GetAccessToTheAccount(toAccountType);
            accountManager.Deposit(customerId, amount);


            OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().SendCustomerInfo(manageCustomerInfo.GetUpdatedInfo(customerId));
            OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult($"Funds were deposited to {toAccountType}");
        }
        public void Withdraw(int customerId, decimal amount, string fromAccountType)
        {
            accountManager = accounts.GetAccessToTheAccount(fromAccountType);

            var isEnoughFunds = accountManager.EnoughFunds(customerId, amount);

            if (isEnoughFunds)
            {
                accountManager.Withdraw(customerId, amount);
                OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().SendCustomerInfo(manageCustomerInfo.GetUpdatedInfo(customerId));
                OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult($"Funds were withdrawn from {fromAccountType}");
            }
            else
                OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Not enough funds");
        }    
        public void InnerTransfer(int customerId, decimal amount, string fromAccountType, string toAccountType)
        {
            accountManager = accounts.GetAccessToTheAccount(fromAccountType);
            

            if (accountManager.EnoughFunds(customerId, amount))
            {
                accountManager.Withdraw(customerId, amount);
                accountManager = accounts.GetAccessToTheAccount(toAccountType);
                accountManager.Deposit(customerId, amount);
                OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().SendCustomerInfo(manageCustomerInfo.GetUpdatedInfo(customerId));
                OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult($"Funds were withdrawn from {fromAccountType} and deposited to {toAccountType}");
            }
            else
                OperationContext.Current.GetCallbackChannel<ICustomerService_DuplexCallBack>().OperationResult("Not enough funds");
        }
        #endregion

    }
}
