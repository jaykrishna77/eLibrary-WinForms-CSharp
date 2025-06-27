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
    public partial class UserOps : Form
    {
        public UserOps()
        {
            InitializeComponent();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            UserDeleteDetails user = new UserDeleteDetails();
            user.ShowDialog();
            
        }

        private void btnInsertUser_Click(object sender, EventArgs e)
        {
            UserInsertDetails userInsertDetails = new UserInsertDetails();
            userInsertDetails.ShowDialog();

        }
    }
}
