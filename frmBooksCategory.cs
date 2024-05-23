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
    public partial class frmBooksCategory : Form
    {
        public frmBooksCategory()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LibraryManagment;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda;
        SqlDataReader sdr;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "insert into tblCategory values('"
                    + txtCategoryID.Text.Trim() + "' , '"
                    + cmbCategory.SelectedItem.ToString().Trim().ToUpper() + "')";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Save Successfully...");
                LoadBookcategory();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearData()
        {
            txtCategoryID.Clear();
            cmbCategory.Text = "Select Category";
        }

        public void LoadBookcategory()
        {
            DataSet ds = new DataSet();
            sda = new SqlDataAdapter("select * from tblCategory", con);
            sda.Fill(ds);
            dgvBooksCategories.DataSource = ds.Tables[0];
        }

        int CId;
        private void dgvBooksCategories_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CId = Convert.ToInt32(dgvBooksCategories.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmd.Connection = con;
            cmd.CommandText = "select * from tblCategory where CategoryId = " + CId;
            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtCategoryID.Text = sdr[0].ToString().Trim();
                cmbCategory.SelectedItem = sdr[1].ToString().Trim();
                

            }
            con.Close();


        }

        private void frmBooksCategory_Load(object sender, EventArgs e)
        {
            LoadBookcategory();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "update tblCategory set " +
                "CategoryId = '" + txtCategoryID.Text.Trim() + "' , " +
                "Category = '" + cmbCategory.SelectedItem.ToString().Trim().ToUpper() + "' where CategoryId = " + CId;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Save Successfully...");
                LoadBookcategory();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure you want to delete it", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (rs == DialogResult.Yes)
            {
                cmd.Connection = con;
                cmd.CommandText = "delete from tblCategory where CategoryId = " + CId;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully..");
                LoadBookcategory();
                ClearData();
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string name = txtSearch.Text.ToString().Trim();
            //string query = "select * from tblCategory where CategoryId like '" + txtCategoryID.ToString() + "%'";
            string query = "select * from tblCategory where CategoryId like'" + name + "%'";
            sda = new SqlDataAdapter(query, con);
            sda.Fill(ds);
            dgvBooksCategories.DataSource = ds.Tables[0];

            
        }

    }
}
