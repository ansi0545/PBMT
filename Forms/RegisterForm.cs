using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_budget_management_tool.Forms
{
    public partial class RegisterForm : Form
    {
        private User currentUser;
        private BudgetManager budgetManager;
        public RegisterForm(BudgetManager manager)
        {
            InitializeComponent();
            budgetManager = manager;
            currentUser = budgetManager.GetCurrentUser();
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
