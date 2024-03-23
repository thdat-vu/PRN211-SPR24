using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_HoangNgocTrinh
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserAccountService service = new UserAccountService();
            UserAccount acc = service.CheckLogin(txtEmail.Text, txtPassword.Text);
            if (acc != null)
            {
                if (acc.Role == 1)
                {
                    BookManagerMainUI mainForm = new BookManagerMainUI();
                    mainForm.Show();
                    this.Hide(); //Ẩn nó thôi. vì nó là form khởi đầu của app. Nếu chỗ này mà close là app chết lun
                }
                else
                {
                    MessageBox.Show("You are not sufficient of role to...");
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
