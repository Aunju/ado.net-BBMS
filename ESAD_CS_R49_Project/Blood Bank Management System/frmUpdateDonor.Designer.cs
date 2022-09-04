
namespace Blood_Bank_Management_System
{
    partial class frmUpdateDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateDonor));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblphoneNo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnpicture = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblbloodgroup = new System.Windows.Forms.Label();
            this.cmbBlood = new System.Windows.Forms.ComboBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.txtPicturePath = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.label4.TabIndex = 84;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 41);
            this.label1.TabIndex = 57;
            this.label1.Text = "UPDATE DONOR DETAILS";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(79, 82);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(82, 19);
            this.lblID.TabIndex = 88;
            this.lblID.Text = "Donor ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(103, 115);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 19);
            this.lblName.TabIndex = 89;
            this.lblName.Text = "Name";
            // 
            // lblphoneNo
            // 
            this.lblphoneNo.AutoSize = true;
            this.lblphoneNo.BackColor = System.Drawing.Color.Transparent;
            this.lblphoneNo.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphoneNo.Location = new System.Drawing.Point(77, 151);
            this.lblphoneNo.Name = "lblphoneNo";
            this.lblphoneNo.Size = new System.Drawing.Size(84, 19);
            this.lblphoneNo.TabIndex = 93;
            this.lblphoneNo.Text = "Phone No";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(93, 181);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 19);
            this.lblEmail.TabIndex = 94;
            this.lblEmail.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 95;
            this.label2.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(169, 115);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(257, 22);
            this.txtName.TabIndex = 96;
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(169, 150);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(257, 22);
            this.txtphone.TabIndex = 100;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(169, 181);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(257, 22);
            this.txtemail.TabIndex = 101;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(169, 209);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(257, 22);
            this.txtaddress.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 103;
            this.label3.Text = "Picture";
            // 
            // btnpicture
            // 
            this.btnpicture.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpicture.Location = new System.Drawing.Point(442, 312);
            this.btnpicture.Name = "btnpicture";
            this.btnpicture.Size = new System.Drawing.Size(39, 28);
            this.btnpicture.TabIndex = 104;
            this.btnpicture.Text = "...";
            this.btnpicture.UseVisualStyleBackColor = true;
            this.btnpicture.Click += new System.EventHandler(this.btnpicture_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(529, 366);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(89, 34);
            this.btnupdate.TabIndex = 105;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(558, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // lblbloodgroup
            // 
            this.lblbloodgroup.AutoSize = true;
            this.lblbloodgroup.BackColor = System.Drawing.Color.Transparent;
            this.lblbloodgroup.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbloodgroup.Location = new System.Drawing.Point(56, 279);
            this.lblbloodgroup.Name = "lblbloodgroup";
            this.lblbloodgroup.Size = new System.Drawing.Size(108, 19);
            this.lblbloodgroup.TabIndex = 107;
            this.lblbloodgroup.Text = "Blood Group";
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
            this.cmbBlood.Location = new System.Drawing.Point(169, 277);
            this.cmbBlood.Name = "cmbBlood";
            this.cmbBlood.Size = new System.Drawing.Size(257, 24);
            this.cmbBlood.TabIndex = 108;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.Transparent;
            this.lblgender.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(93, 247);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(68, 19);
            this.lblgender.TabIndex = 109;
            this.lblgender.Text = "Gender";
            // 
            // cmbgender
            // 
            this.cmbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbgender.Location = new System.Drawing.Point(169, 247);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(257, 24);
            this.cmbgender.TabIndex = 110;
            // 
            // txtPicturePath
            // 
            this.txtPicturePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPicturePath.Location = new System.Drawing.Point(169, 314);
            this.txtPicturePath.Name = "txtPicturePath";
            this.txtPicturePath.Size = new System.Drawing.Size(257, 22);
            this.txtPicturePath.TabIndex = 111;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(652, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 34);
            this.btnDelete.TabIndex = 113;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbID
            // 
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(169, 82);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(257, 21);
            this.cmbID.TabIndex = 114;
            this.cmbID.SelectedIndexChanged += new System.EventHandler(this.cmbID_SelectedIndexChanged);
            // 
            // frmUpdateDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPicturePath);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.cmbBlood);
            this.Controls.Add(this.lblbloodgroup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnupdate);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateDonor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateDonor";
            this.Load += new System.EventHandler(this.frmUpdateDonor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblphoneNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnpicture;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblbloodgroup;
        private System.Windows.Forms.ComboBox cmbBlood;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.TextBox txtPicturePath;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbID;
    }
}