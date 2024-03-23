using Repository.Entities;
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

namespace BookManagement_VuThanhDat
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
            UserAccount acc =  service.CheckLogin(txtEmail.Text.ToString(), txtPassword.Text.ToString());
            if(acc != null)
            {
                if(acc.Role == 1)
                {
                    BookManager form = new();
                    this.Hide();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You don't have permission to access", "Wrong role", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
