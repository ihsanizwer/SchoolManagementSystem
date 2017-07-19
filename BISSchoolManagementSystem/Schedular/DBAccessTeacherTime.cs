using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SQLServerDatabaseAccess;

namespace Schedular
{
    class DBAccessTeacherTime
    {
        public static SqlConnection conn;

        public DBAccessTeacherTime()
        {
            conn = ConnectionManager.getConnection();
        }

        public bool addTeacherTime(string techid, string day ,int periodno,string sttime , string endtime,string classid , string subject)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into teacher_time_table (teacher_id,week_day,period_no,start_time,end_time,class_id,sub_name)values ('" + techid+ "', '" + day + "'," + periodno + ",'" + sttime + "','" + endtime + "','" + classid + "','" + subject + "')";
            try
            {
                newCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            status = true;

            return status;

        }
        public bool updateTeacherTime(string techid, string day, int periodno, string sttime, string endtime, string classid, string subject)
        {
            SqlCommand newCmd3 = conn.CreateCommand();
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            try
            {
                newCmd3.CommandText = "update  teacher_time_table set teacher_id='" + techid + "',week_day='" + day + "',period_no=" + periodno + ",start_time='" + sttime + "',end_time='" + endtime + "',class_id='" + classid + "',sub_name='" + subject + "' where teacher_id='" + techid + "' and week_day='" + day + "'  and period_no=" + periodno + " ";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            newCmd3.ExecuteNonQuery();
            conn.Close();
            status = true;
            return status;

        }

        public bool deleteTeacherTime(string techid, string day, int period)
        {


            bool status = false;




            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;

            try
            {

                newCmd.CommandText = "delete from teacher_time_table where  teacher_id='" + techid + "' and week_day='" + day + "'  and period_no=" + period + " ";

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            newCmd.ExecuteNonQuery();
            conn.Close();
            status = true;

            return status;
        }

        public DataSet FilterTeacherTabTeacherId(String text)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from teacher_time_table where teacher_id = '" + text + "' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "teacher_time_table");

            conn.Close();

            return ds;
        }
        public DataSet FilterTeacherTabUnique(String text1,String text2)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from teacher_time_table where teacher_id = '" + text1 + "' and  week_day='"+text2+"' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "teacher_time_table");

            conn.Close();

            return ds;
        }
    }
}
