namespace BooklatForms
{
    partial class ManagePage
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
            this.pnlManageLogin = new System.Windows.Forms.Panel();
            this.pnlUsernameInput = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlPasswordInput = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.chipPermission = new System.Windows.Forms.Label();
            this.lblLoginMessage = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pnlGroupBooks = new System.Windows.Forms.Panel();
            this.tileGroupBooks = new System.Windows.Forms.Panel();
            this.lblGroupBooks = new System.Windows.Forms.Label();
            this.pnlGroupDividerBooks = new System.Windows.Forms.Panel();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.pnlGroupThesis = new System.Windows.Forms.Panel();
            this.tileGroupThesis = new System.Windows.Forms.Panel();
            this.lblGroupThesis = new System.Windows.Forms.Label();
            this.pnlGroupDividerThesis = new System.Windows.Forms.Panel();
            this.btnAddThesis = new System.Windows.Forms.Button();
            this.btnDeleteThesis = new System.Windows.Forms.Button();
            this.pnlGroupUsers = new System.Windows.Forms.Panel();
            this.tileGroupUsers = new System.Windows.Forms.Panel();
            this.lblGroupUsers = new System.Windows.Forms.Label();
            this.pnlGroupDividerUsers = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.pnlGroupRecords = new System.Windows.Forms.Panel();
            this.tileGroupRecords = new System.Windows.Forms.Panel();
            this.lblGroupRecords = new System.Windows.Forms.Label();
            this.pnlGroupDividerRecords = new System.Windows.Forms.Panel();
            this.btnMonitorRecord = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.pnlManageLogin.SuspendLayout();
            this.pnlUsernameInput.SuspendLayout();
            this.pnlPasswordInput.SuspendLayout();
            this.pnlGroupBooks.SuspendLayout();
            this.pnlGroupThesis.SuspendLayout();
            this.pnlGroupUsers.SuspendLayout();
            this.pnlGroupRecords.SuspendLayout();
            this.SuspendLayout();

            this.pnlManageLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlManageLogin.Controls.Add(this.pnlUsernameInput);
            this.pnlManageLogin.Controls.Add(this.pnlPasswordInput);
            this.pnlManageLogin.Controls.Add(this.btnSignIn);
            this.pnlManageLogin.Controls.Add(this.chipPermission);
            this.pnlManageLogin.Controls.Add(this.lblLoginMessage);
            this.pnlManageLogin.Controls.Add(this.btnSignOut);
            this.pnlManageLogin.Location = new System.Drawing.Point(28, 24);
            this.pnlManageLogin.Name = "pnlManageLogin";
            this.pnlManageLogin.Size = new System.Drawing.Size(1148, 76);
            this.pnlManageLogin.TabIndex = 0;

            this.pnlUsernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.pnlUsernameInput.Controls.Add(this.txtUsername);
            this.pnlUsernameInput.Location = new System.Drawing.Point(20, 16);
            this.pnlUsernameInput.Name = "pnlUsernameInput";
            this.pnlUsernameInput.Size = new System.Drawing.Size(240, 44);
            this.pnlUsernameInput.TabIndex = 0;

            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.txtUsername.Location = new System.Drawing.Point(10, 10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 25);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "lreyes";

            this.pnlPasswordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.pnlPasswordInput.Controls.Add(this.txtPassword);
            this.pnlPasswordInput.Location = new System.Drawing.Point(272, 16);
            this.pnlPasswordInput.Name = "pnlPasswordInput";
            this.pnlPasswordInput.Size = new System.Drawing.Size(240, 44);
            this.pnlPasswordInput.TabIndex = 1;

            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.txtPassword.Location = new System.Drawing.Point(10, 10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(220, 25);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Text = "password1";

            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSignIn.Location = new System.Drawing.Point(524, 16);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(120, 44);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);

