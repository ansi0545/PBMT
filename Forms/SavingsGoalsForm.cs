

namespace Personal_budget_management_tool.Forms
{

    public partial class SavingsGoalsForm : Form
    {
        private Label lblAmount;
        private TextBox txtAmount;
        private Label lblTimeframe;
        private TextBox txtTimeframe;
        private Button btnSave;
        private BudgetApp budgetApp;

        public SavingsGoalsForm(BudgetApp budgetApp)
        {
            InitializeComponent();
            this.budgetApp = budgetApp;

        }


        void btnSave_Click(object sender, EventArgs e)
        {
            double goalAmount = double.Parse(txtAmount.Text);
            DateTime desiredTimeframe = DateTime.Parse(txtTimeframe.Text);
            budgetApp.SetSavingsGoalForCurrentUser(goalAmount, desiredTimeframe);
            budgetApp.SaveUsers();
        }
    }
}