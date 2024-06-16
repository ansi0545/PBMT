namespace Personal_budget_management_tool.Forms
{
    partial class RemindersForm
    {
        private Label lblReminder;
        private TextBox txtReminder;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Button btnSave;
        private ListBox lstReminders;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblReminder = new Label();
            lstReminders = new ListBox();
            txtReminder = new TextBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblReminder
            // 
            lblReminder.Location = new Point(10, 10);
            lblReminder.Name = "lblReminder";
            lblReminder.Size = new Size(100, 23);
            lblReminder.TabIndex = 0;
            lblReminder.Text = "Reminder:";
            //
            // lstReminders
            //
            lstReminders.Location = new Point(10, 200);
            lstReminders.Name = "lstReminders";
            lstReminders.Size = new Size(243, 200);
            lstReminders.TabIndex = 5;
            // 
            // txtReminder
            // 
            txtReminder.Location = new Point(10, 36);
            txtReminder.Name = "txtReminder";
            txtReminder.Size = new Size(243, 31);
            txtReminder.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(10, 70);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 23);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(10, 100);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(243, 31);
            dtpDate.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(10, 151);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(243, 35);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // RemindersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblReminder);
            Controls.Add(lstReminders);
            Controls.Add(txtReminder);
            Controls.Add(lblDate);
            Controls.Add(dtpDate);
            Controls.Add(btnSave);
            Name = "RemindersForm";
            Text = "Reminders";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}