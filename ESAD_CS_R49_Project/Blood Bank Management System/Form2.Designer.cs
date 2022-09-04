
namespace Blood_Bank_Management_System
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientDataSet = new Blood_Bank_Management_System.patientDataSet();
            this.patientTableAdapter = new Blood_Bank_Management_System.patientDataSetTableAdapters.patientTableAdapter();
            this.blood_Bank_ManagementDataSet1 = new Blood_Bank_Management_System.Blood_Bank_ManagementDataSet1();
            this.blood_Bank_ManagementDataSet2 = new Blood_Bank_Management_System.Blood_Bank_ManagementDataSet2();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_Bank_ManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_Bank_ManagementDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIdDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.bloodgroupDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(761, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "patient";
            this.patientBindingSource.DataSource = this.patientDataSet;
            // 
            // patientDataSet
            // 
            this.patientDataSet.DataSetName = "patientDataSet";
            this.patientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // blood_Bank_ManagementDataSet1
            // 
            this.blood_Bank_ManagementDataSet1.DataSetName = "Blood_Bank_ManagementDataSet1";
            this.blood_Bank_ManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blood_Bank_ManagementDataSet2
            // 
            this.blood_Bank_ManagementDataSet2.DataSetName = "Blood_Bank_ManagementDataSet2";
            this.blood_Bank_ManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pIdDataGridViewTextBoxColumn
            // 
            this.pIdDataGridViewTextBoxColumn.DataPropertyName = "pId";
            this.pIdDataGridViewTextBoxColumn.HeaderText = "pId";
            this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "pName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "pName";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            // 
            // bloodgroupDataGridViewTextBoxColumn
            // 
            this.bloodgroupDataGridViewTextBoxColumn.DataPropertyName = "blood-group";
            this.bloodgroupDataGridViewTextBoxColumn.HeaderText = "blood-group";
            this.bloodgroupDataGridViewTextBoxColumn.Name = "bloodgroupDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
           
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_Bank_ManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood_Bank_ManagementDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private patientDataSet patientDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private patientDataSetTableAdapters.patientTableAdapter patientTableAdapter;
        private System.Windows.Forms.Label label1;
        private Blood_Bank_ManagementDataSet1 blood_Bank_ManagementDataSet1;
        private Blood_Bank_ManagementDataSet2 blood_Bank_ManagementDataSet2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroupDataGridViewTextBoxColumn;
    }
}