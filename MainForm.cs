using System;
using System.Windows.Forms;

namespace BooklatForms
{
    public partial class MainForm : Form
    {
        public static MainForm Instance;

        public MainForm()
        {
            InitializeComponent();
            Instance = this;
            ShowPage(new HomePage(), "Home", "Pick a module to get started");
        }

        public void ShowPage(UserControl page, string title, string subtitle)
        {
            panelHost.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelHost.Controls.Add(page);
            lblTitle.Text = title;
            lblSubtitle.Text = subtitle;
        }

        private void btnNavHome_Click(object sender, EventArgs e)
        {
            ShowPage(new HomePage(), "Home", "Pick a module to get started");
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            ShowPage(new DashboardPage(), "Dashboard", "Library totals and borrower eligibility");
        }

        private void btnNavBrowse_Click(object sender, EventArgs e)
        {
        }

        private void btnNavScan_Click(object sender, EventArgs e)
        {
        }

        private void btnNavReturn_Click(object sender, EventArgs e)
        {
        }

        private void btnNavManage_Click(object sender, EventArgs e)
        {
        }

        private void btnBackToManage_Click(object sender, EventArgs e)
        {
        }
    }
}