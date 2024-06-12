using System;
using System.Windows.Forms;
using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{
    public partial class MainForm : Form
    {
        private User currentUser;
        private BudgetManager budgetManager;
        private DataManager dataManager;

        string fileName = Application.StartupPath + "\\Budget.txt";

        public MainForm()
        {
            InitializeComponent();
            dataManager = new DataManager { FilePath = Application.StartupPath + "\\Budget.txt" };
            budgetManager = new BudgetManager(dataManager);
            UpdateFinancialSummary(budgetManager.GetFinancialSummary());
        }

        internal void UpdateFinancialSummary(string summary)
        {
            lblFinancialSummary.Text = summary;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(budgetManager, dataManager);
            loginForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(budgetManager);
            registerForm.Show();
        }

        private void CheckLoginBeforeAction(Action action)
        {
            if (budgetManager.CurrentUser == null)
            {
                MessageBox.Show("Please log in first.");
            }
            else
            {
                action();
            }
        }

        private void btnIncomeRegistration_Click(object sender, EventArgs e)
        {
            CheckLoginBeforeAction(() =>
            {
                IncomeRegistrationForm incomeRegistrationForm = new IncomeRegistrationForm(budgetManager, this);
                incomeRegistrationForm.Show();
            });
        }

        private void btnExpenseTracking_Click(object sender, EventArgs e)
        {
            CheckLoginBeforeAction(() =>
            {
                ExpenseTrackingForm expenseTrackingForm = new ExpenseTrackingForm(budgetManager, this);
                expenseTrackingForm.Show();
            });
        }

        private void btnSavingsGoals_Click(object sender, EventArgs e)
        {
            CheckLoginBeforeAction(() =>
            {
                DataManager dataManager = new DataManager { FilePath = Application.StartupPath + "\\Budget.txt" };
                SavingsGoalsForm savingsGoalsForm = new SavingsGoalsForm(budgetManager, dataManager, this);
                savingsGoalsForm.Show();
            });
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

            CheckLoginBeforeAction(() =>
            {
                if (budgetManager.CurrentUser == null)
                {
                    MessageBox.Show("No user is currently logged in.");
                    return;
                }

                ReportsForm reportsForm = new ReportsForm(budgetManager, budgetManager.CurrentUser);
                reportsForm.Show();
            });
        }

        private void btnReminders_Click(object sender, EventArgs e)
        {
            CheckLoginBeforeAction(() =>
            {
                RemindersForm remindersForm = new RemindersForm(budgetManager);
                remindersForm.Show();
            });
        }
    }
}