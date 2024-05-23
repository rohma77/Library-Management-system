using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class frmBorrowers : Form
    {
        public frmBorrowers()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LibraryManagment;Integrated Security=True");
        SqlDataReader sdr;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda;

        public void LoadBorrowers()
        {
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter("Select * from tblBorrower", con);
            sda.Fill(dt);
            dgvBorrowers.DataSource = dt;
        }

        string Gender,Fname;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearData()
        {
            txtAdhaarno.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            if (rdomale.Checked == true)
                rdomale.Checked = false;
            if (rdofemale.Checked == true)
                rdofemale.Checked = false;
            txtContactNo.Clear();
            pBoxPhoto.Image = null;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                if (rdofemale.Checked)
                {
                    Gender = rdofemale.Text.Trim().ToUpper();
                }
                else
                {
                    Gender = rdomale.Text.Trim().ToUpper();
                }
               
                cmd.Connection = con;
                cmd.CommandText = "insert into tblBorrower values('"
                    + txtAdhaarno.Text.Trim() + "', '" 
                    + txtFirstName.Text.Trim().ToUpper() + "', '"
                    + txtLastName.Text.Trim().ToUpper() + "' , '"
                    + txtAddress.Text.Trim().ToUpper() + "' , '"
                    + Gender + "' ,'" 
                    + txtContactNo.Text.Trim().ToUpper() + "', '"
                    + Fname + "')";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data save successfully..");
                ClearData();
                LoadBorrowers();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBorrowers_Load(object sender, EventArgs e)
        {
            LoadBorrowers();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Fname = openFileDialog1.FileName;
                if (Fname.EndsWith(".png") || Fname.EndsWith(".jpg") || Fname.EndsWith(".jpeg") || Fname.EndsWith(".gif"))
                {
                    
                    pBoxPhoto.Image = Image.FromFile(Fname);
                    pBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Invalid File Format..");
                }
            }
        }

        public int Id;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete the Record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dr == DialogResult.Yes)
                {

                    cmd.Connection = con;
                    cmd.CommandText = "delete from tblBorrower where BorrowerId = " + Id;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                    LoadBorrowers();
                    ClearData();

                }
                else
                {
                    MessageBox.Show("Please Select the record you want to delete..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvBorrowers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Id = Convert.ToInt32(dgvBorrowers.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmd.Connection = con;
            cmd.CommandText = "Select * from tblBorrower where BorrowerId = " + Id;
            con.Open();
            sdr = cmd.ExecuteReader();
           
            while (sdr.Read())
            {
                txtAdhaarno.Text = sdr[1].ToString().Trim();
                txtFirstName.Text = sdr[2].ToString().Trim().ToUpper();
                txtLastName.Text = sdr[3].ToString().Trim().ToUpper();
                txtAddress.Text = sdr[4].ToString().Trim().ToUpper();


                //if (sdr[11].ToString() != "NULL")
                //    chkGraduation.Checked = true;
                //else
                //    chkGraduation.Checked = false;

                if (sdr[5].ToString().ToUpper().Trim() == "FEMALE")
                {
                    rdofemale.Checked = true;
                    rdomale.Checked = false;
                }
                else
                {
                    rdomale.Checked = true;
                    rdofemale.Checked = false;
                }
                //Gender = sdr[5].ToString().ToUpper().Trim();
               
                txtContactNo.Text = sdr[6].ToString().Trim().ToUpper();
                Fname = sdr[7].ToString().Trim().ToUpper();
                pBoxPhoto.Image = Image.FromFile(Fname);
                pBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdofemale.Checked)
                {
                    Gender = rdofemale.Text.Trim().ToUpper();
                }
                else
                {
                    Gender = rdomale.Text.Trim().ToUpper();
                }

                cmd.Connection = con;

                cmd.CommandText = "update tblBorrower set " +
                "Adharno = '" + txtAdhaarno.Text.Trim().ToUpper() + "', " + 
                "Firstname = '" + txtFirstName.Text.Trim().ToUpper() + "', " +
                "Lastname = '" + txtLastName.Text.Trim().ToUpper() + "' , " +
                "Address = '" + txtAddress.Text.Trim().ToUpper() + "' , " +
                "Gender = '" + Gender + "' , " +
                "ContactNo = '" + txtContactNo.Text.Trim().ToUpper() + "', " +
                "BPhoto = '" + Fname + "' where BorrowerId = " + Id;
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data updated successfully..");
                ClearData();
                LoadBorrowers();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

       

    }
}
