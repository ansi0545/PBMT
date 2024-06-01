using System;
using System.Windows.Forms;

namespace Personal_budget_management_tool.Forms
{
    public partial class MainForm : Form
    {
        private User currentUser;
        private BudgetApp budgetApp; // Add this line

        public MainForm()
        {
            InitializeComponent();
            budgetApp = new BudgetApp(); // Initialize the budgetApp variable with a new BudgetApp instance
            UpdateFinancialSummary();
        }

        private void UpdateFinancialSummary()
        {
            lblFinancialSummary.Text = "Financial Summary: Here will be the user's current financial situation.";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUsername = txtUsername.Text; // replace with actual username
            string inputPassword = txtPassword.Text; // replace with actual password

            try
            {
                budgetApp.LoginUser(inputUsername, inputPassword);
                MessageBox.Show("Login successful!");
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string inputUsername = txtUsername.Text;
            string inputPassword = txtPassword.Text;

            try
            {
                budgetApp.LoginUser(inputUsername, inputPassword);
                MessageBox.Show("Login successful!");
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string newUsername = txtNewUsername.Text;
            string newPassword = txtNewPassword.Text;

            currentUser.Register(newUsername, newPassword);
            MessageBox.Show("Registration successful!");
        }

        private void btnIncomeRegistration_Click(object sender, EventArgs e)
        {
            IncomeRegistrationForm incomeRegistrationForm = new IncomeRegistrationForm(budgetApp); // Pass budgetApp to the form
            incomeRegistrationForm.Show();
        }

        private void btnExpenseTracking_Click(object sender, EventArgs e)
        {
            ExpenseTrackingForm expenseTrackingForm = new ExpenseTrackingForm(budgetApp); // Pass budgetApp to the form
            expenseTrackingForm.Show();
        }

        private void btnSavingsGoals_Click(object sender, EventArgs e)
        {
            SavingsGoalsForm savingsGoalsForm = new SavingsGoalsForm(budgetApp); // Pass budgetApp to the form
            savingsGoalsForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm(budgetApp); // Pass budgetApp to the form
            reportsForm.Show();
        }

        private void btnReminders_Click(object sender, EventArgs e)
        {
            RemindersForm remindersForm = new RemindersForm(budgetApp); // Pass budgetApp to the form
            remindersForm.Show();
        }
    }
}