namespace Library
{
    partial class UserInsertDetails
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblUserPhno = new System.Windows.Forms.Label();
            this.lblUserAddress = new System.Windows.Forms.Label();
            this.btnInsertUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(236, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(236, 291);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(236, 205);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(236, 368);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 4;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(94, 45);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(52, 16);
            this.lblUserId.TabIndex = 5;
            this.lblUserId.Text = "User ID";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(94, 129);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(76, 16);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "User Name";
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(94, 211);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(73, 16);
            this.lblUserEmail.TabIndex = 7;
            this.lblUserEmail.Text = "User Email";
            // 
            // lblUserPhno
            // 
            this.lblUserPhno.AutoSize = true;
            this.lblUserPhno.Location = new System.Drawing.Point(97, 296);
            this.lblUserPhno.Name = "lblUserPhno";
            this.lblUserPhno.Size = new System.Drawing.Size(73, 16);
            this.lblUserPhno.TabIndex = 8;
            this.lblUserPhno.Text = "User PhNo";
            // 
            // lblUserAddress
            // 
            this.lblUserAddress.AutoSize = true;
            this.lblUserAddress.Location = new System.Drawing.Point(97, 373);
            this.lblUserAddress.Name = "lblUserAddress";
            this.lblUserAddress.Size = new System.Drawing.Size(90, 16);
            this.lblUserAddress.TabIndex = 9;
            this.lblUserAddress.Text = "User Address";
            // 
            // btnInsertUser
            // 
            this.btnInsertUser.Location = new System.Drawing.Point(424, 451);
            this.btnInsertUser.Name = "btnInsertUser";
            this.btnInsertUser.Size = new System.Drawing.Size(75, 23);
            this.btnInsertUser.TabIndex = 10;
            this.btnInsertUser.Text = "Insert";
            this.btnInsertUser.UseVisualStyleBackColor = true;
            this.btnInsertUser.Click += new System.EventHandler(this.btnInsertUser_Click);
            // 
            // UserInsertDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.btnInsertUser);
            this.Controls.Add(this.lblUserAddress);
            this.Controls.Add(this.lblUserPhno);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "UserInsertDetails";
            this.Text = "UserInsertDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblUserPhno;
        private System.Windows.Forms.Label lblUserAddress;
        private System.Windows.Forms.Button btnInsertUser;
    }
}