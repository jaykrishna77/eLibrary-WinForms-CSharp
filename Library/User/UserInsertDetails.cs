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
    public partial class UserInsertDetails : Form
    {
        public UserInsertDetails()
        {
            InitializeComponent();
        }

        private void btnInsertUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
