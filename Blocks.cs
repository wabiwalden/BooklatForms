using System.Drawing;
using System.Windows.Forms;

namespace BooklatForms
{
    public enum ButtonKind { Primary, Secondary, Success, Danger }

    public enum ChipKind { Green, Amber, Red, Indigo, Sky }

    public static class Blocks
    {
        public static void StyleCard(Panel p)
        {
            p.BackColor = Palette.Card;
            p.BorderStyle = BorderStyle.None;
        }

        public static void StyleDivider(Panel p)
        {
            p.Height = 1;
            p.BackColor = Palette.Line;
        }

        public static void StyleButton(Button b, ButtonKind kind)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Cursor = Cursors.Hand;
            b.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            b.UseVisualStyleBackColor = false;
            switch (kind)
            {
                case ButtonKind.Secondary:
                    b.BackColor = Palette.Raised;
                    b.ForeColor = Palette.Text;
                    b.FlatAppearance.BorderSize = 1;
                    b.FlatAppearance.BorderColor = Palette.SecondaryBorder;
                    break;
                case ButtonKind.Success:
                    b.BackColor = Palette.SuccessButton;
                    b.ForeColor = Palette.SuccessButtonText;
                    break;
                case ButtonKind.Danger:
                    b.BackColor = Palette.DangerButton;
                    b.ForeColor = Color.White;
                    break;
                default:
                    b.BackColor = Palette.Indigo;
                    b.ForeColor = Color.White;
                    break;
            }
        }

        public static void StyleChip(Label l, ChipKind kind)
        {
            l.AutoSize = false;
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            if (l.Width < 110) l.Width = 110;
            l.Height = 24;
            switch (kind)
            {
                case ChipKind.Amber: l.BackColor = Palette.AmberTint; l.ForeColor = Palette.Amber; break;
                case ChipKind.Red: l.BackColor = Palette.RedTint; l.ForeColor = Palette.Red; break;
                case ChipKind.Indigo: l.BackColor = Palette.IndigoTint; l.ForeColor = Palette.IndigoLight; break;
                case ChipKind.Sky: l.BackColor = Palette.SkyTint; l.ForeColor = Palette.Sky; break;
                default: l.BackColor = Palette.GreenTint; l.ForeColor = Palette.Green; break;
            }
        }

        public static void StyleMessageBar(Label l, bool success)
        {
            l.AutoSize = false;
            l.TextAlign = ContentAlignment.MiddleLeft;
            l.Padding = new Padding(12, 0, 0, 0);
            l.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            l.BackColor = success ? Palette.GreenTint : Palette.RedTint;
            l.ForeColor = success ? Palette.Green : Palette.Red;
        }

        public static void StyleInputPanel(Panel p)
        {
            p.BackColor = Palette.Input;
        }

        public static void StyleTextBox(TextBox t)
        {
            t.BorderStyle = BorderStyle.None;
            t.BackColor = Palette.Input;
            t.ForeColor = Palette.Text;
            t.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            t.Location = new Point(10, 10);
        }

        public static void StyleComboBox(ComboBox c)
        {
            c.DropDownStyle = ComboBoxStyle.DropDownList;
            c.FlatStyle = FlatStyle.Flat;
            c.BackColor = Palette.Input;
            c.ForeColor = Palette.Text;
            c.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            c.Location = new Point(8, 8);
        }

        public static void StyleGrid(DataGridView g, int rowHeight)
        {
            g.BorderStyle = BorderStyle.None;
            g.BackgroundColor = Palette.Card;
            g.GridColor = Palette.Line;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.EnableHeadersVisualStyles = false;
            g.RowHeadersVisible = false;
            g.ColumnHeadersHeight = 36;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.ReadOnly = true;
            g.ColumnHeadersDefaultCellStyle.BackColor = Palette.Raised;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Palette.GridHeaderText;
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Palette.Raised;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            g.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            g.DefaultCellStyle.BackColor = Palette.Card;
            g.DefaultCellStyle.ForeColor = Palette.Text;
            g.DefaultCellStyle.SelectionBackColor = Palette.GridSelection;
            g.DefaultCellStyle.SelectionForeColor = Palette.Text;
            g.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            g.AlternatingRowsDefaultCellStyle.BackColor = Palette.GridAlternate;
            g.RowTemplate.Height = rowHeight;
        }
    }
}
