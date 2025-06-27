namespace Library
{
    partial class GenreInsertDetails
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblGenreName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGenreId
            // 
            this.lblGenreId.AutoSize = true;
            this.lblGenreId.Location = new System.Drawing.Point(109, 55);
            this.lblGenreId.Name = "lblGenreId";
            this.lblGenreId.Size = new System.Drawing.Size(60, 16);
            this.lblGenreId.TabIndex = 0;
            this.lblGenreId.Text = "Genre ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Location = new System.Drawing.Point(112, 100);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(84, 16);
            this.lblGenreName.TabIndex = 2;
            this.lblGenreName.Text = "Genre Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(231, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GenreInsertDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblGenreName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblGenreId);
            this.Name = "GenreInsertDetails";
            this.Text = "GenreInsertDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenreId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblGenreName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}