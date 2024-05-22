namespace Personal_budget_management_tool.Forms
{
    partial class ExpenseTrackingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbCategory;


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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "ExpenseTrackingForm";

            dtpDate = new System.Windows.Forms.DateTimePicker();
            txtAmount = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            cmbCategory = new System.Windows.Forms.ComboBox();
            //
            // dtpDate
            //
            dtpDate.Location = new System.Drawing.Point(10, 12);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new System.Drawing.Size(361, 31);
            dtpDate.TabIndex = 0;
            //
            // txtAmount
            //
            txtAmount.Location = new System.Drawing.Point(10, 49);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new System.Drawing.Size(361, 31);
            txtAmount.TabIndex = 1;

            // txtDescription
            txtDescription.Location = new System.Drawing.Point(10, 86);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(361, 31);
            txtDescription.TabIndex = 2;
            //
            // cmbCategory
            //
            cmbCategory.Location = new System.Drawing.Point(10, 123);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(361, 31);
            cmbCategory.TabIndex = 3;
            //
            // btnSave
            //
            btnSave.Location = new System.Drawing.Point(10, 160);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(361, 50);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            //
            // ExpenseTrackingForm
            //
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dtpDate);
            Controls.Add(txtAmount);
            Controls.Add(txtDescription);
            Controls.Add(cmbCategory);
            Controls.Add(btnSave);
            Name = "ExpenseTrackingForm";
            Text = "ExpenseTrackingForm";
            Load += ExpenseTrackingForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
    }
}