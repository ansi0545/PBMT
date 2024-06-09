

using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{

    public partial class SavingsGoalsForm : Form
    {
        private UserManager userManager;
        private MainForm mainForm;

        private BudgetManager budgetManager;

        public SavingsGoalsForm(BudgetManager budgetManager, DataManager dataManager, MainForm mainForm)
        {
            InitializeComponent();
            this.budgetManager = budgetManager;
            userManager = new UserManager(dataManager);
            this.mainForm = mainForm;
        }


        void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTimeframe.Text, out int days))
            {
                MessageBox.Show("Please enter a valid number of days.");
                return;
            }

            double goalAmount = double.Parse(txtAmount.Text);
            days = int.Parse(txtTimeframe.Text);
            DateTime desiredTimeframe = DateTime.Today.AddDays(days);
            budgetManager.SetSavingsGoalForCurrentUser(goalAmount, desiredTimeframe);
            userManager.SaveUsers();
            UpdateFinancialSummary();
            mainForm.UpdateFinancialSummary(budgetManager.GetFinancialSummary());
        }

        public void UpdateFinancialSummary()
        {
            SavingsGoal savingsGoal = budgetManager.GetSavingsGoalForCurrentUser();
            double balance = budgetManager.GetBalanceForCurrentUser();
            double difference = balance - savingsGoal.GoalAmount;

            Console.WriteLine($"Savings Goal: {savingsGoal.GoalAmount}, Balance: {balance}, Difference: {difference}");

            lblFinancialSummary.Text = $"Savings Goal: {savingsGoal.GoalAmount}, Balance: {balance}, Difference: {difference}";

        }
    }
}