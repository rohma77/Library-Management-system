namespace LibraryManagementSystem
{
    partial class frmReport
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
            this.btnTotalbooks = new System.Windows.Forms.Button();
            this.btnListBooks = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.GroupBox1.SuspendLayout();
            this.FlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTotalbooks
            // 
            this.btnTotalbooks.Location = new System.Drawing.Point(10, 53);
            this.btnTotalbooks.Name = "btnTotalbooks";
            this.btnTotalbooks.Size = new System.Drawing.Size(133, 22);
            this.btnTotalbooks.TabIndex = 3;
            this.btnTotalbooks.Text = "Total No. of Books";
            this.btnTotalbooks.UseVisualStyleBackColor = true;
            this.btnTotalbooks.Click += new System.EventHandler(this.btnTotalbooks_Click);
            // 
            // btnListBooks
            // 
            this.btnListBooks.Location = new System.Drawing.Point(9, 25);
            this.btnListBooks.Name = "btnListBooks";
            this.btnListBooks.Size = new System.Drawing.Size(133, 22);
            this.btnListBooks.TabIndex = 2;
            this.btnListBooks.Text = "List of Books";
            this.btnListBooks.UseVisualStyleBackColor = true;
            this.btnListBooks.Click += new System.EventHandler(this.btnListBooks_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 84);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(43, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Status :";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "AVAILABLE",
            "BORROWED"});
            this.cmbStatus.Location = new System.Drawing.Point(6, 103);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(137, 21);
            this.cmbStatus.TabIndex = 0;
            this.cmbStatus.Text = "Borrowed";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnTotalbooks);
            this.GroupBox1.Controls.Add(this.btnListBooks);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.cmbStatus);
            this.GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(152, 160);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Books";
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.Controls.Add(this.GroupBox1);
            this.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(155, 430);
            this.FlowLayoutPanel1.TabIndex = 3;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(155, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(600, 430);
            this.crystalReportViewer1.TabIndex = 4;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 430);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.FlowLayoutPanel1);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnTotalbooks;
        internal System.Windows.Forms.Button btnListBooks;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cmbStatus;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

    }
}