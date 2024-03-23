namespace BookManagement_VuThanhDat
{
    partial class LoginForm
    {
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
            btnExit = new Button();
            btnLogin = new Button();
            grpLogin = new GroupBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblBookDescription = new Label();
            lblBookName = new Label();
            grpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Yellow;
            btnExit.Location = new Point(417, 202);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(199, 55);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 0, 0);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.Yellow;
            btnLogin.Location = new Point(97, 198);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(199, 55);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // grpLogin
            // 
            grpLogin.Controls.Add(btnExit);
            grpLogin.Controls.Add(txtPassword);
            grpLogin.Controls.Add(btnLogin);
            grpLogin.Controls.Add(txtEmail);
            grpLogin.Controls.Add(lblBookDescription);
            grpLogin.Controls.Add(lblBookName);
            grpLogin.Font = new Font("Segoe UI", 13.8F);
            grpLogin.ForeColor = Color.FromArgb(255, 255, 128);
            grpLogin.Location = new Point(113, 122);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(997, 275);
            grpLogin.TabIndex = 8;
            grpLogin.TabStop = false;
            grpLogin.Text = " Login Criteria ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(260, 121);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(396, 38);
            txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(260, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(396, 38);
            txtEmail.TabIndex = 2;
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.BackColor = Color.FromArgb(192, 0, 0);
            lblBookDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblBookDescription.ForeColor = Color.Yellow;
            lblBookDescription.Location = new Point(56, 121);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(114, 31);
            lblBookDescription.TabIndex = 3;
            lblBookDescription.Text = "Password";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.BackColor = Color.FromArgb(192, 0, 0);
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(56, 67);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(73, 31);
            lblBookName.TabIndex = 1;
            lblBookName.Text = "Email";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1326, 538);
            Controls.Add(grpLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnLogin;
        private GroupBox grpLogin;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblBookDescription;
        private Label lblBookName;
    }
}