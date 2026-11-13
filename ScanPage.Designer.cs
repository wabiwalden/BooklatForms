namespace BooklatForms
{
    partial class ScanPage
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
            this.pnlCamera = new System.Windows.Forms.Panel();
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.pnlCameraSelect = new System.Windows.Forms.Panel();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.btnStartScanner = new System.Windows.Forms.Button();
            this.btnStopScanner = new System.Windows.Forms.Button();
            this.lblScanHint = new System.Windows.Forms.Label();
            this.pnlScanResult = new System.Windows.Forms.Panel();
            this.chipScanResult = new System.Windows.Forms.Label();
            this.pnlScanCover = new System.Windows.Forms.Panel();
            this.lblScanBookTitle = new System.Windows.Forms.Label();
            this.lblScanAuthor = new System.Windows.Forms.Label();
            this.lblScanIsbn = new System.Windows.Forms.Label();
            this.chipScanStatus = new System.Windows.Forms.Label();
            this.pnlScanDivider = new System.Windows.Forms.Panel();
            this.lblScanSynopsisTitle = new System.Windows.Forms.Label();
            this.lblScanSynopsis = new System.Windows.Forms.Label();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.btnScanAnother = new System.Windows.Forms.Button();
            this.lblScanMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            this.pnlCamera.SuspendLayout();
            this.pnlCameraSelect.SuspendLayout();
            this.pnlScanResult.SuspendLayout();
            this.SuspendLayout();

            this.pnlCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlCamera.Controls.Add(this.picCamera);
            this.pnlCamera.Controls.Add(this.pnlCameraSelect);
            this.pnlCamera.Controls.Add(this.btnStartScanner);
            this.pnlCamera.Controls.Add(this.btnStopScanner);
            this.pnlCamera.Controls.Add(this.lblScanHint);
            this.pnlCamera.Location = new System.Drawing.Point(28, 24);
            this.pnlCamera.Name = "pnlCamera";
            this.pnlCamera.Size = new System.Drawing.Size(736, 660);
            this.pnlCamera.TabIndex = 0;

            this.picCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
            this.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamera.TabStop = false;
            this.picCamera.Location = new System.Drawing.Point(18, 20);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(700, 500);
            this.picCamera.TabIndex = 0;

            this.pnlCameraSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.pnlCameraSelect.Controls.Add(this.cboCamera);
            this.pnlCameraSelect.Location = new System.Drawing.Point(18, 540);
            this.pnlCameraSelect.Name = "pnlCameraSelect";
            this.pnlCameraSelect.Size = new System.Drawing.Size(300, 44);
            this.pnlCameraSelect.TabIndex = 1;

            this.cboCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.cboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCamera.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Items.AddRange(new object[] {
            "Integrated Webcam",
            "USB Camera"});
            this.cboCamera.Location = new System.Drawing.Point(8, 8);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(284, 25);
            this.cboCamera.TabIndex = 0;

            this.btnStartScanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnStartScanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartScanner.FlatAppearance.BorderSize = 0;
            this.btnStartScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartScanner.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartScanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStartScanner.Location = new System.Drawing.Point(330, 540);
            this.btnStartScanner.Name = "btnStartScanner";
            this.btnStartScanner.Size = new System.Drawing.Size(150, 44);
            this.btnStartScanner.TabIndex = 2;
            this.btnStartScanner.Text = "Start scanner";
            this.btnStartScanner.UseVisualStyleBackColor = false;
            this.btnStartScanner.Click += new System.EventHandler(this.btnStartScanner_Click);

            this.btnStopScanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnStopScanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopScanner.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.btnStopScanner.FlatAppearance.BorderSize = 1;
            this.btnStopScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopScanner.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopScanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnStopScanner.Location = new System.Drawing.Point(492, 540);
            this.btnStopScanner.Name = "btnStopScanner";
            this.btnStopScanner.Size = new System.Drawing.Size(100, 44);
            this.btnStopScanner.TabIndex = 3;
            this.btnStopScanner.Text = "Stop";
            this.btnStopScanner.UseVisualStyleBackColor = false;
            this.btnStopScanner.Click += new System.EventHandler(this.btnStopScanner_Click);

            this.lblScanHint.AutoSize = true;
            this.lblScanHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblScanHint.Location = new System.Drawing.Point(18, 598);
            this.lblScanHint.Name = "lblScanHint";
            this.lblScanHint.Size = new System.Drawing.Size(251, 18);
            this.lblScanHint.TabIndex = 4;
            this.lblScanHint.Text = "Hold the barcode or QR code inside the frame.";

            this.pnlScanResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlScanResult.Controls.Add(this.chipScanResult);
            this.pnlScanResult.Controls.Add(this.pnlScanCover);
            this.pnlScanResult.Controls.Add(this.lblScanBookTitle);
            this.pnlScanResult.Controls.Add(this.lblScanAuthor);
            this.pnlScanResult.Controls.Add(this.lblScanIsbn);
            this.pnlScanResult.Controls.Add(this.chipScanStatus);
            this.pnlScanResult.Controls.Add(this.pnlScanDivider);
            this.pnlScanResult.Controls.Add(this.lblScanSynopsisTitle);
            this.pnlScanResult.Controls.Add(this.lblScanSynopsis);
            this.pnlScanResult.Controls.Add(this.btnEnqueue);
            this.pnlScanResult.Controls.Add(this.btnScanAnother);
            this.pnlScanResult.Controls.Add(this.lblScanMessage);
            this.pnlScanResult.Location = new System.Drawing.Point(780, 24);
            this.pnlScanResult.Name = "pnlScanResult";
            this.pnlScanResult.Size = new System.Drawing.Size(396, 660);
            this.pnlScanResult.TabIndex = 1;

            this.chipScanResult.AutoSize = false;
            this.chipScanResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.chipScanResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipScanResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.chipScanResult.Location = new System.Drawing.Point(22, 20);
            this.chipScanResult.Name = "chipScanResult";
            this.chipScanResult.Size = new System.Drawing.Size(110, 24);
            this.chipScanResult.TabIndex = 0;
            this.chipScanResult.Text = "Scan result";
            this.chipScanResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlScanCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.pnlScanCover.Location = new System.Drawing.Point(22, 64);
            this.pnlScanCover.Name = "pnlScanCover";
            this.pnlScanCover.Size = new System.Drawing.Size(96, 134);
            this.pnlScanCover.TabIndex = 1;

            this.lblScanBookTitle.AutoSize = true;
            this.lblScanBookTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanBookTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblScanBookTitle.Location = new System.Drawing.Point(136, 62);
            this.lblScanBookTitle.Name = "lblScanBookTitle";
            this.lblScanBookTitle.Size = new System.Drawing.Size(102, 30);
            this.lblScanBookTitle.TabIndex = 2;
            this.lblScanBookTitle.Text = "Clean Code";

            this.lblScanAuthor.AutoSize = true;
            this.lblScanAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblScanAuthor.Location = new System.Drawing.Point(136, 94);
            this.lblScanAuthor.Name = "lblScanAuthor";
            this.lblScanAuthor.Size = new System.Drawing.Size(89, 18);
            this.lblScanAuthor.TabIndex = 3;
            this.lblScanAuthor.Text = "Robert C. Martin";

            this.lblScanIsbn.AutoSize = true;
            this.lblScanIsbn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanIsbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblScanIsbn.Location = new System.Drawing.Point(136, 118);
            this.lblScanIsbn.Name = "lblScanIsbn";
            this.lblScanIsbn.Size = new System.Drawing.Size(122, 18);
            this.lblScanIsbn.TabIndex = 4;
            this.lblScanIsbn.Text = "ISBN 978-0-13-235088-4";

            this.chipScanStatus.AutoSize = false;
            this.chipScanStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.chipScanStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipScanStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.chipScanStatus.Location = new System.Drawing.Point(136, 148);
            this.chipScanStatus.Name = "chipScanStatus";
            this.chipScanStatus.Size = new System.Drawing.Size(110, 24);
            this.chipScanStatus.TabIndex = 5;
            this.chipScanStatus.Text = "Available";
            this.chipScanStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlScanDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.pnlScanDivider.Location = new System.Drawing.Point(22, 222);
            this.pnlScanDivider.Name = "pnlScanDivider";
            this.pnlScanDivider.Size = new System.Drawing.Size(352, 1);
            this.pnlScanDivider.TabIndex = 6;

            this.lblScanSynopsisTitle.AutoSize = true;
            this.lblScanSynopsisTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanSynopsisTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblScanSynopsisTitle.Location = new System.Drawing.Point(22, 238);
            this.lblScanSynopsisTitle.Name = "lblScanSynopsisTitle";
            this.lblScanSynopsisTitle.Size = new System.Drawing.Size(54, 20);
            this.lblScanSynopsisTitle.TabIndex = 7;
            this.lblScanSynopsisTitle.Text = "Synopsis";

            this.lblScanSynopsis.AutoSize = false;
            this.lblScanSynopsis.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanSynopsis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblScanSynopsis.Location = new System.Drawing.Point(22, 262);
            this.lblScanSynopsis.Name = "lblScanSynopsis";
            this.lblScanSynopsis.Size = new System.Drawing.Size(352, 100);
            this.lblScanSynopsis.TabIndex = 8;
            this.lblScanSynopsis.Text = "A handbook of agile software craftsmanship that shows how to write readable, maintainable code through practical examples.";

            this.btnEnqueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnEnqueue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnqueue.FlatAppearance.BorderSize = 0;
            this.btnEnqueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnqueue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnqueue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEnqueue.Location = new System.Drawing.Point(22, 400);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(352, 48);
            this.btnEnqueue.TabIndex = 9;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = false;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);

            this.btnScanAnother.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnScanAnother.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScanAnother.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.btnScanAnother.FlatAppearance.BorderSize = 1;
            this.btnScanAnother.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanAnother.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanAnother.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnScanAnother.Location = new System.Drawing.Point(22, 460);
            this.btnScanAnother.Name = "btnScanAnother";
            this.btnScanAnother.Size = new System.Drawing.Size(352, 44);
            this.btnScanAnother.TabIndex = 10;
            this.btnScanAnother.Text = "Scan another";
            this.btnScanAnother.UseVisualStyleBackColor = false;
            this.btnScanAnother.Click += new System.EventHandler(this.btnScanAnother_Click);

            this.lblScanMessage.AutoSize = false;
            this.lblScanMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.lblScanMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.lblScanMessage.Location = new System.Drawing.Point(22, 590);
            this.lblScanMessage.Name = "lblScanMessage";
            this.lblScanMessage.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblScanMessage.Size = new System.Drawing.Size(352, 44);
            this.lblScanMessage.TabIndex = 11;
            this.lblScanMessage.Text = "Scan failed. Try again.";
            this.lblScanMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pnlScanResult);
            this.Controls.Add(this.pnlCamera);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.Name = "ScanPage";
            this.Size = new System.Drawing.Size(1204, 708);
            this.pnlScanResult.ResumeLayout(false);
            this.pnlCameraSelect.ResumeLayout(false);
            this.pnlCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCamera;
        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Panel pnlCameraSelect;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Button btnStartScanner;
        private System.Windows.Forms.Button btnStopScanner;
        private System.Windows.Forms.Label lblScanHint;
        private System.Windows.Forms.Panel pnlScanResult;
        private System.Windows.Forms.Label chipScanResult;
        private System.Windows.Forms.Panel pnlScanCover;
        private System.Windows.Forms.Label lblScanBookTitle;
        private System.Windows.Forms.Label lblScanAuthor;
        private System.Windows.Forms.Label lblScanIsbn;
        private System.Windows.Forms.Label chipScanStatus;
        private System.Windows.Forms.Panel pnlScanDivider;
        private System.Windows.Forms.Label lblScanSynopsisTitle;
        private System.Windows.Forms.Label lblScanSynopsis;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.Button btnScanAnother;
        private System.Windows.Forms.Label lblScanMessage;
    }
}