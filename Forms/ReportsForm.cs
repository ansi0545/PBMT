
using System.Text.Json;
using Personal_budget_management_tool.HelperMethods;
using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{
    public partial class ReportsForm : Form
    {
        private BudgetManager budgetApp;
        private User currentUser;
        private double savings;
        private DataManager dataManager;
        private const string Token = "PersonalBudgetManagementTool";
        string fileName = Application.StartupPath + "\\Reports.txt";

        public ReportsForm(BudgetManager budgetApp, User currentUser)
        {
            InitializeComponent();
            this.Text = "Personal Budget Management Tool by User";
            dataManager = new DataManager();
            this.budgetApp = budgetApp;
            this.currentUser = currentUser;
        }

        public User CurrentUser
        {
            get { return currentUser; }
            set
            {
                ErrorHandling.ValidateUser(value);
                currentUser = value;
            }
        }

        private void toolStripOpenDatafile_Click(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + "\\Reports.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("The file does not exist.");
                return;
            }

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    reader.ReadLine();
                    var fileUserId = reader.ReadLine();
                    if (fileUserId != currentUser.Username)
                    {
                        MessageBox.Show("You are not allowed to open this file.");
                        return;
                    }
                    var jsonReport = reader.ReadLine();
                    var report = JsonSerializer.Deserialize<Report>(jsonReport);
                    dgvReport.DataSource = new List<Report> { report };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the report from a file: " + ex.Message);
            }
        }

        private void toolStripSaveDataFile_Click(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + "\\Reports.txt";
            WriteReportToFile(filePath, true);
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
        
        private void OpenDataFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        reader.ReadLine();
                        var fileUserId = reader.ReadLine();
                        if (fileUserId != currentUser.Username)
                        {
                            MessageBox.Show("You are not allowed to open this file.");
                            return;
                        }
                        var jsonReport = reader.ReadLine();
                        var report = JsonSerializer.Deserialize<Report>(jsonReport);
                        dgvReport.DataSource = new List<Report> { report };
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading the report from a file: " + ex.Message);
                }
            }
        }

        private void SaveDataFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                WriteReportToFile(saveFileDialog.FileName, true);
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WriteReportToFile(string filePath, bool append = false)
        {
            try
            {
                var report = new Report(currentUser.Incomes, currentUser.Expenses, savings, currentUser.SavingsGoal.GoalAmount);
                using (StreamWriter writer = new StreamWriter(filePath, append))
                {
                    writer.WriteLine(Token);
                    writer.WriteLine(currentUser.Username);
                    var jsonReport = JsonSerializer.Serialize(report);
                    writer.WriteLine(jsonReport);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while writing the report to a file: " + ex.Message);
            }
        }

    }
}
