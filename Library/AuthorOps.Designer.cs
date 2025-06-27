namespace Library
{
    partial class AuthorOps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorOps));
            this.Insert = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.UpdateAuthor = new System.Windows.Forms.Button();
            this.AuthorList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.SandyBrown;
            this.Insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Insert.FlatAppearance.BorderSize = 0;
            this.Insert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Insert.Location = new System.Drawing.Point(174, 155);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(200, 73);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Delete
            // 
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Delete.Location = new System.Drawing.Point(540, 155);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(200, 73);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // UpdateAuthor
            // 
            this.UpdateAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateAuthor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UpdateAuthor.FlatAppearance.BorderSize = 0;
            this.UpdateAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateAuthor.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAuthor.ForeColor = System.Drawing.SystemColors.MenuText;
            this.UpdateAuthor.Location = new System.Drawing.Point(174, 358);
            this.UpdateAuthor.Name = "UpdateAuthor";
            this.UpdateAuthor.Size = new System.Drawing.Size(200, 73);
            this.UpdateAuthor.TabIndex = 3;
            this.UpdateAuthor.Text = "Update";
            this.UpdateAuthor.UseVisualStyleBackColor = true;
            this.UpdateAuthor.Click += new System.EventHandler(this.UpdateAuthor_Click);
            // 
            // AuthorList
            // 
            this.AuthorList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthorList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AuthorList.FlatAppearance.BorderSize = 0;
            this.AuthorList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.AuthorList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorList.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorList.ForeColor = System.Drawing.SystemColors.MenuText;
            this.AuthorList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AuthorList.Location = new System.Drawing.Point(540, 358);
            this.AuthorList.Name = "AuthorList";
            this.AuthorList.Size = new System.Drawing.Size(200, 73);
            this.AuthorList.TabIndex = 4;
            this.AuthorList.Text = "List";
            this.AuthorList.UseVisualStyleBackColor = true;
            this.AuthorList.Click += new System.EventHandler(this.AuthorList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(337, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 67);
            this.label1.TabIndex = 4;
            this.label1.Text = "Author🧑‍💼";
            // 
            // AuthorOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(900, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuthorList);
            this.Controls.Add(this.UpdateAuthor);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Insert);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorOps";
            this.Text = "Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button UpdateAuthor;
        private System.Windows.Forms.Button AuthorList;
        private System.Windows.Forms.Label label1;
    }
}