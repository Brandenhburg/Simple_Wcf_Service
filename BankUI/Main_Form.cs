﻿using System;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


using BankUI.BankCustomers;
using BankUI.Operations;

namespace BankUI
{
    public partial class Main_Form : Form, IBankCustomer_ServiceCallback
    {
        IOperationType operationType;
        CustomerInfo customerInfo;
        CheckSelectedItems check;

        InstanceContext instance;
        BankCustomer_ServiceClient bankCustomer_ServiceClient;
        public Main_Form()
        {
            
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;


            instance = new InstanceContext(this);
            bankCustomer_ServiceClient = new BankCustomer_ServiceClient(instance, "NetTcpBinding_IBankCustomer_Service");

            check = new CheckSelectedItems();
        }



        private void button_AddNewCustomer_Click(object sender, EventArgs e)
        {
            AddNewCustomerForm newCustomerForm = new AddNewCustomerForm(this);
            newCustomerForm.StartPosition = FormStartPosition.CenterScreen;

            newCustomerForm.Show();
        }
        private void button_RemoveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                bankCustomer_ServiceClient.DeleteCustomer(customerInfo.Id);

                customerInfo = null;



                textBox_Firstname_MainForm.Text = "";
                textBox_CustomerLastName_MainForm.Text = "";
                textBox_CurrentBalance_MainForm.Text = "";
                textBox_SavingsBalance_MainForm.Text = "";
                
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Select Customer to delete");
            }
        }
        private void button_SearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = int.Parse(textBox_CustomerId.Text);

                bankCustomer_ServiceClient.GetCustomerInfo(customerId);
            }
            catch(FormatException)
            {
                MessageBox.Show("Incorect Id");
            }
            
        }
        private void button_ViewAllCustomers_Click(object sender, EventArgs e)
        {
            ViewAllCustomers_Form viewAllCustomers_Form = new ViewAllCustomers_Form();
            viewAllCustomers_Form.Show();
        }




        //ManageFunds
        private async void button_ManageFunds_Click(object sender, EventArgs e)
        {
            
            while (panel_ManageFunds.Location.X > this.Size.Width / 2)
            {
                await Task.Delay(1);
                panel_ManageFunds.Location = new Point (panel_ManageFunds.Location.X - 20, 0 );
            }

            button_SearchCustomer.Enabled = false;
            textBox_CustomerId.Enabled = false;
        }
        private void button_Depozit_Click(object sender, EventArgs e)
        {
            operationType = new DepositOperation(bankCustomer_ServiceClient);


            comboBox_fromAccountType.SelectedIndex = -1;
            comboBox_fromAccountType.Enabled = false;
            comboBox_toAccountType.Enabled = true;

            textBox_fundsAmount.Enabled = true;

            button_AcceptFundsOperation.Enabled = true;
        }
        private void button_Withdraw_Click(object sender, EventArgs e)
        {
            operationType = new WithdrawalOperation(bankCustomer_ServiceClient);

            comboBox_toAccountType.SelectedIndex = -1;
            comboBox_toAccountType.Enabled = false;
            comboBox_fromAccountType.Enabled = true;

            textBox_fundsAmount.Enabled = true;

            button_AcceptFundsOperation.Enabled = true;
        }
        private void button_InnerTransfer_Click(object sender, EventArgs e)
        {
            operationType = new InnerTransferOperation(bankCustomer_ServiceClient);

            comboBox_fromAccountType.Enabled = true;
            comboBox_fromAccountType.SelectedIndex = -1;

            comboBox_toAccountType.Enabled = true;
            comboBox_toAccountType.SelectedIndex = -1;

            textBox_fundsAmount.Enabled = true;

            button_AcceptFundsOperation.Enabled = true;       
        }
        private void button_AcceptFundsOperation_Click(object sender, EventArgs e)
        {
      
            bool correctSelectedAcc = check.CheckSelectedAccounts(operationType, comboBox_fromAccountType.SelectedIndex, comboBox_toAccountType.SelectedIndex);


            if (correctSelectedAcc)
            {
                string fromAcc = comboBox_fromAccountType.SelectedItem?.ToString();
                string toAcc = comboBox_toAccountType.SelectedItem?.ToString();
                decimal fundsAmount = decimal.Parse(textBox_fundsAmount.Text);

                try
                {
                    operationType.ProcessOperation(customerInfo.Id, fundsAmount, fromAcc, toAcc);

                    textBox_fundsAmount.Text = "";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Incorect amount");
                }
            }
            else
            {
                MessageBox.Show("Select an account ");
                return;
            } 
        }
        private async void button_CancelManagerFunds_Click(object sender, EventArgs e)
        {
            while (panel_ManageFunds.Location.X < this.Size.Width - 20)
            {
                operationType = null;

                await Task.Delay(1);
                panel_ManageFunds.Location = new Point (panel_ManageFunds.Location.X + 20,  0 );
            }

            button_SearchCustomer.Enabled = true;
            textBox_CustomerId.Enabled = true;


            textBox_fundsAmount.Enabled = false;
            textBox_fundsAmount.Text = string.Empty;

            comboBox_fromAccountType.Enabled = false;
            comboBox_fromAccountType.Text = "Select Account";

            comboBox_toAccountType.Enabled = false;
            comboBox_toAccountType.Text = "Select Account";
        }



        //Callbacks
        public void SendCustomerInfo(CustomerInfo cust)
        {
            try
            {
                textBox_Firstname_MainForm.Text = cust.FirstName;
                textBox_CustomerLastName_MainForm.Text = cust.LastName;
                textBox_CurrentBalance_MainForm.Text = cust.CurrentBalance.ToString();
                textBox_SavingsBalance_MainForm.Text = cust.SavingsBalance.ToString();

                button_ManageFunds.Enabled = true;
                button_RemoveCustomer.Enabled = true;

                customerInfo = cust;
            }
            catch(Exception)
            {
                button_ManageFunds.Enabled = false;
                button_RemoveCustomer.Enabled = false;
            }
        }
        public void OperationResult(string result)
        {
            MessageBox.Show(result);
        }
        public void SendAllCustomers(CustomerInfo[] customers)
        {
        }

    }
}
    