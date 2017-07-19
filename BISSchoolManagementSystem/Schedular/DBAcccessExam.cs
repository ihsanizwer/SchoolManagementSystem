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
    class DBAcccessExam
    {
        public static SqlConnection conn;
        public DBAcccessExam()
        {
            conn = ConnectionManager.getConnection();
        }

        public bool addExam(string examid, string sttime, string endtime, string exdate, string tecid , string sub,string clasid, string venue)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into exam_time_table (exam_id,starttime,endtime,exam_date,teacher_id , exam_subject,class_id ,venue)values ('" + examid + "', '" + sttime + "','" + endtime + "','" + exdate + "','" + tecid + "','" + sub + "','" + clasid + "','" + venue + "')";
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
        public bool updateExam(string examid, string sttime, string endtime, string exdate, string tecid, string sub, string clasid, string venue)
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
                newCmd3.CommandText = "update  dbo.exam_time_table set exam_id='" + examid + "',starttime='" + sttime + "',endtime='" + endtime + "',exam_date='" + exdate + "',teacher_id='" + tecid + "' , exam_subject='" + sub + "',class_id='" + clasid + "' ,venue='" + venue + "' where exam_id='" + examid + "' and exam_subject='" + sub + "' and class_id='" + clasid + "'  ";
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
        public bool deleteExam(String exid, string clsid, string sub)
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

                newCmd.CommandText = "delete from dbo.exam_time_table where exam_id ='" + exid + "' and class_id ='" + clsid + "' and  exam_subject='" + sub + "' ";

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
        public DataSet FilterExamTeacher(String text)
        {
          
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from exam_time_table where teacher_id like '%" + text + "%' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "exam_time_table");

            conn.Close();

            return ds;
        }
        public DataSet FilterExamClass(String text)
        {
           

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from exam_time_table where exam_id like '%" + text + "%' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "exam_time_table");

            conn.Close();

            return ds;
        }
        public DataSet FilterExamDate(String text)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from exam_time_table where exam_date  = '" + text + "' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "exam_time_table");

            conn.Close();

            return ds;
        }
        public DataSet FilterExamDateId(String text1 , string text2)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from exam_time_table where exam_id  = '" + text1 + "'  and class_id='"+text2+"'";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "exam_time_table");

            conn.Close();

            return ds;
        }
        public DataSet getAllExam()
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from exam_time_table ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "exam_time_table");

            conn.Close();

            return ds;
        }
    }
}
