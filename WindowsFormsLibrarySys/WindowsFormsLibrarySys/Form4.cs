using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsLibrarySys
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            grid2.DataSource = DataStore.BorrowerTable;
            SetButtonState("default");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            SetButtonState("add");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBorrowerID.Text.Trim() == "" || txtName.Text.Trim() == "")
            {
                MessageBox.Show("Borrower ID and Name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow row = DataStore.BorrowerTable.NewRow();
            row["Borrower ID"] = txtBorrowerID.Text.Trim();
            row["Name"] = txtName.Text.Trim();
            row["Contact"] = txtContact.Text.Trim();
            DataStore.BorrowerTable.Rows.Add(row);
            ClearFields();
            SetButtonState("default");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grid2.SelectedRows.Count == 0) return;
            DataRowView drv = (DataRowView)grid2.SelectedRows[0].DataBoundItem;
            txtBorrowerID.Text = drv["Borrower ID"].ToString();
            txtName.Text = drv["Name"].ToString();
            txtContact.Text = drv["Contact"].ToString();
            SetButtonState("edit");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grid2.SelectedRows.Count == 0) return;
            DataRowView drv = (DataRowView)grid2.SelectedRows[0].DataBoundItem;
            drv["Borrower ID"] = txtBorrowerID.Text.Trim();
            drv["Name"] = txtName.Text.Trim();
            drv["Contact"] = txtContact.Text.Trim();
            ClearFields();
            SetButtonState("default");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grid2.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Delete this borrower?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataRowView drv = (DataRowView)grid2.SelectedRows[0].DataBoundItem;
                drv.Row.Delete();
                ClearFields();
                SetButtonState("default");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string f = txtSearch.Text.Trim().Replace("'", "''");
            DataStore.BorrowerTable.DefaultView.RowFilter = $"Name LIKE '%{f}%' OR Contact LIKE '%{f}%'";
        }

        private void ClearFields()
        {
            txtBorrowerID.Text = txtName.Text = txtContact.Text = "";
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
