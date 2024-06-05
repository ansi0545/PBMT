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
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;


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
            btnRegister = new Button();
            SuspendLayout();
            // 
            // btnIncomeRegistration
            // 
            btnIncomeRegistration.Location = new Point(40, 77);
            btnIncomeRegistration.Margin = new Padding(4, 3, 4, 3);
            btnIncomeRegistration.Name = "btnIncomeRegistration";
            btnIncomeRegistration.Size = new Size(240, 44);
            btnIncomeRegistration.TabIndex = 0;
            btnIncomeRegistration.Text = "Income Registration";
            btnIncomeRegistration.Click += btnIncomeRegistration_Click;
            // 
            // btnExpenseTracking
            // 
            btnExpenseTracking.Location = new Point(40, 11);
            btnExpenseTracking.Margin = new Padding(4, 3, 4, 3);
            btnExpenseTracking.Name = "btnExpenseTracking";
            btnExpenseTracking.Size = new Size(240, 44);
            btnExpenseTracking.TabIndex = 1;
            btnExpenseTracking.Text = "Expense Tracking";
            btnExpenseTracking.Click += btnExpenseTracking_Click;
            // 
            // btnSavingsGoals
            // 
            btnSavingsGoals.Location = new Point(40, 148);
            btnSavingsGoals.Margin = new Padding(4, 3, 4, 3);
            btnSavingsGoals.Name = "btnSavingsGoals";
            btnSavingsGoals.Size = new Size(240, 44);
            btnSavingsGoals.TabIndex = 2;
            btnSavingsGoals.Text = "Savings Goals";
            btnSavingsGoals.Click += btnSavingsGoals_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(40, 216);
            btnReports.Margin = new Padding(4, 3, 4, 3);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(240, 44);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports";
            btnReports.Click += btnReports_Click;
            // 
            // btnReminders
            // 
            btnReminders.Location = new Point(40, 290);
            btnReminders.Margin = new Padding(4, 3, 4, 3);
            btnReminders.Name = "btnReminders";
            btnReminders.Size = new Size(240, 44);
            btnReminders.TabIndex = 4;
            btnReminders.Text = "Reminders";
            btnReminders.Click += btnReminders_Click;
            // 
            // lblFinancialSummary
            // 
            lblFinancialSummary.BackColor = SystemColors.AppWorkspace;
            lblFinancialSummary.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFinancialSummary.Location = new Point(323, 11);
            lblFinancialSummary.Margin = new Padding(4, 0, 4, 0);
            lblFinancialSummary.Name = "lblFinancialSummary";
            lblFinancialSummary.Size = new Size(984, 382);
            lblFinancialSummary.TabIndex = 5;
            lblFinancialSummary.Text = "Financial Summary: ";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(323, 425);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(240, 47);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(612, 425);
            btnRegister.Margin = new Padding(4, 3, 4, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(240, 47);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1711, 583);
            Controls.Add(btnIncomeRegistration);
            Controls.Add(btnExpenseTracking);
            Controls.Add(btnSavingsGoals);
            Controls.Add(btnReports);
            Controls.Add(btnReminders);
            Controls.Add(lblFinancialSummary);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Personal budget management tool";
            ResumeLayout(false);
        }
    }





    #endregion
}

