using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    

    public partial class frmAddNew : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RCQHOMO;Initial Catalog=Blood_Bank_Management;Integrated Security=True");
        public frmAddNew()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpicture_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPicturePath.Text = openFileDialog1.FileName;
            }
        }

        private void AllClear()
        {
            txtId.Text = "";
            txtName.Clear();
            txtphone.Clear();
            txtemail.Clear();
            txtaddress.Clear();
            cmbgender.SelectedIndex = -1;
            cmbBlood.SelectedIndex = -1;
            txtPicturePath.Clear();
        }

        private void LoadCombo()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Id,bloodgroupName FROM bloodGroups", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbBlood.DataSource = ds.Tables[0];
            cmbBlood.DisplayMember = "bloodgroupName";
            cmbBlood.ValueMember = "Id";
            con.Close();

        }



        private void btnInsert_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPicturePath.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO newDonor(dID,[name],phone,email,address,gender,bloodGroupId,picture) VALUES(@i,@n,@p,@e,@a,@g,@id,@pic)";
            cmd.Parameters.AddWithValue("@i", txtId.Text);
            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@p", txtphone.Text);
            cmd.Parameters.AddWithValue("@e", txtemail.Text);
            cmd.Parameters.AddWithValue("@a", txtaddress.Text);
            cmd.Parameters.AddWithValue("@g", cmbgender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@id", cmbBlood.SelectedValue);
            cmd.Parameters.Add(new SqlParameter("@pic", SqlDbType.VarBinary) { Value = ms.ToArray() });



            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data inserted successfully!!!");
            }
            con.Close();
            AllClear();
        }

        private void frmAddNew_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }
    }
}
