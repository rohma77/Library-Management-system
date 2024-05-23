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
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LibraryManagment;Integrated Security=True");
        SqlDataAdapter sda;
        SqlDataReader sdr;
        SqlCommand cmd;

        public void ClearData()
        {
            txtBookID.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtLanguage.Clear();
            dtpPublishDate.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            cmbCId.Text = "--Select Category Id--";
            cmbCategory.Text = "--Select Category--";
            cmbStatus.Text = "--Select Status--";
           

        }

        public void LoadBooks()
        {
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter("select * from tblBooks", con);
            sda.Fill(dt);
            dgvAvailableBooks.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        string status = "AVAILABLE";
        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            cmbStatus.Text = status;
            try
            {


                //if (cmbStatus.SelectedItem != null && cmbStatus.SelectedItem.ToString() == status)
                //{
                //    status = "AVAILABLE";
                //}
                //else
                //{
                //    status = "BORROWED";
                //}
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "insert into tblBooks values ('"
                    +txtBookID.Text.Trim().ToString().ToUpper() + "','"
                    + txtTitle.Text.Trim().ToUpper() + "','"
                    + txtAuthor.Text.Trim().ToUpper() + "' , '"
                    + txtLanguage.Text.Trim().ToUpper() + "' , '"
                    + dtpPublishDate.Value.ToLongDateString() + "' , '"
                    + cmbCId.SelectedItem.ToString().ToUpper() + "' , '"
                    + cmbCategory.SelectedItem.ToString().ToUpper() + "' , '"
                    + status + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Save Successfully...");
                LoadBooks();
                ClearData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Enter Same Id",ex.Message);
            }
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            BindData();
            LoadBooks();
        }

        public void BindData()
        {
            //cmd.Connection = con;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LibraryManagment;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("select * from tblCategory", con);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cmbCId.Items.Add(sdr[0].ToString());
                cmbCategory.Items.Add(sdr[1].ToString());
            }

            con.Close();
            //cmd.Connection = con;
            //con.Open();
            //cmd = new SqlCommand("select Category from tblCategory", con);
            //sdr = cmd.ExecuteReader();
            //while (sdr.Read())
            //{
            //    cmbCategory.Items.Add(sdr[0].ToString());
            //}
            //con.Close();
        }

        int Id;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbStatus.SelectedText == status)
                {
                    status = cmbStatus.SelectedItem.ToString().ToUpper().Trim();
                }
                else
                {
                    status = cmbStatus.SelectedItem.ToString().ToUpper().Trim();
                }
                //if (cmbStatus.SelectedItem == "Available")
                //{
                //    status = "Available";
                //}
                //else
                //{
                //    status = "Not Available";
                //}
                cmd.Connection = con;
                con.Open();
                
                cmd.CommandText = "update tblBooks set " +
                "BookID = '" + txtBookID.Text.ToString().Trim().ToUpper() + "'," +
                "BookTitle = '" + txtTitle.Text.Trim().ToUpper() + "'," +
                "Author = '" + txtAuthor.Text.Trim().ToUpper() + "' , " +
                "Language = '" + txtLanguage.Text.Trim().ToUpper() + "' , " +
                "PublishDate = '" + dtpPublishDate.Value.ToLongDateString() + "' , " +
                "CategoryId = '" + cmbCId.SelectedItem.ToString().ToUpper() + "' , " +
                "Category = '" + cmbCategory.SelectedItem.ToString().ToUpper() + "' , " +
                "Status = '" + status + "' where BookID = " + Id;

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated Successfully...");
                LoadBooks();
                ClearData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Are you sure you want  to delete this....", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (drs == DialogResult.Yes)
            {
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "delete from tblBooks where BookID = " + Id;
                cmd.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Record deleted successfully...");
            LoadBooks();
            ClearData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string name = txtSearch.Text.ToString().Trim().ToUpper();
            string query = "select * from tblBooks where BookID like'" + name +"%'";
            sda = new SqlDataAdapter(query, con);
            sda.Fill(ds);
            dgvAvailableBooks.DataSource = ds.Tables[0];

            
        }

        private void dgvAvailableBooks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Id = Convert.ToInt32(dgvAvailableBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmd.Connection = con;
            cmd.CommandText = "select * from tblBooks where BookID = " + Id;
            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtBookID.Text = sdr[0].ToString().Trim();
                txtTitle.Text = sdr[1].ToString().Trim().ToUpper();
                txtAuthor.Text = sdr[2].ToString().Trim().ToUpper();
                txtLanguage.Text = sdr[3].ToString().Trim().ToUpper();
                dtpPublishDate.Value = Convert.ToDateTime(sdr[4].ToString().Trim());
                cmbCId.SelectedItem = sdr[5].ToString().Trim();
                cmbCategory.SelectedItem = sdr[6].ToString();
                cmbStatus.SelectedItem = sdr[7].ToString().Trim();
            }
            
            con.Close();
            
        }

        //private void cmbCId_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Id = Convert.ToInt32(cmbCId.SelectedItem);
        //    cmd.Connection = con;
        //    cmd.CommandText = "select * from tblCategory where CategoryId = " + Id;
        //    con.Open();
        //    sdr = cmd.ExecuteReader();
        //    cmbCategory.Items.Clear();
        //    while (sdr.Read())
        //    {
        //        // cmbCategory.Items.Add(sdr[1].ToString());
        //        cmbCategory.Text = sdr[1].ToString();
        //    }
        //    con.Close();
        //}

        

        
    }

}