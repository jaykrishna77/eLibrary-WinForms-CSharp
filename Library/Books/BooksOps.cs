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
    public partial class BooksOps : Form
    {
        public BooksOps()
        {
            InitializeComponent();
        }

        private void btnInsertBooks_Click(object sender, EventArgs e)
        {
            BooksInsertDetails Books = new BooksInsertDetails();
            Books.ShowDialog();
        }

        private void btnDeleteBooks_Click(object sender, EventArgs e)
        {
            BooksDeleteDetails Books = new BooksDeleteDetails();
            Books.ShowDialog();
        }
    }
}
