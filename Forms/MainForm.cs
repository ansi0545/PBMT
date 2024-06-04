using System;
using System.Windows.Forms;

namespace Personal_budget_management_tool.Forms
{
    public partial class MainForm : Form
    {
        private User currentUser;
        private BudgetManager budgetApp; // Add this line

        public MainForm()
        {
            InitializeComponent();
            budgetApp = new BudgetManager(); // Initialize the budgetApp variable with a new BudgetManager instance
            UpdateFinancialSummary();
        }

        private void UpdateFinancialSummary()
        {
            lblFinancialSummary.Text = "Financial Summary: Here will be the user's current financial situation.";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(budgetApp); // Pass budgetApp to the form
            loginForm.Show();
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