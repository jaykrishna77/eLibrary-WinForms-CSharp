namespace Library
{
    partial class GenreDeleteDetails
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
            this.lblGenreId = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDeletePublisher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGenreId
            // 
            this.lblGenreId.Location = new System.Drawing.Point(98, 81);
            this.lblGenreId.Name = "lblGenreId";
            this.lblGenreId.Size = new System.Drawing.Size(76, 51);
            this.lblGenreId.TabIndex = 0;
            this.lblGenreId.Text = "Select GenreId to Delete";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110"});
            this.listBox1.Location = new System.Drawing.Point(277, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 1;
            // 
            // btnDeletePublisher
            // 
            this.btnDeletePublisher.Location = new System.Drawing.Point(348, 241);
            this.btnDeletePublisher.Name = "btnDeletePublisher";
            this.btnDeletePublisher.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePublisher.TabIndex = 2;
            this.btnDeletePublisher.Text = "Delete";
            this.btnDeletePublisher.UseVisualStyleBackColor = true;
            this.btnDeletePublisher.Click += new System.EventHandler(this.Delete_Click);
            // 
            // GenreDeleteDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletePublisher);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblGenreId);
            this.Name = "GenreDeleteDetails";
            this.Text = "GenreDeleteDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGenreId;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDeletePublisher;
    }
}