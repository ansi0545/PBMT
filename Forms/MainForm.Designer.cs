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
            btnIncomeRegistration.Location = new Point(287, 129);
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
            btnReminders.Location = new Point(880, 126);
            btnReminders.Name = "btnReminders";
            btnReminders.Size = new Size(200, 50);
            btnReminders.TabIndex = 4;
            btnReminders.Text = "Reminders";
            btnReminders.Click += btnReminders_Click;
            // 
            // lblFinancialSummary
            // 
            lblFinancialSummary.Location = new Point(287, 239);
            lblFinancialSummary.Name = "lblFinancialSummary";
            lblFinancialSummary.Size = new Size(793, 300);
            lblFinancialSummary.TabIndex = 5;
            lblFinancialSummary.Text = "Financial Summary: ";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(582, 567);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 53);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.Click += btnSubmit_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(0, 0);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 0;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(0, 0);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 0;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(0, 0);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(100, 31);
            txtNewUsername.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(0, 0);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(100, 31);
            txtNewPassword.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(0, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(0, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 0;
            // 
            // lblNewUsername
            // 
            lblNewUsername.Location = new Point(0, 0);
            lblNewUsername.Name = "lblNewUsername";
            lblNewUsername.Size = new Size(100, 23);
            lblNewUsername.TabIndex = 0;
            // 
            // lblNewPassword
            // 
            lblNewPassword.Location = new Point(0, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(100, 23);
            lblNewPassword.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 663);
            Controls.Add(btnIncomeRegistration);
            Controls.Add(btnExpenseTracking);
            Controls.Add(btnSavingsGoals);
            Controls.Add(btnReports);
            Controls.Add(btnReminders);
            Controls.Add(lblFinancialSummary);
            Controls.Add(btnLogin);
            Name = "MainForm";
            Text = "Personal budget management tool";
            ResumeLayout(false);
        }

        private Button btnLogin;
    }





    #endregion
}

