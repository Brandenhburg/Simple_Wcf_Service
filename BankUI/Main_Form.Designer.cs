
namespace BankUI
{
    partial class Main_Form
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
            this.textBox_CustomerId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Firstname_MainForm = new System.Windows.Forms.TextBox();
            this.textBox_CustomerLastName_MainForm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CurrentBalance_MainForm = new System.Windows.Forms.TextBox();
            this.textBox_SavingsBalance_MainForm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_AddNewCustomer = new System.Windows.Forms.Button();
            this.button_RemoveCustomer = new System.Windows.Forms.Button();
            this.button_SearchCustomer = new System.Windows.Forms.Button();
            this.button_ViewAllCustomers = new System.Windows.Forms.Button();
            this.button_ManageFunds = new System.Windows.Forms.Button();
            this.panel_ManageFunds = new System.Windows.Forms.Panel();
            this.label_toAccountType = new System.Windows.Forms.Label();
            this.label_fromAccountType = new System.Windows.Forms.Label();
            this.label_FundsAmount = new System.Windows.Forms.Label();
            this.button_AcceptFundsOperation = new System.Windows.Forms.Button();
            this.button_InnerTransfer = new System.Windows.Forms.Button();
            this.button_Withdraw = new System.Windows.Forms.Button();
            this.button_Depozit = new System.Windows.Forms.Button();
            this.textBox_fundsAmount = new System.Windows.Forms.TextBox();
            this.comboBox_fromAccountType = new System.Windows.Forms.ComboBox();
            this.comboBox_toAccountType = new System.Windows.Forms.ComboBox();
            this.button_CancelManagerFunds = new System.Windows.Forms.Button();
            this.panel_ManageFunds.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // textBox_CustomerId
            // 
            this.textBox_CustomerId.Location = new System.Drawing.Point(186, 59);
            this.textBox_CustomerId.Name = "textBox_CustomerId";
            this.textBox_CustomerId.Size = new System.Drawing.Size(100, 20);
            this.textBox_CustomerId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "FirstName";
            // 
            // textBox_Firstname_MainForm
            // 
            this.textBox_Firstname_MainForm.Enabled = false;
            this.textBox_Firstname_MainForm.Location = new System.Drawing.Point(52, 129);
            this.textBox_Firstname_MainForm.Name = "textBox_Firstname_MainForm";
            this.textBox_Firstname_MainForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_Firstname_MainForm.TabIndex = 2;
            // 
            // textBox_CustomerLastName_MainForm
            // 
            this.textBox_CustomerLastName_MainForm.Enabled = false;
            this.textBox_CustomerLastName_MainForm.Location = new System.Drawing.Point(186, 129);
            this.textBox_CustomerLastName_MainForm.Name = "textBox_CustomerLastName_MainForm";
            this.textBox_CustomerLastName_MainForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_CustomerLastName_MainForm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "LastName";
            // 
            // textBox_CurrentBalance_MainForm
            // 
            this.textBox_CurrentBalance_MainForm.Enabled = false;
            this.textBox_CurrentBalance_MainForm.Location = new System.Drawing.Point(52, 207);
            this.textBox_CurrentBalance_MainForm.Name = "textBox_CurrentBalance_MainForm";
            this.textBox_CurrentBalance_MainForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_CurrentBalance_MainForm.TabIndex = 5;
            // 
            // textBox_SavingsBalance_MainForm
            // 
            this.textBox_SavingsBalance_MainForm.Enabled = false;
            this.textBox_SavingsBalance_MainForm.Location = new System.Drawing.Point(186, 208);
            this.textBox_SavingsBalance_MainForm.Name = "textBox_SavingsBalance_MainForm";
            this.textBox_SavingsBalance_MainForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_SavingsBalance_MainForm.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Savings Balance";
            // 
            // button_AddNewCustomer
            // 
            this.button_AddNewCustomer.Location = new System.Drawing.Point(429, 53);
            this.button_AddNewCustomer.Name = "button_AddNewCustomer";
            this.button_AddNewCustomer.Size = new System.Drawing.Size(133, 23);
            this.button_AddNewCustomer.TabIndex = 9;
            this.button_AddNewCustomer.Text = "Add  New Customer";
            this.button_AddNewCustomer.UseVisualStyleBackColor = true;
            this.button_AddNewCustomer.Click += new System.EventHandler(this.button_AddNewCustomer_Click);
            // 
            // button_RemoveCustomer
            // 
            this.button_RemoveCustomer.Enabled = false;
            this.button_RemoveCustomer.Location = new System.Drawing.Point(429, 93);
            this.button_RemoveCustomer.Name = "button_RemoveCustomer";
            this.button_RemoveCustomer.Size = new System.Drawing.Size(133, 22);
            this.button_RemoveCustomer.TabIndex = 10;
            this.button_RemoveCustomer.Text = "Remove Customer";
            this.button_RemoveCustomer.UseVisualStyleBackColor = true;
            this.button_RemoveCustomer.Click += new System.EventHandler(this.button_RemoveCustomer_Click);
            // 
            // button_SearchCustomer
            // 
            this.button_SearchCustomer.Location = new System.Drawing.Point(52, 53);
            this.button_SearchCustomer.Name = "button_SearchCustomer";
            this.button_SearchCustomer.Size = new System.Drawing.Size(100, 26);
            this.button_SearchCustomer.TabIndex = 11;
            this.button_SearchCustomer.Text = "Search Customer";
            this.button_SearchCustomer.UseVisualStyleBackColor = true;
            this.button_SearchCustomer.Click += new System.EventHandler(this.button_SearchCustomer_Click);
            // 
            // button_ViewAllCustomers
            // 
            this.button_ViewAllCustomers.Location = new System.Drawing.Point(599, 55);
            this.button_ViewAllCustomers.Name = "button_ViewAllCustomers";
            this.button_ViewAllCustomers.Size = new System.Drawing.Size(133, 23);
            this.button_ViewAllCustomers.TabIndex = 12;
            this.button_ViewAllCustomers.Text = "View Customers";
            this.button_ViewAllCustomers.UseVisualStyleBackColor = true;
            this.button_ViewAllCustomers.Click += new System.EventHandler(this.button_ViewAllCustomers_Click);
            // 
            // button_ManageFunds
            // 
            this.button_ManageFunds.Enabled = false;
            this.button_ManageFunds.Location = new System.Drawing.Point(599, 93);
            this.button_ManageFunds.Name = "button_ManageFunds";
            this.button_ManageFunds.Size = new System.Drawing.Size(133, 22);
            this.button_ManageFunds.TabIndex = 13;
            this.button_ManageFunds.Text = "Manage Funds";
            this.button_ManageFunds.UseVisualStyleBackColor = true;
            this.button_ManageFunds.Click += new System.EventHandler(this.button_ManageFunds_Click);
            // 
            // panel_ManageFunds
            // 
            this.panel_ManageFunds.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_ManageFunds.Controls.Add(this.label_toAccountType);
            this.panel_ManageFunds.Controls.Add(this.label_fromAccountType);
            this.panel_ManageFunds.Controls.Add(this.label_FundsAmount);
            this.panel_ManageFunds.Controls.Add(this.button_AcceptFundsOperation);
            this.panel_ManageFunds.Controls.Add(this.button_InnerTransfer);
            this.panel_ManageFunds.Controls.Add(this.button_Withdraw);
            this.panel_ManageFunds.Controls.Add(this.button_Depozit);
            this.panel_ManageFunds.Controls.Add(this.textBox_fundsAmount);
            this.panel_ManageFunds.Controls.Add(this.comboBox_fromAccountType);
            this.panel_ManageFunds.Controls.Add(this.comboBox_toAccountType);
            this.panel_ManageFunds.Controls.Add(this.button_CancelManagerFunds);
            this.panel_ManageFunds.Location = new System.Drawing.Point(780, 0);
            this.panel_ManageFunds.Name = "panel_ManageFunds";
            this.panel_ManageFunds.Size = new System.Drawing.Size(400, 440);
            this.panel_ManageFunds.TabIndex = 14;
            // 
            // label_toAccountType
            // 
            this.label_toAccountType.AutoSize = true;
            this.label_toAccountType.Location = new System.Drawing.Point(217, 152);
            this.label_toAccountType.Name = "label_toAccountType";
            this.label_toAccountType.Size = new System.Drawing.Size(90, 13);
            this.label_toAccountType.TabIndex = 10;
            this.label_toAccountType.Text = "To Account Type";
            // 
            // label_fromAccountType
            // 
            this.label_fromAccountType.AutoSize = true;
            this.label_fromAccountType.Location = new System.Drawing.Point(34, 152);
            this.label_fromAccountType.Name = "label_fromAccountType";
            this.label_fromAccountType.Size = new System.Drawing.Size(100, 13);
            this.label_fromAccountType.TabIndex = 9;
            this.label_fromAccountType.Text = "From Account Type";
            // 
            // label_FundsAmount
            // 
            this.label_FundsAmount.AutoSize = true;
            this.label_FundsAmount.Location = new System.Drawing.Point(139, 243);
            this.label_FundsAmount.Name = "label_FundsAmount";
            this.label_FundsAmount.Size = new System.Drawing.Size(71, 13);
            this.label_FundsAmount.TabIndex = 8;
            this.label_FundsAmount.Text = "Insert amount";
            // 
            // button_AcceptFundsOperation
            // 
            this.button_AcceptFundsOperation.Enabled = false;
            this.button_AcceptFundsOperation.Location = new System.Drawing.Point(61, 346);
            this.button_AcceptFundsOperation.Name = "button_AcceptFundsOperation";
            this.button_AcceptFundsOperation.Size = new System.Drawing.Size(84, 31);
            this.button_AcceptFundsOperation.TabIndex = 7;
            this.button_AcceptFundsOperation.Text = "Accept";
            this.button_AcceptFundsOperation.UseVisualStyleBackColor = true;
            this.button_AcceptFundsOperation.Click += new System.EventHandler(this.button_AcceptFundsOperation_Click);
            // 
            // button_InnerTransfer
            // 
            this.button_InnerTransfer.Location = new System.Drawing.Point(235, 84);
            this.button_InnerTransfer.Name = "button_InnerTransfer";
            this.button_InnerTransfer.Size = new System.Drawing.Size(103, 23);
            this.button_InnerTransfer.TabIndex = 6;
            this.button_InnerTransfer.Text = "Inner Transfer";
            this.button_InnerTransfer.UseVisualStyleBackColor = true;
            this.button_InnerTransfer.Click += new System.EventHandler(this.button_InnerTransfer_Click);
            // 
            // button_Withdraw
            // 
            this.button_Withdraw.Location = new System.Drawing.Point(139, 84);
            this.button_Withdraw.Name = "button_Withdraw";
            this.button_Withdraw.Size = new System.Drawing.Size(75, 23);
            this.button_Withdraw.TabIndex = 5;
            this.button_Withdraw.Text = "Withdraw";
            this.button_Withdraw.UseVisualStyleBackColor = true;
            this.button_Withdraw.Click += new System.EventHandler(this.button_Withdraw_Click);
            // 
            // button_Depozit
            // 
            this.button_Depozit.Location = new System.Drawing.Point(34, 84);
            this.button_Depozit.Name = "button_Depozit";
            this.button_Depozit.Size = new System.Drawing.Size(75, 23);
            this.button_Depozit.TabIndex = 4;
            this.button_Depozit.Text = "Depozit";
            this.button_Depozit.UseVisualStyleBackColor = true;
            this.button_Depozit.Click += new System.EventHandler(this.button_Depozit_Click);
            // 
            // textBox_fundsAmount
            // 
            this.textBox_fundsAmount.Enabled = false;
            this.textBox_fundsAmount.Location = new System.Drawing.Point(139, 262);
            this.textBox_fundsAmount.Name = "textBox_fundsAmount";
            this.textBox_fundsAmount.Size = new System.Drawing.Size(100, 20);
            this.textBox_fundsAmount.TabIndex = 3;
            // 
            // comboBox_fromAccountType
            // 
            this.comboBox_fromAccountType.Enabled = false;
            this.comboBox_fromAccountType.FormattingEnabled = true;
            this.comboBox_fromAccountType.Items.AddRange(new object[] {
            "Current Account",
            "Savings Account"});
            this.comboBox_fromAccountType.Location = new System.Drawing.Point(34, 183);
            this.comboBox_fromAccountType.Name = "comboBox_fromAccountType";
            this.comboBox_fromAccountType.Size = new System.Drawing.Size(121, 21);
            this.comboBox_fromAccountType.TabIndex = 2;
            this.comboBox_fromAccountType.Text = "Select Account ";
            // 
            // comboBox_toAccountType
            // 
            this.comboBox_toAccountType.Enabled = false;
            this.comboBox_toAccountType.FormattingEnabled = true;
            this.comboBox_toAccountType.Items.AddRange(new object[] {
            "Current Account",
            "Savings Account"});
            this.comboBox_toAccountType.Location = new System.Drawing.Point(217, 183);
            this.comboBox_toAccountType.Name = "comboBox_toAccountType";
            this.comboBox_toAccountType.Size = new System.Drawing.Size(121, 21);
            this.comboBox_toAccountType.TabIndex = 1;
            this.comboBox_toAccountType.Text = "Select Account";
            // 
            // button_CancelManagerFunds
            // 
            this.button_CancelManagerFunds.Location = new System.Drawing.Point(217, 346);
            this.button_CancelManagerFunds.Name = "button_CancelManagerFunds";
            this.button_CancelManagerFunds.Size = new System.Drawing.Size(84, 31);
            this.button_CancelManagerFunds.TabIndex = 0;
            this.button_CancelManagerFunds.Text = "Cancel";
            this.button_CancelManagerFunds.UseVisualStyleBackColor = true;
            this.button_CancelManagerFunds.Click += new System.EventHandler(this.button_CancelManagerFunds_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.panel_ManageFunds);
            this.Controls.Add(this.button_ManageFunds);
            this.Controls.Add(this.button_ViewAllCustomers);
            this.Controls.Add(this.button_SearchCustomer);
            this.Controls.Add(this.button_RemoveCustomer);
            this.Controls.Add(this.button_AddNewCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_SavingsBalance_MainForm);
            this.Controls.Add(this.textBox_CurrentBalance_MainForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_CustomerLastName_MainForm);
            this.Controls.Add(this.textBox_Firstname_MainForm);
            this.Controls.Add(this.textBox_CustomerId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main_Form";
            this.Text = "Bank Manager";
            this.panel_ManageFunds.ResumeLayout(false);
            this.panel_ManageFunds.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_CustomerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Firstname_MainForm;
        private System.Windows.Forms.TextBox textBox_CustomerLastName_MainForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_CurrentBalance_MainForm;
        private System.Windows.Forms.TextBox textBox_SavingsBalance_MainForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_AddNewCustomer;
        private System.Windows.Forms.Button button_RemoveCustomer;
        private System.Windows.Forms.Button button_SearchCustomer;
        private System.Windows.Forms.Button button_ViewAllCustomers;
        private System.Windows.Forms.Button button_ManageFunds;
        private System.Windows.Forms.Panel panel_ManageFunds;
        private System.Windows.Forms.Button button_CancelManagerFunds;
        private System.Windows.Forms.Button button_InnerTransfer;
        private System.Windows.Forms.Button button_Withdraw;
        private System.Windows.Forms.Button button_Depozit;
        private System.Windows.Forms.TextBox textBox_fundsAmount;
        private System.Windows.Forms.ComboBox comboBox_fromAccountType;
        private System.Windows.Forms.ComboBox comboBox_toAccountType;
        private System.Windows.Forms.Label label_toAccountType;
        private System.Windows.Forms.Label label_fromAccountType;
        private System.Windows.Forms.Label label_FundsAmount;
        private System.Windows.Forms.Button button_AcceptFundsOperation;
    }
}

