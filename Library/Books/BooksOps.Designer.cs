namespace Library
{
    partial class BooksOps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksOps));
            this.btnInsertBooks = new System.Windows.Forms.Button();
            this.btnDeleteBooks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertBooks
            // 
            this.btnInsertBooks.Location = new System.Drawing.Point(216, 135);
            this.btnInsertBooks.Name = "btnInsertBooks";
            this.btnInsertBooks.Size = new System.Drawing.Size(75, 23);
            this.btnInsertBooks.TabIndex = 0;
            this.btnInsertBooks.Text = "Insert";
            this.btnInsertBooks.UseVisualStyleBackColor = true;
            this.btnInsertBooks.Click += new System.EventHandler(this.btnInsertBooks_Click);
            // 
            // btnDeleteBooks
            // 
            this.btnDeleteBooks.Location = new System.Drawing.Point(400, 134);
            this.btnDeleteBooks.Name = "btnDeleteBooks";
            this.btnDeleteBooks.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBooks.TabIndex = 1;
            this.btnDeleteBooks.Text = "Delete";
            this.btnDeleteBooks.UseVisualStyleBackColor = true;
            this.btnDeleteBooks.Click += new System.EventHandler(this.btnDeleteBooks_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "List";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BooksOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteBooks);
            this.Controls.Add(this.btnInsertBooks);
            this.Name = "BooksOps";
            this.Text = "BooksOps";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertBooks;
        private System.Windows.Forms.Button btnDeleteBooks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}