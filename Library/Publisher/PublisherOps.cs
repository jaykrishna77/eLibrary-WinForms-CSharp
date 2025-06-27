using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Publisher;

namespace Library
{
    public partial class PublisherOps : Form
    {
        public PublisherOps()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            PublisherInsertDetails publisher = new PublisherInsertDetails();
            publisher.ShowDialog(this);

        }

        private void DeletePublisher_Click(object sender, EventArgs e)
        {
            PublisherDeleteDetails publisher = new PublisherDeleteDetails();
            publisher.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PublisherUpdateDetails publisher = new PublisherUpdateDetails();
            publisher.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PublisherDetails publisher = new PublisherDetails();
            publisher.Show();

        }
    }
}
