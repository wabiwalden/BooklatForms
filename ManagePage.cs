using System;
using System.Windows.Forms;

namespace BooklatForms
{
    public partial class ManagePage : UserControl
    {
        public ManagePage()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            MainForm.Instance.ShowPage(new AddDeleteBookPage(), "Add / Delete Book", "Staff only \u2013 manage the book catalog");
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            MainForm.Instance.ShowPage(new AddDeleteBookPage(), "Add / Delete Book", "Staff only \u2013 manage the book catalog");
        }

        private void btnAddThesis_Click(object sender, EventArgs e)
        {
            MainForm.Instance.ShowPage(new AddDeleteThesisPage(), "Add / Delete Thesis", "Staff only \u2013 manage thesis papers");
        }

        private void btnDeleteThesis_Click(object sender, EventArgs e)
        {
            MainForm.Instance.ShowPage(new AddDeleteThesisPage(), "Add / Delete Thesis", "Staff only \u2013 manage thesis papers");
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            MainForm.Instance.ShowPage(new AddDeleteUserPage(), "Add / Delete User", "Staff only \u2013 manage borrower accounts");
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            MainForm.Instance.ShowPage(new AddDeleteUserPage(), "Add / Delete User", "Staff only \u2013 manage borrower accounts");
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
        }

        private void btnMonitorRecord_Click(object sender, EventArgs e)
        {
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
        }
    }
}