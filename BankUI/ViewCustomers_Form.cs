using System.ServiceModel;
using System.Windows.Forms;
using System.Drawing;

using BankUI.BankCustomers;


namespace BankUI
{
    enum SearchBy
    {
        Firstname,
        Lastname,
        Email,
        LoadEntireDatabase
    }

    public partial class ViewCustomers_Form : Form, IBankCustomer_ServiceCallback
    {
        SearchBy searchBy;
        BankCustomer_ServiceClient bankCustomer_ServiceClient;
        Main_Form mainForm;


        BankCustomer_ServiceClient BankCustomer_ServiceClient
        {
            get
            {
                if (bankCustomer_ServiceClient.State == CommunicationState.Faulted)
                {
                    bankCustomer_ServiceClient.Abort();
                    bankCustomer_ServiceClient = new BankCustomer_ServiceClient(new InstanceContext(this), "NetTcpBinding_IBankCustomer_Service");
                }
                return bankCustomer_ServiceClient;
            }
        }


        public ViewCustomers_Form(Main_Form mainForm)
        {
            StartPosition = FormStartPosition.CenterScreen;

            this.mainForm = mainForm;

            searchBy = SearchBy.LoadEntireDatabase;

            InitializeComponent();
        }


        #region [Form Events]
        private void ViewAllCustomers_Form_Load(object sender, System.EventArgs e) =>
            bankCustomer_ServiceClient = new BankCustomer_ServiceClient(new InstanceContext(this), "NetTcpBinding_IBankCustomer_Service");

        private void button_DownloadDatabase_Click(object sender, System.EventArgs e)
        {
            if (textBox_searchSubstring.Enabled & textBox_searchSubstring.Text == "")
            {
                textBox_searchSubstring.BackColor = SystemColors.Info;
                return;
            }

            switch (searchBy)
            {
                case SearchBy.Firstname:
                    viewAllcustomersTable.Rows.Clear();
                    BankCustomer_ServiceClient.FilterCustomersAsync(searchBy.ToString(), textBox_searchSubstring.Text);
                    break;
                case SearchBy.Lastname:
                    viewAllcustomersTable.Rows.Clear();
                    BankCustomer_ServiceClient.FilterCustomersAsync(searchBy.ToString(), textBox_searchSubstring.Text);
                    break;
                case SearchBy.Email:
                    viewAllcustomersTable.Rows.Clear();
                    BankCustomer_ServiceClient.FilterCustomersAsync(searchBy.ToString(), textBox_searchSubstring.Text);
                    break;

                default:
                    viewAllcustomersTable.Rows.Clear();
                    BankCustomer_ServiceClient.GetAllCustomersAsync();
                    break;
            }
        }
        private void button_RefreshView_Click(object sender, System.EventArgs e) => button_DownloadDatabase_Click(sender, e);

        private void button_ExitViewAllCustomers_Click(object sender, System.EventArgs e) => Close();
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (bankCustomer_ServiceClient.State == CommunicationState.Faulted)
                bankCustomer_ServiceClient.Abort();

            bankCustomer_ServiceClient.Close();
        }
        #endregion

        #region [Service Callbacks]
        public void OperationResult(string result)
        {
            //throw new System.NotImplementedException();
        }
        public void SendAllCustomers(CustomerInfo[] customers)
        {
            for (int i = 0; i < customers.Length; i++)
                viewAllcustomersTable.Rows.Add(customers[i].Id, customers[i].FirstName, customers[i].LastName, customers[i].Email, customers[i].JoinedOnDate, customers[i].CurrentBalance, customers[i].SavingsBalance);
            //foreach (var customer in customers)
            //    viewAllcustomersTable.Rows.Add(customer.Id, customer.FirstName, customer.LastName, customer.Email, customer.JoinedOnDate, customer.CurrentBalance, customer.SavingsBalance);
        }
        public void SendCustomerInfo(CustomerInfo cust)
        {
            viewAllcustomersTable.Rows.Add(cust.Id, cust.FirstName, cust.LastName, cust.Email, cust.JoinedOnDate, cust.CurrentBalance, cust.SavingsBalance);
            label_NumOfRows.Text = $"Total Rows: {viewAllcustomersTable.Rows.Count}";
        }

        #endregion
    

        #region [Filter State]
        private void radioButton_LoadEntireDatabase_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton_LoadEntireDatabase.Checked)
            {
                textBox_searchSubstring.Text = "";

                searchBy = SearchBy.LoadEntireDatabase;
                textBox_searchSubstring.Enabled = false;

                radioButton_searchByFirstName.Enabled = true;
                radioButton_searchByFirstName.Checked = false;

                radioButton_searchByLastName.Enabled = true;
                radioButton_searchByLastName.Checked = false;

                radioButton_SearchByEmail.Enabled = true;
                radioButton_SearchByEmail.Checked = false;
            }
        }
        private void radioButton_searchByFirstName_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton_searchByFirstName.Checked)
            {
                searchBy = SearchBy.Firstname;
                textBox_searchSubstring.Enabled = true;

                radioButton_LoadEntireDatabase.Enabled = true;
                radioButton_LoadEntireDatabase.Checked = false;

                radioButton_searchByLastName.Enabled = true;
                radioButton_searchByLastName.Checked = false;

                radioButton_SearchByEmail.Enabled = true;
                radioButton_SearchByEmail.Checked = false;
            }
        }
        private void radioButton_searchByLastName_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton_searchByLastName.Checked)
            {
                searchBy = SearchBy.Lastname;
                textBox_searchSubstring.Enabled = true;

                radioButton_LoadEntireDatabase.Enabled = true;
                radioButton_LoadEntireDatabase.Checked = false;

                radioButton_searchByFirstName.Enabled = true;
                radioButton_searchByFirstName.Checked = false;

                radioButton_SearchByEmail.Enabled = true;
                radioButton_SearchByEmail.Checked = false;
            }
        }
        private void radioButton_SearchByEmail_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton_SearchByEmail.Checked)
            {
                searchBy = SearchBy.Email;
                textBox_searchSubstring.Enabled = true;

                radioButton_LoadEntireDatabase.Enabled = true;
                radioButton_LoadEntireDatabase.Checked = false;

                radioButton_searchByFirstName.Enabled = true;
                radioButton_searchByFirstName.Checked = false;

                radioButton_searchByLastName.Enabled = true;
                radioButton_searchByLastName.Checked = false;
            }
        }
        #endregion

    }
}
