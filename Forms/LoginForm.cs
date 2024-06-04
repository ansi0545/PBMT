
namespace Personal_budget_management_tool.Forms
{
    public partial class LoginForm : Form
    {
        private User currentUser;
        private BudgetManager budgetManager;
        public LoginForm(BudgetManager manager)
        {
            InitializeComponent();
            budgetManager = manager;
            currentUser = budgetManager.GetCurrentUser();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string inputUsername = txtUsername.Text;
            string inputPassword = txtPassword.Text;

            try
            {
                //currentUser.Login(inputUsername, inputPassword);
                budgetManager.LoginUser(inputUsername, inputPassword);
                MessageBox.Show("Login successful!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string newUsername = txtNewUsername.Text;
            string newPassword = txtNewPassword.Text;

            if (currentUser == null)
            {
                currentUser = new User(newUsername, newPassword);
            }

            currentUser.Register(newUsername, newPassword);
            MessageBox.Show("Registration successful!");
        }
    }
}
