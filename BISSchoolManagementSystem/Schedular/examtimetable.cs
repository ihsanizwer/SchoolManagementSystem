using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedular
{
    public partial class examtimetable : MetroForm

    {
        DBAcccessExam dba = new DBAcccessExam();
        public examtimetable()
        {
            InitializeComponent();
        }

        private void examtimetable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sudheesanDataSet.exam_time_table' table. You can move, or remove it, as needed.
            this.exam_time_tableTableAdapter.Fill(this.sudheesanDataSet.exam_time_table);
            // TODO: This line of code loads data into the 'sudheesanDataSet.class_time_table' table. You can move, or remove it, as needed.

        }
        public void FilterDataGridExamClass(String a)
        {
            DataSet ds = dba.FilterExamClass(a);
            dgv_exam.DataSource = ds.Tables["exam_time_table"].DefaultView;

        }

        public void FilterDataGridTeacherId(String a)
        {
            DataSet ds = dba.FilterExamTeacher(a);
            dgv_exam.DataSource = ds.Tables["exam_time_table"].DefaultView;

        }

        public void getGrid()
        {
            DataSet ds = dba.getAllExam();
            dgv_exam.DataSource = ds.Tables["exam_time_table"].DefaultView;
        }

        public void FilterDataGridDate(string a)
        {
            DataSet ds = dba.FilterExamDate(a);
            dgv_exam.DataSource = ds.Tables["exam_time_table"].DefaultView;
        }
        public void FilterDataGridDateId(string a,string b)
        {
            DataSet ds = dba.FilterExamDateId(a,b);
            dgv_exam.DataSource = ds.Tables["exam_time_table"].DefaultView;
        }

        private void FillExam()
        {
            this.exam_time_tableTableAdapter.Fill(this.sudheesanDataSet.exam_time_table);

        }
        public static void ClearAllTextBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var textBox = c as TextBox;
                if (textBox != null)
                    (textBox).Clear();
                if (c.HasChildren)
                    ClearAllTextBox(c);
            }
        }
        public void Clear()
        {
            ClearAllTextBox(this);
            metroDateTime2.Value = DateTime.Today;
            FillExam();


            btn_exam_add.Enabled = false;

        }

        public bool validateExamid(string a)
        {
            if(!string.IsNullOrWhiteSpace(a))
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(this, "EXAM ID CANNOT BE NULL");
                metroTextBox3.Focus();
                return false;
            }
        }
        public bool validateTeacherId(string a)
        {
            string b = a.Substring(2, (a.Length - 2));

            if (a.Length == 7)
            {
                if (a.StartsWith("ST") && !string.IsNullOrWhiteSpace(a))
                {
                    if (b.All(char.IsDigit))
                    {
                        return true;
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "PROVIDE CORRECT TEACHER ID");
                        metroTextBox8.Focus();
                        return false;
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "PROVIDE CORRECT TEACHER ID");
                    metroTextBox8.Focus();
                    return false;
                }
            }
            else
            {
                MetroMessageBox.Show(this, "PROVIDE CORRECT TEACHER ID");
                metroTextBox8.Focus();
                return false;
            }
        }
        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroTextButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SheduleHome = new SheduleHome();
            SheduleHome.Closed += (s, args) => this.Close();
            SheduleHome.Show();
        }

        private void dgv_exam_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            metroTextBox3.Text = dgv_exam.Rows[e.RowIndex].Cells["examidDataGridViewTextBoxColumn"].Value.ToString();
            metroComboBox24.Text = dgv_exam.Rows[e.RowIndex].Cells["starttimeDataGridViewTextBoxColumn"].Value.ToString();
            metroComboBox25.Text = dgv_exam.Rows[e.RowIndex].Cells["endtimeDataGridViewTextBoxColumn"].Value.ToString();
            metroTextBox8.Text = dgv_exam.Rows[e.RowIndex].Cells["teacheridDataGridViewTextBoxColumn"].Value.ToString();
            metroComboBox14.Text = dgv_exam.Rows[e.RowIndex].Cells["examsubjectDataGridViewTextBoxColumn"].Value.ToString();
            metroComboBox15.Text = dgv_exam.Rows[e.RowIndex].Cells["classidDataGridViewTextBoxColumn"].Value.ToString();



            metroComboBox3.Text = dgv_exam.Rows[e.RowIndex].Cells["venueDataGridViewTextBoxColumn"].Value.ToString();
            metroDateTime2.Value = (DateTime)dgv_exam.Rows[e.RowIndex].Cells["examdateDataGridViewTextBoxColumn"].Value;

        }

        private void metroTextButton5_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "DO YOU WANT TO DELETE THE RECORD", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {

                    if (dba.deleteExam(metroTextBox3.Text, metroComboBox14.Text, metroComboBox15.Text))
                    {


                        MetroMessageBox.Show(this, "Successfully deleted");
                        ClearAllTextBox(this);
                        FillExam();
                    }
                    else
                    {
                        MetroMessageBox.Show(this,"Error occured");
                    }
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this,ex.Message);
                }
            }

            FillExam();
        }

        private void btn_exam_add_Click(object sender, EventArgs e)
        {
            if (validateExamid(metroTextBox3.Text))
            {
                if (validateTeacherId(metroTextBox8.Text))
                {



                    try
                    {
                        if (dba.addExam(metroTextBox3.Text, metroComboBox24.Text, metroComboBox25.Text, metroDateTime2.Value.Date.ToString("MM/dd/yyyy"), metroTextBox8.Text, metroComboBox14.Text, metroComboBox15.Text, metroComboBox3.Text))
                        {
                            MetroMessageBox.Show(this, "Successfully Added");
                            FillExam();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Error occured");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Clear();

          
                }
            }
                
        }

        private void btn_exam_update_Click(object sender, EventArgs e)
        {
            try
            {

                if (dba.updateExam(metroTextBox3.Text, metroComboBox24.Text, metroComboBox25.Text, metroDateTime2.Value.Date.ToString("MM/dd/yyyy"), metroTextBox8.Text, metroComboBox14.Text, metroComboBox15.Text, metroComboBox3.Text))
                {


                    MessageBox.Show("Successfully Updated");
                }
                else
                {
                    MessageBox.Show("Error occured");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Clear();

            FillExam();

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridExamClass(metroTextBox1.Text);
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            //FilterDataGridTeacherId(metroTextBox2.Text);
        }

        private void metroTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            FilterDataGridExamClass(metroTextBox1.Text);
        }

        private void metroTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            FilterDataGridTeacherId(metroTextBox2.Text);
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridTeacherId(metroTextBox2.Text);
        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            btn_exam_add.Enabled = true;
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            FilterDataGridDate(metroDateTime1.Value.Date.ToString("MM/dd/yyyy"));
        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(metroTextBox1.Text))
            {
                FilterDataGridDateId(metroTextBox1.Text, metroComboBox4.Text.ToString());
            }
            else
            {
                MetroMessageBox.Show(this, "PROVIDE EXAM_ID FOR SEARCH");
                metroTextBox1.Focus();
            }
        }




        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            getGrid();

        }


    }
}
