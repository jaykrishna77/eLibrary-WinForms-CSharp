namespace Library
{
    partial class PublisherInsertDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublisherInsertDetails));
            this.PublisherId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PublisherName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PublisherStatus = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PublisherId
            // 
            this.PublisherId.AutoSize = true;
            this.PublisherId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.PublisherId.Location = new System.Drawing.Point(172, 88);
            this.PublisherId.Name = "PublisherId";
            this.PublisherId.Size = new System.Drawing.Size(138, 25);
            this.PublisherId.TabIndex = 0;
            this.PublisherId.Text = "Publisher ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.textBox1.Location = new System.Drawing.Point(380, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 27);
            this.textBox1.TabIndex = 1;
            // 
            // PublisherName
            // 
            this.PublisherName.AutoSize = true;
            this.PublisherName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.PublisherName.Location = new System.Drawing.Point(169, 180);
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.Size = new System.Drawing.Size(171, 25);
            this.PublisherName.TabIndex = 2;
            this.PublisherName.Text = "Publisher Name";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.textBox2.Location = new System.Drawing.Point(380, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 27);
            this.textBox2.TabIndex = 3;
            // 
            // PublisherStatus
            // 
            this.PublisherStatus.AutoSize = true;
            this.PublisherStatus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.PublisherStatus.Location = new System.Drawing.Point(169, 269);
            this.PublisherStatus.Name = "PublisherStatus";
            this.PublisherStatus.Size = new System.Drawing.Size(175, 25);
            this.PublisherStatus.TabIndex = 4;
            this.PublisherStatus.Text = "Publisher Status";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Items.AddRange(new object[] {
            "-------------select------------------",
            "0",
            "1"});
            this.listBox1.Location = new System.Drawing.Point(380, 271);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 21);
            this.listBox1.TabIndex = 5;
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClick.FlatAppearance.BorderSize = 0;
            this.btnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClick.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnClick.Location = new System.Drawing.Point(347, 356);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(127, 49);
            this.btnClick.TabIndex = 6;
            this.btnClick.Text = "Insert";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // PublisherInsertDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PublisherStatus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.PublisherName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PublisherId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PublisherInsertDetails";
            this.Text = "InsertPublisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PublisherId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PublisherName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label PublisherStatus;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnClick;
    }
}