

using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{
    public partial class ReportsForm : Form
    {
        private BudgetManager budgetApp;
        private User currentUser;
        public ReportsForm(BudgetManager budgetApp, User currentUser)
        {
            InitializeComponent();
            this.budgetApp = budgetApp;
            this.currentUser = currentUser;
            GenerateReport();
        }

        private void GenerateReport()
        {
            if (currentUser.SavingsGoal == null)
            {
                MessageBox.Show("The current user does not have a savings goal set.");
                return;
            }

            double totalIncome = currentUser.Incomes.Sum(i => i.Amount);
            double totalExpenses = currentUser.Expenses.Sum(e => e.Amount);
            double savings = totalIncome - totalExpenses;

            var report = new Report(currentUser.Incomes, currentUser.Expenses, savings, currentUser.SavingsGoal.GoalAmount);
            dgvReport.DataSource = new List<Report> { report };
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFilter = cmbFilter.SelectedItem.ToString();

            switch (selectedFilter)
            {
                case "Incomes":
                    dgvReport.DataSource = currentUser.Incomes;
                    break;
                case "Expenses":
                    dgvReport.DataSource = currentUser.Expenses;
                    break;
                case "SavingsGoal":
                    GenerateReport();
                   // dgvReport.DataSource = new List<SavingsGoal> { currentUser.SavingsGoal };
                    break;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Implement the logic for sorting the data in the DataGridView here
        }
    }
}
