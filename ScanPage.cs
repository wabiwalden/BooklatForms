using System;
using System.Windows.Forms;

namespace BooklatForms
{
    public partial class ScanPage : UserControl
    {
        public ScanPage()
        {
            InitializeComponent();
            cboCamera.SelectedIndex = 0;
        }

        private void btnStartScanner_Click(object sender, EventArgs e)
        {
        }

        private void btnStopScanner_Click(object sender, EventArgs e)
        {
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            using (EnqueueForm f = new EnqueueForm())
            {
                f.ShowDialog();
            }
        }

        private void btnScanAnother_Click(object sender, EventArgs e)
        {
        }
    }
}