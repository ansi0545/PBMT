

using System.Diagnostics;
using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{
    public partial class ReportsForm : Form
    {
        private BudgetManager budgetApp;
        private User currentUser;
        private double savings;
        private string filePath;

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

            WriteReportToFile(filePath);
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
                    break;
            }
        }
        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            // Code to create a new report
        }

        private void OpenDataFileMenuItem_Click(object sender, EventArgs e)
        {
            // Open an OpenFileDialog to choose the file to open
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file
                Process.Start("notepad.exe", openFileDialog.FileName);
            }
        }

        private void SaveDataFileMenuItem_Click(object sender, EventArgs e)
        {
            // Open a SaveFileDialog to choose the location to save the file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save the data to the selected file
                WriteReportToFile(saveFileDialog.FileName);
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            // Code to exit the application
            Application.Exit();
        }

        private void WriteReportToFile(string filePath)
        {
            try
            {
                var report = new Report(currentUser.Incomes, currentUser.Expenses, savings, currentUser.SavingsGoal.GoalAmount);
                using (StreamWriter writer = new StreamWriter("report.txt", false))
                {
                    writer.WriteLine("Income Total: " + report.IncomeTotal);
                    writer.WriteLine("Expense Total: " + report.ExpenseTotal);
                    writer.WriteLine("Savings Total: " + report.SavingsTotal);
                    writer.WriteLine("Savings Difference: " + report.SavingsDifference);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while writing the report to a file: " + ex.Message);
            }
        }

    }
}
