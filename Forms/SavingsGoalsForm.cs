

using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{

    public partial class SavingsGoalsForm : Form
    {
        private UserManager userManager;
        
        private BudgetManager budgetManager;

        public SavingsGoalsForm(BudgetManager budgetManager, DataManager dataManager)
        {
            InitializeComponent();
            this.budgetManager = budgetManager;
            this.userManager = new UserManager(dataManager);

        }


        void btnSave_Click(object sender, EventArgs e)
        {
            double goalAmount = double.Parse(txtAmount.Text);
            DateTime desiredTimeframe = DateTime.Parse(txtTimeframe.Text);
            budgetManager.SetSavingsGoalForCurrentUser(goalAmount, desiredTimeframe);
            userManager.SaveUsers();
        }
    }
}