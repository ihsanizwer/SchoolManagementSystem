namespace Schedular
{
    partial class examtimetable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.GroupBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox4 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_exam = new MetroFramework.Controls.MetroGrid();
            this.examidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacheridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examsubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examtimetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sudheesanDataSet = new Schedular.sudheesanDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroComboBox14 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox15 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox25 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox24 = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroTextButton2 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_exam_delete = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButton3 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_exam_update = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_exam_add = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.exam_time_tableTableAdapter = new Schedular.sudheesanDataSetTableAdapters.exam_time_tableTableAdapter();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.panel1.SuspendLayout();
            this.Search.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examtimetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sudheesanDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 149);
            this.panel1.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.Window;
            this.Search.Controls.Add(this.metroTextButton1);
            this.Search.Controls.Add(this.metroTextBox2);
            this.Search.Controls.Add(this.metroComboBox4);
            this.Search.Controls.Add(this.metroLabel3);
            this.Search.Controls.Add(this.metroLabel6);
            this.Search.Controls.Add(this.metroTextBox1);
            this.Search.Controls.Add(this.metroDateTime1);
            this.Search.Controls.Add(this.metroLabel1);
            this.Search.Controls.Add(this.metroLabel2);
            this.Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(0, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(760, 149);
            this.Search.TabIndex = 1;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(346, 94);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.Size = new System.Drawing.Size(121, 23);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBox2.TabIndex = 18;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox2.TextChanged += new System.EventHandler(this.metroTextBox2_TextChanged);
            this.metroTextBox2.Click += new System.EventHandler(this.metroTextBox2_Click);
            this.metroTextBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.metroTextBox2_KeyUp);
            // 
            // metroComboBox4
            // 
            this.metroComboBox4.FormattingEnabled = true;
            this.metroComboBox4.ItemHeight = 23;
            this.metroComboBox4.Items.AddRange(new object[] {
            "G1",
            "G2",
            "G3",
            "G4",
            "G5",
            "G6"});
            this.metroComboBox4.Location = new System.Drawing.Point(346, 19);
            this.metroComboBox4.Name = "metroComboBox4";
            this.metroComboBox4.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBox4.TabIndex = 17;
            this.metroComboBox4.UseSelectable = true;
            this.metroComboBox4.SelectedIndexChanged += new System.EventHandler(this.metroComboBox4_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(269, 88);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Incharge";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(269, 25);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Class";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(107, 25);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(141, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBox1.TabIndex = 10;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            this.metroTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.metroTextBox1_KeyUp);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(104, 88);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(159, 29);
            this.metroDateTime1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroDateTime1.TabIndex = 9;
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(33, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(33, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Exam ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_exam);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 172);
            this.panel2.TabIndex = 1;
            // 
            // dgv_exam
            // 
            this.dgv_exam.AllowUserToResizeRows = false;
            this.dgv_exam.AutoGenerateColumns = false;
            this.dgv_exam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_exam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_exam.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_exam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_exam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_exam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examidDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.examdateDataGridViewTextBoxColumn,
            this.teacheridDataGridViewTextBoxColumn,
            this.examsubjectDataGridViewTextBoxColumn,
            this.classidDataGridViewTextBoxColumn,
            this.venueDataGridViewTextBoxColumn});
            this.dgv_exam.DataSource = this.examtimetableBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_exam.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_exam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_exam.EnableHeadersVisualStyles = false;
            this.dgv_exam.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_exam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_exam.Location = new System.Drawing.Point(0, 0);
            this.dgv_exam.Name = "dgv_exam";
            this.dgv_exam.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_exam.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_exam.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_exam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_exam.Size = new System.Drawing.Size(760, 172);
            this.dgv_exam.Style = MetroFramework.MetroColorStyle.Green;
            this.dgv_exam.TabIndex = 2;
            this.dgv_exam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.dgv_exam.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_exam_RowHeaderMouseClick);
            // 
            // examidDataGridViewTextBoxColumn
            // 
            this.examidDataGridViewTextBoxColumn.DataPropertyName = "exam_id";
            this.examidDataGridViewTextBoxColumn.HeaderText = "exam_id";
            this.examidDataGridViewTextBoxColumn.Name = "examidDataGridViewTextBoxColumn";
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "starttime";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "starttime";
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "endtime";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "endtime";
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            // 
            // examdateDataGridViewTextBoxColumn
            // 
            this.examdateDataGridViewTextBoxColumn.DataPropertyName = "exam_date";
            this.examdateDataGridViewTextBoxColumn.HeaderText = "exam_date";
            this.examdateDataGridViewTextBoxColumn.Name = "examdateDataGridViewTextBoxColumn";
            // 
            // teacheridDataGridViewTextBoxColumn
            // 
            this.teacheridDataGridViewTextBoxColumn.DataPropertyName = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.HeaderText = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.Name = "teacheridDataGridViewTextBoxColumn";
            // 
            // examsubjectDataGridViewTextBoxColumn
            // 
            this.examsubjectDataGridViewTextBoxColumn.DataPropertyName = "exam_subject";
            this.examsubjectDataGridViewTextBoxColumn.HeaderText = "exam_subject";
            this.examsubjectDataGridViewTextBoxColumn.Name = "examsubjectDataGridViewTextBoxColumn";
            // 
            // classidDataGridViewTextBoxColumn
            // 
            this.classidDataGridViewTextBoxColumn.DataPropertyName = "class_id";
            this.classidDataGridViewTextBoxColumn.HeaderText = "class_id";
            this.classidDataGridViewTextBoxColumn.Name = "classidDataGridViewTextBoxColumn";
            // 
            // venueDataGridViewTextBoxColumn
            // 
            this.venueDataGridViewTextBoxColumn.DataPropertyName = "venue";
            this.venueDataGridViewTextBoxColumn.HeaderText = "venue";
            this.venueDataGridViewTextBoxColumn.Name = "venueDataGridViewTextBoxColumn";
            // 
            // examtimetableBindingSource
            // 
            this.examtimetableBindingSource.DataMember = "exam_time_table";
            this.examtimetableBindingSource.DataSource = this.sudheesanDataSet;
            // 
            // sudheesanDataSet
            // 
            this.sudheesanDataSet.DataSetName = "sudheesanDataSet";
            this.sudheesanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.metroComboBox14);
            this.panel3.Controls.Add(this.metroComboBox15);
            this.panel3.Controls.Add(this.metroComboBox25);
            this.panel3.Controls.Add(this.metroComboBox24);
            this.panel3.Controls.Add(this.metroTextBox8);
            this.panel3.Controls.Add(this.metroTextBox3);
            this.panel3.Controls.Add(this.metroLabel7);
            this.panel3.Controls.Add(this.metroComboBox3);
            this.panel3.Controls.Add(this.metroLabel4);
            this.panel3.Controls.Add(this.metroDateTime2);
            this.panel3.Controls.Add(this.metroLabel15);
            this.panel3.Controls.Add(this.metroLabel10);
            this.panel3.Controls.Add(this.metroLabel11);
            this.panel3.Controls.Add(this.metroLabel12);
            this.panel3.Controls.Add(this.metroLabel13);
            this.panel3.Controls.Add(this.metroLabel14);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 381);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 163);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // metroComboBox14
            // 
            this.metroComboBox14.FormattingEnabled = true;
            this.metroComboBox14.ItemHeight = 23;
            this.metroComboBox14.Items.AddRange(new object[] {
            "MAT",
            "TAM",
            "SCI",
            "ENG",
            "REL"});
            this.metroComboBox14.Location = new System.Drawing.Point(434, 97);
            this.metroComboBox14.Name = "metroComboBox14";
            this.metroComboBox14.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox14.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBox14.TabIndex = 40;
            this.metroComboBox14.UseSelectable = true;
            // 
            // metroComboBox15
            // 
            this.metroComboBox15.FormattingEnabled = true;
            this.metroComboBox15.ItemHeight = 23;
            this.metroComboBox15.Items.AddRange(new object[] {
            "G1",
            "G2",
            "G3",
            "G4",
            "G5",
            "G6",
            "G7"});
            this.metroComboBox15.Location = new System.Drawing.Point(434, 40);
            this.metroComboBox15.Name = "metroComboBox15";
            this.metroComboBox15.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox15.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBox15.TabIndex = 39;
            this.metroComboBox15.UseSelectable = true;
            // 
            // metroComboBox25
            // 
            this.metroComboBox25.FormattingEnabled = true;
            this.metroComboBox25.ItemHeight = 23;
            this.metroComboBox25.Items.AddRange(new object[] {
            "09:10:00",
            "09:50:00",
            "10:30:00",
            "10:50:00",
            "11:30:00",
            "12:10:00",
            "12:50:00",
            "13:30:00"});
            this.metroComboBox25.Location = new System.Drawing.Point(254, 97);
            this.metroComboBox25.Name = "metroComboBox25";
            this.metroComboBox25.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox25.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBox25.TabIndex = 38;
            this.metroComboBox25.UseSelectable = true;
            // 
            // metroComboBox24
            // 
            this.metroComboBox24.FormattingEnabled = true;
            this.metroComboBox24.ItemHeight = 23;
            this.metroComboBox24.Items.AddRange(new object[] {
            "08:30:00",
            "09:10:00",
            "09:50:00",
            "10:50:00",
            "11:30:00",
            "12:10:00",
            "12:50:00"});
            this.metroComboBox24.Location = new System.Drawing.Point(254, 40);
            this.metroComboBox24.Name = "metroComboBox24";
            this.metroComboBox24.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox24.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBox24.TabIndex = 37;
            this.metroComboBox24.UseSelectable = true;
            // 
            // metroTextBox8
            // 
            // 
            // 
            // 
            this.metroTextBox8.CustomButton.Image = null;
            this.metroTextBox8.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.metroTextBox8.CustomButton.Name = "";
            this.metroTextBox8.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox8.CustomButton.TabIndex = 1;
            this.metroTextBox8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox8.CustomButton.UseSelectable = true;
            this.metroTextBox8.CustomButton.Visible = false;
            this.metroTextBox8.Lines = new string[0];
            this.metroTextBox8.Location = new System.Drawing.Point(627, 99);
            this.metroTextBox8.MaxLength = 32767;
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.PasswordChar = '\0';
            this.metroTextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox8.SelectedText = "";
            this.metroTextBox8.SelectionLength = 0;
            this.metroTextBox8.SelectionStart = 0;
            this.metroTextBox8.Size = new System.Drawing.Size(121, 23);
            this.metroTextBox8.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBox8.TabIndex = 36;
            this.metroTextBox8.UseSelectable = true;
            this.metroTextBox8.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox8.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(89, 40);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.Size = new System.Drawing.Size(98, 23);
            this.metroTextBox3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBox3.TabIndex = 35;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox3.TextChanged += new System.EventHandler(this.metroTextBox3_TextChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.White;
            this.metroLabel7.Location = new System.Drawing.Point(562, 103);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 19);
            this.metroLabel7.TabIndex = 33;
            this.metroLabel7.Text = "Incharge";
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.AutoCompleteCustomSource.AddRange(new string[] {
            "G1",
            "G2",
            "G3",
            "G4",
            "G5",
            "G6",
            "G7",
            "G8",
            "G9"});
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Items.AddRange(new object[] {
            "G1",
            "G2",
            "G3",
            "G4",
            "G5",
            "G6",
            "G7",
            "G8",
            "G9"});
            this.metroComboBox3.Location = new System.Drawing.Point(627, 30);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBox3.TabIndex = 32;
            this.metroComboBox3.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(561, 36);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "Venue";
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(89, 103);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(116, 29);
            this.metroDateTime2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroDateTime2.TabIndex = 30;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(381, 103);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(51, 19);
            this.metroLabel15.TabIndex = 28;
            this.metroLabel15.Text = "Subject";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(390, 40);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(38, 19);
            this.metroLabel10.TabIndex = 26;
            this.metroLabel10.Text = "Class";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(226, 107);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(22, 19);
            this.metroLabel11.TabIndex = 25;
            this.metroLabel11.Text = "To";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(207, 40);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(41, 19);
            this.metroLabel12.TabIndex = 23;
            this.metroLabel12.Text = "From";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(12, 107);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(31, 19);
            this.metroLabel13.TabIndex = 22;
            this.metroLabel13.Text = "Day";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(12, 40);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(57, 19);
            this.metroLabel14.TabIndex = 21;
            this.metroLabel14.Text = "Exam ID";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.metroTextButton2);
            this.panel4.Controls.Add(this.btn_exam_delete);
            this.panel4.Controls.Add(this.metroTextButton3);
            this.panel4.Controls.Add(this.btn_exam_update);
            this.panel4.Controls.Add(this.btn_exam_add);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(20, 544);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 49);
            this.panel4.TabIndex = 3;
            // 
            // metroTextButton2
            // 
            this.metroTextButton2.Image = null;
            this.metroTextButton2.Location = new System.Drawing.Point(188, 10);
            this.metroTextButton2.Name = "metroTextButton2";
            this.metroTextButton2.Size = new System.Drawing.Size(85, 23);
            this.metroTextButton2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextButton2.TabIndex = 9;
            this.metroTextButton2.Text = "Logout";
            this.metroTextButton2.UseSelectable = true;
            this.metroTextButton2.UseVisualStyleBackColor = true;
            // 
            // btn_exam_delete
            // 
            this.btn_exam_delete.Image = null;
            this.btn_exam_delete.Location = new System.Drawing.Point(407, 10);
            this.btn_exam_delete.Name = "btn_exam_delete";
            this.btn_exam_delete.Size = new System.Drawing.Size(85, 23);
            this.btn_exam_delete.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_exam_delete.TabIndex = 8;
            this.btn_exam_delete.Text = "Delete";
            this.btn_exam_delete.UseSelectable = true;
            this.btn_exam_delete.UseVisualStyleBackColor = true;
            this.btn_exam_delete.Click += new System.EventHandler(this.metroTextButton5_Click);
            // 
            // metroTextButton3
            // 
            this.metroTextButton3.Image = null;
            this.metroTextButton3.Location = new System.Drawing.Point(636, 10);
            this.metroTextButton3.Name = "metroTextButton3";
            this.metroTextButton3.Size = new System.Drawing.Size(85, 23);
            this.metroTextButton3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextButton3.TabIndex = 6;
            this.metroTextButton3.Text = "Back";
            this.metroTextButton3.UseSelectable = true;
            this.metroTextButton3.UseVisualStyleBackColor = true;
            this.metroTextButton3.Click += new System.EventHandler(this.metroTextButton3_Click);
            // 
            // btn_exam_update
            // 
            this.btn_exam_update.Image = null;
            this.btn_exam_update.Location = new System.Drawing.Point(520, 10);
            this.btn_exam_update.Name = "btn_exam_update";
            this.btn_exam_update.Size = new System.Drawing.Size(85, 23);
            this.btn_exam_update.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_exam_update.TabIndex = 5;
            this.btn_exam_update.Text = "Update";
            this.btn_exam_update.UseSelectable = true;
            this.btn_exam_update.UseVisualStyleBackColor = true;
            this.btn_exam_update.Click += new System.EventHandler(this.btn_exam_update_Click);
            // 
            // btn_exam_add
            // 
            this.btn_exam_add.Image = null;
            this.btn_exam_add.Location = new System.Drawing.Point(299, 10);
            this.btn_exam_add.Name = "btn_exam_add";
            this.btn_exam_add.Size = new System.Drawing.Size(85, 23);
            this.btn_exam_add.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_exam_add.TabIndex = 4;
            this.btn_exam_add.Text = "Add";
            this.btn_exam_add.UseSelectable = true;
            this.btn_exam_add.UseVisualStyleBackColor = true;
            this.btn_exam_add.Click += new System.EventHandler(this.btn_exam_add_Click);
            // 
            // exam_time_tableTableAdapter
            // 
            this.exam_time_tableTableAdapter.ClearBeforeFill = true;
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Image = null;
            this.metroTextButton1.Location = new System.Drawing.Point(537, 56);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(121, 23);
            this.metroTextButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextButton1.TabIndex = 19;
            this.metroTextButton1.Text = "VIEW ALL";
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // examtimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "examtimetable";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Exam Time Table";
            this.Load += new System.EventHandler(this.examtimetable_Load);
            this.panel1.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examtimetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sudheesanDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox Search;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid dgv_exam;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_exam_update;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_exam_add;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private sudheesanDataSet sudheesanDataSet;
        private System.Windows.Forms.BindingSource examtimetableBindingSource;
        private sudheesanDataSetTableAdapters.exam_time_tableTableAdapter exam_time_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn examidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacheridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examsubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox metroTextBox8;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_exam_delete;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox4;
        private MetroFramework.Controls.MetroComboBox metroComboBox25;
        private MetroFramework.Controls.MetroComboBox metroComboBox24;
        private MetroFramework.Controls.MetroComboBox metroComboBox14;
        private MetroFramework.Controls.MetroComboBox metroComboBox15;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton2;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
    }
}