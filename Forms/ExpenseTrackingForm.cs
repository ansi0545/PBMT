using Personal_budget_management_tool.HelperMethods;
using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{
    public partial class ExpenseTrackingForm : Form
    {
        private BudgetManager budgetApp;
        private MainForm mainForm;
        public ExpenseTrackingForm(BudgetManager budgetApp, MainForm mainForm)
        {
            InitializeComponent();
            this.budgetApp = budgetApp;
            string summary = budgetApp.GetFinancialSummary();
            this.mainForm = mainForm;
            mainForm.UpdateFinancialSummary(summary);
        }

        /// <summary>
        /// Event handler for the Save button click event.
        /// Saves the expense details entered by the user and updates the financial summary.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string amountText = txtAmount.Text;
            string description = txtDescription.Text;

          
            if (!ErrorHandling.IsPositiveNumber(amountText, out double amount))
            {
                return;
            }
      
            if (!ErrorHandling.IsValidDescription(description))
            {
                return;
            }

            if (cmbCategory.SelectedItem == null)
            {
                ErrorHandling.ShowErrorMessage("Please select a category.");
                return;
            }
            
            Expense newExpense = new Expense
            {
                Date = dtpDate.Value,
                Amount = amount,
                Description = description,
                Category = (Category)cmbCategory.SelectedItem
            };
           
            budgetApp.AddExpense(newExpense);

            string summary = budgetApp.GetFinancialSummary();
            mainForm.UpdateFinancialSummary(summary);

            dtpDate.Value = DateTime.Now;
            txtAmount.Clear();
            txtDescription.Clear();
            cmbCategory.SelectedIndex = -1;
        }

        /// <summary>
        /// Event handler for the form's Load event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void ExpenseTrackingForm_Load(object sender, EventArgs e)
        {

            foreach (var category in Enum.GetValues(typeof(Category)))
            {
                cmbCategory.Items.Add(category);
            }
        }
    }
}