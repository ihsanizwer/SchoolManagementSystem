namespace AdministrativeCommunicationSystem
{
    partial class ADMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMainMenu));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.metroTile1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroTile2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroTile3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroTile4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroTile5, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 520);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile1.Location = new System.Drawing.Point(8, 8);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(744, 96);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Manage Users";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile2.Location = new System.Drawing.Point(8, 110);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(744, 96);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Monitor Users";
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile3.Location = new System.Drawing.Point(8, 212);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(744, 96);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Backup and Restore";
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile4.Location = new System.Drawing.Point(8, 314);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(744, 96);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "Communication";
            this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile4.UseCustomForeColor = true;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile5.Location = new System.Drawing.Point(8, 416);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(744, 96);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile5.TabIndex = 4;
            this.metroTile5.Text = "Exit";
            this.metroTile5.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile5.TileImage")));
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile5.UseCustomForeColor = true;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // ADMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ADMainMenu";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Administrative and Communication System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ADMainMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;

    }
}

