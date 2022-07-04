namespace BankUI.Launcher
{
    partial class SignUp_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_backToLogin = new System.Windows.Forms.Button();
            this.label_ConfirmPassword = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.linkLabel_Exit = new System.Windows.Forms.LinkLabel();
            this.label_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Username
            // 
            this.textBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(10, 50);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(360, 24);
            this.textBox_Username.TabIndex = 0;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(10, 120);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(360, 24);
            this.textBox_Email.TabIndex = 0;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(10, 190);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(360, 24);
            this.textBox_Password.TabIndex = 0;
            // 
            // textBox_ConfirmPassword
            // 
            this.textBox_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ConfirmPassword.Location = new System.Drawing.Point(10, 260);
            this.textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBox_ConfirmPassword.PasswordChar = '*';
            this.textBox_ConfirmPassword.Size = new System.Drawing.Size(360, 24);
            this.textBox_ConfirmPassword.TabIndex = 0;
            // 
            // button_Submit
            // 
            this.button_Submit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Submit.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Submit.Location = new System.Drawing.Point(10, 336);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(360, 37);
            this.button_Submit.TabIndex = 1;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // button_backToLogin
            // 
            this.button_backToLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_backToLogin.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_backToLogin.Location = new System.Drawing.Point(10, 431);
            this.button_backToLogin.Name = "button_backToLogin";
            this.button_backToLogin.Size = new System.Drawing.Size(360, 37);
            this.button_backToLogin.TabIndex = 1;
            this.button_backToLogin.Text = "Back to Login";
            this.button_backToLogin.UseVisualStyleBackColor = true;
            this.button_backToLogin.Click += new System.EventHandler(this.button_backToLogin_Click);
            // 
            // label_ConfirmPassword
            // 
            this.label_ConfirmPassword.AutoSize = true;
            this.label_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConfirmPassword.Location = new System.Drawing.Point(9, 241);
            this.label_ConfirmPassword.Name = "label_ConfirmPassword";
            this.label_ConfirmPassword.Size = new System.Drawing.Size(115, 16);
            this.label_ConfirmPassword.TabIndex = 2;
            this.label_ConfirmPassword.Text = "Confirm Password";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(9, 171);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(67, 16);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(9, 101);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(41, 16);
            this.label_Email.TabIndex = 2;
            this.label_Email.Text = "Email";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(9, 30);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(70, 16);
            this.label_Username.TabIndex = 2;
            this.label_Username.Text = "Username";
            // 
            // linkLabel_Exit
            // 
            this.linkLabel_Exit.AutoSize = true;
            this.linkLabel_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Exit.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_Exit.Location = new System.Drawing.Point(342, 376);
            this.linkLabel_Exit.Name = "linkLabel_Exit";
            this.linkLabel_Exit.Size = new System.Drawing.Size(28, 16);
            this.linkLabel_Exit.TabIndex = 3;
            this.linkLabel_Exit.TabStop = true;
            this.linkLabel_Exit.Text = "Exit";
            this.linkLabel_Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Error.Location = new System.Drawing.Point(9, 300);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(0, 16);
            this.label_Error.TabIndex = 4;
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 480);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_ConfirmPassword);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.button_backToLogin);
            this.Controls.Add(this.linkLabel_Exit);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_ConfirmPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(380, 480);
            this.MinimumSize = new System.Drawing.Size(380, 480);
            this.Name = "Register_Form";
            this.Text = "Register_Form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Register_Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Register_Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Register_Form_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_ConfirmPassword;
        private System.Windows.Forms.Label label_ConfirmPassword;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_backToLogin;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.LinkLabel linkLabel_Exit;
        private System.Windows.Forms.Label label_Error;
    }
}