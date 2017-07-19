namespace BOOK
{
    partial class Category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.cmb_catstatus = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_noofbooks = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.picker_date = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cmb_racknumber = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_catID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.btn_clear_category = new MetroFramework.Controls.MetroButton();
            this.btn_back_category = new MetroFramework.Controls.MetroButton();
            this.btn_update_category = new MetroFramework.Controls.MetroButton();
            this.btn_delete_category = new MetroFramework.Controls.MetroButton();
            this.btn_Add_category = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.cmb_search_racknumber = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_search_catid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.dgv_category = new MetroFramework.Controls.MetroGrid();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racknoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addeddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofbooksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sudheesanDataSet2 = new BOOK.sudheesanDataSet2();
            this.categoryTableAdapter = new BOOK.sudheesanDataSet2TableAdapters.categoryTableAdapter();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sudheesanDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(760, 76);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroTextBox1);
            this.metroPanel3.Controls.Add(this.cmb_catstatus);
            this.metroPanel3.Controls.Add(this.metroLabel9);
            this.metroPanel3.Controls.Add(this.txt_noofbooks);
            this.metroPanel3.Controls.Add(this.metroLabel8);
            this.metroPanel3.Controls.Add(this.picker_date);
            this.metroPanel3.Controls.Add(this.metroLabel7);
            this.metroPanel3.Controls.Add(this.cmb_racknumber);
            this.metroPanel3.Controls.Add(this.metroLabel6);
            this.metroPanel3.Controls.Add(this.metroLabel5);
            this.metroPanel3.Controls.Add(this.txt_catID);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(20, 330);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(760, 210);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            this.metroPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel3_Paint);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(152, 88);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(153, 23);
            this.metroTextBox1.TabIndex = 17;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmb_catstatus
            // 
            this.cmb_catstatus.FormattingEnabled = true;
            this.cmb_catstatus.ItemHeight = 23;
            this.cmb_catstatus.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.cmb_catstatus.Location = new System.Drawing.Point(554, 150);
            this.cmb_catstatus.Name = "cmb_catstatus";
            this.cmb_catstatus.Size = new System.Drawing.Size(153, 29);
            this.cmb_catstatus.TabIndex = 16;
            this.cmb_catstatus.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(398, 150);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(100, 19);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "Category status";
            // 
            // txt_noofbooks
            // 
            // 
            // 
            // 
            this.txt_noofbooks.CustomButton.Image = null;
            this.txt_noofbooks.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txt_noofbooks.CustomButton.Name = "";
            this.txt_noofbooks.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_noofbooks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_noofbooks.CustomButton.TabIndex = 1;
            this.txt_noofbooks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_noofbooks.CustomButton.UseSelectable = true;
            this.txt_noofbooks.CustomButton.Visible = false;
            this.txt_noofbooks.Lines = new string[0];
            this.txt_noofbooks.Location = new System.Drawing.Point(554, 87);
            this.txt_noofbooks.MaxLength = 32767;
            this.txt_noofbooks.Name = "txt_noofbooks";
            this.txt_noofbooks.PasswordChar = '\0';
            this.txt_noofbooks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_noofbooks.SelectedText = "";
            this.txt_noofbooks.SelectionLength = 0;
            this.txt_noofbooks.SelectionStart = 0;
            this.txt_noofbooks.Size = new System.Drawing.Size(154, 23);
            this.txt_noofbooks.TabIndex = 11;
            this.txt_noofbooks.UseSelectable = true;
            this.txt_noofbooks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_noofbooks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(398, 91);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(116, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Number Of Books";
            // 
            // picker_date
            // 
            this.picker_date.Location = new System.Drawing.Point(554, 20);
            this.picker_date.MinimumSize = new System.Drawing.Size(0, 29);
            this.picker_date.Name = "picker_date";
            this.picker_date.Size = new System.Drawing.Size(154, 29);
            this.picker_date.TabIndex = 9;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(398, 30);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(79, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Added date";
            // 
            // cmb_racknumber
            // 
            this.cmb_racknumber.FormattingEnabled = true;
            this.cmb_racknumber.ItemHeight = 23;
            this.cmb_racknumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmb_racknumber.Location = new System.Drawing.Point(152, 150);
            this.cmb_racknumber.Name = "cmb_racknumber";
            this.cmb_racknumber.Size = new System.Drawing.Size(153, 29);
            this.cmb_racknumber.TabIndex = 7;
            this.cmb_racknumber.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(28, 160);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(89, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Rack Number";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(28, 92);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(101, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Category name";
            // 
            // txt_catID
            // 
            // 
            // 
            // 
            this.txt_catID.CustomButton.Image = null;
            this.txt_catID.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txt_catID.CustomButton.Name = "";
            this.txt_catID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_catID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_catID.CustomButton.TabIndex = 1;
            this.txt_catID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_catID.CustomButton.UseSelectable = true;
            this.txt_catID.CustomButton.Visible = false;
            this.txt_catID.Lines = new string[0];
            this.txt_catID.Location = new System.Drawing.Point(152, 27);
            this.txt_catID.MaxLength = 32767;
            this.txt_catID.Name = "txt_catID";
            this.txt_catID.PasswordChar = '\0';
            this.txt_catID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_catID.SelectedText = "";
            this.txt_catID.SelectionLength = 0;
            this.txt_catID.SelectionStart = 0;
            this.txt_catID.Size = new System.Drawing.Size(153, 23);
            this.txt_catID.TabIndex = 3;
            this.txt_catID.UseSelectable = true;
            this.txt_catID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_catID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_catID.TextChanged += new System.EventHandler(this.txt_catID_TextChanged);
            this.txt_catID.Click += new System.EventHandler(this.txt_catID_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 27);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Category ID";
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.btn_clear_category);
            this.metroPanel4.Controls.Add(this.btn_back_category);
            this.metroPanel4.Controls.Add(this.btn_update_category);
            this.metroPanel4.Controls.Add(this.btn_delete_category);
            this.metroPanel4.Controls.Add(this.btn_Add_category);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(20, 540);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(760, 52);
            this.metroPanel4.TabIndex = 3;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // btn_clear_category
            // 
            this.btn_clear_category.Location = new System.Drawing.Point(563, 14);
            this.btn_clear_category.Name = "btn_clear_category";
            this.btn_clear_category.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_category.TabIndex = 6;
            this.btn_clear_category.Text = "Clear";
            this.btn_clear_category.UseSelectable = true;
            this.btn_clear_category.Click += new System.EventHandler(this.btn_clear_category_Click);
            // 
            // btn_back_category
            // 
            this.btn_back_category.Location = new System.Drawing.Point(653, 14);
            this.btn_back_category.Name = "btn_back_category";
            this.btn_back_category.Size = new System.Drawing.Size(75, 23);
            this.btn_back_category.TabIndex = 5;
            this.btn_back_category.Text = "Back";
            this.btn_back_category.UseSelectable = true;
            this.btn_back_category.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // btn_update_category
            // 
            this.btn_update_category.Location = new System.Drawing.Point(454, 14);
            this.btn_update_category.Name = "btn_update_category";
            this.btn_update_category.Size = new System.Drawing.Size(75, 23);
            this.btn_update_category.TabIndex = 4;
            this.btn_update_category.Text = "Update";
            this.btn_update_category.UseSelectable = true;
            this.btn_update_category.Click += new System.EventHandler(this.btn_update_category_Click);
            // 
            // btn_delete_category
            // 
            this.btn_delete_category.Location = new System.Drawing.Point(347, 14);
            this.btn_delete_category.Name = "btn_delete_category";
            this.btn_delete_category.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_category.TabIndex = 3;
            this.btn_delete_category.Text = "Delete";
            this.btn_delete_category.UseSelectable = true;
            this.btn_delete_category.Click += new System.EventHandler(this.btn_delete_category_Click);
            // 
            // btn_Add_category
            // 
            this.btn_Add_category.Location = new System.Drawing.Point(230, 14);
            this.btn_Add_category.Name = "btn_Add_category";
            this.btn_Add_category.Size = new System.Drawing.Size(75, 23);
            this.btn_Add_category.TabIndex = 2;
            this.btn_Add_category.Text = "Add";
            this.btn_Add_category.UseSelectable = true;
            this.btn_Add_category.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.metroTextBox3);
            this.groupBox1.Controls.Add(this.cmb_search_racknumber);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroTextBox2);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txt_search_catid);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(351, 32);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.Size = new System.Drawing.Size(153, 23);
            this.metroTextBox3.TabIndex = 18;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox3.TextChanged += new System.EventHandler(this.metroTextBox3_TextChanged);
            // 
            // cmb_search_racknumber
            // 
            this.cmb_search_racknumber.FormattingEnabled = true;
            this.cmb_search_racknumber.ItemHeight = 23;
            this.cmb_search_racknumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmb_search_racknumber.Location = new System.Drawing.Point(617, 26);
            this.cmb_search_racknumber.Name = "cmb_search_racknumber";
            this.cmb_search_racknumber.Size = new System.Drawing.Size(109, 29);
            this.cmb_search_racknumber.TabIndex = 6;
            this.cmb_search_racknumber.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(510, 32);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Rack number";
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(-3, 2);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(0, 0);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(373, 30);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.Size = new System.Drawing.Size(0, 0);
            this.metroTextBox2.TabIndex = 3;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(244, 32);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Category name";
            // 
            // txt_search_catid
            // 
            // 
            // 
            // 
            this.txt_search_catid.CustomButton.Image = null;
            this.txt_search_catid.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.txt_search_catid.CustomButton.Name = "";
            this.txt_search_catid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_search_catid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search_catid.CustomButton.TabIndex = 1;
            this.txt_search_catid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search_catid.CustomButton.UseSelectable = true;
            this.txt_search_catid.CustomButton.Visible = false;
            this.txt_search_catid.Lines = new string[0];
            this.txt_search_catid.Location = new System.Drawing.Point(127, 32);
            this.txt_search_catid.MaxLength = 32767;
            this.txt_search_catid.Name = "txt_search_catid";
            this.txt_search_catid.PasswordChar = '\0';
            this.txt_search_catid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search_catid.SelectedText = "";
            this.txt_search_catid.SelectionLength = 0;
            this.txt_search_catid.SelectionStart = 0;
            this.txt_search_catid.Size = new System.Drawing.Size(98, 23);
            this.txt_search_catid.TabIndex = 1;
            this.txt_search_catid.UseSelectable = true;
            this.txt_search_catid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search_catid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_search_catid.TextChanged += new System.EventHandler(this.txt_search_catid_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Category ID";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.dgv_category);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 136);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(760, 194);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            this.metroPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel2_Paint);
            // 
            // dgv_category
            // 
            this.dgv_category.AllowUserToResizeRows = false;
            this.dgv_category.AutoGenerateColumns = false;
            this.dgv_category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_category.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_category.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryidDataGridViewTextBoxColumn,
            this.categorynameDataGridViewTextBoxColumn,
            this.racknoDataGridViewTextBoxColumn,
            this.addeddateDataGridViewTextBoxColumn,
            this.noofbooksDataGridViewTextBoxColumn,
            this.catstatusDataGridViewTextBoxColumn});
            this.dgv_category.DataSource = this.categoryBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_category.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_category.EnableHeadersVisualStyles = false;
            this.dgv_category.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_category.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_category.Location = new System.Drawing.Point(0, 0);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_category.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_category.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_category.Size = new System.Drawing.Size(760, 194);
            this.dgv_category.Style = MetroFramework.MetroColorStyle.Orange;
            this.dgv_category.TabIndex = 2;
            this.dgv_category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_category_CellContentClick);
            this.dgv_category.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_category_RowHeaderMouseClick);
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "category_id";
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            // 
            // categorynameDataGridViewTextBoxColumn
            // 
            this.categorynameDataGridViewTextBoxColumn.DataPropertyName = "category_name";
            this.categorynameDataGridViewTextBoxColumn.HeaderText = "category_name";
            this.categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
            // 
            // racknoDataGridViewTextBoxColumn
            // 
            this.racknoDataGridViewTextBoxColumn.DataPropertyName = "rack_no";
            this.racknoDataGridViewTextBoxColumn.HeaderText = "rack_no";
            this.racknoDataGridViewTextBoxColumn.Name = "racknoDataGridViewTextBoxColumn";
            // 
            // addeddateDataGridViewTextBoxColumn
            // 
            this.addeddateDataGridViewTextBoxColumn.DataPropertyName = "added_date";
            this.addeddateDataGridViewTextBoxColumn.HeaderText = "added_date";
            this.addeddateDataGridViewTextBoxColumn.Name = "addeddateDataGridViewTextBoxColumn";
            // 
            // noofbooksDataGridViewTextBoxColumn
            // 
            this.noofbooksDataGridViewTextBoxColumn.DataPropertyName = "no_of_books";
            this.noofbooksDataGridViewTextBoxColumn.HeaderText = "no_of_books";
            this.noofbooksDataGridViewTextBoxColumn.Name = "noofbooksDataGridViewTextBoxColumn";
            // 
            // catstatusDataGridViewTextBoxColumn
            // 
            this.catstatusDataGridViewTextBoxColumn.DataPropertyName = "cat_status";
            this.catstatusDataGridViewTextBoxColumn.HeaderText = "cat_status";
            this.catstatusDataGridViewTextBoxColumn.Name = "catstatusDataGridViewTextBoxColumn";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.sudheesanDataSet2;
            // 
            // sudheesanDataSet2
            // 
            this.sudheesanDataSet2.DataSetName = "sudheesanDataSet2";
            this.sudheesanDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Category";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "CATEGORY";
            this.Load += new System.EventHandler(this.Category_Load);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sudheesanDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txt_search_catid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroComboBox cmb_search_racknumber;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmb_racknumber;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_catID;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroGrid dgv_category;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_noofbooks;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroDateTime picker_date;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btn_clear_category;
        private MetroFramework.Controls.MetroButton btn_back_category;
        private MetroFramework.Controls.MetroButton btn_update_category;
        private MetroFramework.Controls.MetroButton btn_delete_category;
        private MetroFramework.Controls.MetroButton btn_Add_category;
        private MetroFramework.Controls.MetroComboBox cmb_catstatus;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private sudheesanDataSet2 sudheesanDataSet2;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private sudheesanDataSet2TableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racknoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addeddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofbooksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catstatusDataGridViewTextBoxColumn;
    }
}