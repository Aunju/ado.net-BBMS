using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class frmlogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RCQHOMO;Initial Catalog=Blood_Bank_Management;Integrated Security=True");
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "Anju" && txtpassword.Text == "pass")
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter valid Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblNotRegistered_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister fr = new frmRegister();
            fr.Show();
            this.Hide();
        }
    }
}
