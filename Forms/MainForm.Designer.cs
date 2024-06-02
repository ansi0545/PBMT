namespace Personal_budget_management_tool.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private System.Windows.Forms.Button btnIncomeRegistration;
        private System.Windows.Forms.Button btnExpenseTracking;
        private System.Windows.Forms.Button btnSavingsGoals;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnReminders;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtNewUsername;
        private TextBox txtNewPassword;
        private Button btnSubmit;
        private Button btnRegister;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblNewUsername;
        private Label lblNewPassword;
        private System.Windows.Forms.Label lblFinancialSummary;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIncomeRegistration = new Button();
            btnExpenseTracking = new Button();
            btnSavingsGoals = new Button();
            btnReports = new Button();
            btnReminders = new Button();
            lblFinancialSummary = new Label();
            btnLogin = new Button();
            btnSubmit = new Button();
            btnRegister = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtNewUsername = new TextBox();
            txtNewPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            lblNewUsername = new Label();
            lblNewPassword = new Label();
            SuspendLayout();
            // 
            // btnIncomeRegistration
            // 
            btnIncomeRegistration.Location = new Point(12, 46);
            btnIncomeRegistration.Name = "btnIncomeRegistration";
            btnIncomeRegistration.Size = new Size(200, 50);
            btnIncomeRegistration.TabIndex = 0;
            btnIncomeRegistration.Text = "Income Registration";
            btnIncomeRegistration.Click += btnIncomeRegistration_Click;
            // 
            // btnExpenseTracking
            // 
            btnExpenseTracking.Location = new Point(287, 46);
            btnExpenseTracking.Name = "btnExpenseTracking";
            btnExpenseTracking.Size = new Size(200, 50);
            btnExpenseTracking.TabIndex = 1;
            btnExpenseTracking.Text = "Expense Tracking";
            btnExpenseTracking.Click += btnExpenseTracking_Click;
            // 
            // btnSavingsGoals
            // 
            btnSavingsGoals.Location = new Point(582, 46);
            btnSavingsGoals.Name = "btnSavingsGoals";
            btnSavingsGoals.Size = new Size(200, 50);
            btnSavingsGoals.TabIndex = 2;
            btnSavingsGoals.Text = "Savings Goals";
            btnSavingsGoals.Click += btnSavingsGoals_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(889, 46);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 50);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports";
            btnReports.Click += btnReports_Click;
            // 
            // btnReminders
            // 
            btnReminders.Location = new Point(1192, 46);
            btnReminders.Name = "btnReminders";
            btnReminders.Size = new Size(200, 50);
            btnReminders.TabIndex = 4;
            btnReminders.Text = "Reminders";
            btnReminders.Click += btnReminders_Click;
            // 
            // lblFinancialSummary
            // 
            lblFinancialSummary.Location = new Point(424, 287);
            lblFinancialSummary.Name = "lblFinancialSummary";
            lblFinancialSummary.Size = new Size(600, 300);
            lblFinancialSummary.TabIndex = 5;
            lblFinancialSummary.Text = "Financial Summary: ";
            // 
            // btnLogin
            // 
            btnLogin = new Button();
            btnLogin.Location = new Point(582, 178);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 50);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 663);
            Controls.Add(btnLogin);
            Controls.Add(btnIncomeRegistration);
            Controls.Add(btnExpenseTracking);
            Controls.Add(btnSavingsGoals);
            Controls.Add(btnReports);
            Controls.Add(btnReminders);
            Controls.Add(lblFinancialSummary);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            Name = "MainForm";
            Text = "Personal budget management tool";
            ResumeLayout(false);
        }

        private Button btnLogin;
    }





    #endregion
}

