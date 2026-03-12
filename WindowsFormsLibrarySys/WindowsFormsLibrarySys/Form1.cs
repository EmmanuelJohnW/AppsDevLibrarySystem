using System;
using System.Windows.Forms;

namespace WindowsFormsLibrarySys
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            if (user == "admin" && pass == "1234")
            {
                Form2 menu = new Form2();
                menu.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid username or password.";
            }
        }
    }
}
