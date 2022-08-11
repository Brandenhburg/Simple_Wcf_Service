using System;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using BankUI.BankCustomers;
using BankUI.Operations;
using BankUI.Security;
using BankUI.Launcher;
using BankUI.Menu;
using BankUI.Customizing;

namespace BankUI
{
    public partial class Main_Form : Form, IBankCustomer_ServiceCallback
    {

        #region [Fields]
        IOperationType operationType;
        CustomerInfo customerInfo;
        CheckSelectedItems check;

        internal InstanceContext instanceContext;
        internal BankCustomer_ServiceClient bankCustomer_ServiceClient;
        Security_ServiceClient security_ServiceClient;

        
        //bool isEmployeeAccSettingsPanelOpen = false;
        Point mouseDiffPosition;
        bool isMouseDown = false;

        

        internal Employee signedInEmployee;
        #endregion

        #region [Constructor]
        public Main_Form()
        {
            StartPosition = FormStartPosition.CenterScreen;

            check = new CheckSelectedItems();

            instanceContext = new InstanceContext(this);
            bankCustomer_ServiceClient = new BankCustomer_ServiceClient(instanceContext, "NetTcpBinding_IBankCustomer_Service");


            InitializeComponent();
            initialize();
        }
        #endregion

        #region[Properties]

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        internal Security_ServiceClient Security_ServiceClient 
        {
            get
            {
                if (security_ServiceClient.State == CommunicationState.Faulted)
                {
                    security_ServiceClient.Abort();
                    security_ServiceClient = new Security_ServiceClient("NetTcpBinding_ISecurity_Service");
                }            
                return security_ServiceClient;
            }
            set { security_ServiceClient = value; }           
        }
        internal MyTittleButton EmployeeAccSettings { get => myTitleButton_EmployeeAccSettings; }
        internal bool IsAuthenticated { get; set; } = false;
        internal bool IsDataReadonly { get; set; } = false;
        #endregion


        private void initialize()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {           
            Enabled = false;
            Authentication_Form authForm = new Authentication_Form(this);
            authForm.ShowDialog(this); 
        }

        private void button_AddNewCustomer_Click(object sender, EventArgs e)
        {
            AddNewCustomer_Form newCustomerForm = new AddNewCustomer_Form(this, bankCustomer_ServiceClient);
            Hide();
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
        private async void button_SearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = int.Parse(textBox_CustomerId.Text);

                await bankCustomer_ServiceClient.GetCustomerInfoAsync(customerId);
            }
            catch(FormatException)
            {
                MessageBox.Show("Incorect Id");
            }        
        }
        private void button_ViewCustomers_Click(object sender, EventArgs e)
        {
            ViewCustomers_Form viewAllCustomers_Form = new ViewCustomers_Form(this);
            viewAllCustomers_Form.ShowDialog();
        }


        #region [ManageFunds]
        private async void button_ManageFunds_Click(object sender, EventArgs e)
        {
            while (panel_ManageFunds.Location.X > this.Size.Width / 2)
            {          
                await Task.Delay(1);
                panel_ManageFunds.Refresh();
                panel_ManageFunds.Location = new Point (panel_ManageFunds.Location.X - 20, 25 );
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
                panel_ManageFunds.Location = new Point (panel_ManageFunds.Location.X + 20,  25 );
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
        #endregion


        #region [MenuStrip]
        private void ToolStripMenuItem_SignOut_Click(object sender, EventArgs e)
        {

            try
            {
                Hide();
                Enabled = false;
                bankCustomer_ServiceClient.Close();
            }
            catch (FaultException)
            {
                Hide();
                Enabled = false;
                bankCustomer_ServiceClient.Abort();
            }
            
  
            security_ServiceClient.SignOutAsync(signedInEmployee.Id.ToString(), signedInEmployee.Username);

            signedInEmployee = null;

            Authentication_Form authentication_Form = new Authentication_Form(this);
            authentication_Form.ShowDialog(this);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {               
                security_ServiceClient.SignOutAsync(signedInEmployee.Id.ToString(), signedInEmployee.Username);

                security_ServiceClient.Close();
                bankCustomer_ServiceClient.Close();

                Application.Exit();
            }
            catch (FaultException)
            {
                security_ServiceClient.Abort();
                bankCustomer_ServiceClient.Abort();

                Application.Exit();
            }     
        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tools_Options_Form tools_Options_Form = Tools_Options_Form.GetForm(this);
            tools_Options_Form.ShowDialog(this);
        }
        #endregion


        #region [WCF_CallBacks]
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



        #endregion


        #region [Title Bar]
        private async void myTitleButton_ExitApp_Click(object sender, EventArgs e)
        {
            await Security_ServiceClient.SignOutAsync(signedInEmployee.Id.ToString(), signedInEmployee.Username);
            security_ServiceClient.Close();
          
            Application.Exit();
        }

        private async void myTitleButton_Minimize_Click(object sender, EventArgs e)
        {
            while (Opacity > .80)
            {
                await Task.Delay(1);
                Opacity -= .04;
            }
            WindowState = FormWindowState.Minimized;
        }

        private void Main_Form_Activated(object sender, EventArgs e) => Opacity = 1.00;

        private void myTitleButton_EmployeeAccSettings_Click(object sender, EventArgs e)
        {
            //myTitleButton_EmployeeAccSettings.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;           
        }
        #endregion


        #region [MoveFormEvents]
        protected override void OnMouseDown(MouseEventArgs e)
        {
            mouseDiffPosition.X =  Cursor.Position.X - Left;
            mouseDiffPosition.Y = Cursor.Position.Y - Top;

            isMouseDown = true;
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Left = Cursor.Position.X - mouseDiffPosition.X;
                Top = Cursor.Position.Y - mouseDiffPosition.Y;
            }
        }
        protected override void OnMouseUp(MouseEventArgs e) => isMouseDown = false;
        #endregion

    }
}
    