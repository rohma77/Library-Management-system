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
    public partial class frmBookIssueDetails : Form
    {
        public frmBookIssueDetails()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LibraryManagment;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;
       

        public string BorrowId { get; set; }
        public string BookId { get; set; }

        private void frmBookIssueDetails_Load(object sender, EventArgs e)
        {
            cmd.Connection = con;
            con.Open();
            //"SELECT * FROM tblBorrow WHERE BorrowerId = '" + Id + "' AND BookId = '" + BookId + "'";
            cmd.CommandText = "Select * from tblBorrow where BorrowerId = '" + BorrowId + "' and BookId = '" + BookId + "'";
            
            sdr = cmd.ExecuteReader();

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
        }
    }
}
