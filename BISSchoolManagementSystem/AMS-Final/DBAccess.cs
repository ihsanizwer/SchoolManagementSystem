using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS_Final
{
    class DBAccess
    {
        SqlConnection conn;


        public DBAccess()
        {
            conn = ConnectionManager.getConnection();
        }


        public void execInsert(String command)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = command;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e1)
            {
                if (e1.Number == 2627)
                    MessageBox.Show("There is already a record in the database with the same ID. Enter a different one.");
                else
                    MessageBox.Show(e1.Message);
            }
            conn.Close();
        }

        public DataSet getAllJobs()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from student_attendance";
            //newCmd.CommandText= "select s.admission_no, s.name, s.surname, s.present_grade, g10.date, g10.time_in, g10.status, g10.reason from student s cross join stud_attendace g10 where s.admission_no=g10.admission_no";
            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "student_attendance");

            conn.Close();

            return ds;
        }

        public DataSet getStudAttendance()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd1 = conn.CreateCommand();
            newCmd1.Connection = conn;
            newCmd1.CommandType = CommandType.Text;
            newCmd1.CommandText = "select * from student_attend_history";

            SqlDataAdapter da1 = new SqlDataAdapter(newCmd1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "student_attend_history");

            conn.Close();

            return ds1;
        }

        public DataSet getClassAttendance()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd4 = conn.CreateCommand();
            newCmd4.Connection = conn;
            newCmd4.CommandType = CommandType.Text;
            newCmd4.CommandText = "select * from attendance_student_class";

            SqlDataAdapter da2 = new SqlDataAdapter(newCmd4);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2, "attendance_student_class");

            conn.Close();

            return ds2;
        }

       

        public string getClassAtt(string aNo)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd2 = conn.CreateCommand();
            newCmd2.Connection = conn;
            newCmd2.CommandType = CommandType.Text;
            newCmd2.CommandText = "select present_grade from student where admission_no= '" + aNo + "' ";

            string variable = (string)newCmd2.ExecuteScalar();

            conn.Close();

            return variable;
        }

        public DataSet getTeacherAtt(string cls)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd3 = conn.CreateCommand();
            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "select s.salutation, s.first_name, s.last_name from staff s, class c where s.staff_id=c.teacher_incharge and c.class_id= '" + cls + "' ";

            SqlDataAdapter da2 = new SqlDataAdapter(newCmd3);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);


            conn.Close();

            return ds2;
        }

        public bool deleteAttendStudent(string admission, DateTime date)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from student_attendance where admission_no='" + admission + "' and date='" + date + "' ";
            newCmd.ExecuteNonQuery();

            status = true;

            return status;
        }

        public DataSet FilterStudentId(string admission)
        {
            if (conn.State.ToString() == null)
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from student_attendance where admission_no like '" + admission + "'+'%' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "student_attendance");

            conn.Close();

            return ds;
        }

        public DataSet FilterStudentName(String name)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from student_attendance where name like '%' + '" + name + "' + '%' or surname like '%' + '" + name + "' + '%' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "student_attendance");

            conn.Close();

            return ds;
        }

        public DataSet FilterStudentDate(DateTime date)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from student_attendance where date = '" + date + "' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "student_attendance");

            
            conn.Close();


            return ds;
        }

        public bool updateStudentAttendance(string admission, DateTime date, string dayStatus, string timeIn, string status, string reason)
        {
            SqlCommand newCmd3 = conn.CreateCommand();

            bool statusAttend = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;

            try
            {
                SqlString timeVal = SqlString.Null;

               // MessageBox.Show(timeIn);
                if (timeIn == null)
                {
                    newCmd3.CommandText = "update  student_attendance set date ='" + date + "',dateStatus='" + dayStatus + "', time_in='" + null +"', status='" + status + "', reason='" + reason + "' where admission_no = '" + admission + "' and date = '" + date + "' ";
                }
                else
                    newCmd3.CommandText = "update  student_attendance set date ='" + date + "',dateStatus='" + dayStatus + "', time_in='" + timeIn + "', status='" + status + "', reason='" + reason + "' where admission_no = '" + admission + "' and date = '" + date + "' ";

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            newCmd3.ExecuteNonQuery();
            conn.Close();
            statusAttend = true;
            //MessageBox.Show(statusAttend.ToString());
            return statusAttend;
        }

        public int getStudentPresent(string admission, DateTime date1, DateTime date2)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd2 = conn.CreateCommand();
            newCmd2.Connection = conn;
            newCmd2.CommandType = CommandType.Text;
            newCmd2.CommandText = "select COUNT(admission_no)from student_attendance where status='Present' and admission_no='" +admission+ "' and date>='"+date1+"' and date<= '"+date2+"' "; 

            int days = (int)newCmd2.ExecuteScalar();

            conn.Close();

            return days;
        }

        public int getStudentAbsent(string admission, DateTime date1, DateTime date2)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd2 = conn.CreateCommand();
            newCmd2.Connection = conn;
            newCmd2.CommandType = CommandType.Text;
            newCmd2.CommandText = "select COUNT(admission_no)from student_attendance where status='Absent' and admission_no='" + admission + "'and date>='" + date1 + "' and date<= '" + date2 + "' ";

            int days = (int)newCmd2.ExecuteScalar();

            conn.Close();

            return days;
        }

        //public int getStudentTotaldays(string admission, DateTime date1, DateTime date2)
        //{
        //    if (conn.State.ToString() == "Closed")
        //    {
        //        conn.Open();
        //    }

        //    SqlCommand newCmd2 = conn.CreateCommand();
        //    newCmd2.Connection = conn;
        //    newCmd2.CommandType = CommandType.Text;
        //    newCmd2.CommandText = "select Count(admission_no) from student_attendance where admission_no='" + admission + "' and date>='"+date1+"' and date<= '"+date2+"' ";

        //    int days = (int)newCmd2.ExecuteScalar();

        //    conn.Close();

        //    return days;
        //}

        public int GetWorkingDays(DateTime from, DateTime to)
        {
            var totalDays = 0;
            for (var date = from; date <= to; date = date.AddDays(1))
            {
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                    totalDays++;
            }

            return (totalDays);
        }

        public DataSet FilterStudentDateNameId(string admission, DateTime date)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from student_attendance where admission_no='"+admission+ "' and date = '" + date + "' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "student_attendance");

            conn.Close();

            return ds;
        }

        public DataSet FilterStudentDateName(string name, DateTime date)
        {
            
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from student_attendance where date = '" + date + "' and name like '%' + '" + name + "' + '%' or surname like '%' + '" + name + "' + '%' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "student_attendance");

            conn.Close();

            return ds;
        }

        //To get student details for specified period.
        public DataSet FilterStudentIdFromTo(string admission, DateTime date1, DateTime date2)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from student_attendance where admission_no='" + admission + "' and date>='"+date1+"' and date<= '"+date2+"' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "student_attendance");

            conn.Close();

            return ds;
        }

        public DataSet FilterStudentNameFromTo(string name, DateTime date1, DateTime date2)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd2 = conn.CreateCommand();
            newCmd2.Connection = conn;
            newCmd2.CommandType = CommandType.Text;
            newCmd2.CommandText = "select * from student_attendance where (date>='" + date1 + "' and date<= '" + date2 + "') and (name like '%' + '" + name + "' + '%' or surname like '%' + '" + name + "' + '%')";

            SqlDataAdapter da = new SqlDataAdapter(newCmd2);
            DataSet ds = new DataSet();
            da.Fill(ds, "student_attendance");

            conn.Close();

            return ds;
        }

        public DataSet FilterStudentFromTo(DateTime date1, DateTime date2)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd2 = conn.CreateCommand();
            newCmd2.Connection = conn;
            newCmd2.CommandType = CommandType.Text;
            newCmd2.CommandText = "select * from student_attendance where date>='" + date1 + "' and date<= '" + date2 + "'";

            SqlDataAdapter da = new SqlDataAdapter(newCmd2);
            DataSet ds = new DataSet();
            da.Fill(ds, "student_attendance");

            conn.Close();

            return ds;
        }

        public DataSet FilterStudentHistoryName(String name)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from student_attend_history where first_name like '%' + '" + name + "' + '%' or last_name like '%' + '" + name + "' + '%' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "student_attend_history");

            conn.Close();

            return ds;
        }

        public DataSet FilterStudentHistoryYear(int yearY)
        {
            
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from student_attend_history where year ='" + yearY +"'";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "student_attend_history");

            conn.Close();

            return ds;
        }

        public DataSet FilterStudentHistoryId(string admissionNum)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from student_attend_history where admission_no ='" + admissionNum +"'";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "student_attend_history");

            conn.Close();

            return ds;
        }

        public DataSet FilterStudentIdYear(string admission, int aYr)
        {
            

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from student_attend_history where admission_no='" + admission + "' and year ='" + aYr + "'";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "student_attend_history");

            conn.Close();

            return ds;
        }

        public DataSet getClassList(string cls)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            
            SqlCommand newCmd3 = conn.CreateCommand();
            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "select * from attendance_student_class where grade='" + cls + "'";

            SqlDataAdapter da3 = new SqlDataAdapter(newCmd3);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3, "attendance_student_class");


            conn.Close();

            return ds3;
        }

        public DataSet FilterStudentDateClass(string grade, DateTime date)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from attendance_student_class where grade='" + grade + "' and date = '" + date + "' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "attendance_student_class");

            conn.Close();

            return ds;
        }

        //public bool updateStudentAttendanceHistory(string admission, int yearY, string dayStatus, string timeIn, string status, string reason)
        //{
        //    SqlCommand newCmd3 = conn.CreateCommand();

        //    bool statusAttend = false;
        //    if (conn.State.ToString() == "Closed")
        //    {
        //        conn.Open();
        //    }
        //    newCmd3.Connection = conn;
        //    newCmd3.CommandType = CommandType.Text;

        //    try
        //    {
        //        SqlString timeVal = SqlString.Null;

        //        // MessageBox.Show(timeIn);
        //        if (timeIn == null)
        //        {
        //            newCmd3.CommandText = "update  student_attendance set date ='" + date + "',dateStatus='" + dayStatus + "', time_in='" + null + "', status='" + status + "', reason='" + reason + "' where admission_no = '" + admission + "' and date = '" + date + "' ";
        //        }
        //        else
        //            newCmd3.CommandText = "update  student_attendance set date ='" + date + "',dateStatus='" + dayStatus + "', time_in='" + timeIn + "', status='" + status + "', reason='" + reason + "' where admission_no = '" + admission + "' and date = '" + date + "' ";

        //    }

        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    newCmd3.ExecuteNonQuery();
        //    conn.Close();
        //    statusAttend = true;
        //    //MessageBox.Show(statusAttend.ToString());
        //    return statusAttend;
        //}

        public int getTotalNoOfStudent(String gradeNo)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd2 = conn.CreateCommand();
            newCmd2.Connection = conn;
            newCmd2.CommandType = CommandType.Text;
            newCmd2.CommandText = "select COUNT(admission_no)from student where present_grade='" + gradeNo + "'";

            int totalStudents = (int)newCmd2.ExecuteScalar();

            conn.Close();

            return totalStudents;
        }

        public int getTotalNoOfStudentPresent(String gradeNo,DateTime selectDate)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd2 = conn.CreateCommand();
            newCmd2.Connection = conn;
            newCmd2.CommandType = CommandType.Text;
            newCmd2.CommandText = "select COUNT(admission_no)from attendance_student_class where grade='" + gradeNo + "' and date = '"+selectDate+"' and status = 'Present'";

            int totalStudentsResent = (int)newCmd2.ExecuteScalar();

            conn.Close();

            return totalStudentsResent;
        }

        public int getTotalNoOfStudentAbsent(String gradeNo, DateTime selectDate)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd2 = conn.CreateCommand();
            newCmd2.Connection = conn;
            newCmd2.CommandType = CommandType.Text;
            newCmd2.CommandText = "select COUNT(admission_no)from attendance_student_class where grade='" + gradeNo + "' and date = '" + selectDate + "' and status = 'Absent'";

            int totalStudentsAbsent = (int)newCmd2.ExecuteScalar();

            conn.Close();

            return totalStudentsAbsent;
        }

        public DataSet FilterStudentNameYear(string yName, int aYr)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from student_attend_history where year='" + aYr + "' and  first_name like '%' + '" + yName + "' + '%' or last_name like '%' + '" + yName + "' + '%' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "student_attend_history");

            conn.Close();

            return ds;
        }

    }
}
