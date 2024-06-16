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

        /// <summary>
        /// Event handler for the Save button click event.
        /// Saves the reminder text and date, validates them, creates a new reminder object, adds it to the reminders list, and updates the UI.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
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

        /// <summary>
        /// Overrides the base class method to handle the form closing event.
        /// </summary>
        /// <param name="e">A <see cref="FormClosingEventArgs"/> that contains the event data.</param>
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

        /// <summary>
        /// Overrides the base class's OnLoad method and performs additional logic to load reminders.
        /// </summary>
        /// <param name="e">An <see cref="EventArgs"/> object that contains the event data.</param>
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