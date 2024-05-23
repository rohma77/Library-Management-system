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
    public partial class frmBookReturned : Form
    {
        public frmBookReturned()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LibraryManagment;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;

        public string BorrowerId { get; set; }
        public string BookId { get; set; }

        private void frmBookReturned_Load(object sender, EventArgs e)
        {
             cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Select * from tblReturn where BorrowerID = '" + BorrowerId + "' and BookId = '" + BookId + "'";

            sdr = cmd.ExecuteReader();

            
            while (sdr.Read())
            {
                txtBookID.Text = sdr[0].ToString().Trim();
                txtTitle.Text = sdr[1].ToString().Trim().ToUpper();
                txtBorrowerID.Text = sdr[2].ToString().Trim();
                txtFirstName.Text = sdr[3].ToString().ToUpper().Trim();
                dtpBorrowDate.Value = Convert.ToDateTime(sdr[4].ToString().Trim());
                dtpExpectedReturnDate.Value = Convert.ToDateTime(sdr[5].ToString().Trim());
                dtpActualReturnDate.Value = Convert.ToDateTime(sdr[6].ToString().Trim());
                cmbStatus.Text = sdr[7].ToString().Trim();

            }
            con.Close();
                
        }
    }
}
