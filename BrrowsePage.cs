using System;
using System.Windows.Forms;

namespace BooklatForms
{
    public partial class BrowsePage : UserControl
    {
        public BrowsePage()
        {
            InitializeComponent();
            AddRow("Noli Me Tangere", "José Rizal · Filipiniana", "Available", Palette.Green);
            AddRow("Clean Code", "Robert C. Martin · Circulation", "Available", Palette.Green);
            AddRow("Introduction to Algorithms", "Cormen et al. · Circulation", "Unavailable", Palette.Red);
            AddRow("Database System Concepts", "Silberschatz et al. · Reference", "Available", Palette.Green);
            AddRow("Barcode-Based Attendance Monitoring System", "Santos, Reyes · 2024", "Thesis", Palette.Sky);
            AddRow("El Filibusterismo", "José Rizal · Filipiniana", "Available", Palette.Green);
            AddRow("Mobile Learning App for Grade 7 Science", "Garcia, Lim · 2023", "Thesis", Palette.Sky);
            AddRow("The Pragmatic Programmer", "Hunt, Thomas · Circulation", "Available", Palette.Green);
            AddRow("Fundamentals of Database Systems", "Elmasri, Navathe · Reference", "Available", Palette.Green);
            AddRow("Philippine History", "Zaide · Reserved", "Unavailable", Palette.Red);
            AddRow("Design Patterns", "Gamma et al. · Circulation", "Available", Palette.Green);
        }

        private void AddRow(string title, string authorAndSection, string status, System.Drawing.Color statusColor)
        {
            int i = dgvResults.Rows.Add(title, authorAndSection, status);
            dgvResults.Rows[i].Cells[2].Style.ForeColor = statusColor;
            dgvResults.Rows[i].Cells[2].Style.SelectionForeColor = statusColor;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            BeginInvoke(new Action(() =>
            {
                dgvResults.CurrentCell = dgvResults.Rows[2].Cells[0];
                dgvResults.Rows[2].Selected = true;
            }));
        }

        private void dgvResults_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResults.CurrentRow == null) return;
            bool isThesis = (string)dgvResults.CurrentRow.Cells[2].Value == "Thesis";
            pnlThesisDetails.Visible = isThesis;
            pnlBookDetails.Visible = !isThesis;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
        }
    }
}