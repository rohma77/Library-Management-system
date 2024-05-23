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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        
        private void btnOK_Click(object sender, EventArgs e)
        {
            string UserName = txtUsername.Text.ToString().Trim();
            string Password = txtPassword.Text.ToString().Trim();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LibraryManagment;Integrated Security=True");
            string query = "Select User_name, Pass from tblUser where User_name = '" + UserName + "' and Pass = '" + Password + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("Successfull....");
                Form1 frm = new Form1();
                this.Hide();

                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid....");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
