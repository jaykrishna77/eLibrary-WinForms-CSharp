namespace Library
{
    partial class BookingDeleteDetails
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
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.lblDeleteBooking = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(329, 253);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBooking.TabIndex = 0;
            this.btnDeleteBooking.Text = "Delete";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // lblDeleteBooking
            // 
            this.lblDeleteBooking.Location = new System.Drawing.Point(121, 106);
            this.lblDeleteBooking.Name = "lblDeleteBooking";
            this.lblDeleteBooking.Size = new System.Drawing.Size(113, 45);
            this.lblDeleteBooking.TabIndex = 1;
            this.lblDeleteBooking.Text = "Select BookingID to Delete";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "12201",
            "12202",
            "12203",
            "12204",
            "12205"});
            this.listBox1.Location = new System.Drawing.Point(317, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 2;
            // 
            // BookingDeleteDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblDeleteBooking);
            this.Controls.Add(this.btnDeleteBooking);
            this.Name = "BookingDeleteDetails";
            this.Text = "BookingDeleteDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Label lblDeleteBooking;
        private System.Windows.Forms.ListBox listBox1;
    }
}