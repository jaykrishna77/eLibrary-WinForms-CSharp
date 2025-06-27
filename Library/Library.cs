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
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void Author_Click(object sender, EventArgs e)
        {
            AuthorOps authorForm = new AuthorOps();  // Create an instance
            authorForm.ShowDialog();  // Show the form non-modally

        }

        private void Publisher_Click(object sender, EventArgs e)
        {
            PublisherOps publisher = new PublisherOps();
            publisher.ShowDialog();
        }

        private void Genre_Click(object sender, EventArgs e)
        {
            GenreOps genre = new GenreOps();
            genre.ShowDialog();
        }

        private void Books_Click(object sender, EventArgs e)
        {
            BooksOps books = new BooksOps();
            books.ShowDialog();
        }

        private void User_Click(object sender, EventArgs e)
        {
            UserOps user = new UserOps();
            user.ShowDialog();
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            BookingOps booking = new BookingOps();
            booking.ShowDialog();
        }
    }
}
