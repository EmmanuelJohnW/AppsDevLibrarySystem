using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsLibrarySys
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Populate book combo
            cmbBookID.Items.Clear();
            foreach (DataRow r in DataStore.BookTable.Rows)
                if (r.RowState != DataRowState.Deleted)
                    cmbBookID.Items.Add(r["Book ID"].ToString());

            // Populate borrower combo
            cmbBorrowerID.Items.Clear();
            foreach (DataRow r in DataStore.BorrowerTable.Rows)
                if (r.RowState != DataRowState.Deleted)
                    cmbBorrowerID.Items.Add(r["Borrower ID"].ToString());

            grid3.DataSource = DataStore.TransactionTable;
            dtpBorrowDate.Value = DateTime.Today;
        }

        private void cmbBookID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bookID = cmbBookID.SelectedItem?.ToString();
            lblBookTitle.Text = "";
            if (bookID == null) return;
            DataRow[] rows = DataStore.BookTable.Select($"[Book ID] = '{bookID.Replace("'", "''")}'");
            if (rows.Length > 0)
                lblBookTitle.Text = rows[0]["Title"].ToString();
        }

        private void cmbBorrowerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string borrowerID = cmbBorrowerID.SelectedItem?.ToString();
            lblBorrowerName.Text = "";
            if (borrowerID == null) return;
            DataRow[] rows = DataStore.BorrowerTable.Select($"[Borrower ID] = '{borrowerID.Replace("'", "''")}'");
            if (rows.Length > 0)
                lblBorrowerName.Text = rows[0]["Name"].ToString();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (cmbBookID.SelectedItem == null || cmbBorrowerID.SelectedItem == null)
            {
                MessageBox.Show("Please select a Book and a Borrower.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow row = DataStore.TransactionTable.NewRow();
            row["Transaction ID"] = DataStore.NextTransactionID();
            row["Book ID"] = cmbBookID.SelectedItem.ToString();
            row["Book Title"] = lblBookTitle.Text;
            row["Borrower ID"] = cmbBorrowerID.SelectedItem.ToString();
            row["Borrower Name"] = lblBorrowerName.Text;
            row["Borrow Date"] = dtpBorrowDate.Value.ToString("yyyy-MM-dd");
            row["Return Date"] = "";
            row["Status"] = "Borrowed";
            DataStore.TransactionTable.Rows.Add(row);

            cmbBookID.SelectedIndex = -1;
            cmbBorrowerID.SelectedIndex = -1;
            lblBookTitle.Text = "";
            lblBorrowerName.Text = "";
            dtpBorrowDate.Value = DateTime.Today;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (grid3.SelectedRows.Count == 0) return;
            DataRowView drv = (DataRowView)grid3.SelectedRows[0].DataBoundItem;
            if (drv["Status"].ToString() == "Returned")
            {
                MessageBox.Show("This book has already been returned.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            drv["Return Date"] = DateTime.Today.ToString("yyyy-MM-dd");
            drv["Status"] = "Returned";
        }
    }
}
