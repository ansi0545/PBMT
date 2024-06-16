using Personal_budget_management_tool.HelperMethods;
using Personal_budget_management_tool.Managers;

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
            dataManager = new DataManager { FilePath = Application.StartupPath + "\\Budget.txt" }; 
            userManager = new UserManager(dataManager);
            budgetManager = manager;
            currentUser = budgetManager.GetCurrentUser();
        }

        /// <summary>
        /// Event handler for the Register button click event.
        /// Registers a new user with the provided username and password.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string newUsername = txtNewUsername.Text;
                string newPassword = txtNewPassword.Text;


                ErrorHandling.IsValidDescription(newUsername);
                ErrorHandling.IsValidDescription(newPassword);

                if (!dataManager.FileExists(dataManager.FilePath))
                {
                    dataManager.SaveData(new List<User>());
                }

                User newUser = userManager.RegisterUser(newUsername, newPassword);

                MessageBox.Show($"User {newUser.Username} registered successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
