using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.UserLogin;

namespace Library.UserLogin
{
    public partial class UserSignInForm : Form
    {
        public UserSignInForm()
        {
            InitializeComponent();
            
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
 
            clsUserLogin objuser = new clsUserLogin();
            string strEmail = txtbxSignInEmail.Text;
            string strPassword = txtbxSignInPassword.Text;
            if (strEmail.Length<10 || strPassword.Length<3)
            {

                MessageBox.Show("Enter in Correct Format");
            }
            else {

                if (txtbxSignInPassword.Text != txtbxConformPassword.Text)
                {

                    MessageBox.Show("❌ Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {


                    objuser.InsertLoginQuery(strEmail, strPassword);
                    MessageBox.Show("Signed-In Successfully....");

                    this.Hide();
                    LoginForm loginfrm = new LoginForm();
                    loginfrm.ShowDialog();
                    this.Close();

                }
            }
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            this.Hide(); 
            LoginForm loginfrm = new LoginForm();
            loginfrm.ShowDialog();
            this.Close(); 


        }
    }
}
