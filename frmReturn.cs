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
    public partial class frmReturn : Form
    {
        public frmReturn()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LibraryManagment;Integrated Security=True");
        SqlDataAdapter sda;
        //SqlDataReader sdr;
        //SqlCommand cmd;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadDetails()
        {
            string Status = "BORROWED";
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LibraryManagment;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            string BorrowerId = txtBorrowerId.Text.ToString().Trim();
            if (txtBorrowerId.Text.ToString().Trim() != "")
            {
                //string BorrowerId = txtBorrowerId.Text.ToString().Trim();

                //SqlDataReader sdr;
                cmd.Connection = con;
                cmd.CommandText = "select Name from tblBorrow where BorrowerId like'" + BorrowerId + "%'";
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    // Check if there are any rows
                    if (sdr.Read())
                    {
                        // Update the TextBox with the retrieved Name
                        txtBorrowerName.Text = sdr["Name"].ToString().ToUpper().Trim();

                    }
                    else
                    {
                        // Handle the case when no matching record is found
                        txtBorrowerName.Text = "Borrower not found";
                    }
                }

                DataTable dt = new DataTable();
                BorrowerId = txtBorrowerId.Text.ToString().Trim();
                //string query = "select * from  tblBorrow where BorrowerId like'" + BorrowerId + "%'";
                string query = "select BookId,Title,Author,Language,PublishDate,CategoryId,Category,Status,BorrowDate,ReturnDate,BorrowerId from tblBorrow where BorrowerId like'" + BorrowerId + "%' AND Status = '" + Status + "'";
                sda = new SqlDataAdapter(query, con);
                sda.Fill(dt);
                dgvBorrowedBooks.DataSource = dt;
            }
           
        }

        private void dgvBorrowedBookDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmBookIssueDetails bid = new frmBookIssueDetails();
            bid.BookId = dgvBorrowedBookDetails.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            bid.BorrowId = dgvBorrowedBookDetails.Rows[e.RowIndex].Cells[10].Value.ToString().Trim();
            bid.Show();
            

        }

        private void frmReturn_Load(object sender, EventArgs e)
        {
            string Status = "BORROWED";
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter("select * from tblBorrow where Status = '" + Status + "'", con);
            sda.Fill(dt);
            dgvBorrowedBookDetails.DataSource = dt;

            DataTable dtt = new DataTable();
            sda = new SqlDataAdapter("select * from tblReturn", con);
            sda.Fill(dtt);
            dtgListreturned.DataSource = dtt;
            LoadDetails();
        }

        private void txtBorrowerId_TextChanged(object sender, EventArgs e)
        {
            LoadDetails();
            
        }

        private void txtSearchUnreturnBook_TextChanged(object sender, EventArgs e)
        {
            string Status = "BORROWED";
            DataTable dt = new DataTable();
            string BorrowerId = txtSearchUnreturnBook.Text.ToString().Trim();
            string query = "select * from tblBorrow where BorrowerId like'" + BorrowerId + "%' and Status ='" + Status + "'";

            sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            dgvBorrowedBookDetails.DataSource = dt;
        }

        private void dgvBorrowedBooks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmBookReturnDetails brd = new frmBookReturnDetails();
            brd.BookId = dgvBorrowedBooks.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            brd.BorrowerId = dgvBorrowedBooks.Rows[e.RowIndex].Cells[10].Value.ToString().Trim();
            brd.Show();
        }

        private void TabControl3_Selected(object sender, TabControlEventArgs e)
        {
            DataTable dtt = new DataTable();
            sda = new SqlDataAdapter("select * from tblReturn", con);
            sda.Fill(dtt);
            dtgListreturned.DataSource = dtt;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSearchUnreturnBook.Clear();
            txtBorrowerId.Clear();
            txtBorrowerName.Clear();
        }

        private void dtgListreturned_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmBookReturned bid = new frmBookReturned();

            bid.BookId = dtgListreturned.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            bid.BorrowerId = dtgListreturned.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            bid.Show();
        }

 
    }
}

