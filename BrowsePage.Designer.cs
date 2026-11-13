namespace BooklatForms
{
    partial class BrowsePage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblFiltersTitle = new System.Windows.Forms.Label();
            this.lblTypeCaption = new System.Windows.Forms.Label();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoBooks = new System.Windows.Forms.RadioButton();
            this.rdoThesis = new System.Windows.Forms.RadioButton();
            this.lblSectionCaption = new System.Windows.Forms.Label();
            this.chkFilipiniana = new System.Windows.Forms.CheckBox();
            this.chkCirculation = new System.Windows.Forms.CheckBox();
            this.chkReference = new System.Windows.Forms.CheckBox();
            this.chkReserved = new System.Windows.Forms.CheckBox();
            this.lblStatusCaption = new System.Windows.Forms.Label();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.chkUnavailable = new System.Windows.Forms.CheckBox();
            this.pnlFilterDivider = new System.Windows.Forms.Panel();
            this.lblFilterNote = new System.Windows.Forms.Label();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.pnlSearchInput = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.pnlBookDetails = new System.Windows.Forms.Panel();
            this.pnlBookCover = new System.Windows.Forms.Panel();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookAuthors = new System.Windows.Forms.Label();
            this.lblBookIsbn = new System.Windows.Forms.Label();
            this.chipBookStatus = new System.Windows.Forms.Label();
            this.lblSynopsisTitle = new System.Windows.Forms.Label();
            this.lblSynopsis = new System.Windows.Forms.Label();
            this.lblPublisherCaption = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblYearCaption = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPagesCaption = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblCategoryCaption = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblLocationTitle = new System.Windows.Forms.Label();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.lblMapFilipiniana = new System.Windows.Forms.Label();
            this.lblMapReference = new System.Windows.Forms.Label();
            this.lblMapCirculation = new System.Windows.Forms.Label();
            this.lblMapReserved = new System.Windows.Forms.Label();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.pnlThesisDetails = new System.Windows.Forms.Panel();
            this.lblThesisTitle = new System.Windows.Forms.Label();
            this.chipThesis = new System.Windows.Forms.Label();
            this.lblAbstractTitle = new System.Windows.Forms.Label();
            this.lblAbstract = new System.Windows.Forms.Label();
            this.picQr = new System.Windows.Forms.PictureBox();
            this.lblQrTitle = new System.Windows.Forms.Label();
            this.lblQrHint = new System.Windows.Forms.Label();
            this.lblFileLinkCaption = new System.Windows.Forms.Label();
            this.lblFileLink = new System.Windows.Forms.Label();
            this.colResultTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResultAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResultStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.pnlFilters.SuspendLayout();
            this.pnlResults.SuspendLayout();
            this.pnlSearchInput.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.pnlBookDetails.SuspendLayout();
            this.pnlMap.SuspendLayout();
            this.pnlThesisDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQr)).BeginInit();
            this.SuspendLayout();

            this.pnlFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlFilters.Controls.Add(this.lblFiltersTitle);
            this.pnlFilters.Controls.Add(this.lblTypeCaption);
            this.pnlFilters.Controls.Add(this.rdoAll);
            this.pnlFilters.Controls.Add(this.rdoBooks);
            this.pnlFilters.Controls.Add(this.rdoThesis);
            this.pnlFilters.Controls.Add(this.lblSectionCaption);
            this.pnlFilters.Controls.Add(this.chkFilipiniana);
            this.pnlFilters.Controls.Add(this.chkCirculation);
            this.pnlFilters.Controls.Add(this.chkReference);
            this.pnlFilters.Controls.Add(this.chkReserved);
            this.pnlFilters.Controls.Add(this.lblStatusCaption);
            this.pnlFilters.Controls.Add(this.chkAvailable);
            this.pnlFilters.Controls.Add(this.chkUnavailable);
            this.pnlFilters.Controls.Add(this.pnlFilterDivider);
            this.pnlFilters.Controls.Add(this.lblFilterNote);
            this.pnlFilters.Location = new System.Drawing.Point(28, 24);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(210, 660);
            this.pnlFilters.TabIndex = 0;

            this.lblFiltersTitle.AutoSize = true;
            this.lblFiltersTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblFiltersTitle.Location = new System.Drawing.Point(20, 16);
            this.lblFiltersTitle.Name = "lblFiltersTitle";
            this.lblFiltersTitle.Size = new System.Drawing.Size(57, 24);
            this.lblFiltersTitle.TabIndex = 0;
            this.lblFiltersTitle.Text = "Filters";

            this.lblTypeCaption.AutoSize = true;
            this.lblTypeCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblTypeCaption.Location = new System.Drawing.Point(20, 54);
            this.lblTypeCaption.Name = "lblTypeCaption";
            this.lblTypeCaption.Size = new System.Drawing.Size(21, 16);
            this.lblTypeCaption.TabIndex = 1;
            this.lblTypeCaption.Text = "TYPE";

            this.rdoAll.AutoSize = true;
            this.rdoAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.rdoAll.Checked = true;
            this.rdoAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.rdoAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.rdoAll.Location = new System.Drawing.Point(20, 76);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(52, 23);
            this.rdoAll.TabIndex = 2;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = false;

            this.rdoBooks.AutoSize = true;
            this.rdoBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.rdoBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoBooks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.rdoBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoBooks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.rdoBooks.Location = new System.Drawing.Point(20, 104);
            this.rdoBooks.Name = "rdoBooks";
            this.rdoBooks.Size = new System.Drawing.Size(68, 23);
            this.rdoBooks.TabIndex = 3;
            this.rdoBooks.Text = "Books";
            this.rdoBooks.UseVisualStyleBackColor = false;

            this.rdoThesis.AutoSize = true;
            this.rdoThesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.rdoThesis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoThesis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.rdoThesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoThesis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoThesis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.rdoThesis.Location = new System.Drawing.Point(20, 132);
            this.rdoThesis.Name = "rdoThesis";
            this.rdoThesis.Size = new System.Drawing.Size(72, 23);
            this.rdoThesis.TabIndex = 4;
            this.rdoThesis.Text = "Thesis";
            this.rdoThesis.UseVisualStyleBackColor = false;

            this.lblSectionCaption.AutoSize = true;
            this.lblSectionCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblSectionCaption.Location = new System.Drawing.Point(20, 178);
            this.lblSectionCaption.Name = "lblSectionCaption";
            this.lblSectionCaption.Size = new System.Drawing.Size(38, 16);
            this.lblSectionCaption.TabIndex = 5;
            this.lblSectionCaption.Text = "SECTION";

            this.chkFilipiniana.AutoSize = true;
            this.chkFilipiniana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.chkFilipiniana.Checked = true;
            this.chkFilipiniana.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFilipiniana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkFilipiniana.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.chkFilipiniana.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.chkFilipiniana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFilipiniana.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFilipiniana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.chkFilipiniana.Location = new System.Drawing.Point(20, 200);
            this.chkFilipiniana.Name = "chkFilipiniana";
            this.chkFilipiniana.Size = new System.Drawing.Size(104, 23);
            this.chkFilipiniana.TabIndex = 6;
            this.chkFilipiniana.Text = "Filipiniana";
            this.chkFilipiniana.UseVisualStyleBackColor = false;

            this.chkCirculation.AutoSize = true;
            this.chkCirculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.chkCirculation.Checked = true;
            this.chkCirculation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCirculation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCirculation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.chkCirculation.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.chkCirculation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkCirculation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCirculation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.chkCirculation.Location = new System.Drawing.Point(20, 228);
            this.chkCirculation.Name = "chkCirculation";
            this.chkCirculation.Size = new System.Drawing.Size(103, 23);
            this.chkCirculation.TabIndex = 7;
            this.chkCirculation.Text = "Circulation";
            this.chkCirculation.UseVisualStyleBackColor = false;

            this.chkReference.AutoSize = true;
            this.chkReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.chkReference.Checked = true;
            this.chkReference.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReference.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkReference.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.chkReference.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.chkReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkReference.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.chkReference.Location = new System.Drawing.Point(20, 256);
            this.chkReference.Name = "chkReference";
            this.chkReference.Size = new System.Drawing.Size(96, 23);
            this.chkReference.TabIndex = 8;
            this.chkReference.Text = "Reference";
            this.chkReference.UseVisualStyleBackColor = false;

            this.chkReserved.AutoSize = true;
            this.chkReserved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.chkReserved.Checked = true;
            this.chkReserved.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReserved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkReserved.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.chkReserved.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.chkReserved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkReserved.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReserved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.chkReserved.Location = new System.Drawing.Point(20, 284);
            this.chkReserved.Name = "chkReserved";
            this.chkReserved.Size = new System.Drawing.Size(90, 23);
            this.chkReserved.TabIndex = 9;
            this.chkReserved.Text = "Reserved";
            this.chkReserved.UseVisualStyleBackColor = false;

            this.lblStatusCaption.AutoSize = true;
            this.lblStatusCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblStatusCaption.Location = new System.Drawing.Point(20, 328);
            this.lblStatusCaption.Name = "lblStatusCaption";
            this.lblStatusCaption.Size = new System.Drawing.Size(32, 16);
            this.lblStatusCaption.TabIndex = 10;
            this.lblStatusCaption.Text = "STATUS";

            this.chkAvailable.AutoSize = true;
            this.chkAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.chkAvailable.Checked = true;
            this.chkAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAvailable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAvailable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.chkAvailable.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.chkAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAvailable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.chkAvailable.Location = new System.Drawing.Point(20, 350);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(91, 23);
            this.chkAvailable.TabIndex = 11;
            this.chkAvailable.Text = "Available";
            this.chkAvailable.UseVisualStyleBackColor = false;

            this.chkUnavailable.AutoSize = true;
            this.chkUnavailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.chkUnavailable.Checked = true;
            this.chkUnavailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUnavailable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkUnavailable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.chkUnavailable.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.chkUnavailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkUnavailable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnavailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.chkUnavailable.Location = new System.Drawing.Point(20, 378);
            this.chkUnavailable.Name = "chkUnavailable";
            this.chkUnavailable.Size = new System.Drawing.Size(108, 23);
            this.chkUnavailable.TabIndex = 12;
            this.chkUnavailable.Text = "Unavailable";
            this.chkUnavailable.UseVisualStyleBackColor = false;

            this.pnlFilterDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.pnlFilterDivider.Location = new System.Drawing.Point(20, 426);
            this.pnlFilterDivider.Name = "pnlFilterDivider";
            this.pnlFilterDivider.Size = new System.Drawing.Size(170, 1);
            this.pnlFilterDivider.TabIndex = 13;

            this.lblFilterNote.AutoSize = false;
            this.lblFilterNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblFilterNote.Location = new System.Drawing.Point(20, 440);
            this.lblFilterNote.Name = "lblFilterNote";
            this.lblFilterNote.Size = new System.Drawing.Size(170, 40);
            this.lblFilterNote.TabIndex = 14;
            this.lblFilterNote.Text = "Archived books and thesis are hidden.";

            this.pnlResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlResults.Controls.Add(this.pnlSearchInput);
            this.pnlResults.Controls.Add(this.btnSearch);
            this.pnlResults.Controls.Add(this.lblCount);
            this.pnlResults.Controls.Add(this.dgvResults);
            this.pnlResults.Location = new System.Drawing.Point(254, 24);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(472, 660);
            this.pnlResults.TabIndex = 1;

            this.pnlSearchInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.pnlSearchInput.Controls.Add(this.txtSearch);
            this.pnlSearchInput.Location = new System.Drawing.Point(16, 16);
            this.pnlSearchInput.Name = "pnlSearchInput";
            this.pnlSearchInput.Size = new System.Drawing.Size(330, 42);
            this.pnlSearchInput.TabIndex = 0;

            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.txtSearch.Location = new System.Drawing.Point(10, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(310, 25);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "algorithms";

            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearch.Location = new System.Drawing.Point(356, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 42);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.lblCount.AutoSize = false;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblCount.Location = new System.Drawing.Point(260, 78);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(196, 20);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "11 results";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(182)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(182)))), ((int)(((byte)(211)))));
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.ColumnHeadersHeight = 36;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colResultTitle,
                this.colResultAuthor,
                this.colResultStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.dgvResults.Location = new System.Drawing.Point(8, 116);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.RowTemplate.Height = 44;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(456, 534);
            this.dgvResults.TabIndex = 3;
            this.dgvResults.SelectionChanged += new System.EventHandler(this.dgvResults_SelectionChanged);

            this.colResultTitle.HeaderText = "Title";
            this.colResultTitle.Name = "colResultTitle";
            this.colResultTitle.ReadOnly = true;
            this.colResultTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colResultTitle.Width = 220;

            this.colResultAuthor.HeaderText = "Author and section";
            this.colResultAuthor.Name = "colResultAuthor";
            this.colResultAuthor.ReadOnly = true;
            this.colResultAuthor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colResultAuthor.Width = 150;

            this.colResultStatus.HeaderText = "Status";
            this.colResultStatus.Name = "colResultStatus";
            this.colResultStatus.ReadOnly = true;
            this.colResultStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colResultStatus.Width = 86;

            this.pnlDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlDetails.Controls.Add(this.pnlBookDetails);
            this.pnlDetails.Controls.Add(this.pnlThesisDetails);
            this.pnlDetails.Location = new System.Drawing.Point(742, 24);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(434, 660);
            this.pnlDetails.TabIndex = 2;

            this.pnlBookDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlBookDetails.Controls.Add(this.pnlBookCover);
            this.pnlBookDetails.Controls.Add(this.lblBookTitle);
            this.pnlBookDetails.Controls.Add(this.lblBookAuthors);
            this.pnlBookDetails.Controls.Add(this.lblBookIsbn);
            this.pnlBookDetails.Controls.Add(this.chipBookStatus);
            this.pnlBookDetails.Controls.Add(this.lblSynopsisTitle);
            this.pnlBookDetails.Controls.Add(this.lblSynopsis);
            this.pnlBookDetails.Controls.Add(this.lblPublisherCaption);
            this.pnlBookDetails.Controls.Add(this.lblPublisher);
            this.pnlBookDetails.Controls.Add(this.lblYearCaption);
            this.pnlBookDetails.Controls.Add(this.lblYear);
            this.pnlBookDetails.Controls.Add(this.lblPagesCaption);
            this.pnlBookDetails.Controls.Add(this.lblPages);
            this.pnlBookDetails.Controls.Add(this.lblCategoryCaption);
            this.pnlBookDetails.Controls.Add(this.lblCategory);
            this.pnlBookDetails.Controls.Add(this.lblLocationTitle);
            this.pnlBookDetails.Controls.Add(this.pnlMap);
            this.pnlBookDetails.Controls.Add(this.btnEnqueue);
            this.pnlBookDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlBookDetails.Name = "pnlBookDetails";
            this.pnlBookDetails.Size = new System.Drawing.Size(434, 660);
            this.pnlBookDetails.TabIndex = 0;

            this.pnlBookCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.pnlBookCover.Location = new System.Drawing.Point(20, 20);
            this.pnlBookCover.Name = "pnlBookCover";
            this.pnlBookCover.Size = new System.Drawing.Size(96, 134);
            this.pnlBookCover.TabIndex = 0;

            this.lblBookTitle.AutoSize = false;
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblBookTitle.Location = new System.Drawing.Point(134, 18);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(280, 44);
            this.lblBookTitle.TabIndex = 1;
            this.lblBookTitle.Text = "Introduction to Algorithms";

            this.lblBookAuthors.AutoSize = true;
            this.lblBookAuthors.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblBookAuthors.Location = new System.Drawing.Point(134, 66);
            this.lblBookAuthors.Name = "lblBookAuthors";
            this.lblBookAuthors.Size = new System.Drawing.Size(178, 18);
            this.lblBookAuthors.TabIndex = 2;
            this.lblBookAuthors.Text = "Cormen, Leiserson, Rivest, Stein";

            this.lblBookIsbn.AutoSize = true;
            this.lblBookIsbn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookIsbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblBookIsbn.Location = new System.Drawing.Point(134, 88);
            this.lblBookIsbn.Name = "lblBookIsbn";
            this.lblBookIsbn.Size = new System.Drawing.Size(122, 18);
            this.lblBookIsbn.TabIndex = 3;
            this.lblBookIsbn.Text = "ISBN 978-0-262-04630-5";

            this.chipBookStatus.AutoSize = false;
            this.chipBookStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.chipBookStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipBookStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.chipBookStatus.Location = new System.Drawing.Point(134, 112);
            this.chipBookStatus.Name = "chipBookStatus";
            this.chipBookStatus.Size = new System.Drawing.Size(110, 24);
            this.chipBookStatus.TabIndex = 4;
            this.chipBookStatus.Text = "Unavailable";
            this.chipBookStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSynopsisTitle.AutoSize = true;
            this.lblSynopsisTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSynopsisTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblSynopsisTitle.Location = new System.Drawing.Point(20, 176);
            this.lblSynopsisTitle.Name = "lblSynopsisTitle";
            this.lblSynopsisTitle.Size = new System.Drawing.Size(54, 20);
            this.lblSynopsisTitle.TabIndex = 5;
            this.lblSynopsisTitle.Text = "Synopsis";

            this.lblSynopsis.AutoSize = false;
            this.lblSynopsis.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSynopsis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblSynopsis.Location = new System.Drawing.Point(20, 198);
            this.lblSynopsis.Name = "lblSynopsis";
            this.lblSynopsis.Size = new System.Drawing.Size(394, 80);
            this.lblSynopsis.TabIndex = 6;
            this.lblSynopsis.Text = "Covers the design and analysis of algorithms, from sorting and graph methods to dynamic programming, with clear explanations and exercises in every chapter.";

            this.lblPublisherCaption.AutoSize = true;
            this.lblPublisherCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisherCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblPublisherCaption.Location = new System.Drawing.Point(20, 300);
            this.lblPublisherCaption.Name = "lblPublisherCaption";
            this.lblPublisherCaption.Size = new System.Drawing.Size(50, 18);
            this.lblPublisherCaption.TabIndex = 7;
            this.lblPublisherCaption.Text = "Publisher";

            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblPublisher.Location = new System.Drawing.Point(20, 320);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(88, 20);
            this.lblPublisher.TabIndex = 8;
            this.lblPublisher.Text = "The MIT Press";

            this.lblYearCaption.AutoSize = true;
            this.lblYearCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblYearCaption.Location = new System.Drawing.Point(220, 300);
            this.lblYearCaption.Name = "lblYearCaption";
            this.lblYearCaption.Size = new System.Drawing.Size(78, 18);
            this.lblYearCaption.TabIndex = 9;
            this.lblYearCaption.Text = "Year published";

            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblYear.Location = new System.Drawing.Point(220, 320);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(27, 20);
            this.lblYear.TabIndex = 10;
            this.lblYear.Text = "2022";

            this.lblPagesCaption.AutoSize = true;
            this.lblPagesCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagesCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblPagesCaption.Location = new System.Drawing.Point(20, 346);
            this.lblPagesCaption.Name = "lblPagesCaption";
            this.lblPagesCaption.Size = new System.Drawing.Size(27, 18);
            this.lblPagesCaption.TabIndex = 11;
            this.lblPagesCaption.Text = "Pages";

            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblPages.Location = new System.Drawing.Point(20, 366);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(34, 20);
            this.lblPages.TabIndex = 12;
            this.lblPages.Text = "1,312";

            this.lblCategoryCaption.AutoSize = true;
            this.lblCategoryCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblCategoryCaption.Location = new System.Drawing.Point(220, 346);
            this.lblCategoryCaption.Name = "lblCategoryCaption";
            this.lblCategoryCaption.Size = new System.Drawing.Size(44, 18);
            this.lblCategoryCaption.TabIndex = 13;
            this.lblCategoryCaption.Text = "Category";

            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblCategory.Location = new System.Drawing.Point(220, 366);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(143, 20);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "Computer Science (QA)";

            this.lblLocationTitle.AutoSize = true;
            this.lblLocationTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblLocationTitle.Location = new System.Drawing.Point(20, 404);
            this.lblLocationTitle.Name = "lblLocationTitle";
            this.lblLocationTitle.Size = new System.Drawing.Size(129, 20);
            this.lblLocationTitle.TabIndex = 15;
            this.lblLocationTitle.Text = "Location in library";

            this.pnlMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.pnlMap.Controls.Add(this.lblMapFilipiniana);
            this.pnlMap.Controls.Add(this.lblMapReference);
            this.pnlMap.Controls.Add(this.lblMapCirculation);
            this.pnlMap.Controls.Add(this.lblMapReserved);
            this.pnlMap.Location = new System.Drawing.Point(20, 424);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(394, 150);
            this.pnlMap.TabIndex = 16;

            this.lblMapFilipiniana.AutoSize = false;
            this.lblMapFilipiniana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.lblMapFilipiniana.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapFilipiniana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblMapFilipiniana.Location = new System.Drawing.Point(13, 8);
            this.lblMapFilipiniana.Name = "lblMapFilipiniana";
            this.lblMapFilipiniana.Padding = new System.Windows.Forms.Padding(6, 4, 0, 0);
            this.lblMapFilipiniana.Size = new System.Drawing.Size(141, 55);
            this.lblMapFilipiniana.TabIndex = 0;
            this.lblMapFilipiniana.Text = "Filipiniana";
            this.lblMapFilipiniana.TextAlign = System.Drawing.ContentAlignment.TopLeft;

            this.lblMapReference.AutoSize = false;
            this.lblMapReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.lblMapReference.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblMapReference.Location = new System.Drawing.Point(259, 8);
            this.lblMapReference.Name = "lblMapReference";
            this.lblMapReference.Padding = new System.Windows.Forms.Padding(6, 4, 0, 0);
            this.lblMapReference.Size = new System.Drawing.Size(122, 55);
            this.lblMapReference.TabIndex = 1;
            this.lblMapReference.Text = "Reference";
            this.lblMapReference.TextAlign = System.Drawing.ContentAlignment.TopLeft;

            this.lblMapCirculation.AutoSize = false;
            this.lblMapCirculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.lblMapCirculation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapCirculation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblMapCirculation.Location = new System.Drawing.Point(13, 73);
            this.lblMapCirculation.Name = "lblMapCirculation";
            this.lblMapCirculation.Padding = new System.Windows.Forms.Padding(6, 4, 0, 0);
            this.lblMapCirculation.Size = new System.Drawing.Size(246, 64);
            this.lblMapCirculation.TabIndex = 2;
            this.lblMapCirculation.Text = "Circulation";
            this.lblMapCirculation.TextAlign = System.Drawing.ContentAlignment.TopLeft;

            this.lblMapReserved.AutoSize = false;
            this.lblMapReserved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.lblMapReserved.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapReserved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblMapReserved.Location = new System.Drawing.Point(274, 73);
            this.lblMapReserved.Name = "lblMapReserved";
            this.lblMapReserved.Padding = new System.Windows.Forms.Padding(6, 4, 0, 0);
            this.lblMapReserved.Size = new System.Drawing.Size(107, 64);
            this.lblMapReserved.TabIndex = 3;
            this.lblMapReserved.Text = "Reserved";
            this.lblMapReserved.TextAlign = System.Drawing.ContentAlignment.TopLeft;

            this.btnEnqueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnEnqueue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnqueue.FlatAppearance.BorderSize = 0;
            this.btnEnqueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnqueue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnqueue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEnqueue.Location = new System.Drawing.Point(20, 596);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(394, 46);
            this.btnEnqueue.TabIndex = 17;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = false;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);

            this.pnlThesisDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlThesisDetails.Controls.Add(this.lblThesisTitle);
            this.pnlThesisDetails.Controls.Add(this.chipThesis);
            this.pnlThesisDetails.Controls.Add(this.lblAbstractTitle);
            this.pnlThesisDetails.Controls.Add(this.lblAbstract);
            this.pnlThesisDetails.Controls.Add(this.picQr);
            this.pnlThesisDetails.Controls.Add(this.lblQrTitle);
            this.pnlThesisDetails.Controls.Add(this.lblQrHint);
            this.pnlThesisDetails.Controls.Add(this.lblFileLinkCaption);
            this.pnlThesisDetails.Controls.Add(this.lblFileLink);
            this.pnlThesisDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlThesisDetails.Name = "pnlThesisDetails";
            this.pnlThesisDetails.Size = new System.Drawing.Size(434, 660);
            this.pnlThesisDetails.TabIndex = 1;
            this.pnlThesisDetails.Visible = false;

            this.lblThesisTitle.AutoSize = false;
            this.lblThesisTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThesisTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblThesisTitle.Location = new System.Drawing.Point(20, 20);
            this.lblThesisTitle.Name = "lblThesisTitle";
            this.lblThesisTitle.Size = new System.Drawing.Size(394, 50);
            this.lblThesisTitle.TabIndex = 0;
            this.lblThesisTitle.Text = "Barcode-Based Attendance Monitoring System";

            this.chipThesis.AutoSize = false;
            this.chipThesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.chipThesis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipThesis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.chipThesis.Location = new System.Drawing.Point(20, 78);
            this.chipThesis.Name = "chipThesis";
            this.chipThesis.Size = new System.Drawing.Size(90, 24);
            this.chipThesis.TabIndex = 1;
            this.chipThesis.Text = "Thesis";
            this.chipThesis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblAbstractTitle.AutoSize = true;
            this.lblAbstractTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstractTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblAbstractTitle.Location = new System.Drawing.Point(20, 120);
            this.lblAbstractTitle.Name = "lblAbstractTitle";
            this.lblAbstractTitle.Size = new System.Drawing.Size(54, 20);
            this.lblAbstractTitle.TabIndex = 2;
            this.lblAbstractTitle.Text = "Abstract";

            this.lblAbstract.AutoSize = false;
            this.lblAbstract.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblAbstract.Location = new System.Drawing.Point(20, 142);
            this.lblAbstract.Name = "lblAbstract";
            this.lblAbstract.Size = new System.Drawing.Size(394, 120);
            this.lblAbstract.TabIndex = 3;
            this.lblAbstract.Text = "This study designed and tested a barcode-based system that records student attendance during classes. Results showed faster check-in, fewer encoding errors, and positive feedback from teachers and students.";

            this.picQr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.picQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQr.TabStop = false;
            this.picQr.Location = new System.Drawing.Point(20, 290);
            this.picQr.Name = "picQr";
            this.picQr.Size = new System.Drawing.Size(158, 158);
            this.picQr.TabIndex = 4;

            this.lblQrTitle.AutoSize = true;
            this.lblQrTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQrTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblQrTitle.Location = new System.Drawing.Point(196, 296);
            this.lblQrTitle.Name = "lblQrTitle";
            this.lblQrTitle.Size = new System.Drawing.Size(47, 20);
            this.lblQrTitle.TabIndex = 5;
            this.lblQrTitle.Text = "QR code";

            this.lblQrHint.AutoSize = false;
            this.lblQrHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQrHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblQrHint.Location = new System.Drawing.Point(196, 320);
            this.lblQrHint.Name = "lblQrHint";
            this.lblQrHint.Size = new System.Drawing.Size(190, 40);
            this.lblQrHint.TabIndex = 6;
            this.lblQrHint.Text = "Scan to open the thesis file on your phone.";

            this.lblFileLinkCaption.AutoSize = true;
            this.lblFileLinkCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileLinkCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblFileLinkCaption.Location = new System.Drawing.Point(196, 386);
            this.lblFileLinkCaption.Name = "lblFileLinkCaption";
            this.lblFileLinkCaption.Size = new System.Drawing.Size(50, 18);
            this.lblFileLinkCaption.TabIndex = 7;
            this.lblFileLinkCaption.Text = "File link";

            this.lblFileLink.AutoSize = true;
            this.lblFileLink.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.lblFileLink.Location = new System.Drawing.Point(196, 404);
            this.lblFileLink.Name = "lblFileLink";
            this.lblFileLink.Size = new System.Drawing.Size(102, 20);
            this.lblFileLink.TabIndex = 8;
            this.lblFileLink.Text = "TH-2024-018.pdf";

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.pnlFilters);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.Name = "BrowsePage";
            this.Size = new System.Drawing.Size(1204, 708);
            this.pnlThesisDetails.ResumeLayout(false);
            this.pnlMap.ResumeLayout(false);
            this.pnlBookDetails.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlSearchInput.ResumeLayout(false);
            this.pnlResults.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQr)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblFiltersTitle;
        private System.Windows.Forms.Label lblTypeCaption;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoBooks;
        private System.Windows.Forms.RadioButton rdoThesis;
        private System.Windows.Forms.Label lblSectionCaption;
        private System.Windows.Forms.CheckBox chkFilipiniana;
        private System.Windows.Forms.CheckBox chkCirculation;
        private System.Windows.Forms.CheckBox chkReference;
        private System.Windows.Forms.CheckBox chkReserved;
        private System.Windows.Forms.Label lblStatusCaption;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.CheckBox chkUnavailable;
        private System.Windows.Forms.Panel pnlFilterDivider;
        private System.Windows.Forms.Label lblFilterNote;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Panel pnlSearchInput;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlBookDetails;
        private System.Windows.Forms.Panel pnlBookCover;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookAuthors;
        private System.Windows.Forms.Label lblBookIsbn;
        private System.Windows.Forms.Label chipBookStatus;
        private System.Windows.Forms.Label lblSynopsisTitle;
        private System.Windows.Forms.Label lblSynopsis;
        private System.Windows.Forms.Label lblPublisherCaption;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblYearCaption;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPagesCaption;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblCategoryCaption;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblLocationTitle;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.Label lblMapFilipiniana;
        private System.Windows.Forms.Label lblMapReference;
        private System.Windows.Forms.Label lblMapCirculation;
        private System.Windows.Forms.Label lblMapReserved;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.Panel pnlThesisDetails;
        private System.Windows.Forms.Label lblThesisTitle;
        private System.Windows.Forms.Label chipThesis;
        private System.Windows.Forms.Label lblAbstractTitle;
        private System.Windows.Forms.Label lblAbstract;
        private System.Windows.Forms.PictureBox picQr;
        private System.Windows.Forms.Label lblQrTitle;
        private System.Windows.Forms.Label lblQrHint;
        private System.Windows.Forms.Label lblFileLinkCaption;
        private System.Windows.Forms.Label lblFileLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultStatus;
    }
}