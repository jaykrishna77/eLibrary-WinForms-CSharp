/*
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
    public partial class AuthorInsertDetails : Form
    {
        private string _authorStatus = string.Empty;
        public AuthorInsertDetails()
        {
            InitializeComponent();
            cmbAuthorStatus.SelectedIndexChanged += lstbxAuthorStatus_SelectedIndexChanged;

        }


        private void lstbxAuthorStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            strStatus = Select.Text;
            if (strStatus == "-- Select Author --")
            {
                // Possibly ignore or prompt user
                return;
            }

            // Process valid selection here
           // MessageBox.Show($"Selected Author Status: {strStatus}");
            
            if (SelectL.SelectedIndex <= 0)          // ignore placeholder
                return;

            _authorStatus = SelectL.SelectedItem.ToString();
            // DEBUG: confirm we really got it
            Console.WriteLine($"Stored: {_authorStatus}");


        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //clsUserLogin author = new clsUserLogin();
            //string strId = txtbxauthor_id.Text;
            //string strName = txtbxAuthorName.Text;

            //MessageBox.Show(strStatus);
            if (string.IsNullOrEmpty(_authorStatus))
            {
                MessageBox.Show("Please select a status first.");
                return;
            }

            MessageBox.Show($"Using in another method: {_authorStatus}");
           
            //author.InsertAuthorQuery(strName,Convert.ToInt32(strStatus));
            this.Close();
        }

        private void AuthorInsertDetails_Load(object sender, EventArgs e)
        {
            cmbAuthorStatus.Items.Clear();
            SelectL.Items.Add("-- Select Author --");
            SelectL.Items.Add("0");
            SelectL.Items.Add("1");
            //Select.SelectedIndex = 0;
            
        }
    }
}


*/





























using System;
using System.Windows.Forms;
using Library.UserLogin;

namespace Library
{
    public partial class AuthorInsertDetails : Form
    {
        private string _authorStatus = string.Empty;

        public AuthorInsertDetails()
        {
            InitializeComponent();

            // Hook up the event properly
            cmbAuthorStatus.SelectedIndexChanged += cmbAuthorStatus_SelectedIndexChanged;
        }

        private void AuthorInsertDetails_Load(object sender, EventArgs e)
        {
            // Populate the ComboBox once
            cmbAuthorStatus.Items.Clear();
            cmbAuthorStatus.Items.Add("-- Select Author --");
            cmbAuthorStatus.Items.Add("0");
            cmbAuthorStatus.Items.Add("1");

            cmbAuthorStatus.SelectedIndex = 0;
        }

        private void cmbAuthorStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ignore placeholder
            if (cmbAuthorStatus.SelectedIndex <= 0)
                return;

            _authorStatus = cmbAuthorStatus.SelectedItem.ToString();
            Console.WriteLine($"Stored: {_authorStatus}");
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_authorStatus))
            {
                MessageBox.Show("Please select a status first.");
                return;
            }

            

            // Uncomment and use as needed:
            clsUserLogin author = new clsUserLogin();
            //string strId = txtbxauthor_id.Text;
            string strName = txtbxAuthorName.Text;
            author.InsertAuthorQuery(strName, Convert.ToInt32(_authorStatus));
            MessageBox.Show("Author Added!...");

            this.Close();
        }
    }
}

