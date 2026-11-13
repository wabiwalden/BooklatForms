using System;
using System.Windows.Forms;

namespace BooklatForms
{
    public partial class EnqueueForm : Form
    {
        public EnqueueForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtUserId.SelectionStart = txtUserId.TextLength;
            txtUserId.SelectionLength = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
        }

        private void btnBackToBrowse_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
            MainForm.Instance.ShowPage(new HomePage(), "Home", "Pick a module to get started");
        }
    }
}