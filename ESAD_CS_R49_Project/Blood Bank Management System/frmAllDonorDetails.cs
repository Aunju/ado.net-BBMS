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
    public partial class frmAllDonorDetails : Form
    {
        public frmAllDonorDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAllDonorDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNewDonor.newDonor' table. You can move, or remove it, as needed.
            this.newDonorTableAdapter.Fill(this.dsNewDonor.newDonor);

        }
    }
}
