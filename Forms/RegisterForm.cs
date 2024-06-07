﻿using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{
    public partial class RegisterForm : Form
    {
        private UserManager userManager;
        private DataManager dataManager;
        private User currentUser;
        private BudgetManager budgetManager;

        public RegisterForm(BudgetManager manager)
        {
            InitializeComponent();
            dataManager = new DataManager { FilePath = Application.StartupPath + "\\Budget.txt" }; // Initialize DataManager with file path
            userManager = new UserManager(dataManager); // Initialize userManager with DataManager instance
            budgetManager = manager;
            currentUser = budgetManager.GetCurrentUser();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string newUsername = txtNewUsername.Text;
            string newPassword = txtNewPassword.Text;

            try
            {
                // Attempt to register the user
                User newUser = userManager.RegisterUser(newUsername, newPassword);

                // If registration succeeds, show a success message
                MessageBox.Show($"User {newUser.Username} registered successfully.");
            }
            catch (Exception ex)
            {
                // If registration fails, show an error message
                MessageBox.Show(ex.Message);
            }
        }

    }
}
