using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void manageCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooksCategory bc = new frmBooksCategory();
            bc.Show();
            
        }

        private void manageBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooks bks = new frmBooks();
            bks.Show();
            
        }

        private void manageBorrowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowers brs = new frmBorrowers();
            brs.Show();
           
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers us = new frmUsers();
            us.Show();
            
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            frmIssue iss = new frmIssue();
            iss.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmReturn rtn = new frmReturn();
            rtn.Show();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            frmLogin lgn = new frmLogin();
            lgn.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport rpt = new frmReport();
            rpt.Show();
            
        }
    }
}
