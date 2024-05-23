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
    public partial class frmBookReturnDetails : Form
    {
        public frmBookReturnDetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LibraryManagment;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;
        

        public void ClearData()
        {
            txtBookID.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtLanguage.Clear();
            dtpPublishDate.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            cmbCId.Text = "--------";
            cmbCategory.Text = "------";
            txtBorrowerID.Clear();
            txtFirstName.Clear();
            //if (rdomale.Checked == true)
                rdomale.Checked = false;
            //if (rdofemale.Checked == true)
                rdofemale.Checked = false;
                txtContactNo.Clear();
                dtpPublishDate.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
                dtpReturnDate.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
                cmbStatus.Text = "------";
                dtpDate.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
        }

        public void LoadDetails()
        {
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Select * from tblBorrow where BorrowerId = '" + BorrowerId + "' and BookId = '" + BookId + "'";

            sdr = cmd.ExecuteReader();

            //int number = 1;
            while (sdr.Read())
            {
                txtBookID.Text = sdr[0].ToString().Trim();
                txtTitle.Text = sdr[1].ToString().Trim().ToUpper();
                txtAuthor.Text = sdr[2].ToString().Trim().ToUpper();
                txtLanguage.Text = sdr[3].ToString().Trim().ToUpper();
                dtpPublishDate.Value = Convert.ToDateTime(sdr[4].ToString().Trim());
                cmbCId.Text = sdr[5].ToString().Trim().ToUpper();
                cmbCategory.Text = sdr[6].ToString().Trim().ToUpper();
                cmbStatus.Text = sdr[7].ToString().Trim();
                dtpBorrowDate.Value = Convert.ToDateTime(sdr[8].ToString().Trim());
                dtpReturnDate.Value = Convert.ToDateTime(sdr[9].ToString().Trim());
                txtBorrowerID.Text = sdr[10].ToString().Trim();
                txtFirstName.Text = sdr[11].ToString().ToUpper().Trim();
                if (sdr[12].ToString().ToUpper().Trim() == "FEMALE")
                {
                    rdofemale.Checked = true;
                    rdomale.Checked = false;
                }
                else
                {
                    rdomale.Checked = true;
                    rdofemale.Checked = false;
                }
                txtContactNo.Text = sdr[13].ToString().ToUpper().Trim();
            }
            con.Close();
        }

        public string BorrowerId { get; set; }
        public string BookId { get; set; }

        private void frmBookReturnDetails_Load(object sender, EventArgs e)
        {
            LoadDetails();

        }

        string Status = "RETURNED";

        private void btnreturn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandText = "insert into tblReturn values('"
                        + txtBookID.Text.ToString().ToUpper().Trim() + "', '"
                        + txtTitle.Text.ToString().ToUpper().Trim() + "', '"
                        + txtBorrowerID.Text.ToString().ToUpper().Trim() + "' , '"
                        + txtFirstName.Text.ToString().ToUpper().Trim() + "' , '"
                        + dtpBorrowDate.Value.ToLongDateString() + "' , '"
                        + dtpReturnDate.Value.ToLongDateString() + "' , '"
                        + dtpDate.Value.ToLongDateString() + "', '"
                        + Status + "' )";

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book return Successfully...");
                    ClearData();

                    //con.Open();
                    //cmd.Connection = con;
                    //cmd.CommandText = "delete from tblBorrow where BorrowerId = '" + BorrowerId + "' and BookId = '" + BookId + "'";

                    //cmd.ExecuteNonQuery();
                    //con.Close();

                    if (Status == "RETURNED")
                    {
                        Status = "AVAILABLE";
                    }
                    else { 
                    }
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "update tblBorrow set " +
                    "Status = '" + Status + "' where BookID = " + BookId;

                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "update tblBooks set " +
                    "Status = '" + Status + "' where BookID = " + BookId;

                    cmd.ExecuteNonQuery();
                    con.Close();

                    this.Close();
                    LoadDetails();
                    //MessageBox.Show("Record Deleted Successfully!");
                  //  LoadBorrowers();
                   // ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
