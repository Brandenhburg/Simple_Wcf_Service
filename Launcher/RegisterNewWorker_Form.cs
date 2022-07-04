using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.Generic;
using System.ServiceModel;
using Launcher.Security;

namespace Launcher
{
    partial class RegisterNewWorker_Form : Form
    {
        
        Authentication_Form authentication_Form;

        public RegisterNewWorker_Form(Authentication_Form authentication_Form)
        {
            this.authentication_Form = authentication_Form;
            this.authentication_Form.Visible = false;


            MinimumSize = new Size { Height = 480, Width = 400 };
            MaximumSize = MinimumSize;


            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();            
        }


        protected override void OnClosing(CancelEventArgs e) => authentication_Form.Visible = true;
        private void button_backToLogin_Click(object sender, EventArgs e) => Close();

        private async void button_Submit_Click(object sender, EventArgs e)
        {

            if (CheckForEmptiness())
                return;

            if (!PasswordMatching())
                return;


            textBox_Username.Enabled = false;
            textBox_Email.Enabled = false;
            textBox_Password.Enabled = false;
            textBox_ConfirmPassword.Enabled = false;

            button_backToLogin.Enabled = false;
            button_Submit.Enabled = false;
            button_Exit.Enabled = false;




            authentication_Form.securityService_client.GetAccessToSystem(textBox_Username.Text, textBox_Email.Text, textBox_ConfirmPassword.Text);

            label_PasswordsError.ForeColor = Color.Green;
            label_PasswordsError.Text = "Confirmed";

            await Task.Delay(1500);
            Close();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
            authentication_Form.Close();
        }

        private bool PasswordMatching()
        {
            if (textBox_Password.Text != textBox_ConfirmPassword.Text)
            {
                textBox_Password.BackColor = Color.LightGoldenrodYellow;
                textBox_ConfirmPassword.BackColor = Color.LightGoldenrodYellow;

                label_PasswordsError.ForeColor = Color.Red;
                label_PasswordsError.Text = "*Passwords do not match. Please try again.";
                return false ;
            }

            return true;
        }
        private bool CheckForEmptiness()
        {
            Dictionary<Label, TextBox> dictionary = new Dictionary<Label, TextBox>();
            dictionary.Add(label_Username, textBox_Username);
            dictionary.Add(label_Email, textBox_Email);
            dictionary.Add(label_Password, textBox_Password);
            dictionary.Add(label_ConfirmPassword, textBox_ConfirmPassword);

            bool isEmpty = false;
            foreach (var item in dictionary)
            {
                if (item.Value.Text == string.Empty)
                {
                    item.Key.ForeColor = Color.Red;
                    isEmpty = true;
                }
                else
                    item.Key.ForeColor = Color.Black;
            }

            return isEmpty;
        }

    }
}
