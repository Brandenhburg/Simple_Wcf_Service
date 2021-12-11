
namespace BankUI
{
    partial class AddNewCustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.button_DepozitFunds = new System.Windows.Forms.Button();
            this.button_CreateNewCustomer = new System.Windows.Forms.Button();
            this.button_CancelCreateNewCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(96, 38);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_FirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lastname";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(96, 88);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_LastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(96, 136);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(100, 20);
            this.textBox_Email.TabIndex = 5;
            // 
            // button_DepozitFunds
            // 
            this.button_DepozitFunds.Location = new System.Drawing.Point(316, 38);
            this.button_DepozitFunds.Name = "button_DepozitFunds";
            this.button_DepozitFunds.Size = new System.Drawing.Size(148, 20);
            this.button_DepozitFunds.TabIndex = 6;
            this.button_DepozitFunds.Text = "Depozit Funds";
            this.button_DepozitFunds.UseVisualStyleBackColor = true;
            this.button_DepozitFunds.Click += new System.EventHandler(this.button_DepozitFunds_Click);
            // 
            // button_CreateNewCustomer
            // 
            this.button_CreateNewCustomer.Location = new System.Drawing.Point(95, 213);
            this.button_CreateNewCustomer.Name = "button_CreateNewCustomer";
            this.button_CreateNewCustomer.Size = new System.Drawing.Size(148, 20);
            this.button_CreateNewCustomer.TabIndex = 7;
            this.button_CreateNewCustomer.Text = "Submit";
            this.button_CreateNewCustomer.UseVisualStyleBackColor = true;
            this.button_CreateNewCustomer.Click += new System.EventHandler(this.button_CreateNewCustomer_Click);
            // 
            // button_CancelCreateNewCustomer
            // 
            this.button_CancelCreateNewCustomer.Location = new System.Drawing.Point(95, 239);
            this.button_CancelCreateNewCustomer.Name = "button_CancelCreateNewCustomer";
            this.button_CancelCreateNewCustomer.Size = new System.Drawing.Size(148, 20);
            this.button_CancelCreateNewCustomer.TabIndex = 8;
            this.button_CancelCreateNewCustomer.Text = "Cancel";
            this.button_CancelCreateNewCustomer.UseVisualStyleBackColor = true;
            this.button_CancelCreateNewCustomer.Click += new System.EventHandler(this.button_CancelCreateNewCustomer_Click);
            // 
            // AddNewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 345);
            this.Controls.Add(this.button_CancelCreateNewCustomer);
            this.Controls.Add(this.button_CreateNewCustomer);
            this.Controls.Add(this.button_DepozitFunds);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label1);
            this.Name = "AddNewCustomerForm";
            this.Text = "AddNewCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Button button_DepozitFunds;
        private System.Windows.Forms.Button button_CreateNewCustomer;
        private System.Windows.Forms.Button button_CancelCreateNewCustomer;
    }
}