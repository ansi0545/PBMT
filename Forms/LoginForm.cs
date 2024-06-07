using System;
using System.Windows.Forms;
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

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
