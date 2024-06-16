

using System.Diagnostics;
using System.Text.Json;
using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{
    public partial class ReportsForm : Form
    {
        private BudgetManager budgetApp;
        private User currentUser;
        private double savings;
        private DataManager dataManager;
        string fileName = Application.StartupPath + "\\Reports.txt";

        public ReportsForm(BudgetManager budgetApp, User currentUser)
        {
            InitializeComponent();
            this.Text = "Personal Budget Management Tool by User";
            dataManager = new DataManager();
            this.budgetApp = budgetApp;
            this.currentUser = currentUser;
        }

        private void toolStripOpenDatafile_Click(object sender, EventArgs e)
        {
            try
            {
                dataManager.FilePath = fileName;
                currentUser = dataManager.Users.FirstOrDefault(); // Assuming you want to load the first user
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open file: {ex.Message}");
            }
        }

        private void toolStripSaveDataFile_Click(object sender, EventArgs e)
        {
            try
            {
                dataManager.FilePath = fileName;
                dataManager.Users = new List<User> { currentUser };
                GenerateReport();
                MessageBox.Show("Report saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save file: {ex.Message}");
            }
        }


        private void toolStripExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
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
            savings = totalIncome - totalExpenses;

            var report = new Report(currentUser.Incomes, currentUser.Expenses, savings, currentUser.SavingsGoal.GoalAmount);
            dgvReport.DataSource = new List<Report> { report };

            WriteReportToFile(fileName);
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
            //openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
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
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    writer.WriteLine("PersonalBudgetManagementTool"); // Write the token
                    var jsonReport = JsonSerializer.Serialize(report); // Serialize the report to JSON
                    writer.WriteLine(jsonReport); // Write the JSON report
                    
                    // Write Savings and SavingsTotal                        
                    writer.WriteLine($"Savings: {report.Savings}");
                    writer.WriteLine($"SavingsTotal: {report.SavingsTotal}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while writing the report to a file: " + ex.Message);
            }
        }

    }
}
