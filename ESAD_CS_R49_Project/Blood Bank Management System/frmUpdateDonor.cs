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
    public partial class frmUpdateDonor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RCQHOMO;Initial Catalog=Blood_Bank_Management;Integrated Security=True");
        public frmUpdateDonor()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadCombo()
        {
            //con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Id,bloodgroupName FROM bloodGroups", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbBlood.DataSource = ds.Tables[0];
            cmbBlood.DisplayMember = "bloodgroupName";
            cmbBlood.ValueMember = "Id";


            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT dID FROM newDonor", con);
            DataSet ds2 = new DataSet();
            sda2.Fill(ds2);
            cmbID.DataSource = ds2.Tables[0];
            cmbID.DisplayMember = "dID";
            cmbID.ValueMember = "dID";
            //con.Close();
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPicturePath.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);


            SqlCommand cmd = new SqlCommand("UPDATE newDonor SET name=@n,phone=@p,email=@e,address=@a,gender=@g,bloodGroupId=@bid,picture=@pic WHERE dID=@dId", con);
            cmd.Parameters.AddWithValue("@dId", cmbID.SelectedIndex);
            
            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@p", txtphone.Text);
            cmd.Parameters.AddWithValue("@e", txtemail.Text);
            cmd.Parameters.AddWithValue("@a", txtaddress.Text);
            cmd.Parameters.AddWithValue("@g", cmbgender.SelectedItem);
            cmd.Parameters.Add(new SqlParameter("@pic", SqlDbType.VarBinary) { Value = ms.ToArray() });
            cmd.Parameters.AddWithValue("@bid", cmbBlood.SelectedValue);

            con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Updated successfully!!!");
            }
            con.Close();
            LoadCombo();
        }
  

    private void btnpicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPicturePath.Text = openFileDialog1.FileName;
            }
        }

        private void frmUpdateDonor_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM newDonor WHERE dID=@i", con);
            cmd.Parameters.AddWithValue("@i", cmbID.SelectedValue);
            con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Deleted successfully!!!");
            }
            con.Close();
            LoadCombo();
        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RCQHOMO;Initial Catalog=Blood_Bank_Management;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT dID,[name],phone,email,address,gender,picture,bloodGroupId FROM newDonor WHERE dID=@i";
            cmd.Parameters.AddWithValue("@i", cmbID.SelectedIndex);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtName.Text = dr.GetString(1);
                txtphone.Text = dr.GetString(2);
                txtemail.Text = dr.GetString(3);
                txtaddress.Text = dr.GetString(4);
                pictureBox1.Image = Image.FromStream(dr.GetStream(6));
                cmbBlood.SelectedValue = dr.GetInt32(7);
            }
            con.Close();



            
        }
    }
}

