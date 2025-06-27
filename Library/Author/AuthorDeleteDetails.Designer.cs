namespace Library
{
    partial class AuthorDeleteDetails
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
            this.DeleteDetails = new System.Windows.Forms.Label();
            this.lstbxDeleteDetails = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteDetails
            // 
            this.DeleteDetails.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteDetails.Location = new System.Drawing.Point(300, 49);
            this.DeleteDetails.MaximumSize = new System.Drawing.Size(200, 100);
            this.DeleteDetails.MinimumSize = new System.Drawing.Size(100, 50);
            this.DeleteDetails.Name = "DeleteDetails";
            this.DeleteDetails.Size = new System.Drawing.Size(147, 50);
            this.DeleteDetails.TabIndex = 0;
            this.DeleteDetails.Text = "Author ID";
            this.DeleteDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstbxDeleteDetails
            // 
            this.lstbxDeleteDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstbxDeleteDetails.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxDeleteDetails.FormattingEnabled = true;
            this.lstbxDeleteDetails.ItemHeight = 26;
            this.lstbxDeleteDetails.Items.AddRange(new object[] {
            "---Select--------",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lstbxDeleteDetails.Location = new System.Drawing.Point(300, 179);
            this.lstbxDeleteDetails.Name = "lstbxDeleteDetails";
            this.lstbxDeleteDetails.Size = new System.Drawing.Size(129, 30);
            this.lstbxDeleteDetails.TabIndex = 1;
            this.lstbxDeleteDetails.Click += new System.EventHandler(this.lstbxDeleteDetails_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(300, 303);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AuthorDeleteDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstbxDeleteDetails);
            this.Controls.Add(this.DeleteDetails);
            this.Name = "AuthorDeleteDetails";
            this.Text = "Delete Author";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DeleteDetails;
        private System.Windows.Forms.ListBox lstbxDeleteDetails;
        private System.Windows.Forms.Button btnDelete;
    }
}