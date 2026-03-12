using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsLibrarySys
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            grid4.DataSource = DataStore.TransactionTable;
            RefreshSummary();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshSummary();
        }

        private void RefreshSummary()
        {
            int totalBooks = 0;
            foreach (DataRow r in DataStore.BookTable.Rows)
                if (r.RowState != DataRowState.Deleted) totalBooks++;

            int totalBorrowers = 0;
            foreach (DataRow r in DataStore.BorrowerTable.Rows)
                if (r.RowState != DataRowState.Deleted) totalBorrowers++;

            int totalBorrowed = 0, totalReturned = 0;
            foreach (DataRow r in DataStore.TransactionTable.Rows)
            {
                if (r.RowState == DataRowState.Deleted) continue;
                if (r["Status"].ToString() == "Borrowed") totalBorrowed++;
                else if (r["Status"].ToString() == "Returned") totalReturned++;
            }

            lblTotalBooks.Text = "Total Books: " + totalBooks;
            lblTotalBorrowers.Text = "Total Borrowers: " + totalBorrowers;
            lblTotalBorrowed.Text = "Currently Borrowed: " + totalBorrowed;
            lblTotalReturned.Text = "Total Returned: " + totalReturned;
        }
    }
}
