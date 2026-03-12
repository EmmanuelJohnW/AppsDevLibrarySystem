namespace WindowsFormsLibrarySys
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.lblTotalBorrowers = new System.Windows.Forms.Label();
            this.lblTotalBorrowed = new System.Windows.Forms.Label();
            this.lblTotalReturned = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grid4 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid4)).BeginInit();
            this.SuspendLayout();
            // groupBox1
            this.groupBox1.Controls.Add(this.lblTotalBooks);
            this.groupBox1.Controls.Add(this.lblTotalBorrowers);
            this.groupBox1.Controls.Add(this.lblTotalBorrowed);
            this.groupBox1.Controls.Add(this.lblTotalReturned);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 130);
            this.groupBox1.Text = "Summary";
            // lblTotalBooks
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalBooks.Location = new System.Drawing.Point(15, 30);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Text = "Total Books: 0";
            // lblTotalBorrowers
            this.lblTotalBorrowers.AutoSize = true;
            this.lblTotalBorrowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalBorrowers.Location = new System.Drawing.Point(15, 60);
            this.lblTotalBorrowers.Name = "lblTotalBorrowers";
            this.lblTotalBorrowers.Text = "Total Borrowers: 0";
            // lblTotalBorrowed
            this.lblTotalBorrowed.AutoSize = true;
            this.lblTotalBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalBorrowed.Location = new System.Drawing.Point(250, 30);
            this.lblTotalBorrowed.Name = "lblTotalBorrowed";
            this.lblTotalBorrowed.Text = "Currently Borrowed: 0";
            // lblTotalReturned
            this.lblTotalReturned.AutoSize = true;
            this.lblTotalReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalReturned.Location = new System.Drawing.Point(250, 60);
            this.lblTotalReturned.Name = "lblTotalReturned";
            this.lblTotalReturned.Text = "Total Returned: 0";
            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(450, 88);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 28);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // groupBox2
            this.groupBox2.Controls.Add(this.grid4);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 360);
            this.groupBox2.Text = "Transaction Records";
            // grid4
            this.grid4.AllowUserToAddRows = false;
            this.grid4.AllowUserToDeleteRows = false;
            this.grid4.Location = new System.Drawing.Point(10, 20);
            this.grid4.Name = "grid4";
            this.grid4.ReadOnly = true;
            this.grid4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid4.Size = new System.Drawing.Size(535, 325);
            // Form6
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 530);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form6";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid4)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblTotalBorrowers;
        private System.Windows.Forms.Label lblTotalBorrowed;
        private System.Windows.Forms.Label lblTotalReturned;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grid4;
    }
}
