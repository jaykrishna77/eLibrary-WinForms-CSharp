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

namespace Library.Publisher
{
    public partial class PublisherUpdateDetails : Form
    {
        public PublisherUpdateDetails()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clsUserLogin publisher = new clsUserLogin();
            int iId = Convert.ToInt32(txtbxauthor_id.Text);
            string strName = txtbxAuthorName.Text;
            string strStatus = lstbxAuthorStatus.Text;
            publisher.UpdatePublisherQuery(iId, strName, strStatus);
            this.Close();
        }
    }
}
