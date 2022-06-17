using System.Collections.Generic;
using System.Drawing;
using System.ServiceModel;
using System.Windows.Forms;
using BankUI.BankCustomers;
using System.Threading.Tasks;

namespace BankUI
{
    public partial class ViewAllCustomers_Form : Form, IBankCustomer_ServiceCallback
    {
        BankCustomer_ServiceClient bankCustomer_ServiceClient;
        Main_Form mainForm;
        public ViewAllCustomers_Form(Main_Form mainForm)
        {
            this.mainForm = mainForm;
            MinimumSize = new Size { Height = 475, Width = 730 };
            MaximumSize = MinimumSize;

            StartPosition = FormStartPosition.CenterScreen;


            bankCustomer_ServiceClient = 
                new BankCustomer_ServiceClient(new InstanceContext(this), "NetTcpBinding_IBankCustomer_Service");


            bankCustomer_ServiceClient.GetAllCustomers();
            InitializeComponent();
        }



        //private void ViewAllCustomers_Form_Load(object sender, System.EventArgs e) => bankCustomer_ServiceClient.GetAllCustomers();
        private void button_RefreshView_Click(object sender, System.EventArgs e)
        {
            viewAllcustomersTable.Rows.Clear();
            bankCustomer_ServiceClient.GetAllCustomers();
        }      
        private void button_ExitViewAllCustomers_Click(object sender, System.EventArgs e) => Close();
        protected override void OnFormClosing(FormClosingEventArgs e) => bankCustomer_ServiceClient.Close();



        //Callbacks
        public void OperationResult(string result)
        {
            //throw new System.NotImplementedException();
        }
        public void SendAllCustomers(CustomerInfo[] customers)
        {
            foreach (var customer in customers)
                viewAllcustomersTable.Rows.Add(customer.Id, customer.FirstName, customer.LastName, customer.Email, customer.JoinedOnDate, customer.CurrentBalance, customer.SavingsBalance);
        }
        public void SendCustomerInfo(CustomerInfo cust)
        {
            //throw new System.NotImplementedException();
        }


    }
}
