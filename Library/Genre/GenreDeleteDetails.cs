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
    public partial class GenreDeleteDetails : Form
    {
        public GenreDeleteDetails()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
