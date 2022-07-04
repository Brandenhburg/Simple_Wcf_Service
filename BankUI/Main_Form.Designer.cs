
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
            this.button_SearchCustomer = new System.Windows.Forms.Button();
            this.label_CustomerId = new System.Windows.Forms.Label();
            this.textBox_CustomerId = new System.Windows.Forms.TextBox();
            this.label_Firstname = new System.Windows.Forms.Label();
            this.textBox_Firstname_MainForm = new System.Windows.Forms.TextBox();
            this.textBox_CustomerLastName_MainForm = new System.Windows.Forms.TextBox();
            this.label_Lastname = new System.Windows.Forms.Label();
            this.textBox_CurrentBalance_MainForm = new System.Windows.Forms.TextBox();
            this.textBox_SavingsBalance_MainForm = new System.Windows.Forms.TextBox();
            this.label_CurrentBalance = new System.Windows.Forms.Label();
            this.label_SavingsBalance = new System.Windows.Forms.Label();
            this.button_AddNewCustomer = new System.Windows.Forms.Button();
            this.button_RemoveCustomer = new System.Windows.Forms.Button();
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
            this.ToolStripMenuItem_SignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_ManageFunds.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_CustomerId
            // 
            this.label_CustomerId.AutoSize = true;
            this.label_CustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerId.Location = new System.Drawing.Point(33, 93);
            this.label_CustomerId.Name = "label_CustomerId";
            this.label_CustomerId.Size = new System.Drawing.Size(75, 15);
            this.label_CustomerId.TabIndex = 0;
            this.label_CustomerId.Text = "Customer ID";
            // 
            // textBox_CustomerId
            // 
            this.textBox_CustomerId.Location = new System.Drawing.Point(36, 111);
            this.textBox_CustomerId.Name = "textBox_CustomerId";
            this.textBox_CustomerId.Size = new System.Drawing.Size(100, 20);
            this.textBox_CustomerId.TabIndex = 1;
            // 
            // label_Firstname
            // 
            this.label_Firstname.AutoSize = true;
            this.label_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Firstname.Location = new System.Drawing.Point(33, 152);
            this.label_Firstname.Name = "label_Firstname";
            this.label_Firstname.Size = new System.Drawing.Size(62, 15);
            this.label_Firstname.TabIndex = 0;
            this.label_Firstname.Text = "Firstname";
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
            // label_Lastname
            // 
            this.label_Lastname.AutoSize = true;
            this.label_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Lastname.Location = new System.Drawing.Point(33, 209);
            this.label_Lastname.Name = "label_Lastname";
            this.label_Lastname.Size = new System.Drawing.Size(62, 15);
            this.label_Lastname.TabIndex = 4;
            this.label_Lastname.Text = "Lastname";
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
            // label_CurrentBalance
            // 
            this.label_CurrentBalance.AutoSize = true;
            this.label_CurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentBalance.Location = new System.Drawing.Point(33, 260);
            this.label_CurrentBalance.Name = "label_CurrentBalance";
            this.label_CurrentBalance.Size = new System.Drawing.Size(95, 15);
            this.label_CurrentBalance.TabIndex = 7;
            this.label_CurrentBalance.Text = "Current Balance";
            // 
            // label_SavingsBalance
            // 
            this.label_SavingsBalance.AutoSize = true;
            this.label_SavingsBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SavingsBalance.Location = new System.Drawing.Point(33, 312);
            this.label_SavingsBalance.Name = "label_SavingsBalance";
            this.label_SavingsBalance.Size = new System.Drawing.Size(98, 15);
            this.label_SavingsBalance.TabIndex = 8;
            this.label_SavingsBalance.Text = "Savings Balance";
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
            this.panel_ManageFunds.Location = new System.Drawing.Point(780, 25);
            this.panel_ManageFunds.Name = "panel_ManageFunds";
            this.panel_ManageFunds.Size = new System.Drawing.Size(400, 415);
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
            this.menuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 25);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_SignOut,
            this.ToolStripMenuItem_Exit});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ToolStripMenuItem_SignOut
            // 
            this.ToolStripMenuItem_SignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripMenuItem_SignOut.Name = "ToolStripMenuItem_SignOut";
            this.ToolStripMenuItem_SignOut.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItem_SignOut.Text = "Sign Out";
            this.ToolStripMenuItem_SignOut.Click += new System.EventHandler(this.ToolStripMenuItem_SignOut_Click);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenuItem_Exit.Text = "Exit";
            this.ToolStripMenuItem_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.button_SearchCustomer);
            this.Controls.Add(this.label_CustomerId);
            this.Controls.Add(this.panel_ManageFunds);
            this.Controls.Add(this.textBox_CustomerId);
            this.Controls.Add(this.button_AddNewCustomer);
            this.Controls.Add(this.button_ViewAllCustomers);
            this.Controls.Add(this.button_RemoveCustomer);
            this.Controls.Add(this.button_ManageFunds);
            this.Controls.Add(this.label_CurrentBalance);
            this.Controls.Add(this.textBox_CurrentBalance_MainForm);
            this.Controls.Add(this.label_SavingsBalance);
            this.Controls.Add(this.textBox_SavingsBalance_MainForm);
            this.Controls.Add(this.label_Firstname);
            this.Controls.Add(this.textBox_Firstname_MainForm);
            this.Controls.Add(this.label_Lastname);
            this.Controls.Add(this.textBox_CustomerLastName_MainForm);
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

        private System.Windows.Forms.Label label_CustomerId;
        private System.Windows.Forms.TextBox textBox_CustomerId;
        private System.Windows.Forms.Label label_Firstname;
        private System.Windows.Forms.TextBox textBox_Firstname_MainForm;
        private System.Windows.Forms.TextBox textBox_CustomerLastName_MainForm;
        private System.Windows.Forms.Label label_Lastname;
        private System.Windows.Forms.TextBox textBox_CurrentBalance_MainForm;
        private System.Windows.Forms.TextBox textBox_SavingsBalance_MainForm;
        private System.Windows.Forms.Label label_CurrentBalance;
        private System.Windows.Forms.Label label_SavingsBalance;
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
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SignOut;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}

