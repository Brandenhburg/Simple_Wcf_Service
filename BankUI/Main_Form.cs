using System;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


using BankUI.BankCustomers;
using BankUI.Operations;
using System.Diagnostics;
using System.ComponentModel;

namespace BankUI
{
    public partial class Main_Form : Form, IBankCustomer_ServiceCallback
    {
        IOperationType operationType;
        CustomerInfo customerInfo;
        CheckSelectedItems check;

        InstanceContext instanceContext;
        BankCustomer_ServiceClient bankCustomer_ServiceClient;




        public bool IsAuthenticated { get; private set; } = false;
        public bool IsDataReadonly { get; private set; } = false;


        public  Main_Form(bool isAuthenticated)
        {

            
            IsAuthenticated = isAuthenticated;


            MinimumSize = new Size { Width = 800, Height = 480 };
            MaximumSize = MinimumSize;

            StartPosition = FormStartPosition.CenterScreen;


            instanceContext = new InstanceContext(this);
            bankCustomer_ServiceClient = new BankCustomer_ServiceClient(instanceContext, "NetTcpBinding_IBankCustomer_Service");

            check = new CheckSelectedItems();

            InitializeComponent();
        }
        private async void Main_Form_Load(object sender, EventArgs e)
        {
            while (Process.GetProcessesByName("Launcher").Length > 0)
                await Task.Delay(1000);


            Process.Start(new ProcessStartInfo { FileName = "cmd", Arguments = $"/c taskkill /f /im SecurityService_Host.exe", WindowStyle = ProcessWindowStyle.Hidden }).WaitForExit();

            if (!IsAuthenticated)
            {
                button_AddNewCustomer.Enabled = false;
            }
        }



        private void button_AddNewCustomer_Click(object sender, EventArgs e)
        {
            AddNewCustomer_Form newCustomerForm = new AddNewCustomer_Form(this, bankCustomer_ServiceClient);
            newCustomerForm.ShowDialog();
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
            ViewAllCustomers_Form viewAllCustomers_Form = new ViewAllCustomers_Form(this);
            viewAllCustomers_Form.ShowDialog();
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





        //ToolStrip Menu
        private void connectToSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"D:\Simple Wcf Service\Launcher\bin\Debug\Launcher.exe"});
            Application.Exit();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();



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
    