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
            MainForm.Instance.ShowPage(new BrowsePage(), "Browse Menu", "Search, filter, and open an item");
        }

        private void btnOpenDashboard_Click(object sender, EventArgs e)
        {
            MainForm.Instance.ShowPage(new DashboardPage(), "Dashboard", "Library totals and borrower eligibility");
        }

        private void btnOpenBrowse_Click(object sender, EventArgs e)
        {
            MainForm.Instance.ShowPage(new BrowsePage(), "Browse Menu", "Search, filter, and open an item");
        }

        private void btnOpenScan_Click(object sender, EventArgs e)
        {
            MainForm.Instance.ShowPage(new ScanPage(), "Scan Menu", "Scan an ISBN or QR code");
        }

        private void btnOpenReturn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.ShowPage(new ReturnPage(), "Return Book", "Staff only \u2013 record a returned copy");
        }

        private void btnOpenManage_Click(object sender, EventArgs e)
        {
            MainForm.Instance.ShowPage(new ManagePage(), "Manage Menu", "Staff only \u2013 library maintenance");
        }
    }
}