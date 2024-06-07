using System;
using System.Windows.Forms;
using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{
    public partial class MainForm : Form
    {
        private User currentUser;


        private BudgetManager budgetManager; // Add this line
        private DataManager dataManager;

        string fileName = Application.StartupPath + "\\Budget.txt";

        public MainForm()
        {
            InitializeComponent();
            dataManager = new DataManager { FilePath = Application.StartupPath + "\\Budget.txt" };
            budgetManager = new BudgetManager(dataManager);
            UpdateFinancialSummary();
        }

        private void UpdateFinancialSummary()
        {
            lblFinancialSummary.Text = "Financial Summary: Here will be the user's current financial situation.";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(budgetManager, dataManager); // Pass budgetManager to the form
            loginForm.Show();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(budgetManager); // Pass budgetManager to the form
            registerForm.Show();
        }
        private void btnIncomeRegistration_Click(object sender, EventArgs e)
        {
            IncomeRegistrationForm incomeRegistrationForm = new IncomeRegistrationForm(budgetManager); // Pass budgetManager to the form
            incomeRegistrationForm.Show();
        }

        private void btnExpenseTracking_Click(object sender, EventArgs e)
        {
            ExpenseTrackingForm expenseTrackingForm = new ExpenseTrackingForm(budgetManager); // Pass budgetManager to the form
            expenseTrackingForm.Show();
        }

        private void btnSavingsGoals_Click(object sender, EventArgs e)
        {
            DataManager dataManager = new DataManager();
            SavingsGoalsForm savingsGoalsForm = new SavingsGoalsForm(budgetManager, dataManager); // Pass budgetManager to the form
            savingsGoalsForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm(budgetManager); // Pass budgetManager to the form
            reportsForm.Show();
        }

        private void btnReminders_Click(object sender, EventArgs e)
        {
            RemindersForm remindersForm = new RemindersForm(budgetManager); // Pass budgetManager to the form
            remindersForm.Show();
        }

    }
}