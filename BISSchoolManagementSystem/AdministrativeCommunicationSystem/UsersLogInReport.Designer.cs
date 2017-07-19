namespace AdministrativeCommunicationSystem
{
    partial class UsersLogInReport
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
            this.CrystalReport21 = new AdministrativeCommunicationSystem.CrystalReport2();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport31 = new AdministrativeCommunicationSystem.CrystalReport3();
            this.CrystalReport32 = new AdministrativeCommunicationSystem.CrystalReport3();
            this.CrystalReport22 = new AdministrativeCommunicationSystem.CrystalReport2();
            this.CrystalReport23 = new AdministrativeCommunicationSystem.CrystalReport2();
            this.CrystalReport33 = new AdministrativeCommunicationSystem.CrystalReport3();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(20, 60);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport21;
            this.crystalReportViewer1.Size = new System.Drawing.Size(760, 520);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // UsersLogInReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "UsersLogInReport";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "UsersLogInReport";
            this.Load += new System.EventHandler(this.UsersLogInReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReport2 CrystalReport21;
        private CrystalReport3 CrystalReport31;
        private CrystalReport3 CrystalReport32;
        private CrystalReport2 CrystalReport22;
        private CrystalReport2 CrystalReport23;
        private CrystalReport3 CrystalReport33;
    }
}