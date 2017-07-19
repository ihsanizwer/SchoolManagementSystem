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

namespace AMS_Final
{
    public partial class StudentAttendance : MetroForm
    {
        DBAccess dba = new DBAccess();
        studentValidate st1 = new studentValidate();

        public StudentAttendance()
        {
            InitializeComponent();
        }

        private void StudentAttendance_Load(object sender, EventArgs e)
        {
            FillGrid();
            
        }

        private void metroTabPage5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDadmission_Click(object sender, EventArgs e)
        {
            txtDsName.Clear();
            ClearAllTextBox(this);
            dateDdate.Value = DateTime.Now;
            FillGrid();

        }

        private void btnDupdate_Click(object sender, EventArgs e)
        {
            //string admissionNo = txtDadmission.Text;
            //string sName = txtDsName.Text;
            //string status = txtDstatus.Text;

            //studentValidate st1 = new studentValidate(admissionNo, sName);
            //Boolean val1 = st1.studentValidEmpty();
            //Boolean val2 = st1.studentSearchValid();
            //int len1 = admissionNo.Length;

            //Boolean val3 = st1.isLetter(sName);
            

            //if (val1 == false)
            //{
            //    MessageBox.Show("Cannot keep fields empty");
            //}
            //else if ((val2 == false) || (val3 == false)) 
            //    {
            //        MessageBox.Show("Input correct value");
            //    }
            //else if (val3 == true || val2 == true)
            //{
            //    MessageBox.Show("Correct");
            //}
            string admission = txtDnO.Text;
            DateTime Ddate = metroDateTime3.Value;
            string dayStatus=txtDdStatus.Text;
            string DtimeIn = txtDtime.Text;
            string Dstatus = txtDstatus.Text;
            string Dreason = txtDreason.Text;

            if (txtDnO.Text.Length <= 0)
            {
                MetroMessageBox.Show(this, "Cannot keep admission no empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!st1.studentSearchValid(txtDnO.Text))
            {
                MetroMessageBox.Show(this, "Admission no is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txtDname.Text.Length <= 0)
            {
                MetroMessageBox.Show(this, "Cannot keep Student name empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (st1.isNumber(txtDname.Text))
            {
                MetroMessageBox.Show(this, "Name cannot have integer values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtDroll.Text.Length <= 0)
            {
                MetroMessageBox.Show(this, "Cannot keep roll no empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!st1.isNumber(txtDroll.Text))
            {
                MetroMessageBox.Show(this, "Roll no can have only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if ((txtDroll.Text.Length > 2) || txtDroll.Text == "0")
            {
                MetroMessageBox.Show(this, "Insert a valid roll no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (!st1.studentValidEmpty(txtDclass.Text))
            {
                MetroMessageBox.Show(this, "Cannot keep this Class empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!st1.studentSearchClass(txtDclass.Text))
            {
                MetroMessageBox.Show(this, "Class Name should starts with either letter G or g", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtDstatus.Text.Length<=0 && st1.isLetter(txtDstatus.Text))
            {
                MetroMessageBox.Show(this, "Input valid data to status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtDdStatus.Text.Length<=0 &&  st1.isLetter(txtDdStatus.Text))
            {
                MetroMessageBox.Show(this, "Input valid data to date status ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (st1.isNumber(txtDreason.Text))
            {
                MetroMessageBox.Show(this, "Cannot use integers for reason", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var result = MetroMessageBox.Show(this, "DO YOU WANT TO UPDATE THE RECORD", "UPDATE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (dba.updateStudentAttendance(admission, Ddate, dayStatus, DtimeIn, Dstatus, Dreason))
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
                    FillGrid();
                }


            }

            

        }




        public void FillGrid()
        {
            DataSet ds = dba.getAllJobs();
            gridStuDate.DataSource = ds.Tables["student_attendance"].DefaultView;
            gridMonthSt.DataSource = ds.Tables["student_attendance"].DefaultView;

            DataSet ds1 = dba.getStudAttendance();
            metroGrid2.DataSource = ds1.Tables["student_attend_history"].DefaultView;

            DataSet ds2 = dba.getClassAttendance();
            metroGrid3.DataSource = ds2.Tables["attendance_student_class"].DefaultView;
        }

        private void gridStuDate_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
              
        }

        private void gridStuDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //gridStuDate.Columns["date"].DefaultCellStyle.Format = "MM/dd/yyyy";
        }

        private void btnDreset_Click(object sender, EventArgs e)
        {

            ClearAllTextBox(this);
            dateDdate.Value = DateTime.Now;
            metroDateTime3.Value = DateTime.Now;
            FillGrid();
            

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

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void gridStuDate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridStuDate.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string admission = gridStuDate.SelectedRows[0].Cells[0].Value + string.Empty;
                string rollNo = gridStuDate.SelectedRows[0].Cells[1].Value + string.Empty;
                string name = gridStuDate.SelectedRows[0].Cells[2].Value + string.Empty;
                string surname = gridStuDate.SelectedRows[0].Cells[3].Value + string.Empty;
                metroDateTime3.Value = Convert.ToDateTime(gridStuDate.SelectedRows[0].Cells[4].Value);
                string dateStatus = gridStuDate.SelectedRows[0].Cells[5].Value + string.Empty;
                string timeIn = gridStuDate.SelectedRows[0].Cells[6].Value + string.Empty;
                string status = (gridStuDate.SelectedRows[0].Cells[7].Value + string.Empty);
                string reason = gridStuDate.SelectedRows[0].Cells[8].Value + string.Empty;

                txtDnO.Text = admission;
                txtDroll.Text = rollNo;
                txtDname.Text = name + " " + surname;
                txtDdStatus.Text = dateStatus;
                txtDstatus.Text = status;
              

                if (timeIn == "")
                {
                    txtDtime.Text = "-";
                }
                else
                    txtDtime.Text = timeIn;


                //if (status == "True")
                //{
                //    txtDstatus.Text = "Present";
                //}
                //else
                //    txtDstatus.Text = "Absent";


                if (reason == "")
                {
                    txtDreason.Text = "-";
                }
                else
                    txtDreason.Text = reason;
                

                string cls =dba.getClassAtt(txtDnO.Text);
                txtDclass.Text = cls.ToString();

                DataSet teacher = dba.getTeacherAtt(txtDclass.Text);
                txtDteacher.Text = teacher.ToString();
            }


        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridMonthSt.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string admission = gridMonthSt.SelectedRows[0].Cells[0].Value + string.Empty;
                string rollNo = gridMonthSt.SelectedRows[0].Cells[1].Value + string.Empty;
                string name = gridMonthSt.SelectedRows[0].Cells[2].Value + string.Empty;
                string surname = gridMonthSt.SelectedRows[0].Cells[3].Value + string.Empty;
                string date = gridMonthSt.SelectedRows[0].Cells[4].Value + string.Empty;
                string dateStatus = gridMonthSt.SelectedRows[0].Cells[5].Value + string.Empty;
                string timeIn = gridMonthSt.SelectedRows[0].Cells[6].Value + string.Empty;
                string status = (gridMonthSt.SelectedRows[0].Cells[7].Value + string.Empty);
                string reason = gridMonthSt.SelectedRows[0].Cells[8].Value + string.Empty;

                txtMsNo.Text = admission;
                txtMroll.Text = rollNo;
                txtMname.Text = name + " " + surname;

                DateTime date1 = metroDateTime1.Value;

                DateTime date2 = metroDateTime2.Value;


                string cls = dba.getClassAtt(txtMsNo.Text);
                txtMclass.Text = cls.ToString();

               // txtMtot.Text = (metroDateTime2.Value - metroDateTime1.Value).TotalDays.ToString("#");

                int presentDays = dba.getStudentPresent(admission,date1, date2);
                txtMpres.Text = presentDays.ToString();

                int absentDays = dba.getStudentAbsent(admission,date1,date2);
                txtMab.Text = absentDays.ToString();

                //int totalDays = dba.getStudentTotaldays(admission, date1, date2);
                
                int workingDays = dba.GetWorkingDays(date1, date2);
                txtMtot.Text = workingDays.ToString();

                double presentPercent = (double)(((double)presentDays/(double)workingDays)*100.000);
                double presentPercentage = Math.Round(presentPercent, 3);
                txtMpresp.Text = presentPercentage.ToString();

                double abpercent = (double)((((double)absentDays / (double)workingDays)) * 100.000);
                double absentPercentage = Math.Round(abpercent, 3);
                txtMabp.Text = absentPercentage.ToString();


            }

        }

        private void metroGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid2.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string admission = metroGrid2.SelectedRows[0].Cells[0].Value + string.Empty;
                string rollNo = metroGrid2.SelectedRows[0].Cells[1].Value + string.Empty;
                string name = metroGrid2.SelectedRows[0].Cells[2].Value + string.Empty;
                string surname = metroGrid2.SelectedRows[0].Cells[3].Value + string.Empty;
                string year = metroGrid2.SelectedRows[0].Cells[4].Value + string.Empty;
                string tot = metroGrid2.SelectedRows[0].Cells[5].Value + string.Empty;
                string present = metroGrid2.SelectedRows[0].Cells[6].Value + string.Empty;
                string pPresent = metroGrid2.SelectedRows[0].Cells[7].Value + string.Empty;
                string absent = metroGrid2.SelectedRows[0].Cells[8].Value + string.Empty;
                string pAbsent = metroGrid2.SelectedRows[0].Cells[9].Value + string.Empty;

                txtYno.Text = admission;
                txtYroll.Text = rollNo;
                txtYsName.Text = name + " " + surname;
                txtYyear.Text = year;
                txtYtot.Text = tot;
                txtYpres.Text = present;
                txtYno.Text = admission;
                txtYpp.Text = pPresent;
                txtYab.Text = absent;
                txtYabp.Text = pAbsent;

                string cls = dba.getClassAtt(txtYno.Text);
                txtYclass.Text = cls.ToString();

            }
        }

        private void btnDdelete_Click(object sender, EventArgs e)
        {
            string admi = txtDnO.Text;
            metroDateTime3.Value = Convert.ToDateTime(gridStuDate.SelectedRows[0].Cells[4].Value);
            var result = MetroMessageBox.Show(this, "DO YOU WANT TO DELETE THE RECORD", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dba.deleteAttendStudent(admi, metroDateTime3.Value))
                    {
                        MessageBox.Show("Successfully deleted");
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
                FillGrid();
            }

        }

        

        public void FilterStudentId(String a)
        {
            try
            {
                DataSet ds = dba.FilterStudentId(a);
                gridStuDate.DataSource = ds.Tables["student_attendance"].DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDadmission_TextChanged(object sender, EventArgs e)
        {
                txtDsName.Clear();
                FilterStudentId(txtDadmission.Text);

                
            
        }

        public void FilterStudentName(String n)
        {
            try
            {

                DataSet ds = dba.FilterStudentName(n);
                gridStuDate.DataSource = ds.Tables["student_attendance"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDsName_TextChanged(object sender, EventArgs e)
        {
            
            FilterStudentName(txtDsName.Text);  
        }

        public void FilterStudentDate(DateTime n)
        {
            try
            {
                DataSet ds = dba.FilterStudentDate(n);
                gridStuDate.DataSource = ds.Tables["student_attendance"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FilterStudentDateNameId(string b, DateTime c)
        {
            try
            {
                DataSet ds = dba.FilterStudentDateNameId(b, c);
                gridStuDate.DataSource = ds.Tables["student_attendance"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void FilterStudentDateName(string name, DateTime date)
        {
            try
            {
                DataSet ds = dba.FilterStudentDateName(name, date);
                gridStuDate.DataSource = ds.Tables["student_attendance"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateDdate_ValueChanged(object sender, EventArgs e)
        {

            if (txtDadmission.Text.Length > 0)
            {
                FilterStudentDateNameId(txtDadmission.Text, dateDdate.Value);
            }
            else 
                if (txtDsName.Text.Length > 0)
            {
                FilterStudentDateName(txtDsName.Text, dateDdate.Value);
            } 
            else
                FilterStudentDate(dateDdate.Value);
            
        }

        public void FilterStudentIdFromTo(string admissionNo, DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataSet ds = dba.FilterStudentIdFromTo(admissionNo, fromDate, toDate);
                gridMonthSt.DataSource = ds.Tables["student_attendance"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FilterStudentNameFromTo(string name, DateTime from, DateTime to)
        {
            try
            {
                DataSet ds = dba.FilterStudentNameFromTo(name, from, to);
                gridMonthSt.DataSource = ds.Tables["student_attendance"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void FilterStudentFromTo(DateTime from, DateTime to)
        {
            try
            {
                DataSet ds = dba.FilterStudentFromTo(from, to);
                gridMonthSt.DataSource = ds.Tables["student_attendance"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void metroDateTime2_ValueChanged(object sender, EventArgs e)
        {
      
            DateTime date1 = metroDateTime1.Value;

            DateTime date2 = metroDateTime2.Value;

            if (txtMadmissionNo.Text.Length > 0)
            {
                FilterStudentIdFromTo(txtMadmissionNo.Text, date1, date2);
            }
            else
                if (txtMsname.Text.Length > 0)
                {
                    FilterStudentNameFromTo(txtMsname.Text, date1, date2);
                }
                else
                    FilterStudentFromTo(date1, date2);
            

            int workingDays = dba.GetWorkingDays(date1, date2);
            txtMtot.Text = workingDays.ToString();



        }

        private void metroDateTime1_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime date1 = metroDateTime1.Value;

            DateTime date2 = metroDateTime2.Value;

            int workingDays = dba.GetWorkingDays(date1, date2);
            txtMtot.Text = workingDays.ToString();
        }

        private void txtDsName_Click(object sender, EventArgs e)
        {
            txtDadmission.Clear();
            ClearAllTextBox(this);
            dateDdate.Value = DateTime.Now;
            FillGrid();
        }

        public void FilterStudentId2(String b)
        {
            try
            {
                DataSet ds = dba.FilterStudentId(b);
                gridMonthSt.DataSource = ds.Tables["student_attendance"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtMadmissionNo_TextChanged(object sender, EventArgs e)
        {
            FilterStudentId2(txtMadmissionNo.Text);
        }

        public void FilterStudentName2(String n)
        {
            try
            {
                DataSet ds = dba.FilterStudentName(n);
                gridMonthSt.DataSource = ds.Tables["student_attendance"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMsname_TextChanged(object sender, EventArgs e)
        {
            FilterStudentName2(txtMsname.Text);
        }

        private void txtMadmissionNo_Click(object sender, EventArgs e)
        {
            txtMsname.Clear();
            metroDateTime1.Value = DateTime.Now;
            metroDateTime2.Value = DateTime.Now;
            FillGrid();
            ClearAllTextBox(this);
        }

        private void txtMsname_Click(object sender, EventArgs e)
        {
            txtMadmissionNo.Clear();
            metroDateTime1.Value = DateTime.Now;
            metroDateTime2.Value = DateTime.Now;
            FillGrid();
            ClearAllTextBox(this);
        }

        private void btnMreset_Click(object sender, EventArgs e)
        {
            ClearAllTextBox(this);
            metroDateTime1.Value = DateTime.Now;
            metroDateTime2.Value = DateTime.Now;
            txtMtot.Clear();
            FillGrid();   
        }

        public void FilterStudentHistoryName(String yName)
        {
            try
            {
                DataSet ds = dba.FilterStudentHistoryName(yName);
                metroGrid2.DataSource = ds.Tables["student_attend_history"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtYname_TextChanged(object sender, EventArgs e)
        {
            FilterStudentHistoryName(txtYname.Text);
        }

        
        public void FilterStudentIdYear(string admission, int yr)
        {
            try
            {
                DataSet ds = dba.FilterStudentIdYear(admission, yr);
                metroGrid2.DataSource = ds.Tables["student_attend_history"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void txtYsYear_TextChanged(object sender, EventArgs e)
        {
            //int y = Int32.Parse(cmbYyear.Text);

            //if (txtYaNo.Text.Length > 0)
            //{
            //    FilterStudentIdYear(txtYaNo.Text, y);
            //}
            //else
            //    FilterStudentHistoryYear(y);
        }

        public void FilterStudentHistoryId(string yadmission)
        {
            try
            {
                DataSet ds = dba.FilterStudentHistoryId(yadmission);
                metroGrid2.DataSource = ds.Tables["student_attend_history"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtYaNo_TextChanged(object sender, EventArgs e)
        {
            FilterStudentHistoryId(txtYaNo.Text);
        }

        public void FilterStudentDateClass(string classId, DateTime dateClass)
        {
            try
            {
                DataSet ds = dba.FilterStudentDateClass(classId, dateClass);
                metroGrid3.DataSource = ds.Tables["attendance_student_class"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateCdate2_ValueChanged(object sender, EventArgs e)
        {
            FilterStudentDateClass(cmbCcls.Text.ToString(), dateCdate2.Value);


            int totalStudent = dba.getTotalNoOfStudent(cmbCcls.Text);
            txtCtot.Text = totalStudent.ToString();

            DateTime classDate = dateCdate2.Value;
            int presentStudent = dba.getTotalNoOfStudentPresent(cmbCclass.Text, classDate);
            txtCpresent.Text = presentStudent.ToString();

            double presentStudentPercent = (double)(((double)presentStudent / (double)totalStudent) * 100.000);
            double presentStudentPercentage = Math.Round(presentStudentPercent, 3);
            txtCpresentPercent.Text = presentStudentPercentage.ToString();

            int absentStudent = dba.getTotalNoOfStudentAbsent(cmbCclass.Text, classDate);
            txtCabsent.Text = absentStudent.ToString();

            double absentStudentPercent = (double)(((double)absentStudent / (double)totalStudent) * 100.000);
            double absentStudentPercentage = Math.Round(absentStudentPercent, 3);
            txtCabsentPercentage.Text = absentStudentPercentage.ToString();


            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ClearAllTextBox(this);
            cmbYyear.SelectedItem = null;
            FillGrid();
        }

        private void btnCreset_Click(object sender, EventArgs e)
        {
            ClearAllTextBox(this);
            cmbCcls.SelectedItem = null;
            cmbCclass.SelectedItem = null;
            dateCdate2.Value = DateTime.Now;
            dateCdate.Value = DateTime.Now;
            dateCdate1.Value = DateTime.Now;
            txtCtot.Clear();
            txtCpresent.Clear();
            txtCpresentPercent.Clear();
            txtCabsent.Clear();
            txtCabsentPercentage.Clear();
            FillGrid();
        }


        public void getClassList(string class_id)
        {
            try
            {
                DataSet ds3 = dba.getClassList(class_id);
                metroGrid3.DataSource = ds3.Tables["attendance_student_class"].DefaultView;
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCcls_SelectedValueChanged(object sender, EventArgs e)
        {
            getClassList(cmbCcls.Text);
        }

        private void cmbCcls_TextChanged(object sender, EventArgs e)
        {
            int totalStudent = dba.getTotalNoOfStudent(cmbCcls.Text);
            txtCtot.Text = totalStudent.ToString();
        }

        private void txtYaNo_Click(object sender, EventArgs e)
        {
            txtYname.Clear();
            ClearAllTextBox(this);
            FillGrid();
        }

        private void txtYname_Click(object sender, EventArgs e)
        {
            txtYaNo.Clear();
            dateDdate.Value = DateTime.Now;
            ClearAllTextBox(this);
            FillGrid();
        }

        private void metroGrid3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid3.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string admissionY = metroGrid3.SelectedRows[0].Cells[0].Value + string.Empty;
                string rollNoY = metroGrid3.SelectedRows[0].Cells[1].Value + string.Empty;
                string classY = metroGrid3.SelectedRows[0].Cells[2].Value + string.Empty;
                string nameY = metroGrid3.SelectedRows[0].Cells[3].Value + string.Empty;
                string surnameY = metroGrid3.SelectedRows[0].Cells[4].Value + string.Empty;
                dateCdate.Value = Convert.ToDateTime(metroGrid3.SelectedRows[0].Cells[5].Value);
                string dateStatusY = metroGrid3.SelectedRows[0].Cells[6].Value + string.Empty;
                string timeInY = metroGrid3.SelectedRows[0].Cells[7].Value + string.Empty;
                string statusY = metroGrid3.SelectedRows[0].Cells[8].Value + string.Empty;
                string reasonY = metroGrid3.SelectedRows[0].Cells[9].Value + string.Empty;

                txtCaNo.Text = admissionY;
                txtCname.Text = nameY + " " + surnameY;
                txtCroll.Text = rollNoY;
                txtCdStatus.Text = dateStatusY;
                dateCdate1.Value = dateCdate.Value;
                txtCdStatus.Text = dateStatusY;
                txtCtime.Text = timeInY;
                txtCstatus.Text = statusY;
                txtCreason.Text = reasonY;
                cmbCclass.Text = classY;

                

                int totalStudent = dba.getTotalNoOfStudent(cmbCcls.Text);
                txtCtot.Text = totalStudent.ToString();

                DateTime classDate = dateCdate2.Value;
                int presentStudent = dba.getTotalNoOfStudentPresent(cmbCclass.Text,classDate);
                txtCpresent.Text = presentStudent.ToString();

                double presentStudentPercent = (double)(((double)presentStudent / (double)totalStudent) * 100.000);
                double presentStudentPercentage = Math.Round(presentStudentPercent, 3);
                txtCpresentPercent.Text = presentStudentPercentage.ToString();

            }
        }

        private void btnMupdate_Click(object sender, EventArgs e)
        {
            //string admission = txtMsNo.Text;
            //DateTime Ddate = metroDateTime3.Value;
            //string dayStatus = txtDdStatus.Text;
            //string DtimeIn = txtDtime.Text;
            //string Dstatus = txtDstatus.Text;
            //string Dreason = txtDreason.Text;

            //var result = MetroMessageBox.Show(this, "DO YOU WANT TO UPDATE THE RECORD", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //if (result == DialogResult.Yes)
            //{
            //    try
            //    {
            //        if (dba.updateStudentAttendance(admission, Ddate, dayStatus, DtimeIn, Dstatus, Dreason))
            //        {
            //            MessageBox.Show("Successfully Updated");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Error occured");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    FillGrid();
            //}
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
        //    string admission = txtYno.Text;
        //    string Yyear = txtYyear.Text;
        //    string totalDays = txtYtot.Text;
        //    string presentDays = txtYpres.Text;
        //    string absentDays = txtYab.Text;
            

        //    var result = MetroMessageBox.Show(this, "DO YOU WANT TO UPDATE THE RECORD", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        //    if (result == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            if (dba.updateStudentAttendance(admission, Ddate, dayStatus, DtimeIn, Dstatus, Dreason))
        //            {
        //                MessageBox.Show("Successfully Updated");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Error occured");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //        FillGrid();
        //    }
        }

        private void btnCupdate_Click(object sender, EventArgs e)
        {
            //string admission = txtCaNo.Text;
            //DateTime Ddate = metroDateTime3.Value;
            //string dayStatus = txtDdStatus.Text;
            //string DtimeIn = txtDtime.Text;
            //string Dstatus = txtDstatus.Text;
            //string Dreason = txtDreason.Text;

            //var result = MetroMessageBox.Show(this, "DO YOU WANT TO UPDATE THE RECORD", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //if (result == DialogResult.Yes)
            //{
            //    try
            //    {
            //        if (dba.updateStudentAttendance(admission, Ddate, dayStatus, DtimeIn, Dstatus, Dreason))
            //        {
            //            MessageBox.Show("Successfully Updated");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Error occured");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    FillGrid();
            //}
            

        }

        public void FilterStudentHistoryYear(int sYear)
        {
            try
            {
                DataSet ds = dba.FilterStudentHistoryYear(sYear);
                metroGrid2.DataSource = ds.Tables["student_attend_history"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //public void FilterStudentIdYear(string admin, int yr)
        //{
        //    try
        //    {
        //        DataSet ds = dba.FilterStudentIdYear(admin, yr);
        //        metroGrid2.DataSource = ds.Tables["student_attend_history"].DefaultView;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        public void FilterStudentNameYear(string nm, int yr)
        {
            try
            {
                DataSet ds = dba.FilterStudentNameYear(nm, yr);
                metroGrid2.DataSource = ds.Tables["student_attend_history"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbYyear_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txtYname.Text.Length <= 0)
            {
                FilterStudentIdYear(txtYaNo.Text, Convert.ToInt32(cmbYyear.Text));
            }
            else
                 FilterStudentHistoryYear(Convert.ToInt32(cmbYyear.Text));
        }

        private void txtDname_Click(object sender, EventArgs e)
        {
            
        }

        private void txtDname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDnO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDroll_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDclass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDdStatus_TextChanged(object sender, EventArgs e)
        {
            //if (!st1.studentValidEmpty(txtDdStatus.Text))
            //{
            //    MetroMessageBox.Show(this, "Cannot keep this field emply", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //}
            //else if (!st1.isLetter(txtDdStatus.Text))
            //{
            //    MetroMessageBox.Show(this, "Input a valid term which contains only text", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //}
        }

        private void txtDtime_TextChanged(object sender, EventArgs e)
        {
            //if (!st1.isNumber(txtDtime.Text))
            //{
            //    MetroMessageBox.Show(this, "Insert a time value", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //}
        }

       
        

    }
}
