using Personal_budget_management_tool.HelperMethods;
using Personal_budget_management_tool.Managers;

namespace Personal_budget_management_tool.Forms
{
    public partial class RemindersForm : Form
    {
        private BudgetManager budgetApp;
        private DataManager dataManager;
        private User currentUser;
        private List<Reminders> reminders = new List<Reminders>();
        public RemindersForm(BudgetManager budgetApp, DataManager dataManager)
        {
            InitializeComponent();
            this.budgetApp = budgetApp;
            this.dataManager = dataManager;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string reminderText = txtReminder.Text;
            DateTime reminderDate = dtpDate.Value;

            try
            {
                ErrorHandling.IsValidDescription(reminderText);
                ErrorHandling.ValidateReminderDate(reminderDate);

                Reminders reminder = new Reminders(reminderText, reminderDate);
                reminders.Add(reminder);

                lstReminders.Items.Add(reminderText);

                txtReminder.Clear();
                dtpDate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            try
            {
                dataManager.SaveReminders(reminders);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the reminders: " + ex.Message);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                reminders = dataManager.LoadReminders();

                foreach (var reminder in reminders)
                {
                    lstReminders.Items.Add(reminder.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the reminders: " + ex.Message);
            }
        }
    }
}