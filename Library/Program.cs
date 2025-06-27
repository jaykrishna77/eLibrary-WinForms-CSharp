using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.UserLogin;

namespace Library
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserSignInForm());
            
        }
        /// A Windows Forms-based eLibrary Management System built in C#. 
        /// This desktop application allows users to manage books, authors, and borrowers with features like book issue/return, author management, and user authentication.
        /// Ideal for small-scale library management in schools or personal collections.
    }
}
