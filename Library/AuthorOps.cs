using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Author;

namespace Library
{
    public partial class AuthorOps : Form
    {
        public AuthorOps()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            AuthorInsertDetails authorForm = new AuthorInsertDetails();  
            authorForm.Show();  

        }
        private void Delete_Click(object sender, EventArgs e)
        {
            AuthorDeleteDetails authorForm = new AuthorDeleteDetails();  
            authorForm.Show();  

        }

        private void UpdateAuthor_Click(object sender, EventArgs e)
        {
            AuthorUpdateDetails authorForm = new AuthorUpdateDetails();
            authorForm.Show();
        }

        private void AuthorList_Click(object sender, EventArgs e)
        {
            AuthorDetails authorForm = new AuthorDetails();
            authorForm.Show();
        }
    }
}

