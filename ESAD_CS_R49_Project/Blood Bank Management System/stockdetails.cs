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
    public partial class stockdetails : Form
    {
        public stockdetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stockdetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsStockDetails.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.dsStockDetails.stock);

        }
    }
}
