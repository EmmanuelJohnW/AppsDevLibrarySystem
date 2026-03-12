namespace WindowsFormsLibrarySys
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBookID = new System.Windows.Forms.ComboBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBorrowerID = new System.Windows.Forms.ComboBox();
            this.lblBorrowerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grid3 = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid3)).BeginInit();
            this.SuspendLayout();
            // groupBox1
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbBookID);
            this.groupBox1.Controls.Add(this.lblBookTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBorrowerID);
            this.groupBox1.Controls.Add(this.lblBorrowerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpBorrowDate);
            this.groupBox1.Controls.Add(this.btnBorrow);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 160);
            this.groupBox1.Text = "Borrow Book";
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Text = "Book ID";
            // cmbBookID
            this.cmbBookID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookID.Location = new System.Drawing.Point(100, 32);
            this.cmbBookID.Name = "cmbBookID";
            this.cmbBookID.Size = new System.Drawing.Size(130, 21);
            this.cmbBookID.SelectedIndexChanged += new System.EventHandler(this.cmbBookID_SelectedIndexChanged);
            // lblBookTitle
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(240, 35);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(0, 13);
            this.lblBookTitle.Text = "";
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Text = "Borrower ID";
            // cmbBorrowerID
            this.cmbBorrowerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBorrowerID.Location = new System.Drawing.Point(100, 67);
            this.cmbBorrowerID.Name = "cmbBorrowerID";
            this.cmbBorrowerID.Size = new System.Drawing.Size(130, 21);
            this.cmbBorrowerID.SelectedIndexChanged += new System.EventHandler(this.cmbBorrowerID_SelectedIndexChanged);
            // lblBorrowerName
            this.lblBorrowerName.AutoSize = true;
            this.lblBorrowerName.Location = new System.Drawing.Point(240, 70);
            this.lblBorrowerName.Name = "lblBorrowerName";
            this.lblBorrowerName.Size = new System.Drawing.Size(0, 13);
            this.lblBorrowerName.Text = "";
            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Name = "label3";
            this.label3.Text = "Borrow Date";
            // dtpBorrowDate
            this.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrowDate.Location = new System.Drawing.Point(100, 102);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(130, 20);
            // btnBorrow
            this.btnBorrow.Location = new System.Drawing.Point(450, 95);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(90, 30);
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // groupBox2
            this.groupBox2.Controls.Add(this.grid3);
            this.groupBox2.Controls.Add(this.btnReturn);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 340);
            this.groupBox2.Text = "Transaction Records";
            // grid3
            this.grid3.AllowUserToAddRows = false;
            this.grid3.AllowUserToDeleteRows = false;
            this.grid3.Location = new System.Drawing.Point(10, 20);
            this.grid3.Name = "grid3";
            this.grid3.ReadOnly = true;
            this.grid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid3.Size = new System.Drawing.Size(535, 270);
            // btnReturn
            this.btnReturn.Location = new System.Drawing.Point(450, 298);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(95, 30);
            this.btnReturn.Text = "Return Selected";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // Form5
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form5";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid3)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBookID;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBorrowerID;
        private System.Windows.Forms.Label lblBorrowerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grid3;
        private System.Windows.Forms.Button btnReturn;
    }
}
