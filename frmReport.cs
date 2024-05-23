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
using CrystalDecisions.CrystalReports.Engine;

namespace LibraryManagementSystem
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=LibraryManagment;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        

        private void frmReport_Load(object sender, EventArgs e)
        {


        }
        private void reports(string sql, string rptname)
        {
           
        }

        private void btnListBooks_Click(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
           string Status = "BORROWED";
          // cmbStatus.Text = Status;
           if (cmbStatus.Text == Status)
           {
               //DataSet1 ds = new DataSet1();
               string query = "select * from tblBooks where Status = '" + Status + "'";
               SqlDataAdapter sda = new SqlDataAdapter(query, con);
               sda.Fill(ds, "tblBooks");
           }
           else
           {
               Status = "AVAILABLE";
               //DataSet1 ds = new DataSet1();
               string query = "select * from tblBooks where Status = '" + Status + "'";
               SqlDataAdapter sda = new SqlDataAdapter(query, con);
               sda.Fill(ds, "tblBooks");
           }

               CrystalReport1 myreport = new CrystalReport1();
               myreport.SetDataSource(ds);
               crystalReportViewer1.ReportSource = myreport;
            

           
           //else
           //{
           //    DataSet1 ds1 = new DataSet1();
           //    string Status1 = "AVAILABLE";
           //    string query1 = "select * from tblBooks where Status = '" + Status1 + "'";
           //    SqlDataAdapter sda = new SqlDataAdapter(query1, con);
           //    sda.Fill(ds1, "tblBooks");
           //    CrystalReport1 myreport = new CrystalReport1();
           //    myreport.SetDataSource(ds1);
           //    crystalReportViewer1.ReportSource = myreport;
           //}
         
           
     
        }

        private void btnTotalbooks_Click(object sender, EventArgs e)
        {
            string query = "select * from tblBooks";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //DataSet1 ds = new DataSet1();
            //sda.Fill(ds, "tblBooks");
            DataTable dt = new DataTable();
            sda.Fill(dt);

            CrystalReport1 myreport = new CrystalReport1();
            myreport.SetDataSource(dt);
            crystalReportViewer1.ReportSource = myreport;
        }
    }
}
