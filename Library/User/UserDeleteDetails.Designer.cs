namespace Library
{
    partial class UserDeleteDetails
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
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lblDeleteUser = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(388, 227);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 1;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // lblDeleteUser
            // 
            this.lblDeleteUser.Location = new System.Drawing.Point(100, 99);
            this.lblDeleteUser.Name = "lblDeleteUser";
            this.lblDeleteUser.Size = new System.Drawing.Size(123, 62);
            this.lblDeleteUser.TabIndex = 2;
            this.lblDeleteUser.Text = "Select UserID to Delete";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "251",
            "252",
            "253",
            "254",
            "255"});
            this.listBox1.Location = new System.Drawing.Point(238, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 3;
            // 
            // UserDeleteDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblDeleteUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Name = "UserDeleteDetails";
            this.Text = "UserDeleteDetails";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label lblDeleteUser;
        private System.Windows.Forms.ListBox listBox1;
    }
}