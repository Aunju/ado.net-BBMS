
namespace Blood_Bank_Management_System
{
    partial class frmAllDonorDetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllDonorDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.blood_Bank_ManagementDataSet = new Blood_Bank_Management_System.Blood_Bank_ManagementDataSet();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.bloodBankManagementSystemDataSet = new Blood_Bank_Management_System.BloodBankManagementSystemDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.newDonorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNewDonor = new Blood_Bank_Management_System.dsNewDonor();
            this.newDonorTableAdapter = new Blood_Bank_Management_System.dsNewDonorTableAdapters.newDonorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.blood_Bank_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBankManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDonorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNewDonor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 41);
            this.label1.TabIndex = 58;
            this.label1.Text = "All DONOR DETAILS";
            // 
            // blood_Bank_ManagementDataSet
            // 
            this.blood_Bank_ManagementDataSet.DataSetName = "Blood_Bank_ManagementDataSet";
            this.blood_Bank_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(12, 399);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(82, 37);
            this.btnPrint.TabIndex = 61;
            this.btnPrint.Text = " Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(998, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bloodBankManagementSystemDataSet
            // 
            this.bloodBankManagementSystemDataSet.DataSetName = "BloodBankManagementSystemDataSet";
            this.bloodBankManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.bloodGroupIdDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.newDonorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1061, 321);
            this.dataGridView1.TabIndex = 63;
            // 
            // dIDDataGridViewTextBoxColumn
            // 
            this.dIDDataGridViewTextBoxColumn.DataPropertyName = "dID";
            this.dIDDataGridViewTextBoxColumn.HeaderText = "dID";
            this.dIDDataGridViewTextBoxColumn.Name = "dIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // bloodGroupIdDataGridViewTextBoxColumn
            // 
            this.bloodGroupIdDataGridViewTextBoxColumn.DataPropertyName = "bloodGroupId";
            this.bloodGroupIdDataGridViewTextBoxColumn.HeaderText = "bloodGroupId";
            this.bloodGroupIdDataGridViewTextBoxColumn.Name = "bloodGroupIdDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // newDonorBindingSource
            // 
            this.newDonorBindingSource.DataMember = "newDonor";
            this.newDonorBindingSource.DataSource = this.dsNewDonor;
            // 
            // dsNewDonor
            // 
            this.dsNewDonor.DataSetName = "dsNewDonor";
            this.dsNewDonor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newDonorTableAdapter
            // 
            this.newDonorTableAdapter.ClearBeforeFill = true;
            // 
            // frmAllDonorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAllDonorDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAllDonorDetails";
            this.Load += new System.EventHandler(this.frmAllDonorDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blood_Bank_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBankManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDonorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNewDonor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private BloodBankManagementSystemDataSet bloodBankManagementSystemDataSet;
        private Blood_Bank_ManagementDataSet blood_Bank_ManagementDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsNewDonor dsNewDonor;
        private System.Windows.Forms.BindingSource newDonorBindingSource;
        private dsNewDonorTableAdapters.newDonorTableAdapter newDonorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
    }
}