﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankUI.BankCustomers {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerInfo", Namespace="http://schemas.datacontract.org/2004/07/CustomerService")]
    [System.SerializableAttribute()]
    public partial class CustomerInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal CurrentBalanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JoinedOnDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal SavingsBalanceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal CurrentBalance {
            get {
                return this.CurrentBalanceField;
            }
            set {
                if ((this.CurrentBalanceField.Equals(value) != true)) {
                    this.CurrentBalanceField = value;
                    this.RaisePropertyChanged("CurrentBalance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JoinedOnDate {
            get {
                return this.JoinedOnDateField;
            }
            set {
                if ((object.ReferenceEquals(this.JoinedOnDateField, value) != true)) {
                    this.JoinedOnDateField = value;
                    this.RaisePropertyChanged("JoinedOnDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal SavingsBalance {
            get {
                return this.SavingsBalanceField;
            }
            set {
                if ((this.SavingsBalanceField.Equals(value) != true)) {
                    this.SavingsBalanceField = value;
                    this.RaisePropertyChanged("SavingsBalance");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BankCustomers.IBankCustomer_Service", CallbackContract=typeof(BankUI.BankCustomers.IBankCustomer_ServiceCallback))]
    public interface IBankCustomer_Service {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/CreateCustomer")]
        void CreateCustomer(string firstName, string lastName, string email, string createdOnDate, decimal currentFunds, decimal savingsFunds);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/CreateCustomer")]
        System.Threading.Tasks.Task CreateCustomerAsync(string firstName, string lastName, string email, string createdOnDate, decimal currentFunds, decimal savingsFunds);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/DeleteCustomer")]
        void DeleteCustomer(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/DeleteCustomer")]
        System.Threading.Tasks.Task DeleteCustomerAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/GetCustomerInfo")]
        void GetCustomerInfo(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/GetCustomerInfo")]
        System.Threading.Tasks.Task GetCustomerInfoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/Withdraw")]
        void Withdraw(int customerId, decimal amount, string fromAccountType);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/Withdraw")]
        System.Threading.Tasks.Task WithdrawAsync(int customerId, decimal amount, string fromAccountType);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/Depozit")]
        void Depozit(int customerId, decimal amount, string toAccountType);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/Depozit")]
        System.Threading.Tasks.Task DepozitAsync(int customerId, decimal amount, string toAccountType);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/InnerTransfer")]
        void InnerTransfer(int customerId, decimal amount, string fromAccountType, string toAccountType);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/InnerTransfer")]
        System.Threading.Tasks.Task InnerTransferAsync(int customerId, decimal amount, string fromAccountType, string toAccountType);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/GetAllCustomers")]
        void GetAllCustomers();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/GetAllCustomers")]
        System.Threading.Tasks.Task GetAllCustomersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBankCustomer_ServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/SendCustomerInfo")]
        void SendCustomerInfo(BankUI.BankCustomers.CustomerInfo cust);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/OperationResult")]
        void OperationResult(string result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankCustomer_Service/SendAllCustomers")]
        void SendAllCustomers(BankUI.BankCustomers.CustomerInfo[] customers);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBankCustomer_ServiceChannel : BankUI.BankCustomers.IBankCustomer_Service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BankCustomer_ServiceClient : System.ServiceModel.DuplexClientBase<BankUI.BankCustomers.IBankCustomer_Service>, BankUI.BankCustomers.IBankCustomer_Service {
        
        public BankCustomer_ServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public BankCustomer_ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public BankCustomer_ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public BankCustomer_ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public BankCustomer_ServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void CreateCustomer(string firstName, string lastName, string email, string createdOnDate, decimal currentFunds, decimal savingsFunds) {
            base.Channel.CreateCustomer(firstName, lastName, email, createdOnDate, currentFunds, savingsFunds);
        }
        
        public System.Threading.Tasks.Task CreateCustomerAsync(string firstName, string lastName, string email, string createdOnDate, decimal currentFunds, decimal savingsFunds) {
            return base.Channel.CreateCustomerAsync(firstName, lastName, email, createdOnDate, currentFunds, savingsFunds);
        }
        
        public void DeleteCustomer(int id) {
            base.Channel.DeleteCustomer(id);
        }
        
        public System.Threading.Tasks.Task DeleteCustomerAsync(int id) {
            return base.Channel.DeleteCustomerAsync(id);
        }
        
        public void GetCustomerInfo(int id) {
            base.Channel.GetCustomerInfo(id);
        }
        
        public System.Threading.Tasks.Task GetCustomerInfoAsync(int id) {
            return base.Channel.GetCustomerInfoAsync(id);
        }
        
        public void Withdraw(int customerId, decimal amount, string fromAccountType) {
            base.Channel.Withdraw(customerId, amount, fromAccountType);
        }
        
        public System.Threading.Tasks.Task WithdrawAsync(int customerId, decimal amount, string fromAccountType) {
            return base.Channel.WithdrawAsync(customerId, amount, fromAccountType);
        }
        
        public void Depozit(int customerId, decimal amount, string toAccountType) {
            base.Channel.Depozit(customerId, amount, toAccountType);
        }
        
        public System.Threading.Tasks.Task DepozitAsync(int customerId, decimal amount, string toAccountType) {
            return base.Channel.DepozitAsync(customerId, amount, toAccountType);
        }
        
        public void InnerTransfer(int customerId, decimal amount, string fromAccountType, string toAccountType) {
            base.Channel.InnerTransfer(customerId, amount, fromAccountType, toAccountType);
        }
        
        public System.Threading.Tasks.Task InnerTransferAsync(int customerId, decimal amount, string fromAccountType, string toAccountType) {
            return base.Channel.InnerTransferAsync(customerId, amount, fromAccountType, toAccountType);
        }
        
        public void GetAllCustomers() {
            base.Channel.GetAllCustomers();
        }
        
        public System.Threading.Tasks.Task GetAllCustomersAsync() {
            return base.Channel.GetAllCustomersAsync();
        }
    }
}
