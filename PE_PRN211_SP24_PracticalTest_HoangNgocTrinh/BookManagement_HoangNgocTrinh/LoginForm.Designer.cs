namespace BookManagement_HoangNgocTrinh
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
            btnQuit = new Button();
            btnLogin = new Button();
            lblEmail = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            grbLoginInfo = new GroupBox();
            grbLoginInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnQuit
            // 
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnQuit.ForeColor = Color.Yellow;
            btnQuit.Location = new Point(602, 237);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(188, 51);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SeaGreen;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnLogin.ForeColor = Color.Yellow;
            btnLogin.Location = new Point(160, 237);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(188, 51);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblEmail.ForeColor = Color.Yellow;
            lblEmail.Location = new Point(35, 60);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(73, 31);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblPassword.ForeColor = Color.Yellow;
            lblPassword.Location = new Point(35, 119);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 31);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(293, 57);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(696, 38);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(293, 116);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(696, 38);
            txtPassword.TabIndex = 1;
            // 
            // grbLoginInfo
            // 
            grbLoginInfo.BackColor = Color.LimeGreen;
            grbLoginInfo.Controls.Add(btnLogin);
            grbLoginInfo.Controls.Add(btnQuit);
            grbLoginInfo.Controls.Add(txtPassword);
            grbLoginInfo.Controls.Add(txtEmail);
            grbLoginInfo.Controls.Add(lblPassword);
            grbLoginInfo.Controls.Add(lblEmail);
            grbLoginInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            grbLoginInfo.ForeColor = Color.Yellow;
            grbLoginInfo.Location = new Point(49, 114);
            grbLoginInfo.Name = "grbLoginInfo";
            grbLoginInfo.Size = new Size(1022, 366);
            grbLoginInfo.TabIndex = 5;
            grbLoginInfo.TabStop = false;
            grbLoginInfo.Text = "Login Info ";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1137, 507);
            Controls.Add(grbLoginInfo);
            Name = "LoginForm";
            Text = "LoginForm";
            grbLoginInfo.ResumeLayout(false);
            grbLoginInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnQuit;
        private Button btnLogin;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private GroupBox grbLoginInfo;
    }
}