            this.chipPermission.AutoSize = false;
            this.chipPermission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.chipPermission.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipPermission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.chipPermission.Location = new System.Drawing.Point(668, 24);
            this.chipPermission.Name = "chipPermission";
            this.chipPermission.Size = new System.Drawing.Size(330, 30);
            this.chipPermission.TabIndex = 3;
            this.chipPermission.Text = "Permission confirmed \u00b7 Liza Reyes";
            this.chipPermission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblLoginMessage.AutoSize = false;
            this.lblLoginMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.lblLoginMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.lblLoginMessage.Location = new System.Drawing.Point(668, 16);
            this.lblLoginMessage.Name = "lblLoginMessage";
            this.lblLoginMessage.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblLoginMessage.Size = new System.Drawing.Size(330, 44);
            this.lblLoginMessage.TabIndex = 4;
            this.lblLoginMessage.Text = "User has no permission.";
            this.lblLoginMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLoginMessage.Visible = false;

            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.btnSignOut.FlatAppearance.BorderSize = 1;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnSignOut.Location = new System.Drawing.Point(1020, 16);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(108, 44);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Sign out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);

            this.pnlGroupBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlGroupBooks.Controls.Add(this.tileGroupBooks);
            this.pnlGroupBooks.Controls.Add(this.lblGroupBooks);
            this.pnlGroupBooks.Controls.Add(this.pnlGroupDividerBooks);
            this.pnlGroupBooks.Controls.Add(this.btnAddBook);
            this.pnlGroupBooks.Controls.Add(this.btnDeleteBook);
            this.pnlGroupBooks.Location = new System.Drawing.Point(28, 116);
            this.pnlGroupBooks.Name = "pnlGroupBooks";
            this.pnlGroupBooks.Size = new System.Drawing.Size(275, 568);
            this.pnlGroupBooks.TabIndex = 1;

            this.tileGroupBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.tileGroupBooks.Location = new System.Drawing.Point(20, 14);
            this.tileGroupBooks.Name = "tileGroupBooks";
            this.tileGroupBooks.Size = new System.Drawing.Size(40, 40);
            this.tileGroupBooks.TabIndex = 0;

            this.lblGroupBooks.AutoSize = true;
            this.lblGroupBooks.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblGroupBooks.Location = new System.Drawing.Point(70, 22);
            this.lblGroupBooks.Name = "lblGroupBooks";
            this.lblGroupBooks.Size = new System.Drawing.Size(44, 26);
            this.lblGroupBooks.TabIndex = 1;
            this.lblGroupBooks.Text = "Books";

            this.pnlGroupDividerBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.pnlGroupDividerBooks.Location = new System.Drawing.Point(20, 66);
            this.pnlGroupDividerBooks.Name = "pnlGroupDividerBooks";
            this.pnlGroupDividerBooks.Size = new System.Drawing.Size(235, 1);
            this.pnlGroupDividerBooks.TabIndex = 2;

            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(88)))));
            this.btnAddBook.FlatAppearance.BorderSize = 1;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnAddBook.Location = new System.Drawing.Point(9, 84);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnAddBook.Size = new System.Drawing.Size(257, 84);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Book\r\nNew title and its copies";
            this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);

            this.btnDeleteBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnDeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(88)))));
            this.btnDeleteBook.FlatAppearance.BorderSize = 1;
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnDeleteBook.Location = new System.Drawing.Point(9, 180);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnDeleteBook.Size = new System.Drawing.Size(257, 84);
            this.btnDeleteBook.TabIndex = 4;
            this.btnDeleteBook.Text = "Delete Book\r\nArchive a title";
            this.btnDeleteBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);

            this.pnlGroupThesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlGroupThesis.Controls.Add(this.tileGroupThesis);
            this.pnlGroupThesis.Controls.Add(this.lblGroupThesis);
            this.pnlGroupThesis.Controls.Add(this.pnlGroupDividerThesis);
            this.pnlGroupThesis.Controls.Add(this.btnAddThesis);
            this.pnlGroupThesis.Controls.Add(this.btnDeleteThesis);
            this.pnlGroupThesis.Location = new System.Drawing.Point(319, 116);
            this.pnlGroupThesis.Name = "pnlGroupThesis";
            this.pnlGroupThesis.Size = new System.Drawing.Size(275, 568);
            this.pnlGroupThesis.TabIndex = 2;

            this.tileGroupThesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.tileGroupThesis.Location = new System.Drawing.Point(20, 14);
            this.tileGroupThesis.Name = "tileGroupThesis";
            this.tileGroupThesis.Size = new System.Drawing.Size(40, 40);
            this.tileGroupThesis.TabIndex = 0;

            this.lblGroupThesis.AutoSize = true;
            this.lblGroupThesis.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupThesis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblGroupThesis.Location = new System.Drawing.Point(70, 22);
            this.lblGroupThesis.Name = "lblGroupThesis";
            this.lblGroupThesis.Size = new System.Drawing.Size(53, 26);
            this.lblGroupThesis.TabIndex = 1;
            this.lblGroupThesis.Text = "Thesis";

            this.pnlGroupDividerThesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.pnlGroupDividerThesis.Location = new System.Drawing.Point(20, 66);
            this.pnlGroupDividerThesis.Name = "pnlGroupDividerThesis";
            this.pnlGroupDividerThesis.Size = new System.Drawing.Size(235, 1);
            this.pnlGroupDividerThesis.TabIndex = 2;

            this.btnAddThesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnAddThesis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddThesis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(88)))));
            this.btnAddThesis.FlatAppearance.BorderSize = 1;
            this.btnAddThesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddThesis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddThesis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnAddThesis.Location = new System.Drawing.Point(9, 84);
            this.btnAddThesis.Name = "btnAddThesis";
            this.btnAddThesis.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnAddThesis.Size = new System.Drawing.Size(257, 84);
            this.btnAddThesis.TabIndex = 3;
            this.btnAddThesis.Text = "Add Thesis\r\nTitle, abstract, file link";
            this.btnAddThesis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddThesis.UseVisualStyleBackColor = false;
            this.btnAddThesis.Click += new System.EventHandler(this.btnAddThesis_Click);

            this.btnDeleteThesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnDeleteThesis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteThesis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(88)))));
            this.btnDeleteThesis.FlatAppearance.BorderSize = 1;
            this.btnDeleteThesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteThesis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteThesis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnDeleteThesis.Location = new System.Drawing.Point(9, 180);
            this.btnDeleteThesis.Name = "btnDeleteThesis";
            this.btnDeleteThesis.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnDeleteThesis.Size = new System.Drawing.Size(257, 84);
            this.btnDeleteThesis.TabIndex = 4;
            this.btnDeleteThesis.Text = "Delete Thesis\r\nArchive a thesis";
            this.btnDeleteThesis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteThesis.UseVisualStyleBackColor = false;
            this.btnDeleteThesis.Click += new System.EventHandler(this.btnDeleteThesis_Click);

            this.pnlGroupUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlGroupUsers.Controls.Add(this.tileGroupUsers);
            this.pnlGroupUsers.Controls.Add(this.lblGroupUsers);
            this.pnlGroupUsers.Controls.Add(this.pnlGroupDividerUsers);
            this.pnlGroupUsers.Controls.Add(this.btnAddUser);
            this.pnlGroupUsers.Controls.Add(this.btnDeleteUser);
            this.pnlGroupUsers.Controls.Add(this.btnSearchUser);
            this.pnlGroupUsers.Controls.Add(this.btnUpdateUser);
            this.pnlGroupUsers.Location = new System.Drawing.Point(610, 116);
            this.pnlGroupUsers.Name = "pnlGroupUsers";
            this.pnlGroupUsers.Size = new System.Drawing.Size(275, 568);
            this.pnlGroupUsers.TabIndex = 3;

            this.tileGroupUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.tileGroupUsers.Location = new System.Drawing.Point(20, 14);
            this.tileGroupUsers.Name = "tileGroupUsers";
            this.tileGroupUsers.Size = new System.Drawing.Size(40, 40);
            this.tileGroupUsers.TabIndex = 0;

            this.lblGroupUsers.AutoSize = true;
            this.lblGroupUsers.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblGroupUsers.Location = new System.Drawing.Point(70, 22);
            this.lblGroupUsers.Name = "lblGroupUsers";
            this.lblGroupUsers.Size = new System.Drawing.Size(44, 26);
            this.lblGroupUsers.TabIndex = 1;
            this.lblGroupUsers.Text = "Users";

            this.pnlGroupDividerUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.pnlGroupDividerUsers.Location = new System.Drawing.Point(20, 66);
            this.pnlGroupDividerUsers.Name = "pnlGroupDividerUsers";
            this.pnlGroupDividerUsers.Size = new System.Drawing.Size(235, 1);
            this.pnlGroupDividerUsers.TabIndex = 2;

            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(88)))));
            this.btnAddUser.FlatAppearance.BorderSize = 1;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnAddUser.Location = new System.Drawing.Point(9, 84);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnAddUser.Size = new System.Drawing.Size(257, 84);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User\r\nRegister a borrower";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);

            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(88)))));
            this.btnDeleteUser.FlatAppearance.BorderSize = 1;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnDeleteUser.Location = new System.Drawing.Point(9, 180);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnDeleteUser.Size = new System.Drawing.Size(257, 84);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Delete User\r\nArchive a borrower";
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);

            this.btnSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnSearchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(88)))));
            this.btnSearchUser.FlatAppearance.BorderSize = 1;
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnSearchUser.Location = new System.Drawing.Point(9, 276);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnSearchUser.Size = new System.Drawing.Size(257, 84);
            this.btnSearchUser.TabIndex = 5;
            this.btnSearchUser.Text = "Search User\r\nFind by ID or name";
            this.btnSearchUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchUser.UseVisualStyleBackColor = false;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);

            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(88)))));
            this.btnUpdateUser.FlatAppearance.BorderSize = 1;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnUpdateUser.Location = new System.Drawing.Point(9, 372);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnUpdateUser.Size = new System.Drawing.Size(257, 84);
            this.btnUpdateUser.TabIndex = 6;
            this.btnUpdateUser.Text = "Update User Info\r\nEdit details or role";
            this.btnUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);

            this.pnlGroupRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlGroupRecords.Controls.Add(this.tileGroupRecords);
            this.pnlGroupRecords.Controls.Add(this.lblGroupRecords);
            this.pnlGroupRecords.Controls.Add(this.pnlGroupDividerRecords);
            this.pnlGroupRecords.Controls.Add(this.btnMonitorRecord);
            this.pnlGroupRecords.Controls.Add(this.btnGenerateReport);
            this.pnlGroupRecords.Location = new System.Drawing.Point(901, 116);
            this.pnlGroupRecords.Name = "pnlGroupRecords";
            this.pnlGroupRecords.Size = new System.Drawing.Size(275, 568);
            this.pnlGroupRecords.TabIndex = 4;

            this.tileGroupRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(45)))));
            this.tileGroupRecords.Location = new System.Drawing.Point(20, 14);
            this.tileGroupRecords.Name = "tileGroupRecords";
            this.tileGroupRecords.Size = new System.Drawing.Size(40, 40);
            this.tileGroupRecords.TabIndex = 0;

            this.lblGroupRecords.AutoSize = true;
            this.lblGroupRecords.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.lblGroupRecords.Location = new System.Drawing.Point(70, 22);
            this.lblGroupRecords.Name = "lblGroupRecords";
            this.lblGroupRecords.Size = new System.Drawing.Size(62, 26);
            this.lblGroupRecords.TabIndex = 1;
            this.lblGroupRecords.Text = "Records";

            this.pnlGroupDividerRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.pnlGroupDividerRecords.Location = new System.Drawing.Point(20, 66);
            this.pnlGroupDividerRecords.Name = "pnlGroupDividerRecords";
            this.pnlGroupDividerRecords.Size = new System.Drawing.Size(235, 1);
            this.pnlGroupDividerRecords.TabIndex = 2;

            this.btnMonitorRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnMonitorRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonitorRecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(88)))));
            this.btnMonitorRecord.FlatAppearance.BorderSize = 1;
            this.btnMonitorRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitorRecord.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitorRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnMonitorRecord.Location = new System.Drawing.Point(9, 84);
            this.btnMonitorRecord.Name = "btnMonitorRecord";
            this.btnMonitorRecord.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnMonitorRecord.Size = new System.Drawing.Size(257, 84);
            this.btnMonitorRecord.TabIndex = 3;
            this.btnMonitorRecord.Text = "Monitor Borrowing Record\r\nWho borrowed what, due dates, fines";
            this.btnMonitorRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitorRecord.UseVisualStyleBackColor = false;
            this.btnMonitorRecord.Click += new System.EventHandler(this.btnMonitorRecord_Click);

            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(88)))));
            this.btnGenerateReport.FlatAppearance.BorderSize = 1;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.btnGenerateReport.Location = new System.Drawing.Point(9, 180);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnGenerateReport.Size = new System.Drawing.Size(257, 84);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Generate Report\r\nHoldings, overdue, most borrowed";
            this.btnGenerateReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pnlGroupRecords);
            this.Controls.Add(this.pnlGroupUsers);
            this.Controls.Add(this.pnlGroupThesis);
            this.Controls.Add(this.pnlGroupBooks);
            this.Controls.Add(this.pnlManageLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.Name = "ManagePage";
            this.Size = new System.Drawing.Size(1204, 708);
            this.pnlGroupRecords.ResumeLayout(false);
            this.pnlGroupUsers.ResumeLayout(false);
            this.pnlGroupThesis.ResumeLayout(false);
            this.pnlGroupBooks.ResumeLayout(false);
            this.pnlPasswordInput.ResumeLayout(false);
            this.pnlUsernameInput.ResumeLayout(false);
            this.pnlManageLogin.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlManageLogin;
        private System.Windows.Forms.Panel pnlUsernameInput;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlPasswordInput;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label chipPermission;
        private System.Windows.Forms.Label lblLoginMessage;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel pnlGroupBooks;
        private System.Windows.Forms.Panel tileGroupBooks;
        private System.Windows.Forms.Label lblGroupBooks;
        private System.Windows.Forms.Panel pnlGroupDividerBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Panel pnlGroupThesis;
        private System.Windows.Forms.Panel tileGroupThesis;
        private System.Windows.Forms.Label lblGroupThesis;
        private System.Windows.Forms.Panel pnlGroupDividerThesis;
        private System.Windows.Forms.Button btnAddThesis;
        private System.Windows.Forms.Button btnDeleteThesis;
        private System.Windows.Forms.Panel pnlGroupUsers;
        private System.Windows.Forms.Panel tileGroupUsers;
        private System.Windows.Forms.Label lblGroupUsers;
        private System.Windows.Forms.Panel pnlGroupDividerUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Panel pnlGroupRecords;
        private System.Windows.Forms.Panel tileGroupRecords;
        private System.Windows.Forms.Label lblGroupRecords;
        private System.Windows.Forms.Panel pnlGroupDividerRecords;
        private System.Windows.Forms.Button btnMonitorRecord;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}