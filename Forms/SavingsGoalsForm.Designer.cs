namespace Personal_budget_management_tool.Forms
{
    partial class SavingsGoalsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblAmount;
        private TextBox txtAmount;
        private Label lblTimeframe;
        private TextBox txtTimeframe;
        private Button btnSave;

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
            lblAmount = new Label();
            txtAmount = new TextBox();
            lblTimeframe = new Label();
            txtTimeframe = new TextBox();
            btnSave = new Button();
            textBox1 = new TextBox();
            lblGoal = new Label();
            SuspendLayout();
            // 
            // lblAmount
            // 
            lblAmount.Location = new Point(12, 9);
            lblAmount.Margin = new Padding(4, 0, 4, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(120, 20);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(12, 32);
            txtAmount.Margin = new Padding(4, 3, 4, 3);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(239, 30);
            txtAmount.TabIndex = 1;
            // 
            // lblTimeframe
            // 
            lblTimeframe.Location = new Point(12, 79);
            lblTimeframe.Margin = new Padding(4, 0, 4, 0);
            lblTimeframe.Name = "lblTimeframe";
            lblTimeframe.Size = new Size(120, 20);
            lblTimeframe.TabIndex = 2;
            lblTimeframe.Text = "Timeframe:";
            // 
            // txtTimeframe
            // 
            txtTimeframe.Location = new Point(12, 102);
            txtTimeframe.Margin = new Padding(4, 3, 4, 3);
            txtTimeframe.Name = "txtTimeframe";
            txtTimeframe.Size = new Size(239, 30);
            txtTimeframe.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 309);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(240, 35);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 176);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 30);
            textBox1.TabIndex = 5;
            // 
            // lblGoal
            // 
            lblGoal.Location = new Point(13, 153);
            lblGoal.Margin = new Padding(4, 0, 4, 0);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(120, 20);
            lblGoal.TabIndex = 6;
            lblGoal.Text = "Goal:";
            // 
            // SavingsGoalsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 396);
            Controls.Add(lblGoal);
            Controls.Add(textBox1);
            Controls.Add(lblAmount);
            Controls.Add(txtAmount);
            Controls.Add(lblTimeframe);
            Controls.Add(txtTimeframe);
            Controls.Add(btnSave);
            Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SavingsGoalsForm";
            Text = "Savings Goals";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBox1;
        private Label lblGoal;
    }

        #endregion
    }