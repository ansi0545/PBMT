using System;
using System.Windows.Forms;
using Personal_budget_management_tool.HelperMethods;
using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{
    public partial class LoginForm : Form
    {
        private UserManager userManager;
        private BudgetManager budgetManager;
        private DataManager dataManager;

        public LoginForm(BudgetManager budgetManager, DataManager dataManager)
        {
            InitializeComponent();
            this.dataManager = dataManager;
            this.budgetManager = budgetManager;
            userManager = new UserManager(dataManager);
        }

        /// <summary>
        /// Event handler for the Submit button click event.
        /// Validates the username and password, checks if the budget file exists,
        /// loads data from the budget file, and validates the user's credentials.
        /// If the login is successful, sets the current user and closes the form.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (!ErrorHandling.IsValidDescription(username) || !ErrorHandling.IsValidDescription(password))
            {
                return;
            }

            if (!dataManager.FileExists("Budget.txt"))
            {
                MessageBox.Show("Budget file does not exist. Please create a budget first.");
                return;
            }

            dataManager.FilePath = "Budget.txt";
            if (dataManager.LoadDataFromFile<object>() == null)
            {
                return;
            }

            if (userManager.ValidateUser(username, password))
            {
                User user = userManager.LoginUser(username, password);
                if (user != null)
                {
                    budgetManager.CurrentUser = user;
                    MessageBox.Show("Login successful!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Login failed. Invalid username or password.");
            }
        }
    }
}
