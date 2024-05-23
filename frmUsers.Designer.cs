namespace LibraryManagementSystem
{
    partial class frmUsers
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
            this.dgv_UserList = new System.Windows.Forms.DataGridView();
            this.btn_saveuser = new System.Windows.Forms.Button();
            this.btnCloseUser = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_UserList
            // 
            this.dgv_UserList.AllowUserToAddRows = false;
            this.dgv_UserList.AllowUserToDeleteRows = false;
            this.dgv_UserList.AllowUserToResizeColumns = false;
            this.dgv_UserList.AllowUserToResizeRows = false;
            this.dgv_UserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_UserList.Location = new System.Drawing.Point(3, 144);
            this.dgv_UserList.Name = "dgv_UserList";
            this.dgv_UserList.RowHeadersVisible = false;
            this.dgv_UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UserList.Size = new System.Drawing.Size(531, 238);
            this.dgv_UserList.TabIndex = 43;
            this.dgv_UserList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UserList_CellContentDoubleClick);
            // 
            // btn_saveuser
            // 
            this.btn_saveuser.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveuser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveuser.Location = new System.Drawing.Point(84, 388);
            this.btn_saveuser.Name = "btn_saveuser";
            this.btn_saveuser.Size = new System.Drawing.Size(76, 30);
            this.btn_saveuser.TabIndex = 34;
            this.btn_saveuser.Text = "Save";
            this.btn_saveuser.UseVisualStyleBackColor = false;
            this.btn_saveuser.Click += new System.EventHandler(this.btn_saveuser_Click);
            // 
            // btnCloseUser
            // 
            this.btnCloseUser.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUser.Location = new System.Drawing.Point(330, 388);
            this.btnCloseUser.Name = "btnCloseUser";
            this.btnCloseUser.Size = new System.Drawing.Size(76, 30);
            this.btnCloseUser.TabIndex = 38;
            this.btnCloseUser.Text = "Close";
            this.btnCloseUser.UseVisualStyleBackColor = false;
            this.btnCloseUser.Click += new System.EventHandler(this.btnCloseUser_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(141, 31);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(322, 25);
            this.txt_name.TabIndex = 28;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label3.Location = new System.Drawing.Point(61, 111);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(71, 17);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "Password :";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(141, 71);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(322, 25);
            this.txt_username.TabIndex = 29;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label2.Location = new System.Drawing.Point(58, 71);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(74, 17);
            this.Label2.TabIndex = 32;
            this.Label2.Text = "Username :";
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(141, 111);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(322, 25);
            this.txt_pass.TabIndex = 30;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label1.Location = new System.Drawing.Point(82, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 17);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "Name :";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Location = new System.Drawing.Point(166, 388);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(76, 30);
            this.btnUpdateUser.TabIndex = 38;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(248, 388);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(76, 30);
            this.btnDeleteUser.TabIndex = 38;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 430);
            this.Controls.Add(this.dgv_UserList);
            this.Controls.Add(this.btn_saveuser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnCloseUser);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.Label1);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.DataGridView dgv_UserList;
        internal System.Windows.Forms.Button btn_saveuser;
        internal System.Windows.Forms.Button btnCloseUser;
        internal System.Windows.Forms.TextBox txt_name;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txt_username;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txt_pass;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnUpdateUser;
        internal System.Windows.Forms.Button btnDeleteUser;

    }
}