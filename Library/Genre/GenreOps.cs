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
    public partial class GenreOps : Form
    {
        public GenreOps()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            GenreInsertDetails Genre = new GenreInsertDetails();
            Genre.ShowDialog();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            GenreDeleteDetails Genre = new GenreDeleteDetails();
            Genre.ShowDialog();
        }
    }
}
