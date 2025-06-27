using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.UserLogin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            
            InitializeComponent();
            

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            clsUserLogin userLogin = new clsUserLogin();
            string strEmail = txtbxLoginEmail.Text.Trim();
            string strPassword = txtbxLoginpassword.Text;

            if (userLogin.loginValid(strEmail, strPassword))
            {
                MessageBox.Show("✅ Login Successful");
                this.Hide();
                new Library().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("❌ Invalid login Details. Please Signup or try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
