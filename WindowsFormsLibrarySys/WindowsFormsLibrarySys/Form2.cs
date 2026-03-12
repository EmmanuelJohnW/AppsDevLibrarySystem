using System;
using System.Windows.Forms;

namespace WindowsFormsLibrarySys
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 books = new Form3();
            books.FormClosed += (s, args) => this.Show();
            books.Show();
            this.Hide();
        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 borrower = new Form4();
            borrower.FormClosed += (s, args) => this.Show();
            borrower.Show();
            this.Hide();
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 transaction = new Form5();
            transaction.FormClosed += (s, args) => this.Show();
            transaction.Show();
            this.Hide();
        }

        private void summaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 reports = new Form6();
            reports.FormClosed += (s, args) => this.Show();
            reports.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
