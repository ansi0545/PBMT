
namespace Personal_budget_management_tool.Forms
{
    public partial class LoginForm : Form
    {
        private User currentUser;
        public LoginForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string inputUsername = txtUsername.Text;
            string inputPassword = txtPassword.Text;

            try
            {
                currentUser.Login(inputUsername, inputPassword);
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

            currentUser.Register(newUsername, newPassword);
            MessageBox.Show("Registration successful!");
        }
    }
}
