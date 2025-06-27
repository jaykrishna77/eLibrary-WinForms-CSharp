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

namespace Library
{
    public partial class AuthorDeleteDetails : Form
    {
        public AuthorDeleteDetails()
        {
            InitializeComponent();
        }

        private void lstbxDeleteDetails_Click(object sender, EventArgs e)
        {
            lstbxDeleteDetails.Items.Add("1");
            lstbxDeleteDetails.Items.Add("2");
            lstbxDeleteDetails.Items.Add("3");
            lstbxDeleteDetails.Items.Add("4");
            lstbxDeleteDetails.Items.Add("5");
            lstbxDeleteDetails.Items.Add("6");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsUserLogin author = new clsUserLogin();
            //string strId = txtbxauthor_id.Text;
            int iId = Convert.ToInt32(lstbxDeleteDetails.Text);
            author.DeleteAuthorQuery(iId);
            this.Close();
        }
    }
}
