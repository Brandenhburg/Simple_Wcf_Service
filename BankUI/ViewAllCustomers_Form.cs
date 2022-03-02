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
        InstanceContext instance;
        BankCustomer_ServiceClient bankCustomer_ServiceClient;

        public ViewAllCustomers_Form()
        {
            InitializeComponent();


            MinimumSize = new Size { Height = 475, Width = 730 };
            MaximumSize = MinimumSize;

            StartPosition = FormStartPosition.CenterScreen;



            instance = new InstanceContext(this);
            bankCustomer_ServiceClient = new BankCustomer_ServiceClient(instance, "NetTcpBinding_IBankCustomer_Service");
            bankCustomer_ServiceClient.GetAllCustomers();        
        }

        private void button_ExitViewAllCustomers_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void button_RefreshView_Click(object sender, System.EventArgs e)
        {
            viewAllcustomersTable.Rows.Clear();
            bankCustomer_ServiceClient.GetAllCustomers();
        }
        




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
