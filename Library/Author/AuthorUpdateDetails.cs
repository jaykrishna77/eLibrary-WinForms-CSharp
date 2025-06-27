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

namespace Library.Author
{
    public partial class AuthorUpdateDetails : Form
    {
        public AuthorUpdateDetails()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            clsUserLogin author = new clsUserLogin();
            int iId = Convert.ToInt32(txtbxauthor_id.Text);
            string strName = txtbxAuthorName.Text;
            string strStatus = lstbxAuthorStatus.Text;
            author.UpdateAuthorQuery(iId,strName, strStatus);
            this.Close();
        }
    }
}
