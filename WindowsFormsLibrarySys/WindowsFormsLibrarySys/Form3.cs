using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsLibrarySys
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            grid1.DataSource = DataStore.BookTable;
            SetButtonState("default");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            SetButtonState("add");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text.Trim() == "" || txtTitle.Text.Trim() == "")
            {
                MessageBox.Show("Book ID and Title are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow row = DataStore.BookTable.NewRow();
            row["Book ID"] = txtBookID.Text.Trim();
            row["Title"] = txtTitle.Text.Trim();
            row["Author"] = txtAuthor.Text.Trim();
            DataStore.BookTable.Rows.Add(row);
            ClearFields();
            SetButtonState("default");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grid1.SelectedRows.Count == 0) return;
            DataRowView drv = (DataRowView)grid1.SelectedRows[0].DataBoundItem;
            txtBookID.Text = drv["Book ID"].ToString();
            txtTitle.Text = drv["Title"].ToString();
            txtAuthor.Text = drv["Author"].ToString();
            SetButtonState("edit");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grid1.SelectedRows.Count == 0) return;
            DataRowView drv = (DataRowView)grid1.SelectedRows[0].DataBoundItem;
            drv["Book ID"] = txtBookID.Text.Trim();
            drv["Title"] = txtTitle.Text.Trim();
            drv["Author"] = txtAuthor.Text.Trim();
            ClearFields();
            SetButtonState("default");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grid1.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Delete this book?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataRowView drv = (DataRowView)grid1.SelectedRows[0].DataBoundItem;
                drv.Row.Delete();
                ClearFields();
                SetButtonState("default");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string f = txtSearch.Text.Trim().Replace("'", "''");
            DataStore.BookTable.DefaultView.RowFilter = $"Title LIKE '%{f}%' OR Author LIKE '%{f}%'";
        }

        private void ClearFields()
        {
            txtBookID.Text = txtTitle.Text = txtAuthor.Text = "";
        }

        private void SetButtonState(string mode)
        {
            btnAdd.Enabled = mode == "default";
            btnEdit.Enabled = mode == "default";
            btnDelete.Enabled = mode == "default";
            btnSave.Enabled = mode == "add";
            btnUpdate.Enabled = mode == "edit";
        }
    }
}
