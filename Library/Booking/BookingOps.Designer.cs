namespace Library
{
    partial class BookingOps
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
            this.btnInsertBooking = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertBooking
            // 
            this.btnInsertBooking.Location = new System.Drawing.Point(212, 134);
            this.btnInsertBooking.Name = "btnInsertBooking";
            this.btnInsertBooking.Size = new System.Drawing.Size(75, 23);
            this.btnInsertBooking.TabIndex = 0;
            this.btnInsertBooking.Text = "Insert";
            this.btnInsertBooking.UseVisualStyleBackColor = true;
            this.btnInsertBooking.Click += new System.EventHandler(this.btnInsertBooking_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(450, 134);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBooking.TabIndex = 1;
            this.btnDeleteBooking.Text = "Delete";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "List";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BookingOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.btnInsertBooking);
            this.Name = "BookingOps";
            this.Text = "BookingOps";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertBooking;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}