
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_ManageFunds.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // textBox_CustomerId
            // 
            this.textBox_CustomerId.Location = new System.Drawing.Point(36, 111);
            this.textBox_CustomerId.Name = "textBox_CustomerId";
            this.textBox_CustomerId.Size = new System.Drawing.Size(100, 20);
            this.textBox_CustomerId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firstname";
            // 
            // textBox_Firstname_MainForm
            // 
            this.textBox_Firstname_MainForm.Enabled = false;
            this.textBox_Firstname_MainForm.Location = new System.Drawing.Point(36, 170);
            this.textBox_Firstname_MainForm.Name = "textBox_Firstname_MainForm";
            this.textBox_Firstname_MainForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_Firstname_MainForm.TabIndex = 2;
            // 
            // textBox_CustomerLastName_MainForm
            // 
            this.textBox_CustomerLastName_MainForm.Enabled = false;
            this.textBox_CustomerLastName_MainForm.Location = new System.Drawing.Point(36, 227);
            this.textBox_CustomerLastName_MainForm.Name = "textBox_CustomerLastName_MainForm";
            this.textBox_CustomerLastName_MainForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_CustomerLastName_MainForm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lastname";
            // 
            // textBox_CurrentBalance_MainForm
            // 
            this.textBox_CurrentBalance_MainForm.Enabled = false;
            this.textBox_CurrentBalance_MainForm.Location = new System.Drawing.Point(36, 278);
            this.textBox_CurrentBalance_MainForm.Name = "textBox_CurrentBalance_MainForm";
            this.textBox_CurrentBalance_MainForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_CurrentBalance_MainForm.TabIndex = 5;
            // 
            // textBox_SavingsBalance_MainForm
            // 
            this.textBox_SavingsBalance_MainForm.Enabled = false;
            this.textBox_SavingsBalance_MainForm.Location = new System.Drawing.Point(36, 330);
            this.textBox_SavingsBalance_MainForm.Name = "textBox_SavingsBalance_MainForm";
            this.textBox_SavingsBalance_MainForm.Size = new System.Drawing.Size(100, 20);
            this.textBox_SavingsBalance_MainForm.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Savings Balance";
            // 
            // button_AddNewCustomer
            // 
            this.button_AddNewCustomer.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddNewCustomer.Location = new System.Drawing.Point(417, 55);
            this.button_AddNewCustomer.Name = "button_AddNewCustomer";
            this.button_AddNewCustomer.Size = new System.Drawing.Size(140, 40);
            this.button_AddNewCustomer.TabIndex = 9;
            this.button_AddNewCustomer.Text = "Add  New Customer";
            this.button_AddNewCustomer.UseVisualStyleBackColor = true;
            this.button_AddNewCustomer.Click += new System.EventHandler(this.button_AddNewCustomer_Click);
            // 
            // button_RemoveCustomer
            // 
            this.button_RemoveCustomer.Enabled = false;
            this.button_RemoveCustomer.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RemoveCustomer.Location = new System.Drawing.Point(417, 101);
            this.button_RemoveCustomer.Name = "button_RemoveCustomer";
            this.button_RemoveCustomer.Size = new System.Drawing.Size(140, 40);
            this.button_RemoveCustomer.TabIndex = 10;
            this.button_RemoveCustomer.Text = "Remove Customer";
            this.button_RemoveCustomer.UseVisualStyleBackColor = true;
            this.button_RemoveCustomer.Click += new System.EventHandler(this.button_RemoveCustomer_Click);
            // 
            // button_SearchCustomer
            // 
            this.button_SearchCustomer.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SearchCustomer.Location = new System.Drawing.Point(36, 38);
            this.button_SearchCustomer.Name = "button_SearchCustomer";
            this.button_SearchCustomer.Size = new System.Drawing.Size(100, 40);
            this.button_SearchCustomer.TabIndex = 11;
            this.button_SearchCustomer.Text = "Search Customer";
            this.button_SearchCustomer.UseVisualStyleBackColor = true;
            this.button_SearchCustomer.Click += new System.EventHandler(this.button_SearchCustomer_Click);
            // 
            // button_ViewAllCustomers
            // 
            this.button_ViewAllCustomers.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ViewAllCustomers.Location = new System.Drawing.Point(580, 55);
            this.button_ViewAllCustomers.Name = "button_ViewAllCustomers";
            this.button_ViewAllCustomers.Size = new System.Drawing.Size(140, 40);
            this.button_ViewAllCustomers.TabIndex = 12;
            this.button_ViewAllCustomers.Text = "View Customers";
            this.button_ViewAllCustomers.UseVisualStyleBackColor = true;
            this.button_ViewAllCustomers.Click += new System.EventHandler(this.button_ViewAllCustomers_Click);
            // 
            // button_ManageFunds
            // 
            this.button_ManageFunds.Enabled = false;
            this.button_ManageFunds.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ManageFunds.Location = new System.Drawing.Point(580, 101);
            this.button_ManageFunds.Name = "button_ManageFunds";
            this.button_ManageFunds.Size = new System.Drawing.Size(140, 40);
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
            this.label_toAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_toAccountType.Location = new System.Drawing.Point(239, 46);
            this.label_toAccountType.Name = "label_toAccountType";
            this.label_toAccountType.Size = new System.Drawing.Size(96, 15);
            this.label_toAccountType.TabIndex = 10;
            this.label_toAccountType.Text = "To Account Type";
            // 
            // label_fromAccountType
            // 
            this.label_fromAccountType.AutoSize = true;
            this.label_fromAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fromAccountType.Location = new System.Drawing.Point(239, 117);
            this.label_fromAccountType.Name = "label_fromAccountType";
            this.label_fromAccountType.Size = new System.Drawing.Size(111, 15);
            this.label_fromAccountType.TabIndex = 9;
            this.label_fromAccountType.Text = "From Account Type";
            // 
            // label_FundsAmount
            // 
            this.label_FundsAmount.AutoSize = true;
            this.label_FundsAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FundsAmount.Location = new System.Drawing.Point(239, 187);
            this.label_FundsAmount.Name = "label_FundsAmount";
            this.label_FundsAmount.Size = new System.Drawing.Size(82, 15);
            this.label_FundsAmount.TabIndex = 8;
            this.label_FundsAmount.Text = "Insert amount";
            // 
            // button_AcceptFundsOperation
            // 
            this.button_AcceptFundsOperation.Enabled = false;
            this.button_AcceptFundsOperation.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AcceptFundsOperation.Location = new System.Drawing.Point(45, 346);
            this.button_AcceptFundsOperation.Name = "button_AcceptFundsOperation";
            this.button_AcceptFundsOperation.Size = new System.Drawing.Size(120, 30);
            this.button_AcceptFundsOperation.TabIndex = 7;
            this.button_AcceptFundsOperation.Text = "Accept";
            this.button_AcceptFundsOperation.UseVisualStyleBackColor = true;
            this.button_AcceptFundsOperation.Click += new System.EventHandler(this.button_AcceptFundsOperation_Click);
            // 
            // button_InnerTransfer
            // 
            this.button_InnerTransfer.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InnerTransfer.Location = new System.Drawing.Point(45, 134);
            this.button_InnerTransfer.Name = "button_InnerTransfer";
            this.button_InnerTransfer.Size = new System.Drawing.Size(120, 30);
            this.button_InnerTransfer.TabIndex = 6;
            this.button_InnerTransfer.Text = "Inner Transfer";
            this.button_InnerTransfer.UseVisualStyleBackColor = true;
            this.button_InnerTransfer.Click += new System.EventHandler(this.button_InnerTransfer_Click);
            // 
            // button_Withdraw
            // 
            this.button_Withdraw.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Withdraw.Location = new System.Drawing.Point(45, 98);
            this.button_Withdraw.Name = "button_Withdraw";
            this.button_Withdraw.Size = new System.Drawing.Size(120, 30);
            this.button_Withdraw.TabIndex = 5;
            this.button_Withdraw.Text = "Withdraw";
            this.button_Withdraw.UseVisualStyleBackColor = true;
            this.button_Withdraw.Click += new System.EventHandler(this.button_Withdraw_Click);
            // 
            // button_Depozit
            // 
            this.button_Depozit.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Depozit.Location = new System.Drawing.Point(45, 62);
            this.button_Depozit.Name = "button_Depozit";
            this.button_Depozit.Size = new System.Drawing.Size(120, 30);
            this.button_Depozit.TabIndex = 4;
            this.button_Depozit.Text = "Depozit";
            this.button_Depozit.UseVisualStyleBackColor = true;
            this.button_Depozit.Click += new System.EventHandler(this.button_Depozit_Click);
            // 
            // textBox_fundsAmount
            // 
            this.textBox_fundsAmount.Enabled = false;
            this.textBox_fundsAmount.Location = new System.Drawing.Point(242, 205);
            this.textBox_fundsAmount.Name = "textBox_fundsAmount";
            this.textBox_fundsAmount.Size = new System.Drawing.Size(120, 20);
            this.textBox_fundsAmount.TabIndex = 3;
            // 
            // comboBox_fromAccountType
            // 
            this.comboBox_fromAccountType.Enabled = false;
            this.comboBox_fromAccountType.FormattingEnabled = true;
            this.comboBox_fromAccountType.Items.AddRange(new object[] {
            "Current Account",
            "Savings Account"});
            this.comboBox_fromAccountType.Location = new System.Drawing.Point(242, 133);
            this.comboBox_fromAccountType.Name = "comboBox_fromAccountType";
            this.comboBox_fromAccountType.Size = new System.Drawing.Size(120, 21);
            this.comboBox_fromAccountType.TabIndex = 2;
            // 
            // comboBox_toAccountType
            // 
            this.comboBox_toAccountType.Enabled = false;
            this.comboBox_toAccountType.FormattingEnabled = true;
            this.comboBox_toAccountType.Items.AddRange(new object[] {
            "Current Account",
            "Savings Account"});
            this.comboBox_toAccountType.Location = new System.Drawing.Point(242, 65);
            this.comboBox_toAccountType.Name = "comboBox_toAccountType";
            this.comboBox_toAccountType.Size = new System.Drawing.Size(120, 21);
            this.comboBox_toAccountType.TabIndex = 1;
            // 
            // button_CancelManagerFunds
            // 
            this.button_CancelManagerFunds.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CancelManagerFunds.Location = new System.Drawing.Point(242, 346);
            this.button_CancelManagerFunds.Name = "button_CancelManagerFunds";
            this.button_CancelManagerFunds.Size = new System.Drawing.Size(120, 30);
            this.button_CancelManagerFunds.TabIndex = 0;
            this.button_CancelManagerFunds.Text = "Cancel";
            this.button_CancelManagerFunds.UseVisualStyleBackColor = true;
            this.button_CancelManagerFunds.Click += new System.EventHandler(this.button_CancelManagerFunds_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 25);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToSystemToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectToSystemToolStripMenuItem
            // 
            this.connectToSystemToolStripMenuItem.Name = "connectToSystemToolStripMenuItem";
            this.connectToSystemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectToSystemToolStripMenuItem.Text = "Logout";
            this.connectToSystemToolStripMenuItem.Click += new System.EventHandler(this.connectToSystemToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.Controls.Add(this.menuStrip);
            this.Name = "Main_Form";
            this.Text = "Bank Manager";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panel_ManageFunds.ResumeLayout(false);
            this.panel_ManageFunds.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

