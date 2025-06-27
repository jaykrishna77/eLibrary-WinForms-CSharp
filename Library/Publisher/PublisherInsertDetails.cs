using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.UserLogin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class PublisherInsertDetails : Form
    {
        public PublisherInsertDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsUserLogin publisher = new clsUserLogin();
            //string strId = txtbxauthor_id.Text;
            string strName = textBox2.Text;
            string strStatus = listBox1.Text;
            publisher.InsertPublisherQuery(strName, strStatus);
            this.Close();
        }
    }
}
