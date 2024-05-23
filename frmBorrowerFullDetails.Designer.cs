namespace LibraryManagementSystem
{
    partial class frmBorrowerFullDetails
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
            this.pBoxPhoto = new System.Windows.Forms.PictureBox();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAdhaarno = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblContactno = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblAdhaarNo = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxPhoto
            // 
            this.pBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxPhoto.Location = new System.Drawing.Point(146, 27);
            this.pBoxPhoto.Name = "pBoxPhoto";
            this.pBoxPhoto.Size = new System.Drawing.Size(153, 118);
            this.pBoxPhoto.TabIndex = 44;
            this.pBoxPhoto.TabStop = false;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(253, 295);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(59, 17);
            this.rdofemale.TabIndex = 35;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(174, 295);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(48, 17);
            this.rdomale.TabIndex = 34;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(146, 248);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(275, 46);
            this.txtAddress.TabIndex = 33;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(146, 318);
            this.txtContactNo.Multiline = true;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.ReadOnly = true;
            this.txtContactNo.Size = new System.Drawing.Size(275, 23);
            this.txtContactNo.TabIndex = 36;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(146, 219);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(275, 23);
            this.txtLastName.TabIndex = 32;
            // 
            // txtAdhaarno
            // 
            this.txtAdhaarno.Location = new System.Drawing.Point(146, 161);
            this.txtAdhaarno.Multiline = true;
            this.txtAdhaarno.Name = "txtAdhaarno";
            this.txtAdhaarno.ReadOnly = true;
            this.txtAdhaarno.Size = new System.Drawing.Size(275, 23);
            this.txtAdhaarno.TabIndex = 30;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(146, 190);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(275, 23);
            this.txtFirstName.TabIndex = 31;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(71, 295);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(51, 15);
            this.lblGender.TabIndex = 38;
            this.lblGender.Text = "Gender :";
            // 
            // lblContactno
            // 
            this.lblContactno.AutoSize = true;
            this.lblContactno.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactno.Location = new System.Drawing.Point(48, 320);
            this.lblContactno.Name = "lblContactno";
            this.lblContactno.Size = new System.Drawing.Size(74, 15);
            this.lblContactno.TabIndex = 40;
            this.lblContactno.Text = "Contact No :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(63, 250);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 15);
            this.lblAddress.TabIndex = 39;
            this.lblAddress.Text = "Address :";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(53, 221);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(69, 15);
            this.lblLastname.TabIndex = 41;
            this.lblLastname.Text = "Last Name :";
            // 
            // lblAdhaarNo
            // 
            this.lblAdhaarNo.AutoSize = true;
            this.lblAdhaarNo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdhaarNo.Location = new System.Drawing.Point(24, 166);
            this.lblAdhaarNo.Name = "lblAdhaarNo";
            this.lblAdhaarNo.Size = new System.Drawing.Size(98, 15);
            this.lblAdhaarNo.TabIndex = 42;
            this.lblAdhaarNo.Text = "Adhaar Number :";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(52, 192);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(70, 15);
            this.lblFirstname.TabIndex = 43;
            this.lblFirstname.Text = "First Name :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmBorrowerFullDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 369);
            this.Controls.Add(this.pBoxPhoto);
            this.Controls.Add(this.rdofemale);
            this.Controls.Add(this.rdomale);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAdhaarno);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblContactno);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblAdhaarNo);
            this.Controls.Add(this.lblFirstname);
            this.Name = "frmBorrowerFullDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBorrowerFullDetails";
            this.Load += new System.EventHandler(this.frmBorrowerFullDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxPhoto;
        private System.Windows.Forms.RadioButton rdofemale;
        private System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAdhaarno;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblContactno;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblAdhaarNo;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}