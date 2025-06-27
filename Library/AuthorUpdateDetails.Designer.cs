namespace Library.Author
{
    partial class AuthorUpdateDetails
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
            this.AuthorName = new System.Windows.Forms.Label();
            this.txtbxauthor_id = new System.Windows.Forms.TextBox();
            this.txtbxAuthorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorId = new System.Windows.Forms.Label();
            this.AuthorStatus = new System.Windows.Forms.Label();
            this.lstbxAuthorStatus = new System.Windows.Forms.ListBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorName.Location = new System.Drawing.Point(169, 147);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(149, 25);
            this.AuthorName.TabIndex = 8;
            this.AuthorName.Text = "Author Name";
            // 
            // txtbxauthor_id
            // 
            this.txtbxauthor_id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtbxauthor_id.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxauthor_id.Location = new System.Drawing.Point(380, 56);
            this.txtbxauthor_id.Name = "txtbxauthor_id";
            this.txtbxauthor_id.Size = new System.Drawing.Size(216, 27);
            this.txtbxauthor_id.TabIndex = 9;
            // 
            // txtbxAuthorName
            // 
            this.txtbxAuthorName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtbxAuthorName.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtbxAuthorName.Location = new System.Drawing.Point(380, 147);
            this.txtbxAuthorName.Name = "txtbxAuthorName";
            this.txtbxAuthorName.Size = new System.Drawing.Size(216, 27);
            this.txtbxAuthorName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 11;
            // 
            // AuthorId
            // 
            this.AuthorId.AllowDrop = true;
            this.AuthorId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorId.AutoSize = true;
            this.AuthorId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorId.Location = new System.Drawing.Point(172, 61);
            this.AuthorId.MaximumSize = new System.Drawing.Size(190, 190);
            this.AuthorId.Name = "AuthorId";
            this.AuthorId.Size = new System.Drawing.Size(112, 25);
            this.AuthorId.TabIndex = 12;
            this.AuthorId.Text = "Author Id";
            this.AuthorId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorStatus
            // 
            this.AuthorStatus.AutoSize = true;
            this.AuthorStatus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorStatus.Location = new System.Drawing.Point(169, 245);
            this.AuthorStatus.Name = "AuthorStatus";
            this.AuthorStatus.Size = new System.Drawing.Size(153, 25);
            this.AuthorStatus.TabIndex = 13;
            this.AuthorStatus.Text = "Author Status";
            // 
            // lstbxAuthorStatus
            // 
            this.lstbxAuthorStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lstbxAuthorStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbxAuthorStatus.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lstbxAuthorStatus.FormattingEnabled = true;
            this.lstbxAuthorStatus.ItemHeight = 19;
            this.lstbxAuthorStatus.Items.AddRange(new object[] {
            "---------Select---------------",
            "0",
            "1"});
            this.lstbxAuthorStatus.Location = new System.Drawing.Point(380, 251);
            this.lstbxAuthorStatus.Name = "lstbxAuthorStatus";
            this.lstbxAuthorStatus.Size = new System.Drawing.Size(216, 19);
            this.lstbxAuthorStatus.TabIndex = 14;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Submit.FlatAppearance.BorderSize = 2;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Submit.Location = new System.Drawing.Point(304, 357);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(127, 49);
            this.Submit.TabIndex = 15;
            this.Submit.Text = "Update";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AuthorUpdateDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.lstbxAuthorStatus);
            this.Controls.Add(this.AuthorStatus);
            this.Controls.Add(this.AuthorId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxAuthorName);
            this.Controls.Add(this.txtbxauthor_id);
            this.Controls.Add(this.AuthorName);
            this.Name = "AuthorUpdateDetails";
            this.Text = "AuthorUpdateDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AuthorName;
        private System.Windows.Forms.TextBox txtbxauthor_id;
        private System.Windows.Forms.TextBox txtbxAuthorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AuthorId;
        private System.Windows.Forms.Label AuthorStatus;
        private System.Windows.Forms.ListBox lstbxAuthorStatus;
        private System.Windows.Forms.Button Submit;
    }
}