

namespace Personal_budget_management_tool.Forms
{

    public partial class SavingsGoalsForm : Form
    {
        private Label lblAmount;
        private TextBox txtAmount;
        private Label lblTimeframe;
        private TextBox txtTimeframe;
        private Button btnSave;

        public SavingsGoalsForm()
        {
            InitializeComponent();

        }




        void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Click += btnSave_Click;
        }
    }
}