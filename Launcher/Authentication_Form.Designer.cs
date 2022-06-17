namespace Launcher
{
    partial class Authentication_Form
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
            this.components = new System.ComponentModel.Container();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Authenticate = new System.Windows.Forms.Button();
            this.button_GetAccess = new System.Windows.Forms.Button();
            this.linkLabel_ReadOnlyMode = new System.Windows.Forms.LinkLabel();
            this.label_Error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel_DefaultCredentials = new System.Windows.Forms.LinkLabel();
            this.toolTip_defaultCredentials = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(25, 55);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(332, 26);
            this.textBox_username.TabIndex = 0;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(25, 135);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Password.MinimumSize = new System.Drawing.Size(332, 30);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(332, 26);
            this.textBox_Password.TabIndex = 1;
            // 
            // button_Authenticate
            // 
            this.button_Authenticate.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Authenticate.Location = new System.Drawing.Point(25, 200);
            this.button_Authenticate.Margin = new System.Windows.Forms.Padding(4);
            this.button_Authenticate.Name = "button_Authenticate";
            this.button_Authenticate.Size = new System.Drawing.Size(333, 37);
            this.button_Authenticate.TabIndex = 2;
            this.button_Authenticate.Text = "Login";
            this.button_Authenticate.UseVisualStyleBackColor = true;
            this.button_Authenticate.Click += new System.EventHandler(this.button_Authenticate_Click);
            // 
            // button_GetAccess
            // 
            this.button_GetAccess.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GetAccess.Location = new System.Drawing.Point(25, 377);
            this.button_GetAccess.Margin = new System.Windows.Forms.Padding(4);
            this.button_GetAccess.Name = "button_GetAccess";
            this.button_GetAccess.Size = new System.Drawing.Size(333, 37);
            this.button_GetAccess.TabIndex = 3;
            this.button_GetAccess.Text = "Get Access to System ";
            this.button_GetAccess.UseVisualStyleBackColor = true;
            this.button_GetAccess.Click += new System.EventHandler(this.button_GetAccess_Click);
            // 
            // linkLabel_ReadOnlyMode
            // 
            this.linkLabel_ReadOnlyMode.AutoSize = true;
            this.linkLabel_ReadOnlyMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_ReadOnlyMode.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_ReadOnlyMode.Location = new System.Drawing.Point(249, 241);
            this.linkLabel_ReadOnlyMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_ReadOnlyMode.Name = "linkLabel_ReadOnlyMode";
            this.linkLabel_ReadOnlyMode.Size = new System.Drawing.Size(109, 16);
            this.linkLabel_ReadOnlyMode.TabIndex = 4;
            this.linkLabel_ReadOnlyMode.TabStop = true;
            this.linkLabel_ReadOnlyMode.Text = "Read Only Mode";
            this.linkLabel_ReadOnlyMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_ReadOnlyMode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ReadOnlyMode_LinkClicked);
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(21, 170);
            this.label_Error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(0, 18);
            this.label_Error.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // linkLabel_DefaultCredentials
            // 
            this.linkLabel_DefaultCredentials.AutoSize = true;
            this.linkLabel_DefaultCredentials.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_DefaultCredentials.Location = new System.Drawing.Point(24, 241);
            this.linkLabel_DefaultCredentials.Name = "linkLabel_DefaultCredentials";
            this.linkLabel_DefaultCredentials.Size = new System.Drawing.Size(78, 16);
            this.linkLabel_DefaultCredentials.TabIndex = 7;
            this.linkLabel_DefaultCredentials.TabStop = true;
            this.linkLabel_DefaultCredentials.Text = "Default user";
            // 
            // Authentication_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 441);
            this.Controls.Add(this.linkLabel_DefaultCredentials);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.linkLabel_ReadOnlyMode);
            this.Controls.Add(this.button_GetAccess);
            this.Controls.Add(this.button_Authenticate);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Authentication_Form";
            this.Text = "Authentication_Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Authentication_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Authenticate;
        private System.Windows.Forms.Button button_GetAccess;
        private System.Windows.Forms.LinkLabel linkLabel_ReadOnlyMode;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel_DefaultCredentials;
        private System.Windows.Forms.ToolTip toolTip_defaultCredentials;
    }
}