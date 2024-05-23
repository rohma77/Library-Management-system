namespace LibraryManagementSystem
{
    partial class frmBookReturned
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
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblBookId = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBorrowerID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblBorrowerID = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.dtpExpectedReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblExpectedReturnDate = new System.Windows.Forms.Label();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblActualReturnDate = new System.Windows.Forms.Label();
            this.dtpActualReturnDate = new System.Windows.Forms.DateTimePicker();
            this.gboxBookTReturned = new System.Windows.Forms.GroupBox();
            this.gboxBookTReturned.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(175, 36);
            this.txtBookID.Multiline = true;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(195, 23);
            this.txtBookID.TabIndex = 29;
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.Location = new System.Drawing.Point(100, 38);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(55, 15);
            this.lblBookId.TabIndex = 30;
            this.lblBookId.Text = "Book Id :";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(175, 76);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(195, 23);
            this.txtTitle.TabIndex = 31;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(118, 84);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 15);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Title :";
            // 
            // txtBorrowerID
            // 
            this.txtBorrowerID.Location = new System.Drawing.Point(175, 117);
            this.txtBorrowerID.Multiline = true;
            this.txtBorrowerID.Name = "txtBorrowerID";
            this.txtBorrowerID.Size = new System.Drawing.Size(195, 23);
            this.txtBorrowerID.TabIndex = 51;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(175, 158);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(195, 23);
            this.txtFirstName.TabIndex = 52;
            // 
            // lblBorrowerID
            // 
            this.lblBorrowerID.AutoSize = true;
            this.lblBorrowerID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowerID.Location = new System.Drawing.Point(77, 125);
            this.lblBorrowerID.Name = "lblBorrowerID";
            this.lblBorrowerID.Size = new System.Drawing.Size(78, 15);
            this.lblBorrowerID.TabIndex = 53;
            this.lblBorrowerID.Text = "Borrower ID :";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(112, 161);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(43, 15);
            this.lblFirstname.TabIndex = 54;
            this.lblFirstname.Text = "Name :";
            // 
            // dtpExpectedReturnDate
            // 
            this.dtpExpectedReturnDate.Location = new System.Drawing.Point(175, 274);
            this.dtpExpectedReturnDate.Name = "dtpExpectedReturnDate";
            this.dtpExpectedReturnDate.Size = new System.Drawing.Size(195, 20);
            this.dtpExpectedReturnDate.TabIndex = 55;
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Location = new System.Drawing.Point(175, 199);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(195, 20);
            this.dtpBorrowDate.TabIndex = 56;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 15;
            this.cmbStatus.Items.AddRange(new object[] {
            "AVAILBALE",
            "BORROWED"});
            this.cmbStatus.Location = new System.Drawing.Point(175, 312);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(195, 23);
            this.cmbStatus.TabIndex = 60;
            // 
            // lblExpectedReturnDate
            // 
            this.lblExpectedReturnDate.AutoSize = true;
            this.lblExpectedReturnDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectedReturnDate.Location = new System.Drawing.Point(27, 274);
            this.lblExpectedReturnDate.Name = "lblExpectedReturnDate";
            this.lblExpectedReturnDate.Size = new System.Drawing.Size(128, 15);
            this.lblExpectedReturnDate.TabIndex = 58;
            this.lblExpectedReturnDate.Text = "Expected Return Date :";
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowDate.Location = new System.Drawing.Point(75, 204);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(80, 15);
            this.lblBorrowDate.TabIndex = 57;
            this.lblBorrowDate.Text = "Borrow Date :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(108, 320);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 15);
            this.lblStatus.TabIndex = 59;
            this.lblStatus.Text = "Status :";
            // 
            // lblActualReturnDate
            // 
            this.lblActualReturnDate.AutoSize = true;
            this.lblActualReturnDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualReturnDate.Location = new System.Drawing.Point(39, 237);
            this.lblActualReturnDate.Name = "lblActualReturnDate";
            this.lblActualReturnDate.Size = new System.Drawing.Size(116, 15);
            this.lblActualReturnDate.TabIndex = 58;
            this.lblActualReturnDate.Text = "Actual Return Date :";
            // 
            // dtpActualReturnDate
            // 
            this.dtpActualReturnDate.Location = new System.Drawing.Point(175, 237);
            this.dtpActualReturnDate.Name = "dtpActualReturnDate";
            this.dtpActualReturnDate.Size = new System.Drawing.Size(195, 20);
            this.dtpActualReturnDate.TabIndex = 55;
            // 
            // gboxBookTReturned
            // 
            this.gboxBookTReturned.Controls.Add(this.dtpBorrowDate);
            this.gboxBookTReturned.Controls.Add(this.dtpActualReturnDate);
            this.gboxBookTReturned.Controls.Add(this.lblBookId);
            this.gboxBookTReturned.Controls.Add(this.dtpExpectedReturnDate);
            this.gboxBookTReturned.Controls.Add(this.txtBookID);
            this.gboxBookTReturned.Controls.Add(this.lblTitle);
            this.gboxBookTReturned.Controls.Add(this.lblActualReturnDate);
            this.gboxBookTReturned.Controls.Add(this.txtTitle);
            this.gboxBookTReturned.Controls.Add(this.cmbStatus);
            this.gboxBookTReturned.Controls.Add(this.lblFirstname);
            this.gboxBookTReturned.Controls.Add(this.lblExpectedReturnDate);
            this.gboxBookTReturned.Controls.Add(this.lblBorrowerID);
            this.gboxBookTReturned.Controls.Add(this.lblBorrowDate);
            this.gboxBookTReturned.Controls.Add(this.txtFirstName);
            this.gboxBookTReturned.Controls.Add(this.lblStatus);
            this.gboxBookTReturned.Controls.Add(this.txtBorrowerID);
            this.gboxBookTReturned.Location = new System.Drawing.Point(12, 12);
            this.gboxBookTReturned.Name = "gboxBookTReturned";
            this.gboxBookTReturned.Size = new System.Drawing.Size(408, 349);
            this.gboxBookTReturned.TabIndex = 61;
            this.gboxBookTReturned.TabStop = false;
            this.gboxBookTReturned.Text = "Returned Books";
            // 
            // frmBookReturned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 368);
            this.Controls.Add(this.gboxBookTReturned);
            this.Name = "frmBookReturned";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBookReturned";
            this.Load += new System.EventHandler(this.frmBookReturned_Load);
            this.gboxBookTReturned.ResumeLayout(false);
            this.gboxBookTReturned.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBorrowerID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblBorrowerID;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.DateTimePicker dtpExpectedReturnDate;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblExpectedReturnDate;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblActualReturnDate;
        private System.Windows.Forms.DateTimePicker dtpActualReturnDate;
        private System.Windows.Forms.GroupBox gboxBookTReturned;
    }
}