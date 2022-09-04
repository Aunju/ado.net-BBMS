
namespace Blood_Bank_Management_System
{
    partial class frmAddNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNew));
            this.txtPicturePath = new System.Windows.Forms.TextBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.cmbBlood = new System.Windows.Forms.ComboBox();
            this.lblbloodgroup = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnpicture = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblphoneNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPicturePath
            // 
            this.txtPicturePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPicturePath.Location = new System.Drawing.Point(171, 327);
            this.txtPicturePath.Name = "txtPicturePath";
            this.txtPicturePath.Size = new System.Drawing.Size(257, 22);
            this.txtPicturePath.TabIndex = 56;
            // 
            // cmbgender
            // 
            this.cmbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbgender.Location = new System.Drawing.Point(171, 254);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(257, 24);
            this.cmbgender.TabIndex = 55;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.Transparent;
            this.lblgender.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(95, 254);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(68, 19);
            this.lblgender.TabIndex = 54;
            this.lblgender.Text = "Gender";
            // 
            // cmbBlood
            // 
            this.cmbBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBlood.FormattingEnabled = true;
            this.cmbBlood.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.cmbBlood.Location = new System.Drawing.Point(171, 284);
            this.cmbBlood.Name = "cmbBlood";
            this.cmbBlood.Size = new System.Drawing.Size(257, 24);
            this.cmbBlood.TabIndex = 53;
            // 
            // lblbloodgroup
            // 
            this.lblbloodgroup.AutoSize = true;
            this.lblbloodgroup.BackColor = System.Drawing.Color.Transparent;
            this.lblbloodgroup.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbloodgroup.Location = new System.Drawing.Point(58, 286);
            this.lblbloodgroup.Name = "lblbloodgroup";
            this.lblbloodgroup.Size = new System.Drawing.Size(108, 19);
            this.lblbloodgroup.TabIndex = 52;
            this.lblbloodgroup.Text = "Blood Group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(560, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(529, 372);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(89, 34);
            this.btnInsert.TabIndex = 49;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnpicture
            // 
            this.btnpicture.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpicture.Location = new System.Drawing.Point(444, 325);
            this.btnpicture.Name = "btnpicture";
            this.btnpicture.Size = new System.Drawing.Size(39, 28);
            this.btnpicture.TabIndex = 48;
            this.btnpicture.Text = "...";
            this.btnpicture.UseVisualStyleBackColor = true;
            this.btnpicture.Click += new System.EventHandler(this.btnpicture_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Picture";
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(171, 216);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(257, 22);
            this.txtaddress.TabIndex = 46;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(171, 188);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(257, 22);
            this.txtemail.TabIndex = 45;
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(169, 157);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(257, 22);
            this.txtphone.TabIndex = 44;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(169, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(257, 22);
            this.txtName.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Address";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(95, 188);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 19);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "Email";
            // 
            // lblphoneNo
            // 
            this.lblphoneNo.AutoSize = true;
            this.lblphoneNo.BackColor = System.Drawing.Color.Transparent;
            this.lblphoneNo.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphoneNo.Location = new System.Drawing.Point(79, 158);
            this.lblphoneNo.Name = "lblphoneNo";
            this.lblphoneNo.Size = new System.Drawing.Size(84, 19);
            this.lblphoneNo.TabIndex = 37;
            this.lblphoneNo.Text = "Phone No";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(103, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 19);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(79, 88);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(82, 19);
            this.lblID.TabIndex = 31;
            this.lblID.Text = "Donor ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 41);
            this.label1.TabIndex = 30;
            this.label1.Text = "ADD NEW DONOR";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(763, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 24);
            this.label4.TabIndex = 85;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(167, 87);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(259, 20);
            this.txtId.TabIndex = 88;
            // 
            // frmAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPicturePath);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.cmbBlood);
            this.Controls.Add(this.lblbloodgroup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnpicture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblphoneNo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNew";
            this.Load += new System.EventHandler(this.frmAddNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPicturePath;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.ComboBox cmbBlood;
        private System.Windows.Forms.Label lblbloodgroup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnpicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblphoneNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtId;
    }
}