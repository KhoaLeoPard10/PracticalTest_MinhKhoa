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

namespace BookManagerment_MinhKhoa
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you really want to cancel?", "Cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //chửi khi không nhập gì cả mà nhấn login
            //validation
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPasword.Text))
            {
                MessageBox.Show("Please input both email & password", "Input plz.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserAccountService service = new UserAccountService();
            UserAccount? acc = service.CheckLogin(txtEmail.Text, txtPasword.Text);

            if (acc == null)
            {
                MessageBox.Show("Login failed. Check the email and password again!", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //acc okie rồi, khác null
            if (acc.Role != 1)
            {
                MessageBox.Show("You have no permission to access this function!", "Wrong privilege", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //ngon với đúng rồi
            //mở form main 
            BookManagerMainUI f = new BookManagerMainUI();
            f.Show();
            this.Hide();
        }
    }
}
