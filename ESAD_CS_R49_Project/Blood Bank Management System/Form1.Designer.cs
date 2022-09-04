
namespace Blood_Bank_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatientListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorInformationReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(862, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 58);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donorToolStripMenuItem
            // 
            this.donorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.updateDetailsToolStripMenuItem,
            this.allDonorToolStripMenuItem});
            this.donorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donorToolStripMenuItem.Image")));
            this.donorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            this.donorToolStripMenuItem.Size = new System.Drawing.Size(102, 54);
            this.donorToolStripMenuItem.Text = "Donor";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewToolStripMenuItem.Image")));
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // updateDetailsToolStripMenuItem
            // 
            this.updateDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateDetailsToolStripMenuItem.Image")));
            this.updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            this.updateDetailsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.updateDetailsToolStripMenuItem.Text = "Update Details";
            this.updateDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDetailsToolStripMenuItem_Click);
            // 
            // allDonorToolStripMenuItem
            // 
            this.allDonorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("allDonorToolStripMenuItem.Image")));
            this.allDonorToolStripMenuItem.Name = "allDonorToolStripMenuItem";
            this.allDonorToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.allDonorToolStripMenuItem.Text = "All Donor Details";
            this.allDonorToolStripMenuItem.Click += new System.EventHandler(this.allDonorToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPatientListToolStripMenuItem});
            this.patientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("patientToolStripMenuItem.Image")));
            this.patientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(106, 54);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // newPatientListToolStripMenuItem
            // 
            this.newPatientListToolStripMenuItem.Name = "newPatientListToolStripMenuItem";
            this.newPatientListToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.newPatientListToolStripMenuItem.Text = "New Patient List";
            this.newPatientListToolStripMenuItem.Click += new System.EventHandler(this.newPatientListToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockToolStripMenuItem.Image")));
            this.stockToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(64, 54);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorInformationReportToolStripMenuItem,
            this.patientInformationToolStripMenuItem});
            this.reportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportToolStripMenuItem.Image")));
            this.reportToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(74, 54);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // donorInformationReportToolStripMenuItem
            // 
            this.donorInformationReportToolStripMenuItem.Name = "donorInformationReportToolStripMenuItem";
            this.donorInformationReportToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.donorInformationReportToolStripMenuItem.Text = "Donor Information Report";
            
            // 
            // patientInformationToolStripMenuItem
            // 
            this.patientInformationToolStripMenuItem.Name = "patientInformationToolStripMenuItem";
            this.patientInformationToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.patientInformationToolStripMenuItem.Text = "Patient Information";
            this.patientInformationToolStripMenuItem.Click += new System.EventHandler(this.patientInformationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorInformationReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPatientListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
    }
}

