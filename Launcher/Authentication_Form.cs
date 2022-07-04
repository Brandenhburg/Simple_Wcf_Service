using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.ServiceModel;
using Launcher.Security;
using System.Threading.Tasks;

namespace Launcher
{
    public partial class Authentication_Form : Form
    {

        internal Security_ServiceClient securityService_client;

        public Authentication_Form()
        {

            StartPosition = FormStartPosition.CenterScreen;


            securityService_client = new Security_ServiceClient("NetTcpBinding_ISecurity_Service");

            AcceptButton = button_Authenticate;


            InitializeComponent();

        }

        private async void button_Authenticate_Click(object sender, EventArgs e)
        {
            button_Authenticate.Enabled = false;
            button_GetAccess.Enabled = false;
            linkLabel_ReadOnlyMode.Enabled = false;

            bool CorrenctUserCredentials = await securityService_client.LoginAsync (textBox_username.Text, textBox_Password.Text);

            


            if (!CorrenctUserCredentials)
            {
                textBox_username.Clear();
                textBox_Password.Clear();

                label_Error.Text = "Wrong username or password";

                button_Authenticate.Enabled = true;
                button_GetAccess.Enabled = true;
                linkLabel_ReadOnlyMode.Enabled = true;


                return;
            }
            else
            {
                label_Error.ForeColor = Color.Green;
                label_Error.Text = "Confirmed";
                await Task.Delay(1500);
                Process.Start(new ProcessStartInfo { FileName = @"D:\Simple WCF Service\BankUI\bin\Debug\BankUI.exe", Arguments = CorrenctUserCredentials.ToString()});
                Application.Exit();
            }  
        }
        private void button_GetAccess_Click(object sender, EventArgs e)
        {
            RegisterNewWorker_Form form = new RegisterNewWorker_Form(this);
            form.ShowDialog();


            textBox_username.Clear();
            textBox_Password.Clear();
        }

        private void linkLabel_ReadOnlyMode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { }

        private void Authentication_Form_Load(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(linkLabel_DefaultCredentials, "Username: user\nPassword: user");
        }
    }
}
