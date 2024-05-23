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
    public partial class frmIssue : Form
    {
        public frmIssue()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LibraryManagment;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmdinsrt = new SqlCommand();
        SqlCommand cmdupdt = new SqlCommand();
        SqlDataReader sdr;
        SqlDataAdapter sda;

        public void LoadBorrowedBookDetalis()
        {

            //cmbStatus.SelectedText = "BORROWED";
            string st = "BORROWED";
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter("select * from tblBorrow where Status = '" + st +"'", con);
            sda.Fill(dt);
            dgvBorrowedBook.DataSource = dt;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        public void ClearData()
        {
            txtBookId.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtLanguage.Clear();
            dtpPublishDate.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            cmbCId.Text = "--Select Category Id--";
            cmbCategory.Text = "--Select Category--";
            cmbStatus.Text = "--Select Status--";
            txtBorrowerID.Clear();
            txtFirstName.Clear();
            if (rdomale.Checked == true)
                rdomale.Checked = false;
            if (rdofemale.Checked == true)
                rdofemale.Checked = false;
            txtContactNo.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnBorrowerFullDetails_Click(object sender, EventArgs e)
        {
            frmBorrowerFullDetails fd = new frmBorrowerFullDetails();
           
            fd.Id = Convert.ToInt32(txtBorrowerID.Text.Trim());
            fd.Show();
        
        }

        public void Fetchdata()
        {
            string Id = txtBookId.Text.ToString().Trim();
            cmd.Connection = con;
            cmd.CommandText = "select * from  tblBooks where BookID = " + Id;
            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtTitle.Text = sdr[1].ToString().Trim().ToUpper();
                txtAuthor.Text = sdr[2].ToString().Trim().ToUpper();
                txtLanguage.Text = sdr[3].ToString().Trim().ToUpper();
                dtpPublishDate.Value = Convert.ToDateTime(sdr[3].ToString().Trim().ToUpper());
                cmbCId.SelectedItem = sdr[5].ToString().Trim().ToUpper();
                cmbCategory.SelectedItem = sdr[6].ToString().Trim().ToUpper();
                cmbStatus.SelectedItem = sdr[7].ToString().Trim().ToUpper();
            }
            con.Close();

        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {


            if (txtBookId.Text.Trim() != "")
            {
                int BookId = Convert.ToInt32(txtBookId.Text.Trim());

                string Status = "AVAILABLE";
                cmbStatus.Text = Status;
                DataSet ds = new DataSet();
                cmd.Connection = con;

                cmd.CommandText = "select * from tblBooks where BookID LIKE '%" + BookId + "%' AND Status = '" + Status + "'";
                con.Open();
                sdr = cmd.ExecuteReader();
                if (sdr.FieldCount > 1)
                {
                    if (sdr.Read())
                    {
                        txtBookId.Text = sdr[0].ToString().Trim();
                        txtTitle.Text = sdr[1].ToString().Trim().ToUpper();
                        txtAuthor.Text = sdr[2].ToString().Trim().ToUpper();
                        txtLanguage.Text = sdr[3].ToString().Trim().ToUpper();
                        dtpPublishDate.Value = Convert.ToDateTime(sdr[4].ToString().Trim());
                        cmbCId.Text = sdr[5].ToString().Trim().ToUpper();
                        cmbCategory.Text = sdr[6].ToString().Trim().ToUpper();
                        cmbStatus.Text = sdr[7].ToString().Trim();

                    }
                    else
                    {
                        MessageBox.Show("No Book available with this ID");
                    }
                    con.Close();
                }
               
            }
            
           
            
           

        }

        string Gender;
        private void btn_Bsave_Click(object sender, EventArgs e)
        {
            string Status = "BORROWED";
            int BookId = Convert.ToInt32(txtBookId.Text.Trim());
            cmbStatus.Text = Status;
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LibraryManagment;Integrated Security=True");
            
            //using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LibraryManagment;Integrated Security=True"))
            //{
                try
                {

                    if (rdofemale != null && rdomale != null)
                    {
                        if (rdofemale.Checked)
                        {
                            Gender = rdofemale.Text.Trim().ToUpper();
                        }
                        else
                        {
                            Gender = rdomale.Text.Trim().ToUpper();
                        }
                    }
                    else
                    {
                        // Handle the case where rdofemale or rdomale is null
                        MessageBox.Show("One or both radio buttons are not initialized.");
                    }

                    
                    con.Open();
                    cmdinsrt.Connection = con;
                    cmdinsrt.CommandText = "insert into tblBorrow values ('"
                        + txtBookId.Text.ToString().ToUpper().Trim() + "' , '"
                        + txtTitle.Text.ToString().ToUpper().Trim() + "' , '"
                        + txtAuthor.Text.ToString().ToUpper().Trim() + "' , '"
                        + txtLanguage.Text.ToString().ToUpper().Trim() + "' , '"
                        + dtpPublishDate.Value.ToLongDateString() + "' , '"
                        + cmbCId.Text.ToString().ToUpper().Trim() + "' , '"
                        + cmbCategory.Text.ToString().ToUpper().Trim() + "' , '"
                        + Status + "' , '"
                        + dtpBorrowDate.Value.ToLongDateString() + "' , '"
                        + dtpReturnDate.Value.ToLongDateString() + "' , '"
                        + txtBorrowerID.Text.ToString().Trim() + "' , '"
                        + txtFirstName.Text.ToString().ToUpper().Trim() + "' , '"
                        + Gender + "' , '"
                        + txtContactNo.Text.ToString().ToUpper().Trim() + "')";

                    cmdinsrt.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book issue Successfully...");



                    con.Open();
                    cmdupdt.Connection = con;
                    cmdupdt.CommandText = "update tblBooks set " +
                    "Status = '" + Status + "' where BookID = " + BookId;

                    cmdupdt.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show("Data Updated Successfully...");

                    ClearData();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                LoadBorrowedBookDetalis();
            
        }

        private void txtBorrowerID_TextChanged(object sender, EventArgs e)
        {
            if (txtBorrowerID.Text.ToString().Trim() != "")
            {
                int BorrowerId = Convert.ToInt32(txtBorrowerID.Text.ToString().Trim());
                DataSet ds = new DataSet();
                string query = "select * from tblBorrower where BorrowerId like " + BorrowerId;
                cmd.Connection = con;
                cmd.CommandText = query;
                con.Open();
                sdr = cmd.ExecuteReader();
                if (sdr.FieldCount > 1)
                {
                    if (sdr.Read())
                    {
                        txtBorrowerID.Text = sdr[0].ToString().Trim();
                        txtFirstName.Text = sdr[2].ToString().ToUpper().Trim();
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
                        txtContactNo.Text = sdr[6].ToString().ToUpper().Trim();
                    }
                    else
                    {
                        MessageBox.Show("No Borrower available with this ID");
                    }

                    con.Close();
                }

            }
        }

        //private void tbpgBorrowedBook_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();
        //    sda = new SqlDataAdapter("select * from tblBorrow", con);
        //    sda.Fill(dt);
        //    dgvBorrowedBook.DataSource = dt;
        //}

        
        private void frmIssue_Load(object sender, EventArgs e)
        {
            LoadBorrowedBookDetalis();
            //cmbStatus.SelectedText = "BORROWED";
            dtpReturnDate.Value = dtpReturnDate.Value.AddDays(7);
        }

        private void dgvBorrowedBook_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmBookIssueDetails bid = new frmBookIssueDetails();
            
            bid.BookId = dgvBorrowedBook.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            bid.BorrowId = dgvBorrowedBook.Rows[e.RowIndex].Cells[10].Value.ToString().Trim();
            bid.Show();

        }

    }
}
