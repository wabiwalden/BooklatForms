namespace BooklatForms
{
    partial class MainForm
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
            this.panelRail = new System.Windows.Forms.Panel();
            this.btnNavHome = new System.Windows.Forms.Button();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavBrowse = new System.Windows.Forms.Button();
            this.btnNavScan = new System.Windows.Forms.Button();
            this.btnNavReturn = new System.Windows.Forms.Button();
            this.btnNavManage = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.btnBackToManage = new System.Windows.Forms.Button();
            this.panelHost = new System.Windows.Forms.Panel();
            this.panelRail.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            
            this.panelRail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.panelRail.Controls.Add(this.btnNavHome);
            this.panelRail.Controls.Add(this.btnNavDashboard);
            this.panelRail.Controls.Add(this.btnNavBrowse);
            this.panelRail.Controls.Add(this.btnNavScan);
            this.panelRail.Controls.Add(this.btnNavReturn);
            this.panelRail.Controls.Add(this.btnNavManage);
            this.panelRail.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRail.Location = new System.Drawing.Point(0, 0);
            this.panelRail.Name = "panelRail";
            this.panelRail.Size = new System.Drawing.Size(76, 768);
            this.panelRail.TabIndex = 0;
            
            this.btnNavHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnNavHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavHome.FlatAppearance.BorderSize = 0;
            this.btnNavHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.btnNavHome.Location = new System.Drawing.Point(0, 80);
            this.btnNavHome.Name = "btnNavHome";
            this.btnNavHome.Size = new System.Drawing.Size(76, 66);
            this.btnNavHome.TabIndex = 0;
            this.btnNavHome.Text = "Home";
            this.btnNavHome.UseVisualStyleBackColor = false;
            this.btnNavHome.Click += new System.EventHandler(this.btnNavHome_Click);
            
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.btnNavDashboard.Location = new System.Drawing.Point(0, 158);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(76, 66);
            this.btnNavDashboard.TabIndex = 1;
            this.btnNavDashboard.Text = "Dashboard";
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
            
            this.btnNavBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnNavBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBrowse.FlatAppearance.BorderSize = 0;
            this.btnNavBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.btnNavBrowse.Location = new System.Drawing.Point(0, 236);
            this.btnNavBrowse.Name = "btnNavBrowse";
            this.btnNavBrowse.Size = new System.Drawing.Size(76, 66);
            this.btnNavBrowse.TabIndex = 2;
            this.btnNavBrowse.Text = "Browse";
            this.btnNavBrowse.UseVisualStyleBackColor = false;
            this.btnNavBrowse.Click += new System.EventHandler(this.btnNavBrowse_Click);
            
            this.btnNavScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnNavScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavScan.FlatAppearance.BorderSize = 0;
            this.btnNavScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavScan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavScan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.btnNavScan.Location = new System.Drawing.Point(0, 314);
            this.btnNavScan.Name = "btnNavScan";
            this.btnNavScan.Size = new System.Drawing.Size(76, 66);
            this.btnNavScan.TabIndex = 3;
            this.btnNavScan.Text = "Scan";
            this.btnNavScan.UseVisualStyleBackColor = false;
            this.btnNavScan.Click += new System.EventHandler(this.btnNavScan_Click);
            
            this.btnNavReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnNavReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavReturn.FlatAppearance.BorderSize = 0;
            this.btnNavReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReturn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.btnNavReturn.Location = new System.Drawing.Point(0, 392);
            this.btnNavReturn.Name = "btnNavReturn";
            this.btnNavReturn.Size = new System.Drawing.Size(76, 66);
            this.btnNavReturn.TabIndex = 4;
            this.btnNavReturn.Text = "Return";
            this.btnNavReturn.UseVisualStyleBackColor = false;
            this.btnNavReturn.Click += new System.EventHandler(this.btnNavReturn_Click);
            
            this.btnNavManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnNavManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavManage.FlatAppearance.BorderSize = 0;
            this.btnNavManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavManage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.btnNavManage.Location = new System.Drawing.Point(0, 470);
            this.btnNavManage.Name = "btnNavManage";
            this.btnNavManage.Size = new System.Drawing.Size(76, 66);
            this.btnNavManage.TabIndex = 5;
            this.btnNavManage.Text = "Manage";
            this.btnNavManage.UseVisualStyleBackColor = false;
            this.btnNavManage.Click += new System.EventHandler(this.btnNavManage_Click);
            
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblSubtitle);
            this.panelTop.Controls.Add(this.lblStaff);
            this.panelTop.Controls.Add(this.btnBackToManage);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(76, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1204, 60);
            this.panelTop.TabIndex = 1;
            
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(28, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(32, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblSubtitle.Location = new System.Drawing.Point(29, 38);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(224, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Pick a module to get started";
            
            this.lblStaff.AutoSize = false;
            this.lblStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.lblStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.lblStaff.Location = new System.Drawing.Point(1020, 17);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(160, 28);
            this.lblStaff.TabIndex = 2;
            this.lblStaff.Text = "Liza Reyes \u00b7 Librarian";
            this.lblStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStaff.Visible = false;
            
            this.btnBackToManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnBackToManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToManage.FlatAppearance.BorderSize = 1;
            this.btnBackToManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.btnBackToManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToManage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnBackToManage.Location = new System.Drawing.Point(800, 12);
            this.btnBackToManage.Name = "btnBackToManage";
            this.btnBackToManage.Size = new System.Drawing.Size(190, 36);
            this.btnBackToManage.TabIndex = 3;
            this.btnBackToManage.Text = "Back to Manage Menu";
            this.btnBackToManage.UseVisualStyleBackColor = false;
            this.btnBackToManage.Visible = false;
            this.btnBackToManage.Click += new System.EventHandler(this.btnBackToManage_Click);
            
            this.panelHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.panelHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHost.Location = new System.Drawing.Point(76, 60);
            this.panelHost.Name = "panelHost";
            this.panelHost.Size = new System.Drawing.Size(1204, 708);
            this.panelHost.TabIndex = 2;
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.panelHost);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelRail);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booklat \u2013 Library Management System";
            this.panelTop.ResumeLayout(false);
            this.panelRail.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelRail;
        private System.Windows.Forms.Button btnNavHome;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavBrowse;
        private System.Windows.Forms.Button btnNavScan;
        private System.Windows.Forms.Button btnNavReturn;
        private System.Windows.Forms.Button btnNavManage;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Button btnBackToManage;
        private System.Windows.Forms.Panel panelHost;
    }
}
