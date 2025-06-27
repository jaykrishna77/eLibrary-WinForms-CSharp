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

namespace Library.Publisher
{
    public partial class PublisherDetails : Form
    {
        public PublisherDetails()
        {
            InitializeComponent();
        }

        private void PublisherDetails_Load(object sender, EventArgs e)
        {
            clsUserLogin userLogin = new clsUserLogin();
            DataTable books = userLogin.GetAllPublishers();

            dataGridView1.DataSource = books;

            // Auto-size and disable user editing
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Set font
            dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            // Header styling
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false; // allow custom header style

            // Alternating row colors
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128); // light blue-gray

            // Row styling
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            // Selection colors
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 149, 237); // cornflower blue
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            // Borders
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.GridColor = Color.LightGray;
        }
    }
}
