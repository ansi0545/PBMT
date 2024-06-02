namespace Personal_budget_management_tool.Forms
{
    public partial class ExpenseTrackingForm : Form
    {
        private BudgetApp budgetApp;
        public ExpenseTrackingForm(BudgetApp budgetApp)
        {
            InitializeComponent();
            this.budgetApp = budgetApp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Add your save logic here
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
