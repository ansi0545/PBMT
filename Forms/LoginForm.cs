
using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{
    public partial class LoginForm : Form
    {
        private UserManager userManager;
        private User currentUser;
        private BudgetManager budgetManager;

        public LoginForm(BudgetManager manager, DataManager dataManager)
        {
            InitializeComponent();
            budgetManager = manager;
            currentUser = budgetManager.GetCurrentUser();
            userManager = new UserManager(dataManager); // Initialize userManager
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string inputUsername = txtUsername.Text;
            string inputPassword = txtPassword.Text;

            User user = userManager.LoginUser(inputUsername, inputPassword);
            if (user != null)
            {
                MessageBox.Show("Login successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(budgetManager);
            registerForm.Show();
        }
    }
}
