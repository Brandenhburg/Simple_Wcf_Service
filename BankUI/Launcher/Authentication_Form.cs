using System;
using System.ComponentModel;
using System.Drawing;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        #endregion


        public Authentication_Form(Main_Form main_Form)
        {
            this.main_Form = main_Form;

            StartPosition = FormStartPosition.CenterScreen;
            Settings.Default.Light_Theme = true;
            securityService_client = new Security_ServiceClient("NetTcpBinding_ISecurity_Service");

            InitializeComponent();
        }

        public Security_ServiceClient securityService_client { get; private set; }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (!main_Form.IsAuthenticated)
                Application.Exit();
        }
        private void Authentication_Form_Load(object sender, EventArgs e) => main_Form.Hide();


        private async void button_Authenticate_Click(object sender, EventArgs e)
        {

            DisableFormControls();

            try
            {               
                Employee currentEmployee = await securityService_client.SignInAsync(textBox_username.Text, textBox_Password.Text);

                label_Error.ForeColor = Color.Green;
                label_Error.Text = "Confirmed";


                await Task.Delay(1500);

                
                main_Form.currentEmployee = currentEmployee;
                main_Form.Enabled = true;
                main_Form.IsAuthenticated = true;

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



        private void button_GetAccess_Click(object sender, EventArgs e)
        {
            SignUp_Form form = new SignUp_Form(this);
            form.ShowDialog();


            textBox_username.Clear();
            textBox_Password.Clear();
        }

        private void linkLabel_ReadOnlyMode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel_ExitApp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Application.Exit();


        #region [Mouse Events]
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

            button_Authenticate.Enabled = false;
            button_GetAccess.Enabled = false;

            linkLabel_ReadOnlyMode.Enabled = false;
        }
        private void EnableFormControls()
        {
            textBox_username.Enabled = true;
            textBox_Password.Enabled = true;

            button_Authenticate.Enabled = true;
            button_Authenticate.Focus();

            button_GetAccess.Enabled = true;
            linkLabel_ReadOnlyMode.Enabled = true;
        }
        #endregion
    }
}
