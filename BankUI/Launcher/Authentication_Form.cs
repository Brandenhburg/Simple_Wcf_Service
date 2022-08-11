using System;
using System.ComponentModel;
using System.Drawing;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;

using BankUI.BankCustomers;
using BankUI.Properties;
using BankUI.Security;

namespace BankUI.Launcher
{



    public partial class Authentication_Form : Form
    {
        #region [Fields]

        Point mouseDiffPoint;
        bool mouseDown = false;

        Main_Form main_Form;
        SignUp_Form signUp_form;

        #endregion

        public Authentication_Form(Main_Form main_Form)
        {

            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo($"{Settings.Default.CurrentCulture.ToLower()}");
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo($"{Settings.Default.CurrentCulture.ToLower()}");

            this.main_Form = main_Form;

            StartPosition = FormStartPosition.CenterScreen;
            Settings.Default.Light_Theme = true;
            main_Form.Security_ServiceClient = new Security_ServiceClient("NetTcpBinding_ISecurity_Service");
   
            InitializeComponent();
       
        }

        private void Authentication_Form_Load(object sender, EventArgs e) => WinAPI.AnimateWindow(Handle, 200, WinAPI.BLEND); 
        protected override void OnClosing(CancelEventArgs e)
        {
            if (!main_Form.IsAuthenticated)
                Application.Exit();
        }


        private async void button_SignIn_Click(object sender, EventArgs e)
        {
            DisableFormControls();

            try
            {
                Employee currentEmployee = await main_Form.Security_ServiceClient.SignInAsync(textBox_username.Text, textBox_Password.Text);

                label_Error.ForeColor = Color.Green;
                label_Error.Text = "Confirmed";

                await Task.Delay(1500);

                OnSignInConfirmed(currentEmployee);

                Close();
            }
            catch (FaultException ex)
            {
                label_Error.ForeColor = Color.Red;
                label_Error.Text = ex.Message;

                EnableFormControls();

                return;
            }
        }
        private  void button_GetAccess_Click(object sender, EventArgs e)
        {


            signUp_form = new SignUp_Form(this,main_Form);
            signUp_form.ShowDialog(this);

            

            //textBox_username.Clear();
            //textBox_Password.Clear();
        }
        private void linkLabel_ReadOnlyMode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO
        }
        private async void linkLabel_ExitApp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            while (Opacity > .80)
            {
                await Task.Delay(1);
                Opacity -= .04;
            }    
            Application.Exit();         
        }   
        private void OnSignInConfirmed(Employee currentEmployee)
        {
            main_Form.signedInEmployee = currentEmployee;
            main_Form.Enabled = true;
            main_Form.IsAuthenticated = true;
            main_Form.EmployeeAccSettings.Text = currentEmployee.Username;


            main_Form.instanceContext = new InstanceContext(main_Form);
            main_Form.bankCustomer_ServiceClient = new BankCustomer_ServiceClient(main_Form.instanceContext, "NetTcpBinding_IBankCustomer_Service");

            main_Form.Show();
        }


        #region [Move Form Events]
        private void Authentication_Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDiffPoint.X = Cursor.Position.X - Left;
            mouseDiffPoint.Y = Cursor.Position.Y - Top;
            mouseDown = true;
        }
        private void Authentication_Form_MouseUp(object sender, MouseEventArgs e) => mouseDown = false;
        private void Authentication_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Left = Cursor.Position.X - mouseDiffPoint.X;
                Top = Cursor.Position.Y - mouseDiffPoint.Y;
            }
        }

        #endregion

        #region [Manage Form Controls]
        private void DisableFormControls()
        {
            textBox_username.Enabled = false;
            textBox_Password.Enabled = false;

            button_SignIn.Enabled = false;
            button_GetAccess.Enabled = false;

            linkLabel_ReadOnlyMode.Enabled = false;
        }
        private void EnableFormControls()
        {
            textBox_username.Enabled = true;
            textBox_Password.Enabled = true;

            button_SignIn.Enabled = true;
            button_SignIn.Focus();

            button_GetAccess.Enabled = true;
            linkLabel_ReadOnlyMode.Enabled = true;
        }

        #endregion
    }
}
