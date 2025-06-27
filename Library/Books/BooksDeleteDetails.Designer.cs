namespace Library
{
    partial class BooksDeleteDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDeleteBook = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDeleteBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeleteBook
            // 
            this.lblDeleteBook.Location = new System.Drawing.Point(70, 99);
            this.lblDeleteBook.Name = "lblDeleteBook";
            this.lblDeleteBook.Size = new System.Drawing.Size(97, 45);
            this.lblDeleteBook.TabIndex = 0;
            this.lblDeleteBook.Text = "Select BookID to Delete";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "12201",
            "12202",
            "12203",
            "12204",
            "12205"});
            this.listBox1.Location = new System.Drawing.Point(204, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 1;
            // 
            // btnDeleteBooks
            // 
            this.btnDeleteBooks.Location = new System.Drawing.Point(249, 251);
            this.btnDeleteBooks.Name = "btnDeleteBooks";
            this.btnDeleteBooks.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBooks.TabIndex = 2;
            this.btnDeleteBooks.Text = "Delete";
            this.btnDeleteBooks.UseVisualStyleBackColor = true;
            this.btnDeleteBooks.Click += new System.EventHandler(this.btnDeleteBooks_Click);
            // 
            // BooksDeleteDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteBooks);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblDeleteBook);
            this.Name = "BooksDeleteDetails";
            this.Text = "BooksDeleteDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteBook;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDeleteBooks;
    }
}