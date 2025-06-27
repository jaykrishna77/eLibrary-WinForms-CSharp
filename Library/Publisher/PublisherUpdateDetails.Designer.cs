namespace Library.Publisher
{
    partial class PublisherUpdateDetails
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.lstbxAuthorStatus = new System.Windows.Forms.ListBox();
            this.AuthorStatus = new System.Windows.Forms.Label();
            this.AuthorId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxAuthorName = new System.Windows.Forms.TextBox();
            this.txtbxauthor_id = new System.Windows.Forms.TextBox();
            this.AuthorName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(351, 359);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.Submit.Location = new System.Drawing.Point(322, 351);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(127, 49);
            this.Submit.TabIndex = 23;
            this.Submit.Text = "Update";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.lstbxAuthorStatus.Location = new System.Drawing.Point(398, 245);
            this.lstbxAuthorStatus.Name = "lstbxAuthorStatus";
            this.lstbxAuthorStatus.Size = new System.Drawing.Size(216, 19);
            this.lstbxAuthorStatus.TabIndex = 22;
            // 
            // AuthorStatus
            // 
            this.AuthorStatus.AutoSize = true;
            this.AuthorStatus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorStatus.Location = new System.Drawing.Point(187, 239);
            this.AuthorStatus.Name = "AuthorStatus";
            this.AuthorStatus.Size = new System.Drawing.Size(175, 25);
            this.AuthorStatus.TabIndex = 21;
            this.AuthorStatus.Text = "Publisher Status";
            // 
            // AuthorId
            // 
            this.AuthorId.AllowDrop = true;
            this.AuthorId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorId.AutoSize = true;
            this.AuthorId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorId.Location = new System.Drawing.Point(190, 55);
            this.AuthorId.MaximumSize = new System.Drawing.Size(190, 190);
            this.AuthorId.Name = "AuthorId";
            this.AuthorId.Size = new System.Drawing.Size(134, 25);
            this.AuthorId.TabIndex = 20;
            this.AuthorId.Text = "Publisher Id";
            this.AuthorId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 19;
            // 
            // txtbxAuthorName
            // 
            this.txtbxAuthorName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtbxAuthorName.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtbxAuthorName.Location = new System.Drawing.Point(398, 141);
            this.txtbxAuthorName.Name = "txtbxAuthorName";
            this.txtbxAuthorName.Size = new System.Drawing.Size(216, 27);
            this.txtbxAuthorName.TabIndex = 18;
            // 
            // txtbxauthor_id
            // 
            this.txtbxauthor_id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtbxauthor_id.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxauthor_id.Location = new System.Drawing.Point(398, 50);
            this.txtbxauthor_id.Name = "txtbxauthor_id";
            this.txtbxauthor_id.Size = new System.Drawing.Size(216, 27);
            this.txtbxauthor_id.TabIndex = 17;
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorName.Location = new System.Drawing.Point(187, 141);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(171, 25);
            this.AuthorName.TabIndex = 16;
            this.AuthorName.Text = "Publisher Name";
            // 
            // PublisherUpdateDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.lstbxAuthorStatus);
            this.Controls.Add(this.AuthorStatus);
            this.Controls.Add(this.AuthorId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxAuthorName);
            this.Controls.Add(this.txtbxauthor_id);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.btnUpdate);
            this.Name = "PublisherUpdateDetails";
            this.Text = "PublisherUpdateDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ListBox lstbxAuthorStatus;
        private System.Windows.Forms.Label AuthorStatus;
        private System.Windows.Forms.Label AuthorId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxAuthorName;
        private System.Windows.Forms.TextBox txtbxauthor_id;
        private System.Windows.Forms.Label AuthorName;
    }
}