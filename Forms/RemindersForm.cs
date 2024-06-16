﻿using Personal_budget_management_tool.Managers;

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
            this.currentUser = currentUser;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string reminderText = txtReminder.Text;
            DateTime reminderDate = dtpDate.Value;

            if (string.IsNullOrEmpty(reminderText))
            {
                MessageBox.Show("Please enter a reminder.");
                return;
            }

            Reminders reminder = new Reminders(reminderText, reminderDate);
            reminders.Add(reminder);

            // Add the reminder to the ListBox
            lstReminders.Items.Add(reminderText);

            // Clear the text box and reset the date picker for the next reminder
            txtReminder.Clear();
            dtpDate.Value = DateTime.Now;
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

                // Load the reminders into the ListBox
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