using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class BooksInsertDetails : Form
    {
        public BooksInsertDetails()
        {
            InitializeComponent();
        }

        private void btnInsertBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
