using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmAddNew frmNew = new frmAddNew();
            frmNew.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateDonor up = new frmUpdateDonor();
            up.Show();
        }

        private void allDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllDonorDetails donorDetails = new frmAllDonorDetails();
            donorDetails.Show();
        }

  

        private void newPatientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void patientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreport2 rpt = new frmreport2();
            rpt.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockdetails sdetails = new stockdetails();
            sdetails.Show();
        }
    }
}
