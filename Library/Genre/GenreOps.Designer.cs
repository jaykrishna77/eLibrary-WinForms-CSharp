namespace Library
{
    partial class GenreOps
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
            this.btnGenreInsert = new System.Windows.Forms.Button();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenreInsert
            // 
            this.btnGenreInsert.Location = new System.Drawing.Point(204, 130);
            this.btnGenreInsert.Name = "btnGenreInsert";
            this.btnGenreInsert.Size = new System.Drawing.Size(75, 23);
            this.btnGenreInsert.TabIndex = 0;
            this.btnGenreInsert.Text = "Insert";
            this.btnGenreInsert.UseVisualStyleBackColor = true;
            this.btnGenreInsert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Location = new System.Drawing.Point(402, 130);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGenre.TabIndex = 1;
            this.btnDeleteGenre.Text = "Delete";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "List";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GenreOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteGenre);
            this.Controls.Add(this.btnGenreInsert);
            this.Name = "GenreOps";
            this.Text = "GenreOps";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenreInsert;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}