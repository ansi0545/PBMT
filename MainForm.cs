namespace Personal_budget_management_tool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateFinancialSummary();
        }
        private void UpdateFinancialSummary()
        {
            lblFinancialSummary.Text = "Financial Summary: Here will be the user's current financial situation.";
        }

        private void btnExpenseTracking_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Expense Tracking button clicked");
        }

        private void btnSavingsGoals_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Savings Goals button clicked");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports button clicked");
        }

        private void btnReminders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reminders button clicked");
        }

        private void btnIncomeRegistration_Click(object sender, EventArgs e)
        {
            IncomeRegistrationForm incomeRegistrationForm = new IncomeRegistrationForm();
            incomeRegistrationForm.Show();
        }
    }
}
