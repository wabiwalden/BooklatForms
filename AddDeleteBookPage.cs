using System;
using System.Windows.Forms;

namespace BooklatForms
{
    public partial class AddDeleteBookPage : UserControl
    {
        public AddDeleteBookPage()
        {
            InitializeComponent();
            cboCategory.SelectedIndex = 0;
            cboSection.SelectedIndex = 1;
        }

        private void btnScanBarcode_Click(object sender, EventArgs e)
        {
        }

        private void btnConfirmDetails_Click(object sender, EventArgs e)
        {
        }

        private void btnScanDelete_Click(object sender, EventArgs e)
        {
        }

        private void btnConfirmDelete_Click(object sender, EventArgs e)
        {
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
        }
    }
}