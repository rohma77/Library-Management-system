namespace LibraryManagementSystem
{
    partial class frmIssue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbctrlBorrowDetails = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBorrowerFullDetails = new System.Windows.Forms.Button();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtBorrowerID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblContactno = new System.Windows.Forms.Label();
            this.lblBorrowerID = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbCId = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbpgBorrowedBook = new System.Windows.Forms.TabPage();
            this.dgvBorrowedBook = new System.Windows.Forms.DataGridView();
            this.btn_Bsave = new System.Windows.Forms.Button();
            this.tbctrlBorrowDetails.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpgBorrowedBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBook)).BeginInit();
            this.SuspendLayout();
            // 
            // tbctrlBorrowDetails
            // 
            this.tbctrlBorrowDetails.Controls.Add(this.tabPage1);
            this.tbctrlBorrowDetails.Controls.Add(this.tbpgBorrowedBook);
            this.tbctrlBorrowDetails.Location = new System.Drawing.Point(2, 0);
            this.tbctrlBorrowDetails.Name = "tbctrlBorrowDetails";
            this.tbctrlBorrowDetails.SelectedIndex = 0;
            this.tbctrlBorrowDetails.Size = new System.Drawing.Size(753, 427);
            this.tbctrlBorrowDetails.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnNew);
            this.tabPage1.Controls.Add(this.btn_Bsave);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(622, 320);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 36);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(515, 320);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 36);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "Clear";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBorrowerFullDetails);
            this.groupBox2.Controls.Add(this.rdofemale);
            this.groupBox2.Controls.Add(this.rdomale);
            this.groupBox2.Controls.Add(this.txtContactNo);
            this.groupBox2.Controls.Add(this.txtBorrowerID);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.lblGender);
            this.groupBox2.Controls.Add(this.lblContactno);
            this.groupBox2.Controls.Add(this.lblBorrowerID);
            this.groupBox2.Controls.Add(this.lblFirstname);
            this.groupBox2.Location = new System.Drawing.Point(382, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 210);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borrowers Details";
            // 
            // btnBorrowerFullDetails
            // 
            this.btnBorrowerFullDetails.Location = new System.Drawing.Point(247, 155);
            this.btnBorrowerFullDetails.Name = "btnBorrowerFullDetails";
            this.btnBorrowerFullDetails.Size = new System.Drawing.Size(75, 23);
            this.btnBorrowerFullDetails.TabIndex = 28;
            this.btnBorrowerFullDetails.Text = "Full Details";
            this.btnBorrowerFullDetails.UseVisualStyleBackColor = true;
            this.btnBorrowerFullDetails.Click += new System.EventHandler(this.btnBorrowerFullDetails_Click);
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(212, 78);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(59, 17);
            this.rdofemale.TabIndex = 22;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(133, 78);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(48, 17);
            this.rdomale.TabIndex = 21;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(133, 103);
            this.txtContactNo.Multiline = true;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(189, 23);
            this.txtContactNo.TabIndex = 23;
            // 
            // txtBorrowerID
            // 
            this.txtBorrowerID.Location = new System.Drawing.Point(133, 19);
            this.txtBorrowerID.Multiline = true;
            this.txtBorrowerID.Name = "txtBorrowerID";
            this.txtBorrowerID.Size = new System.Drawing.Size(189, 23);
            this.txtBorrowerID.TabIndex = 19;
            this.txtBorrowerID.TextChanged += new System.EventHandler(this.txtBorrowerID_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(133, 48);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(189, 23);
            this.txtFirstName.TabIndex = 20;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(58, 80);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(51, 15);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "Gender :";
            // 
            // lblContactno
            // 
            this.lblContactno.AutoSize = true;
            this.lblContactno.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactno.Location = new System.Drawing.Point(35, 105);
            this.lblContactno.Name = "lblContactno";
            this.lblContactno.Size = new System.Drawing.Size(74, 15);
            this.lblContactno.TabIndex = 25;
            this.lblContactno.Text = "Contact No :";
            // 
            // lblBorrowerID
            // 
            this.lblBorrowerID.AutoSize = true;
            this.lblBorrowerID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowerID.Location = new System.Drawing.Point(31, 24);
            this.lblBorrowerID.Name = "lblBorrowerID";
            this.lblBorrowerID.Size = new System.Drawing.Size(78, 15);
            this.lblBorrowerID.TabIndex = 26;
            this.lblBorrowerID.Text = "Borrower ID :";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(66, 48);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(43, 15);
            this.lblFirstname.TabIndex = 27;
            this.lblFirstname.Text = "Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBookId);
            this.groupBox1.Controls.Add(this.dtpReturnDate);
            this.groupBox1.Controls.Add(this.dtpBorrowDate);
            this.groupBox1.Controls.Add(this.dtpPublishDate);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.cmbCId);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.lblReturnDate);
            this.groupBox1.Controls.Add(this.lblBorrowDate);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblPublishDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.txtLanguage);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.lblAuthor);
            this.groupBox1.Controls.Add(this.lblLanguage);
            this.groupBox1.Controls.Add(this.lblBookId);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books Details";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(107, 21);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(195, 20);
            this.txtBookId.TabIndex = 22;
            this.txtBookId.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(107, 338);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(195, 20);
            this.dtpReturnDate.TabIndex = 14;
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Location = new System.Drawing.Point(107, 305);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(195, 20);
            this.dtpBorrowDate.TabIndex = 14;
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Location = new System.Drawing.Point(107, 160);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(195, 20);
            this.dtpPublishDate.TabIndex = 14;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 15;
            this.cmbStatus.Items.AddRange(new object[] {
            "AVAILBALE",
            "BORROWED"});
            this.cmbStatus.Location = new System.Drawing.Point(107, 268);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(195, 23);
            this.cmbStatus.TabIndex = 20;
            // 
            // cmbCId
            // 
            this.cmbCId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCId.FormattingEnabled = true;
            this.cmbCId.ItemHeight = 15;
            this.cmbCId.Location = new System.Drawing.Point(107, 195);
            this.cmbCId.Name = "cmbCId";
            this.cmbCId.Size = new System.Drawing.Size(195, 23);
            this.cmbCId.TabIndex = 15;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 15;
            this.cmbCategory.Location = new System.Drawing.Point(107, 232);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(195, 23);
            this.cmbCategory.TabIndex = 16;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(12, 343);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(77, 15);
            this.lblReturnDate.TabIndex = 17;
            this.lblReturnDate.Text = "Return Date :";
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowDate.Location = new System.Drawing.Point(7, 310);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(80, 15);
            this.lblBorrowDate.TabIndex = 17;
            this.lblBorrowDate.Text = "Borrow Date :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(40, 276);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 15);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Category :";
            // 
            // lblPublishDate
            // 
            this.lblPublishDate.AutoSize = true;
            this.lblPublishDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublishDate.Location = new System.Drawing.Point(6, 165);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(81, 15);
            this.lblPublishDate.TabIndex = 19;
            this.lblPublishDate.Text = "Publish Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Category Id :";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(107, 88);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(195, 23);
            this.txtAuthor.TabIndex = 8;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(107, 123);
            this.txtLanguage.Multiline = true;
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(195, 23);
            this.txtLanguage.TabIndex = 9;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(107, 55);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(195, 23);
            this.txtTitle.TabIndex = 7;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(35, 96);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(52, 15);
            this.lblAuthor.TabIndex = 10;
            this.lblAuthor.Text = "Author :";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(21, 131);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(66, 15);
            this.lblLanguage.TabIndex = 11;
            this.lblLanguage.Text = "Language :";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.Location = new System.Drawing.Point(35, 25);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(55, 15);
            this.lblBookId.TabIndex = 12;
            this.lblBookId.Text = "Book Id :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(52, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 15);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Title :";
            // 
            // tbpgBorrowedBook
            // 
            this.tbpgBorrowedBook.Controls.Add(this.dgvBorrowedBook);
            this.tbpgBorrowedBook.Location = new System.Drawing.Point(4, 22);
            this.tbpgBorrowedBook.Name = "tbpgBorrowedBook";
            this.tbpgBorrowedBook.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgBorrowedBook.Size = new System.Drawing.Size(745, 401);
            this.tbpgBorrowedBook.TabIndex = 1;
            this.tbpgBorrowedBook.Text = "Borrowed Books";
            this.tbpgBorrowedBook.UseVisualStyleBackColor = true;
            // 
            // dgvBorrowedBook
            // 
            this.dgvBorrowedBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrowedBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBorrowedBook.Location = new System.Drawing.Point(0, 0);
            this.dgvBorrowedBook.Name = "dgvBorrowedBook";
            this.dgvBorrowedBook.ReadOnly = true;
            this.dgvBorrowedBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowedBook.Size = new System.Drawing.Size(745, 401);
            this.dgvBorrowedBook.TabIndex = 0;
            this.dgvBorrowedBook.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowedBook_CellContentDoubleClick);
            // 
            // btn_Bsave
            // 
            this.btn_Bsave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bsave.Location = new System.Drawing.Point(409, 320);
            this.btn_Bsave.Name = "btn_Bsave";
            this.btn_Bsave.Size = new System.Drawing.Size(89, 36);
            this.btn_Bsave.TabIndex = 20;
            this.btn_Bsave.Text = "Borrow";
            this.btn_Bsave.UseVisualStyleBackColor = true;
            this.btn_Bsave.Click += new System.EventHandler(this.btn_Bsave_Click);
            // 
            // frmIssue
            // 
            this.ClientSize = new System.Drawing.Size(755, 430);
            this.Controls.Add(this.tbctrlBorrowDetails);
            this.Name = "frmIssue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmIssue_Load);
            this.tbctrlBorrowDetails.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpgBorrowedBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbctrlBorrowDetails;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbpgBorrowedBook;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbCId;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPublishDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtBorrowerID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblContactno;
        private System.Windows.Forms.Label lblBorrowerID;
        private System.Windows.Forms.Label lblFirstname;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnBorrowerFullDetails;
        private System.Windows.Forms.RadioButton rdofemale;
        private System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.DataGridView dgvBorrowedBook;
        private System.Windows.Forms.TextBox txtBookId;
        internal System.Windows.Forms.Button btn_Bsave;
    }
}