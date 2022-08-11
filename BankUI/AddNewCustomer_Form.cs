using System;
using System.Drawing;
using System.ServiceModel;
using System.Windows.Forms;

using BankUI.BankCustomers;

namespace BankUI
{
    partial class AddNewCustomer_Form : Form, IBankCustomer_ServiceCallback
    {
        #region [Fields]
        Label label_CurrentFunds;
        Label label_SavingsFunds;
        TextBox textBox_CurrentFundsValue;
        TextBox textBox_SavingsFundsValue;


        bool Depozit = false;
        Main_Form mainForm;

        Point mousePositionDifference;
        bool isMouseDown = false;


        BankCustomer_ServiceClient bankCustomer_ServiceClient;
        #endregion

        public AddNewCustomer_Form(Main_Form mainForm, BankCustomer_ServiceClient customerInfo_ServiceClient)
        {
            this.mainForm = mainForm;
            this.mainForm.Enabled = false;

            StartPosition = FormStartPosition.CenterScreen;

            
            bankCustomer_ServiceClient = 
                new BankCustomer_ServiceClient(new InstanceContext(this), "NetTcpBinding_IBankCustomer_Service");
            
            InitializeComponent();
        }


        #region [Manage Funds Methods]
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

            try
            {
                if (Depozit)
                {
                    currentAccFunds = decimal.Parse(textBox_CurrentFundsValue.Text);
                    savingsAccFunds = decimal.Parse(textBox_SavingsFundsValue.Text);

                    bankCustomer_ServiceClient.CreateCustomer(textBox_FirstName.Text, textBox_LastName.Text, textBox_Email.Text, currentDate, currentAccFunds, savingsAccFunds);

                    return;
                }

                bankCustomer_ServiceClient.CreateCustomer(textBox_FirstName.Text, textBox_LastName.Text, textBox_Email.Text, currentDate, 0, 0);
                
                Close();
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
        private void button_CancelCreateNewCustomer_Click(object sender, EventArgs e) => Close();
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            bankCustomer_ServiceClient.Close();
            mainForm.Enabled = true;
        }
        #endregion [Form Methods]

        #region [Service Callbacks]
        public void SendCustomerInfo(CustomerInfo cust)
        {
            //throw new NotImplementedException();
        }
        public void OperationResult(string result)
        {
            MessageBox.Show(result);
            Close();
        }
        public void SendAllCustomers(CustomerInfo[] customers)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region [Mouse Events]
        protected override void OnMouseDown(MouseEventArgs e)
        {
            mousePositionDifference.X = Cursor.Position.X - Left;
            mousePositionDifference.Y = Cursor.Position.Y - Top;
            isMouseDown = true;
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Left = Cursor.Position.X - mousePositionDifference.X;
                Top = Cursor.Position.Y - mousePositionDifference.Y;
            }
        }
        protected override void OnMouseUp(MouseEventArgs e) => isMouseDown = false;
        private void myTittleButton_CloseForm_Click(object sender, EventArgs e)
        {         
            mainForm.Show();
            Close();
        }     
        private void myTittleButton1_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        #endregion

    }
}
