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
    public partial class BookingOps : Form
    {
        public BookingOps()
        {
            InitializeComponent();
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            BookingDeleteDetails delBooking = new BookingDeleteDetails();
            delBooking.Show();
        }

        private void btnInsertBooking_Click(object sender, EventArgs e)
        {
            BookingInsertDetails InsertBooking = new BookingInsertDetails();
            InsertBooking.Show();
        }
    }
}
