using System;
using System.Windows.Forms;

namespace BooklatForms
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnBrowseCatalog_Click(object sender, EventArgs e)
        {
        }

        private void btnOpenDashboard_Click(object sender, EventArgs e)
        {
            MainForm.Instance.ShowPage(new DashboardPage(), "Dashboard", "Library totals and borrower eligibility");
        }

        private void btnOpenBrowse_Click(object sender, EventArgs e)
        {
        }

        private void btnOpenScan_Click(object sender, EventArgs e)
        {
        }

        private void btnOpenReturn_Click(object sender, EventArgs e)
        {
        }

        private void btnOpenManage_Click(object sender, EventArgs e)
        {
        }
    }
}