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
    public partial class teachertimetable : MetroForm
    {
        DBAccessTeacherTime dba = new DBAccessTeacherTime();
        public teachertimetable()
        {
            InitializeComponent();
        }

        private void teachertimetable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sudheesanDataSet.academic_staff' table. You can move, or remove it, as needed.
            this.academic_staffTableAdapter.Fill(this.sudheesanDataSet.academic_staff);
            // TODO: This line of code loads data into the 'sudheesanDataSet1.teacher_time_table' table. You can move, or remove it, as needed.
            this.teacher_time_tableTableAdapter1.Fill(this.sudheesanDataSet1.teacher_time_table);
        
            this.scl_subjectTableAdapter.Fill(this.sudheesanDataSet.scl_subject);
            // TODO: This line of code loads data into the 'sudheesanDataSet._class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.sudheesanDataSet._class);
            // TODO: This line of code loads data into the 'sudheesanDataSet.class_time_table' table. You can move, or remove it, as needed.
           // this.class_time_tableTableAdapter.Fill(this.sudheesanDataSet.class_time_table);

        }

       public void FillTeacherTime()
       {
                       this.teacher_time_tableTableAdapter1.Fill(this.sudheesanDataSet1.teacher_time_table);

       }
        public void Clear()
        {
            ClearAllTextBox(this);
            FillTeacherTime();


            btn_teacher_add.Enabled = false;

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
         public void FilterDataGridTeacherId(String a)
         {
             DataSet ds = dba.FilterTeacherTabTeacherId(a);
             dgv_teacher_time.DataSource = ds.Tables["teacher_time_table"].DefaultView;

         }
         public void FilterDataGridUnique(string a,string b)
         {
             DataSet ds = dba.FilterTeacherTabUnique(a,b);
             dgv_teacher_time.DataSource = ds.Tables["teacher_time_table"].DefaultView;

         }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Enter(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SheduleHome = new SheduleHome();
            SheduleHome.Closed += (s, args) => this.Close();
            SheduleHome.Show();
        }
        public bool validateTeacherId(string a)
        {
            //  string b = a.Substring(2,(a.Length-2));

            if (a.Length == 7)
            {
                if (!string.IsNullOrWhiteSpace(a) && a.StartsWith("ST"))
                {
                    if (a.Substring(2, (a.Length - 2)).All(char.IsDigit))
                    {
                        return true;
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "PROVIDE CORRECT TEACHER ID");
                        metroTextBox4.Focus();
                        return false;
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "PROVIDE CORRECT TEACHER ID");
                    metroTextBox4.Focus();
                    return false;
                }
            }
            else
            {
                MetroMessageBox.Show(this, "PROVIDE CORRECT TEACHER ID");
                metroTextBox4.Focus();
                return false;
            }
        }
        private void dgv_teacher_time_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            metroTextBox4.Text = dgv_teacher_time.Rows[e.RowIndex].Cells["teacheridDataGridViewTextBoxColumn"].Value.ToString();
            metroComboBox7.Text = dgv_teacher_time.Rows[e.RowIndex].Cells["weekdayDataGridViewTextBoxColumn"].Value.ToString();
            metroComboBox5.Text = dgv_teacher_time.Rows[e.RowIndex].Cells["periodnoDataGridViewTextBoxColumn"].Value.ToString();
            metroComboBox24.Text = dgv_teacher_time.Rows[e.RowIndex].Cells["starttimeDataGridViewTextBoxColumn"].Value.ToString();
            metroComboBox25.Text = dgv_teacher_time.Rows[e.RowIndex].Cells["endtimeDataGridViewTextBoxColumn"].Value.ToString();
            metroComboBox8.Text = dgv_teacher_time.Rows[e.RowIndex].Cells["classidDataGridViewTextBoxColumn"].Value.ToString();
            metroComboBox2.Text = dgv_teacher_time.Rows[e.RowIndex].Cells["subnameDataGridViewTextBoxColumn"].Value.ToString();

        }

        private void btn_teacher_add_Click(object sender, EventArgs e)
        {
            if (validateTeacherId(metroTextBox4.Text))
            {


                try
                {
                    if (dba.addTeacherTime(metroTextBox4.Text, metroComboBox7.Text, Convert.ToInt16(metroComboBox5.Text), metroComboBox24.Text, metroComboBox25.Text, metroComboBox8.Text, metroComboBox2.Text))
                    {
                        MetroMessageBox.Show(this, "Successfully Added");
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

                FillTeacherTime();
            }
        
        }

        private void btn_teacher_update_Click(object sender, EventArgs e)
        {
            if (validateTeacherId(metroTextBox4.Text))
            {


                try
                {

                    if (dba.updateTeacherTime(metroTextBox4.Text, metroComboBox7.Text, Convert.ToInt16(metroComboBox5.Text), metroComboBox24.Text, metroComboBox25.Text, metroComboBox8.Text, metroComboBox2.Text))
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

                FillTeacherTime();
            }
        
        }

        private void btn_teacher_delete_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "DO YOU WANT TO DELETE THE RECORD", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {

                    if (dba.deleteTeacherTime(metroTextBox4.Text, metroComboBox7.Text,Convert.ToInt16( metroComboBox5.Text)))
                    {


                        MetroMessageBox.Show(this, "Successfully deleted");
                        ClearAllTextBox(this);
                        FillTeacherTime();
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

            FillTeacherTime();
        }

        private void metroComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataGridTeacherId(metroComboBox6.Text);
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataGridUnique(metroComboBox6.Text, metroComboBox1.Text);
        }

        private void metroTextBox4_TextChanged(object sender, EventArgs e)
        {
            btn_teacher_add.Enabled = true;
        }



         
    }
}
