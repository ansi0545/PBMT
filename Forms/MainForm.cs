namespace Personal_budget_management_tool.Forms
{
    public partial class MainForm : Form
    {
        private User currentUser;
        private BudgetApp budgetApp; // Add this line

        public MainForm()
        {
            InitializeComponent();
            budgetApp = new BudgetApp(); // Initialize the budgetApp variable with a new BudgetApp instance
            UpdateFinancialSummary();
        }

        private void UpdateFinancialSummary()
        {
            lblFinancialSummary.Text = "Financial Summary: Here will be the user's current financial situation.";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            currentUser = new User(); // Initialize the currentUser variable with a new User instance
            LoginForm loginForm = new LoginForm(budgetApp); // Pass budgetApp instead of currentUser
            loginForm.Show();
        }

        private void btnIncomeRegistration_Click(object sender, EventArgs e)
        {
            IncomeRegistrationForm incomeRegistrationForm = new IncomeRegistrationForm();
            incomeRegistrationForm.Show();
        }

        private void btnExpenseTracking_Click(object sender, EventArgs e)
        {
            ExpenseTrackingForm expenseTrackingForm = new ExpenseTrackingForm();
            expenseTrackingForm.Show();
        }

        private void btnSavingsGoals_Click(object sender, EventArgs e)
        {
            SavingsGoalsForm savingsGoalsForm = new SavingsGoalsForm();
            savingsGoalsForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
        }

        private void btnReminders_Click(object sender, EventArgs e)
        {
            RemindersForm remindersForm = new RemindersForm();
            remindersForm.Show();
        }
    }
}