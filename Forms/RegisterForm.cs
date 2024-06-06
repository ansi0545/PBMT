
using Personal_budget_management_tool.Managers;
using Personal_budget_management_tool.HelperMethods;

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
            dataManager = new DataManager(); // Create a new DataManager instance
            userManager = new UserManager(dataManager); // Initialize userManager with DataManager instance
            budgetManager = manager;
            currentUser = budgetManager.GetCurrentUser();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string newUsername = txtNewUsername.Text;
            string newPassword = txtNewPassword.Text;

             User user = userManager.RegisterUser(newUsername, newPassword);
            if (user != null && userManager.ValidateUser(newUsername, newPassword))
            {
                MessageBox.Show("Registration successful!");
            }
            else
            {
                MessageBox.Show("Registration failed.");
            }
        }

    }
}
