using System;
using System.Drawing;
using System.ServiceModel;
using System.Windows.Forms;
using BankUI.BankCustomers;


namespace BankUI
{
    public partial class AddNewCustomerForm : Form, IBankCustomer_ServiceCallback
    {

        Label label_CurrentFunds;
        Label label_SavingsFunds;
        TextBox textBox_CurrentFundsValue;
        TextBox textBox_SavingsFundsValue;



        bool Depozit = false;
        private readonly Main_Form mainFormInstance;

        public AddNewCustomerForm(Main_Form mainFormInstance)
        {
            InitializeComponent();
            Owner = mainFormInstance;
            Owner.Enabled = false;

            StartPosition = FormStartPosition.CenterParent;

            MinimumSize = new Size { Width = 636, Height = 384};
            MaximumSize = MinimumSize;

            
            this.mainFormInstance = mainFormInstance;
        }
        
        private void button_DepozitFunds_Click(object sender, EventArgs e)
        {
            Depozit = !Depozit;

            if (Depozit)
            {
                button_DepozitFunds.Text = "Discard";

  

                label_CurrentFunds = new Label() { Location = new Point { X = 338, Y = 72 } };
                label_CurrentFunds.Size = new Size { Width = 100, Height = 13 };
                label_CurrentFunds.Text = "Current Account";

                label_SavingsFunds = new Label() { Location = new Point { X = 338, Y = 120 } };
                label_SavingsFunds.Size = new Size { Width = 100, Height = 13 };
                label_SavingsFunds.Text = "Savings Account";

                textBox_CurrentFundsValue = new TextBox() { Location = new Point { X = 338, Y = 88 } };
                textBox_CurrentFundsValue.Size = new Size { Width = 150, Height = 20 };

                textBox_SavingsFundsValue = new TextBox() { Location = new Point { X = 338, Y = 136 } };
                textBox_SavingsFundsValue.Size = new Size { Width = 150, Height = 20 };

                Controls.Add(label_CurrentFunds);
                Controls.Add(label_SavingsFunds);
                Controls.Add(textBox_CurrentFundsValue);
                Controls.Add(textBox_SavingsFundsValue);
            }
            else
            {
                button_DepozitFunds.Text = "Depozit Funds";

                label_CurrentFunds.Dispose();


                Controls.Remove(label_CurrentFunds);
                Controls.Remove(label_SavingsFunds);
                Controls.Remove(textBox_CurrentFundsValue);
                Controls.Remove(textBox_SavingsFundsValue);


                //label_CurrentFunds.Dispose();
                label_SavingsFunds.Dispose();
                textBox_CurrentFundsValue.Dispose();
                textBox_SavingsFundsValue.Dispose();
            }       
        }

        private void button_CreateNewCustomer_Click(object sender, EventArgs e)
        {
            string currentDate = DateTime.Today.ToString();

            decimal currentAccFunds;
            decimal savingsAccFunds;


            InstanceContext instance = new InstanceContext(this);
            BankCustomer_ServiceClient customerInfo_ServiceClient = new BankCustomer_ServiceClient(instance, "NetTcpBinding_IBankCustomer_Service");

            try
            {
                if (Depozit)
                {
                    currentAccFunds = decimal.Parse(textBox_CurrentFundsValue.Text);
                    savingsAccFunds = decimal.Parse(textBox_SavingsFundsValue.Text);

                    customerInfo_ServiceClient.CreateCustomer(textBox_FirstName.Text, textBox_LastName.Text, textBox_Email.Text, currentDate, currentAccFunds, savingsAccFunds);

                    return;
                }

                customerInfo_ServiceClient.CreateCustomer(textBox_FirstName.Text, textBox_LastName.Text, textBox_Email.Text, currentDate, 0, 0);

                //MessageBox.Show();
                this.Close();
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_CancelCreateNewCustomer_Click(object sender, EventArgs e)
        {
            Owner.Enabled = true;
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Owner.Enabled = true;
        }

        public void SendCustomerInfo(CustomerInfo cust)
        {
            //throw new NotImplementedException();
        }

        public void OperationResult(string result)
        {
            MessageBox.Show(result);

            Owner.Enabled = true;
            Close();
        }

        public void SendAllCustomers(CustomerInfo[] customers)
        {
            throw new NotImplementedException();
        }
    }
}
