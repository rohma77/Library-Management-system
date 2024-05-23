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
    public partial class frmBorrowerFullDetails : Form
    {
        public frmBorrowerFullDetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LibraryManagment;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;
        
        string Fname;
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

        public int Id { get; set; }

        private void frmBorrowerFullDetails_Load(object sender, EventArgs e)
        {
            //string query = "select *from tblBorrower where BorrowerId =" + Id;
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
                
                txtContactNo.Text = sdr[6].ToString().Trim().ToUpper();
                Fname = sdr[7].ToString().Trim().ToUpper();
                pBoxPhoto.Image = Image.FromFile(Fname);
                pBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            con.Close();
        }
    }
}
