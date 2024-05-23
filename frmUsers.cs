using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//step1 import System.Data.SqlClient namespace

namespace LibraryManagementSystem
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        //step 2 create object of sqlConnection and sqlCommand
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LibraryManagment;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda;
        SqlDataReader sdr;

        public bool CheckValidation()
        {
            bool isValid = true;
            try
            {
                if (txt_name.Text == "" || txt_username.Text == "" || txt_username.Text == "" )
                {
                    MessageBox.Show("Please fill all the fields", "Required Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Data Validation Error", "Data ValidationConstraints Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            return isValid;
        }

        private void btn_saveuser_Click(object sender, EventArgs e)
        {
            //step3 create object of sqlParameter class, specify data to its value property
           
            try
            {
                if (CheckValidation() == true)
                {
                    //SqlParameter p1 = new SqlParameter("@UserId", SqlDbType.Int);
                    //p1.Value = txt_ID.Text.ToString();

                    SqlParameter p1 = new SqlParameter("@Fullname", SqlDbType.VarChar);
                    p1.Value = txt_name.Text.Trim();

                    SqlParameter p2 = new SqlParameter("@User_name", SqlDbType.VarChar);
                    p2.Value = txt_username.Text.Trim();

                    SqlParameter p3 = new SqlParameter("@Pass", SqlDbType.VarChar);
                    p3.Value = txt_pass.Text.Trim();
                    //step 5 clear/add the parameters to its command object

                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);


                    //step 6 specify connection object to command object property
                    cmd.Connection = con;

                    //step7 store the sql query in command object CommandText Property
                    cmd.CommandText = "insert into tblUser(Fullname,User_name,Pass)values(@Fullname,@User_name,@Pass)";

                    //step 8 Open the Connection
                    con.Open();

                    //step 9 Execeute the query
                    cmd.ExecuteNonQuery();

                    //step 10 Close the Connection
                    con.Close();
                    MessageBox.Show("Record Enter Successfully...");
                    ClearData();
                    LoadUser();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearData()
        {
            txt_name.Text = "";
            txt_username.Text = "";
            txt_pass.Text = "";
        }

        public void LoadUser()
        {
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter("Select * from tblUser", con);
            sda.Fill(dt);
            dgv_UserList.DataSource = dt;
        }
   
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                    //SqlParameter p1 = new SqlParameter("@UserId", SqlDbType.Int);
                    //p1.Value = txt_ID.Text.ToString();

                    SqlParameter p1 = new SqlParameter("@Fullname", SqlDbType.VarChar);
                    p1.Value = txt_name.Text.Trim();

                    SqlParameter p2 = new SqlParameter("@User_name", SqlDbType.VarChar);
                    p2.Value = txt_username.Text.Trim();

                    SqlParameter p3 = new SqlParameter("@Pass", SqlDbType.VarChar);
                    p3.Value = txt_pass.Text.Trim();
                    //step 5 clear/add the parameters to its command object

                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);


                    //step 6 specify connection object to command object property
                    cmd.Connection = con;

                    //step7 store the sql query in command object CommandText Property
                    cmd.CommandText = "update tblUser set Fullname = @Fullname, User_name = @User_name, Pass = @Pass where UserId = " + Id;

                    //step 8 Open the Connection
                    con.Open();

                    //step 9 Execeute the query
                    cmd.ExecuteNonQuery();

                    //step 10 Close the Connection
                    con.Close();
                    MessageBox.Show("Record Updated Successfully...");
                    ClearData();
                    LoadUser();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want  to delete this....", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "delete from tblUser where UserId  = " + Id;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Successfully...");
                }
               
                else
                {
                    //MessageBox.Show("");
                }
                ClearData();
                LoadUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
           
        private void btnCloseUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        int Id;
        private void dgv_UserList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dgv_UserList.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmd.Connection = con;
            cmd.CommandText = "Select * from tblUser where UserId = " + Id;
            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txt_name.Text = sdr[1].ToString().Trim();
                txt_username.Text = sdr[2].ToString().Trim();
                txt_pass.Text = sdr[3].ToString().Trim();
            }
            con.Close();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

    }
}
