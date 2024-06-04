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
        
        private Button btnLogin;
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
            btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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

    }





    #endregion
}

