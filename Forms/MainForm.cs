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

        /// <summary>
        /// Updates the financial summary label with the specified summary text.
        /// </summary>
        /// <param name="summary">The summary text to be displayed.</param>
        internal void UpdateFinancialSummary(string summary)
        {
            lblFinancialSummary.Text = summary;
        }

        /// <summary>
        /// Event handler for the login button click event.
        /// Opens the login form.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(budgetManager, dataManager);
            loginForm.Show();
        }

        /// <summary>
        /// Event handler for the click event of the btnRegister button.
        /// Opens the RegisterForm and passes the budgetManager object to it.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(budgetManager);
            registerForm.Show();
        }

        /// <summary>
        /// Checks if the user is logged in before executing the specified action.
        /// </summary>
        /// <param name="action">The action to be executed.</param>
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

        /// <summary>
        /// Event handler for the btnIncomeRegistration button click event.
        /// Opens the IncomeRegistrationForm after checking the login status.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnIncomeRegistration_Click(object sender, EventArgs e)
        {
            CheckLoginBeforeAction(() =>
            {
                IncomeRegistrationForm incomeRegistrationForm = new IncomeRegistrationForm(budgetManager, this);
                incomeRegistrationForm.Show();
            });
        }

        /// <summary>
        /// Event handler for the Expense Tracking button click.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnExpenseTracking_Click(object sender, EventArgs e)
        {
            CheckLoginBeforeAction(() =>
            {
                ExpenseTrackingForm expenseTrackingForm = new ExpenseTrackingForm(budgetManager, this);
                expenseTrackingForm.Show();
            });
        }

        /// <summary>
        /// Event handler for the btnSavingsGoals button click event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnSavingsGoals_Click(object sender, EventArgs e)
        {
            CheckLoginBeforeAction(() =>
            {
                DataManager dataManager = new DataManager { FilePath = Application.StartupPath + "\\Budget.txt" };
                SavingsGoalsForm savingsGoalsForm = new SavingsGoalsForm(budgetManager, dataManager, this);
                savingsGoalsForm.Show();
            });
        }

        /// <summary>
        /// Event handler for the "Reports" button click event.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
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

        /// <summary>
        /// Event handler for the btnReminders button click event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnReminders_Click(object sender, EventArgs e)
        {
            CheckLoginBeforeAction(() =>
            {
                RemindersForm remindersForm = new RemindersForm(budgetManager, dataManager);
                remindersForm.Show();
            });
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}