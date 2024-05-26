namespace Personal_budget_management_tool.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtNewUsername;
        private TextBox txtNewPassword;
        private Button btnSubmit;
        private Button btnRegister;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblNewUsername;
        private Label lblNewPassword;

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
            btnSubmit = new Button();
            btnRegister = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtNewUsername = new TextBox();
            txtNewPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            lblNewUsername = new Label();
            lblNewPassword = new Label();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(219, 301);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(141, 40);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(411, 301);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(137, 40);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(219, 29);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(329, 31);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(219, 93);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(329, 31);
            txtPassword.TabIndex = 1;
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(219, 156);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(329, 31);
            txtNewUsername.TabIndex = 2;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(219, 232);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(329, 31);
            txtNewPassword.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(49, 29);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(49, 101);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // lblNewUsername
            // 
            lblNewUsername.AutoSize = true;
            lblNewUsername.Location = new Point(49, 162);
            lblNewUsername.Name = "lblNewUsername";
            lblNewUsername.Size = new Size(131, 25);
            lblNewUsername.TabIndex = 8;
            lblNewUsername.Text = "New Username";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(49, 238);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(127, 25);
            lblNewPassword.TabIndex = 9;
            lblNewPassword.Text = "New Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtNewUsername);
            Controls.Add(txtNewPassword);
            Controls.Add(btnSubmit);
            Controls.Add(btnRegister);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblNewUsername);
            Controls.Add(lblNewPassword);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}