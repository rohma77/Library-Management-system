namespace LibraryManagementSystem
{
    partial class frmReturn
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
            this.TabControl3 = new System.Windows.Forms.TabControl();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearchUnreturnBook = new System.Windows.Forms.TextBox();
            this.dgvBorrowedBookDetails = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Label();
            this.grp_Rgroup = new System.Windows.Forms.GroupBox();
            this.txtBorrowerName = new System.Windows.Forms.TextBox();
            this.dgvBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.txtBorrowerId = new System.Windows.Forms.TextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_accessionNo = new System.Windows.Forms.Label();
            this.lbl_transid = new System.Windows.Forms.Label();
            this.lbl_borrowerId = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_Rduedate = new System.Windows.Forms.Label();
            this.lbl_rpayments = new System.Windows.Forms.Label();
            this.lbl_Rchange = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.txt_RtenAmount = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtrbooksSearch = new System.Windows.Forms.TextBox();
            this.dtgListreturned = new System.Windows.Forms.DataGridView();
            this.TabControl3.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBookDetails)).BeginInit();
            this.grp_Rgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.TabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListreturned)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl3
            // 
            this.TabControl3.Controls.Add(this.TabPage5);
            this.TabControl3.Controls.Add(this.TabPage6);
            this.TabControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabControl3.Location = new System.Drawing.Point(0, 0);
            this.TabControl3.Name = "TabControl3";
            this.TabControl3.SelectedIndex = 0;
            this.TabControl3.Size = new System.Drawing.Size(755, 427);
            this.TabControl3.TabIndex = 6;
            this.TabControl3.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl3_Selected);
            // 
            // TabPage5
            // 
            this.TabPage5.Controls.Add(this.GroupBox3);
            this.TabPage5.Controls.Add(this.grp_Rgroup);
            this.TabPage5.Controls.Add(this.btnClose);
            this.TabPage5.Controls.Add(this.btnNew);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage5.Size = new System.Drawing.Size(747, 401);
            this.TabPage5.TabIndex = 0;
            this.TabPage5.Text = "Unreturn Books";
            this.TabPage5.UseVisualStyleBackColor = true;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtSearchUnreturnBook);
            this.GroupBox3.Controls.Add(this.dgvBorrowedBookDetails);
            this.GroupBox3.Controls.Add(this.Search);
            this.GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(6, 6);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(386, 389);
            this.GroupBox3.TabIndex = 1;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "View Details of Unreturn Books";
            // 
            // txtSearchUnreturnBook
            // 
            this.txtSearchUnreturnBook.Location = new System.Drawing.Point(76, 24);
            this.txtSearchUnreturnBook.Name = "txtSearchUnreturnBook";
            this.txtSearchUnreturnBook.Size = new System.Drawing.Size(304, 25);
            this.txtSearchUnreturnBook.TabIndex = 25;
            this.txtSearchUnreturnBook.TextChanged += new System.EventHandler(this.txtSearchUnreturnBook_TextChanged);
            // 
            // dgvBorrowedBookDetails
            // 
            this.dgvBorrowedBookDetails.AllowUserToAddRows = false;
            this.dgvBorrowedBookDetails.AllowUserToDeleteRows = false;
            this.dgvBorrowedBookDetails.AllowUserToResizeColumns = false;
            this.dgvBorrowedBookDetails.AllowUserToResizeRows = false;
            this.dgvBorrowedBookDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBorrowedBookDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedBookDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBorrowedBookDetails.Location = new System.Drawing.Point(6, 55);
            this.dgvBorrowedBookDetails.MultiSelect = false;
            this.dgvBorrowedBookDetails.Name = "dgvBorrowedBookDetails";
            this.dgvBorrowedBookDetails.RowHeadersVisible = false;
            this.dgvBorrowedBookDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowedBookDetails.Size = new System.Drawing.Size(374, 328);
            this.dgvBorrowedBookDetails.TabIndex = 0;
            this.dgvBorrowedBookDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowedBookDetails_CellDoubleClick);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(6, 28);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(64, 21);
            this.Search.TabIndex = 24;
            this.Search.Text = "Search :";
            // 
            // grp_Rgroup
            // 
            this.grp_Rgroup.Controls.Add(this.txtBorrowerName);
            this.grp_Rgroup.Controls.Add(this.dgvBorrowedBooks);
            this.grp_Rgroup.Controls.Add(this.txtBorrowerId);
            this.grp_Rgroup.Controls.Add(this.Label27);
            this.grp_Rgroup.Controls.Add(this.GroupBox2);
            this.grp_Rgroup.Controls.Add(this.Label18);
            this.grp_Rgroup.Controls.Add(this.GroupBox5);
            this.grp_Rgroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Rgroup.Location = new System.Drawing.Point(398, 17);
            this.grp_Rgroup.Name = "grp_Rgroup";
            this.grp_Rgroup.Size = new System.Drawing.Size(331, 325);
            this.grp_Rgroup.TabIndex = 2;
            this.grp_Rgroup.TabStop = false;
            this.grp_Rgroup.Text = "Return";
            // 
            // txtBorrowerName
            // 
            this.txtBorrowerName.Location = new System.Drawing.Point(30, 106);
            this.txtBorrowerName.Name = "txtBorrowerName";
            this.txtBorrowerName.Size = new System.Drawing.Size(278, 25);
            this.txtBorrowerName.TabIndex = 25;
            this.txtBorrowerName.TextChanged += new System.EventHandler(this.txtBorrowerId_TextChanged);
            // 
            // dgvBorrowedBooks
            // 
            this.dgvBorrowedBooks.AllowUserToAddRows = false;
            this.dgvBorrowedBooks.AllowUserToDeleteRows = false;
            this.dgvBorrowedBooks.AllowUserToResizeColumns = false;
            this.dgvBorrowedBooks.AllowUserToResizeRows = false;
            this.dgvBorrowedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBorrowedBooks.Location = new System.Drawing.Point(29, 137);
            this.dgvBorrowedBooks.MultiSelect = false;
            this.dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            this.dgvBorrowedBooks.RowHeadersVisible = false;
            this.dgvBorrowedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowedBooks.Size = new System.Drawing.Size(279, 182);
            this.dgvBorrowedBooks.TabIndex = 0;
            this.dgvBorrowedBooks.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowedBooks_CellContentDoubleClick);
            // 
            // txtBorrowerId
            // 
            this.txtBorrowerId.Location = new System.Drawing.Point(30, 44);
            this.txtBorrowerId.Name = "txtBorrowerId";
            this.txtBorrowerId.Size = new System.Drawing.Size(278, 25);
            this.txtBorrowerId.TabIndex = 25;
            this.txtBorrowerId.TextChanged += new System.EventHandler(this.txtBorrowerId_TextChanged);
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(27, 24);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(84, 17);
            this.Label27.TabIndex = 24;
            this.Label27.Text = "Borrower Id :";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.lbl_accessionNo);
            this.GroupBox2.Controls.Add(this.lbl_transid);
            this.GroupBox2.Controls.Add(this.lbl_borrowerId);
            this.GroupBox2.Location = new System.Drawing.Point(515, 116);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(25, 10);
            this.GroupBox2.TabIndex = 25;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "ID\'s Secret";
            // 
            // lbl_accessionNo
            // 
            this.lbl_accessionNo.AutoSize = true;
            this.lbl_accessionNo.Location = new System.Drawing.Point(56, 42);
            this.lbl_accessionNo.Name = "lbl_accessionNo";
            this.lbl_accessionNo.Size = new System.Drawing.Size(88, 17);
            this.lbl_accessionNo.TabIndex = 5;
            this.lbl_accessionNo.Text = "Accession #  :";
            // 
            // lbl_transid
            // 
            this.lbl_transid.AutoSize = true;
            this.lbl_transid.Location = new System.Drawing.Point(59, 59);
            this.lbl_transid.Name = "lbl_transid";
            this.lbl_transid.Size = new System.Drawing.Size(48, 17);
            this.lbl_transid.TabIndex = 24;
            this.lbl_transid.Text = "transid";
            // 
            // lbl_borrowerId
            // 
            this.lbl_borrowerId.AutoSize = true;
            this.lbl_borrowerId.Location = new System.Drawing.Point(56, 25);
            this.lbl_borrowerId.Name = "lbl_borrowerId";
            this.lbl_borrowerId.Size = new System.Drawing.Size(78, 17);
            this.lbl_borrowerId.TabIndex = 21;
            this.lbl_borrowerId.Text = "borrower id";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(26, 81);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(108, 17);
            this.Label18.TabIndex = 19;
            this.Label18.Text = "Borrower Name :";
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.lbl_Rduedate);
            this.GroupBox5.Controls.Add(this.lbl_rpayments);
            this.GroupBox5.Controls.Add(this.lbl_Rchange);
            this.GroupBox5.Controls.Add(this.Label24);
            this.GroupBox5.Controls.Add(this.Label23);
            this.GroupBox5.Controls.Add(this.txt_RtenAmount);
            this.GroupBox5.Controls.Add(this.Label22);
            this.GroupBox5.Controls.Add(this.Label21);
            this.GroupBox5.Location = new System.Drawing.Point(506, 144);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(45, 25);
            this.GroupBox5.TabIndex = 4;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "do not touch.Time and Days for the future used. ";
            // 
            // lbl_Rduedate
            // 
            this.lbl_Rduedate.AutoSize = true;
            this.lbl_Rduedate.Location = new System.Drawing.Point(71, 26);
            this.lbl_Rduedate.Name = "lbl_Rduedate";
            this.lbl_Rduedate.Size = new System.Drawing.Size(53, 17);
            this.lbl_Rduedate.TabIndex = 7;
            this.lbl_Rduedate.Text = "Label25";
            // 
            // lbl_rpayments
            // 
            this.lbl_rpayments.AutoSize = true;
            this.lbl_rpayments.Location = new System.Drawing.Point(71, 52);
            this.lbl_rpayments.Name = "lbl_rpayments";
            this.lbl_rpayments.Size = new System.Drawing.Size(53, 17);
            this.lbl_rpayments.TabIndex = 4;
            this.lbl_rpayments.Text = "Label25";
            // 
            // lbl_Rchange
            // 
            this.lbl_Rchange.AutoSize = true;
            this.lbl_Rchange.Location = new System.Drawing.Point(75, 122);
            this.lbl_Rchange.Name = "lbl_Rchange";
            this.lbl_Rchange.Size = new System.Drawing.Size(53, 17);
            this.lbl_Rchange.TabIndex = 6;
            this.lbl_Rchange.Text = "Label26";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(15, 122);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(59, 17);
            this.Label24.TabIndex = 5;
            this.Label24.Text = "Change :";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(6, 87);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(120, 17);
            this.Label23.TabIndex = 3;
            this.Label23.Text = "Tendered Amount :";
            // 
            // txt_RtenAmount
            // 
            this.txt_RtenAmount.Location = new System.Drawing.Point(132, 84);
            this.txt_RtenAmount.Name = "txt_RtenAmount";
            this.txt_RtenAmount.Size = new System.Drawing.Size(177, 25);
            this.txt_RtenAmount.TabIndex = 2;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(6, 52);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(70, 17);
            this.Label22.TabIndex = 1;
            this.Label22.Text = "Payments :";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(6, 26);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(70, 17);
            this.Label21.TabIndex = 0;
            this.Label21.Text = "Over Due :";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(578, 353);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 27);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(447, 353);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 27);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Clear";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // TabPage6
            // 
            this.TabPage6.Controls.Add(this.Label4);
            this.TabPage6.Controls.Add(this.txtrbooksSearch);
            this.TabPage6.Controls.Add(this.dtgListreturned);
            this.TabPage6.Location = new System.Drawing.Point(4, 22);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage6.Size = new System.Drawing.Size(747, 401);
            this.TabPage6.TabIndex = 1;
            this.TabPage6.Text = "Returned Books";
            this.TabPage6.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(413, 424);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(86, 25);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Search :";
            // 
            // txtrbooksSearch
            // 
            this.txtrbooksSearch.BackColor = System.Drawing.Color.White;
            this.txtrbooksSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrbooksSearch.Location = new System.Drawing.Point(505, 419);
            this.txtrbooksSearch.Name = "txtrbooksSearch";
            this.txtrbooksSearch.Size = new System.Drawing.Size(295, 30);
            this.txtrbooksSearch.TabIndex = 1;
            // 
            // dtgListreturned
            // 
            this.dtgListreturned.AllowUserToAddRows = false;
            this.dtgListreturned.AllowUserToDeleteRows = false;
            this.dtgListreturned.AllowUserToResizeColumns = false;
            this.dtgListreturned.AllowUserToResizeRows = false;
            this.dtgListreturned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgListreturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListreturned.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgListreturned.Location = new System.Drawing.Point(6, 6);
            this.dtgListreturned.Name = "dtgListreturned";
            this.dtgListreturned.RowHeadersVisible = false;
            this.dtgListreturned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListreturned.Size = new System.Drawing.Size(738, 398);
            this.dtgListreturned.TabIndex = 0;
            this.dtgListreturned.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListreturned_CellContentDoubleClick);
            // 
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 430);
            this.Controls.Add(this.TabControl3);
            this.Name = "frmReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmReturn_Load);
            this.TabControl3.ResumeLayout(false);
            this.TabPage5.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBookDetails)).EndInit();
            this.grp_Rgroup.ResumeLayout(false);
            this.grp_Rgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListreturned)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl3;
        internal System.Windows.Forms.TabPage TabPage5;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox txtBorrowerId;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.DataGridView dgvBorrowedBookDetails;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.TabPage TabPage6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtrbooksSearch;
        internal System.Windows.Forms.DataGridView dtgListreturned;
        internal System.Windows.Forms.GroupBox grp_Rgroup;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label lbl_accessionNo;
        internal System.Windows.Forms.Label lbl_transid;
        internal System.Windows.Forms.Label lbl_borrowerId;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Label lbl_Rduedate;
        internal System.Windows.Forms.Label lbl_rpayments;
        internal System.Windows.Forms.Label lbl_Rchange;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.TextBox txt_RtenAmount;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.TextBox txtSearchUnreturnBook;
        protected System.Windows.Forms.Label Search;
        internal System.Windows.Forms.TextBox txtBorrowerName;
        internal System.Windows.Forms.DataGridView dgvBorrowedBooks;

    }
}