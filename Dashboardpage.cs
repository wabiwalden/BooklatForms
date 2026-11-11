using System;
using System.Windows.Forms;

namespace BooklatForms
{
    public partial class DashboardPage : UserControl
    {
        public DashboardPage()
        {
            InitializeComponent();
            int a = dgvBorrowed.Rows.Add("Clean Code", "AC-004512", "Oct 30", "Nov 6", "On time");
            dgvBorrowed.Rows[a].Cells[4].Style.ForeColor = Palette.Green;
            int b = dgvBorrowed.Rows.Add("Database System Concepts", "AC-001877", "Nov 2", "Nov 5", "Due soon");
            dgvBorrowed.Rows[b].Cells[4].Style.ForeColor = Palette.Amber;
            dgvBorrowed.ClearSelection();
        }

        private void btnCheckEligibility_Click(object sender, EventArgs e)
        {
        }
    }
}