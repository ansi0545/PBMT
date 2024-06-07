using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{
    public partial class ExpenseTrackingForm : Form
    {
        private BudgetManager budgetApp;
        private MainForm mainForm;
        public ExpenseTrackingForm(BudgetManager budgetApp)
        {
            InitializeComponent();
            this.budgetApp = budgetApp;
        }

        public ExpenseTrackingForm(BudgetManager budgetManager, MainForm mainForm) : this(budgetManager)
        {
            this.mainForm = mainForm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create a new Expense object
            Expense newExpense = new Expense
            {
                Date = dtpDate.Value,
                Amount = double.Parse(txtAmount.Text),
                Description = txtDescription.Text,
                Category = (Category)cmbCategory.SelectedItem
            };

            // Add the new expense to the BudgetManager
            budgetApp.AddExpense(newExpense);


            // Update the financial summary in MainForm
            string summary = budgetApp.GetFinancialSummary(); // Replace this with your actual method to get the summary
            mainForm.UpdateFinancialSummary(summary);


            // Clear the form
            dtpDate.Value = DateTime.Now;
            txtAmount.Clear();
            txtDescription.Clear();
            cmbCategory.SelectedIndex = -1;
        }

        private void ExpenseTrackingForm_Load(object sender, EventArgs e)
        {
            // Load categories into the ComboBox
            foreach (var category in Enum.GetValues(typeof(Category)))
            {
                cmbCategory.Items.Add(category);
            }
        }
    }
}