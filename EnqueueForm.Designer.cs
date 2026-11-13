namespace BooklatForms
{
    partial class EnqueueForm
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
            this.tileEnqueue = new System.Windows.Forms.Panel();
            this.lblEnqueueTitle = new System.Windows.Forms.Label();
            this.lblEnqueueBook = new System.Windows.Forms.Label();
            this.pnlHeaderDivider = new System.Windows.Forms.Panel();
            this.lblIdCaption = new System.Windows.Forms.Label();
            this.pnlIdInput = new System.Windows.Forms.Panel();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlBookSummary = new System.Windows.Forms.Panel();
            this.pnlSummaryCover = new System.Windows.Forms.Panel();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.lblSummaryAuthor = new System.Windows.Forms.Label();
            this.lblSummarySection = new System.Windows.Forms.Label();
            this.chipSummaryStatus = new System.Windows.Forms.Label();
            this.lblCheck0 = new System.Windows.Forms.Label();
            this.lblResultCaption0 = new System.Windows.Forms.Label();
            this.lblResultValue0 = new System.Windows.Forms.Label();
            this.lblCheck1 = new System.Windows.Forms.Label();
            this.lblResultCaption1 = new System.Windows.Forms.Label();
            this.lblResultValue1 = new System.Windows.Forms.Label();
            this.lblCheck2 = new System.Windows.Forms.Label();
            this.lblResultCaption2 = new System.Windows.Forms.Label();
            this.lblResultValue2 = new System.Windows.Forms.Label();
            this.lblCheck3 = new System.Windows.Forms.Label();
            this.lblResultCaption3 = new System.Windows.Forms.Label();
            this.lblResultValue3 = new System.Windows.Forms.Label();
            this.pnlQueue = new System.Windows.Forms.Panel();
            this.lblQueueCaption = new System.Windows.Forms.Label();
            this.lblQueueNumber = new System.Windows.Forms.Label();
            this.lblQueueTitle = new System.Windows.Forms.Label();
            this.lblQueueNote = new System.Windows.Forms.Label();
            this.lblEnqueueError = new System.Windows.Forms.Label();
            this.btnBackToBrowse = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlIdInput.SuspendLayout();
            this.pnlBookSummary.SuspendLayout();
            this.pnlQueue.SuspendLayout();
            this.SuspendLayout();

            this.tileEnqueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.tileEnqueue.Location = new System.Drawing.Point(20, 12);
            this.tileEnqueue.Name = "tileEnqueue";
            this.tileEnqueue.Size = new System.Drawing.Size(40, 40);
            this.tileEnqueue.TabIndex = 0;

            this.lblEnqueueTitle.AutoSize = true;
            this.lblEnqueueTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnqueueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblEnqueueTitle.Location = new System.Drawing.Point(70, 10);
            this.lblEnqueueTitle.Name = "lblEnqueueTitle";
            this.lblEnqueueTitle.Size = new System.Drawing.Size(62, 26);
            this.lblEnqueueTitle.TabIndex = 1;
            this.lblEnqueueTitle.Text = "Enqueue";

            this.lblEnqueueBook.AutoSize = true;
            this.lblEnqueueBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnqueueBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblEnqueueBook.Location = new System.Drawing.Point(70, 36);
            this.lblEnqueueBook.Name = "lblEnqueueBook";
            this.lblEnqueueBook.Size = new System.Drawing.Size(223, 18);
            this.lblEnqueueBook.TabIndex = 2;
            this.lblEnqueueBook.Text = "Introduction to Algorithms \u00b7 Unavailable";

            this.pnlHeaderDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.pnlHeaderDivider.Location = new System.Drawing.Point(0, 64);
            this.pnlHeaderDivider.Name = "pnlHeaderDivider";
            this.pnlHeaderDivider.Size = new System.Drawing.Size(760, 1);
            this.pnlHeaderDivider.TabIndex = 3;

            this.lblIdCaption.AutoSize = true;
            this.lblIdCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblIdCaption.Location = new System.Drawing.Point(24, 80);
            this.lblIdCaption.Name = "lblIdCaption";
            this.lblIdCaption.Size = new System.Drawing.Size(189, 18);
            this.lblIdCaption.TabIndex = 4;
            this.lblIdCaption.Text = "Student No. / Employment No. or ID";

            this.pnlIdInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.pnlIdInput.Controls.Add(this.txtUserId);
            this.pnlIdInput.Location = new System.Drawing.Point(24, 102);
            this.pnlIdInput.Name = "pnlIdInput";
            this.pnlIdInput.Size = new System.Drawing.Size(300, 40);
            this.pnlIdInput.TabIndex = 5;

            this.txtUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.txtUserId.Location = new System.Drawing.Point(10, 8);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(280, 25);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.Text = "2023-00123";

            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSubmit.Location = new System.Drawing.Point(24, 158);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(300, 44);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.pnlBookSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.pnlBookSummary.Controls.Add(this.pnlSummaryCover);
            this.pnlBookSummary.Controls.Add(this.lblSummaryTitle);
            this.pnlBookSummary.Controls.Add(this.lblSummaryAuthor);
            this.pnlBookSummary.Controls.Add(this.lblSummarySection);
            this.pnlBookSummary.Controls.Add(this.chipSummaryStatus);
            this.pnlBookSummary.Location = new System.Drawing.Point(24, 228);
            this.pnlBookSummary.Name = "pnlBookSummary";
            this.pnlBookSummary.Size = new System.Drawing.Size(300, 140);
            this.pnlBookSummary.TabIndex = 7;

            this.pnlSummaryCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.pnlSummaryCover.Location = new System.Drawing.Point(14, 14);
            this.pnlSummaryCover.Name = "pnlSummaryCover";
            this.pnlSummaryCover.Size = new System.Drawing.Size(56, 80);
            this.pnlSummaryCover.TabIndex = 0;

            this.lblSummaryTitle.AutoSize = false;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblSummaryTitle.Location = new System.Drawing.Point(82, 14);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(206, 40);
            this.lblSummaryTitle.TabIndex = 1;
            this.lblSummaryTitle.Text = "Introduction to Algorithms";

            this.lblSummaryAuthor.AutoSize = true;
            this.lblSummaryAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblSummaryAuthor.Location = new System.Drawing.Point(82, 56);
            this.lblSummaryAuthor.Name = "lblSummaryAuthor";
            this.lblSummaryAuthor.Size = new System.Drawing.Size(72, 18);
            this.lblSummaryAuthor.TabIndex = 2;
            this.lblSummaryAuthor.Text = "Cormen et al.";

            this.lblSummarySection.AutoSize = true;
            this.lblSummarySection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummarySection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblSummarySection.Location = new System.Drawing.Point(82, 74);
            this.lblSummarySection.Name = "lblSummarySection";
            this.lblSummarySection.Size = new System.Drawing.Size(61, 18);
            this.lblSummarySection.TabIndex = 3;
            this.lblSummarySection.Text = "Circulation";

            this.chipSummaryStatus.AutoSize = false;
            this.chipSummaryStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.chipSummaryStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipSummaryStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.chipSummaryStatus.Location = new System.Drawing.Point(82, 100);
            this.chipSummaryStatus.Name = "chipSummaryStatus";
            this.chipSummaryStatus.Size = new System.Drawing.Size(110, 24);
            this.chipSummaryStatus.TabIndex = 4;
            this.chipSummaryStatus.Text = "Unavailable";
            this.chipSummaryStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblCheck0.AutoSize = false;
            this.lblCheck0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.lblCheck0.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(46)))), ((int)(((byte)(34)))));
            this.lblCheck0.Location = new System.Drawing.Point(348, 84);
            this.lblCheck0.Name = "lblCheck0";
            this.lblCheck0.Size = new System.Drawing.Size(28, 28);
            this.lblCheck0.TabIndex = 8;
            this.lblCheck0.Text = "\u2713";
            this.lblCheck0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblResultCaption0.AutoSize = true;
            this.lblResultCaption0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultCaption0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblResultCaption0.Location = new System.Drawing.Point(392, 80);
            this.lblResultCaption0.Name = "lblResultCaption0";
            this.lblResultCaption0.Size = new System.Drawing.Size(61, 18);
            this.lblResultCaption0.TabIndex = 9;
            this.lblResultCaption0.Text = "Registered?";

            this.lblResultValue0.AutoSize = true;
            this.lblResultValue0.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultValue0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblResultValue0.Location = new System.Drawing.Point(392, 96);
            this.lblResultValue0.Name = "lblResultValue0";
            this.lblResultValue0.Size = new System.Drawing.Size(150, 22);
            this.lblResultValue0.TabIndex = 10;
            this.lblResultValue0.Text = "Yes \u2014 Juan Dela Cruz";

            this.lblCheck1.AutoSize = false;
            this.lblCheck1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.lblCheck1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(46)))), ((int)(((byte)(34)))));
            this.lblCheck1.Location = new System.Drawing.Point(348, 154);
            this.lblCheck1.Name = "lblCheck1";
            this.lblCheck1.Size = new System.Drawing.Size(28, 28);
            this.lblCheck1.TabIndex = 11;
            this.lblCheck1.Text = "\u2713";
            this.lblCheck1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblResultCaption1.AutoSize = true;
            this.lblResultCaption1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblResultCaption1.Location = new System.Drawing.Point(392, 150);
            this.lblResultCaption1.Name = "lblResultCaption1";
            this.lblResultCaption1.Size = new System.Drawing.Size(117, 18);
            this.lblResultCaption1.TabIndex = 12;
            this.lblResultCaption1.Text = "Credit score standing";

            this.lblResultValue1.AutoSize = true;
            this.lblResultValue1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultValue1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblResultValue1.Location = new System.Drawing.Point(392, 166);
            this.lblResultValue1.Name = "lblResultValue1";
            this.lblResultValue1.Size = new System.Drawing.Size(135, 22);
            this.lblResultValue1.TabIndex = 13;
            this.lblResultValue1.Text = "92 \u00b7 Good Standing";

            this.lblCheck2.AutoSize = false;
            this.lblCheck2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.lblCheck2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(46)))), ((int)(((byte)(34)))));
            this.lblCheck2.Location = new System.Drawing.Point(348, 224);
            this.lblCheck2.Name = "lblCheck2";
            this.lblCheck2.Size = new System.Drawing.Size(28, 28);
            this.lblCheck2.TabIndex = 14;
            this.lblCheck2.Text = "\u2713";
            this.lblCheck2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblResultCaption2.AutoSize = true;
            this.lblResultCaption2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultCaption2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblResultCaption2.Location = new System.Drawing.Point(392, 220);
            this.lblResultCaption2.Name = "lblResultCaption2";
            this.lblResultCaption2.Size = new System.Drawing.Size(106, 18);
            this.lblResultCaption2.TabIndex = 15;
            this.lblResultCaption2.Text = "Eligible to borrow?";

            this.lblResultValue2.AutoSize = true;
            this.lblResultValue2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultValue2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblResultValue2.Location = new System.Drawing.Point(392, 236);
            this.lblResultValue2.Name = "lblResultValue2";
            this.lblResultValue2.Size = new System.Drawing.Size(22, 22);
            this.lblResultValue2.TabIndex = 16;
            this.lblResultValue2.Text = "Yes";

            this.lblCheck3.AutoSize = false;
            this.lblCheck3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.lblCheck3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(46)))), ((int)(((byte)(34)))));
            this.lblCheck3.Location = new System.Drawing.Point(348, 294);
            this.lblCheck3.Name = "lblCheck3";
            this.lblCheck3.Size = new System.Drawing.Size(28, 28);
            this.lblCheck3.TabIndex = 17;
            this.lblCheck3.Text = "\u2713";
            this.lblCheck3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblResultCaption3.AutoSize = true;
            this.lblResultCaption3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultCaption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblResultCaption3.Location = new System.Drawing.Point(392, 290);
            this.lblResultCaption3.Name = "lblResultCaption3";
            this.lblResultCaption3.Size = new System.Drawing.Size(117, 18);
            this.lblResultCaption3.TabIndex = 18;
            this.lblResultCaption3.Text = "Added to borrow queue";

            this.lblResultValue3.AutoSize = true;
            this.lblResultValue3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultValue3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblResultValue3.Location = new System.Drawing.Point(392, 306);
            this.lblResultValue3.Name = "lblResultValue3";
            this.lblResultValue3.Size = new System.Drawing.Size(82, 22);
            this.lblResultValue3.TabIndex = 19;
            this.lblResultValue3.Text = "Position #3";

            this.pnlQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(40)))));
            this.pnlQueue.Controls.Add(this.lblQueueCaption);
            this.pnlQueue.Controls.Add(this.lblQueueNumber);
            this.pnlQueue.Controls.Add(this.lblQueueTitle);
            this.pnlQueue.Controls.Add(this.lblQueueNote);
            this.pnlQueue.Location = new System.Drawing.Point(24, 396);
            this.pnlQueue.Name = "pnlQueue";
            this.pnlQueue.Size = new System.Drawing.Size(712, 82);
            this.pnlQueue.TabIndex = 20;

            this.lblQueueCaption.AutoSize = true;
            this.lblQueueCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.lblQueueCaption.Location = new System.Drawing.Point(24, 12);
            this.lblQueueCaption.Name = "lblQueueCaption";
            this.lblQueueCaption.Size = new System.Drawing.Size(78, 18);
            this.lblQueueCaption.TabIndex = 0;
            this.lblQueueCaption.Text = "Queue position";

            this.lblQueueNumber.AutoSize = true;
            this.lblQueueNumber.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.lblQueueNumber.Location = new System.Drawing.Point(24, 28);
            this.lblQueueNumber.Name = "lblQueueNumber";
            this.lblQueueNumber.Size = new System.Drawing.Size(32, 48);
            this.lblQueueNumber.TabIndex = 1;
            this.lblQueueNumber.Text = "#3";

            this.lblQueueTitle.AutoSize = true;
            this.lblQueueTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblQueueTitle.Location = new System.Drawing.Point(110, 16);
            this.lblQueueTitle.Name = "lblQueueTitle";
            this.lblQueueTitle.Size = new System.Drawing.Size(186, 26);
            this.lblQueueTitle.TabIndex = 2;
            this.lblQueueTitle.Text = "You are in the queue.";

            this.lblQueueNote.AutoSize = true;
            this.lblQueueNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(189)))));
            this.lblQueueNote.Location = new System.Drawing.Point(110, 46);
            this.lblQueueNote.Name = "lblQueueNote";
            this.lblQueueNote.Size = new System.Drawing.Size(279, 18);
            this.lblQueueNote.TabIndex = 3;
            this.lblQueueNote.Text = "We will notify you as soon as a copy is available.";

            this.lblEnqueueError.AutoSize = false;
            this.lblEnqueueError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.lblEnqueueError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnqueueError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.lblEnqueueError.Location = new System.Drawing.Point(24, 496);
            this.lblEnqueueError.Name = "lblEnqueueError";
            this.lblEnqueueError.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblEnqueueError.Size = new System.Drawing.Size(360, 36);
            this.lblEnqueueError.TabIndex = 21;
            this.lblEnqueueError.Text = "User not registered.";
            this.lblEnqueueError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnBackToBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnBackToBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.btnBackToBrowse.FlatAppearance.BorderSize = 1;
            this.btnBackToBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToBrowse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnBackToBrowse.Location = new System.Drawing.Point(412, 498);
            this.btnBackToBrowse.Name = "btnBackToBrowse";
            this.btnBackToBrowse.Size = new System.Drawing.Size(160, 42);
            this.btnBackToBrowse.TabIndex = 22;
            this.btnBackToBrowse.Text = "Back to Browse";
            this.btnBackToBrowse.UseVisualStyleBackColor = false;
            this.btnBackToBrowse.Click += new System.EventHandler(this.btnBackToBrowse_Click);

            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(139)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(46)))), ((int)(((byte)(34)))));
            this.btnHome.Location = new System.Drawing.Point(584, 498);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(152, 42);
            this.btnHome.TabIndex = 23;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(760, 560);
            this.Controls.Add(this.tileEnqueue);
            this.Controls.Add(this.lblEnqueueTitle);
            this.Controls.Add(this.lblEnqueueBook);
            this.Controls.Add(this.pnlHeaderDivider);
            this.Controls.Add(this.lblIdCaption);
            this.Controls.Add(this.pnlIdInput);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlBookSummary);
            this.Controls.Add(this.lblCheck0);
            this.Controls.Add(this.lblResultCaption0);
            this.Controls.Add(this.lblResultValue0);
            this.Controls.Add(this.lblCheck1);
            this.Controls.Add(this.lblResultCaption1);
            this.Controls.Add(this.lblResultValue1);
            this.Controls.Add(this.lblCheck2);
            this.Controls.Add(this.lblResultCaption2);
            this.Controls.Add(this.lblResultValue2);
            this.Controls.Add(this.lblCheck3);
            this.Controls.Add(this.lblResultCaption3);
            this.Controls.Add(this.lblResultValue3);
            this.Controls.Add(this.pnlQueue);
            this.Controls.Add(this.lblEnqueueError);
            this.Controls.Add(this.btnBackToBrowse);
            this.Controls.Add(this.btnHome);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnqueueForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enqueue";
            this.pnlQueue.ResumeLayout(false);
            this.pnlBookSummary.ResumeLayout(false);
            this.pnlIdInput.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel tileEnqueue;
        private System.Windows.Forms.Label lblEnqueueTitle;
        private System.Windows.Forms.Label lblEnqueueBook;
        private System.Windows.Forms.Panel pnlHeaderDivider;
        private System.Windows.Forms.Label lblIdCaption;
        private System.Windows.Forms.Panel pnlIdInput;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlBookSummary;
        private System.Windows.Forms.Panel pnlSummaryCover;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Label lblSummaryAuthor;
        private System.Windows.Forms.Label lblSummarySection;
        private System.Windows.Forms.Label chipSummaryStatus;
        private System.Windows.Forms.Label lblCheck0;
        private System.Windows.Forms.Label lblResultCaption0;
        private System.Windows.Forms.Label lblResultValue0;
        private System.Windows.Forms.Label lblCheck1;
        private System.Windows.Forms.Label lblResultCaption1;
        private System.Windows.Forms.Label lblResultValue1;
        private System.Windows.Forms.Label lblCheck2;
        private System.Windows.Forms.Label lblResultCaption2;
        private System.Windows.Forms.Label lblResultValue2;
        private System.Windows.Forms.Label lblCheck3;
        private System.Windows.Forms.Label lblResultCaption3;
        private System.Windows.Forms.Label lblResultValue3;
        private System.Windows.Forms.Panel pnlQueue;
        private System.Windows.Forms.Label lblQueueCaption;
        private System.Windows.Forms.Label lblQueueNumber;
        private System.Windows.Forms.Label lblQueueTitle;
        private System.Windows.Forms.Label lblQueueNote;
        private System.Windows.Forms.Label lblEnqueueError;
        private System.Windows.Forms.Button btnBackToBrowse;
        private System.Windows.Forms.Button btnHome;
    }
}