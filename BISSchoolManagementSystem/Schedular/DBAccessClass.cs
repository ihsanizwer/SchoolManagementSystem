using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using SQLServerDatabaseAccess;


namespace Schedular
{
    
    class DBAccessClass
    {


        public static SqlConnection conn;
        public DBAccessClass()
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
        

        public   DataSet getClassTime( )
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
        
           String text = new classtimetable().getTabText();

            
          

            if(text == "TabPage: {MONDAY}")
            {
                newCmd.CommandText = "select week_day ,class_id ,sub_no, sub_name, start_time ,end_time,teacher_id from class_time_table  where week_day='Monday' ";
      

            }
            else if (text == "TabPage: {TUESDAY}")
            {
                newCmd.CommandText = "select week_day ,class_id ,sub_no, sub_name, start_time ,end_time,teacher_id from class_time_table  where week_day='Tuesday' ";

            }
            else if (text == "TabPage: {WENDSDAY}")
            {
                newCmd.CommandText = "select week_day ,class_id ,sub_no, sub_name, start_time ,end_time,teacher_id from class_time_table  where week_day='Wendsday'";
            }
            else if (text == "TabPage: {THURSDAY}")
            {
                newCmd.CommandText = "select week_day ,class_id ,sub_no, sub_name, start_time ,end_time,teacher_id from class_time_table  where week_day='Thursday' ";
            }
            else if (text == "TabPage: {FRIDAY}")
            {
                newCmd.CommandText = "select week_day ,class_id ,sub_no, sub_name, start_time ,end_time,teacher_id from class_time_table  where week_day='Friday' ";
            }

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }


                SqlDataAdapter da = new SqlDataAdapter(newCmd);


                DataSet ds = new DataSet();
                da.Fill(ds, "class_time_table");
                conn.Close();

                return ds;

          

           
            
            
        }

     /*   public DataTable getClass()
        {
            DataTable dt = new DataTable();
           
            dt.Columns.Add("ClassName", typeof(string));

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select class_id from class";
            SqlDataReader dr = newCmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add( dr["class_id"]);
            }
            conn.Close();
            return dt;
        }*/

        public bool updateClassTable(String starttime, String endtime, String teacherid, String classid, String subjectid, string subno)
        {
           int subjectNo =Convert.ToInt16( subno);
            SqlCommand newCmd3 = conn.CreateCommand();
           
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            newCmd3.Connection = conn;
            newCmd3.CommandType= CommandType.Text;


            String text = new classtimetable().getTabText();


            if (text == "TabPage: {MONDAY}")
            {
                try
                {
                    MessageBox.Show("MONDAY");
                    newCmd3.CommandText = "update  dbo.class_time_table set sub_name = '" + subjectid + "', start_time = '" + starttime + "', end_time = '" + endtime + "',teacher_id = '" + teacherid + "'  where class_id = '" + classid + "' and week_day = 'Monday' and sub_no=" + subjectNo + " ";
                   
                }

                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (text == "TabPage: {TUESDAY}")
            {
                newCmd3.CommandText = "update  dbo.class_time_table set sub_name = '" + subjectid + "', start_time = '" + starttime + "', end_time = '" + endtime + "',teacher_id = '" + teacherid + "'  where class_id = '" + classid + "' and week_day = 'Tuesday' and sub_no=" + subjectNo + " ";

            }
            else if (text == "TabPage: {WENDSDAY}")
            {
                newCmd3.CommandText = "update class_time_table set sub_name = '" + subjectid + "', start_time = '" + starttime + "', end_time = '" + endtime + "',teacher_id = '" + teacherid + "'  where class_id = '" + classid + "' and  week_day = 'Wendsday' and sub_no=" + subjectNo + " ";
            }
            else if (text == "TabPage: {THURSDAY}")
            {
                newCmd3.CommandText = "update class_time_table set sub_name = '" + subjectid + "', start_time = '" + starttime + "', end_time = '" + endtime + "',teacher_id = '" + teacherid + "'  where class_id = '" + classid + "' and week_day = 'Thursday' and sub_no=" + subjectNo + " ";
            }
            else if (text == "TabPage: {FRIDAY}")
            {
                newCmd3.CommandText = "update class_time_table set sub_name = '" + subjectid + "', start_time = '" + starttime + "', end_time = '" + endtime + "',teacher_id = '" + teacherid + "'  where class_id = '" + classid + "' and week_day = 'Friday' and sub_no=" + subjectNo + " ";
            }


           

            newCmd3.ExecuteNonQuery();
            conn.Close();
            status = true;

            return status;

        }

        public bool deleteClassShedule(String classname , string subno)
        {

            int subjectNo = Convert.ToInt16(subno);
            bool status = false;
            String text = new classtimetable().getTabText();
        

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            if (text == "TabPage: {MONDAY}")
            {
                try
                {
                    MessageBox.Show("MONDAY");
                    newCmd.CommandText = "delete from dbo.class_time_table where week_day='Monday' and class_id='" + classname + "' and sub_no=" + subjectNo + " ";

                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (text == "TabPage: {TUESDAY}")
            {
                newCmd.CommandText = "delete from dbo.class_time_table where week_day='Tuesday' and class_id='" + classname + "' and sub_no=" + subjectNo + " ";

            }
            else if (text == "TabPage: {WENDSDAY}")
            {
                newCmd.CommandText = "delete from dbo.class_time_table where week_day='Wendsday' and class_id='" + classname + "' and sub_no=" + subjectNo + " ";
            }
            else if (text == "TabPage: {THURSDAY}")
            {
                newCmd.CommandText = "delete from dbo.class_time_table where week_day='Thursday' and class_id='" + classname + "' and sub_no=" + subjectNo + " ";
            }
            else if (text == "TabPage: {FRIDAY}")
            {
                newCmd.CommandText = "delete from dbo.class_time_table where week_day='Friday' and class_id='" + classname + "' and sub_no=" + subjectNo + " ";
            }





           
            newCmd.ExecuteNonQuery();
            conn.Close();
            status = true;

            return status;
        }

       


        public DataSet getClassGrid(String classname, String subno)
        {
            int subjectno = Convert.ToInt32(subno);
            
            //MessageBox.Show(classname);
           // MessageBox.Show(subno);
           // MessageBox.Show(subjectname);
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd4 = conn.CreateCommand();
            newCmd4.Connection = conn;
            newCmd4.CommandType = CommandType.Text;

            String text = new classtimetable().getTabText();
            if (text == "TabPage: {MONDAY}")
            {
                newCmd4.CommandText = "select * from class_time_table  where week_day='Monday' and class_id = '" + classname + "' and sub_no=" + subjectno + " ";


            }
            else if (text == "TabPage: {TUESDAY}")
            {
                newCmd4.CommandText = "select * from class_time_table  where week_day='Tuesday' and class_id = '" + classname + "' and sub_no=" + subjectno + " ";

            }
            else if (text == "TabPage: {WENDSDAY}")
            {
                newCmd4.CommandText = "select * from class_time_table  where week_day='Wendsday' and class_id = '" + classname + "' and sub_no=" + subjectno + " ";
            }
            else if (text == "TabPage: {THURSDAY}")
            {
                newCmd4.CommandText = "select * from class_time_table  where week_day='Thursday' and class_id = '" + classname + "' and sub_no=" + subjectno + "  ";
            }
            else if (text == "TabPage: {FRIDAY}")
            {
                newCmd4.CommandText = "select * from class_time_table  where week_day='Friday' and class_id = '" + classname + "' and sub_no=" + subjectno + " ";
            }



            SqlDataAdapter da = new SqlDataAdapter(newCmd4);


            DataSet ds = new DataSet();
            da.Fill(ds, "class_time_table");
            

            return ds;
        }
        public DataSet getClassTabClassId(String classname)
        {
                 

            //MessageBox.Show(classname);
            // MessageBox.Show(subno);
            // MessageBox.Show(subjectname);
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd4 = conn.CreateCommand();
            newCmd4.Connection = conn;
            newCmd4.CommandType = CommandType.Text;

            String text = new classtimetable().getTabText();
            if (text == "TabPage: {MONDAY}")
            {
                newCmd4.CommandText = "select * from class_time_table  where week_day='Monday' and class_id = '" + classname + "' ";


            }
            else if (text == "TabPage: {TUESDAY}")
            {
                newCmd4.CommandText = "select * from class_time_table  where week_day='Tuesday' and class_id = '" + classname + "' ";

            }
            else if (text == "TabPage: {WENDSDAY}")
            {
                newCmd4.CommandText = "select * from class_time_table  where week_day='Wendsday' and class_id = '" + classname + "' ";
            }
            else if (text == "TabPage: {THURSDAY}")
            {
                newCmd4.CommandText = "select * from class_time_table  where week_day='Thursday' and class_id = '" + classname + "' ";
            }
            else if (text == "TabPage: {FRIDAY}")
            {
                newCmd4.CommandText = "select * from class_time_table  where week_day='Friday' and class_id = '" + classname + "'  ";
            }



            SqlDataAdapter da = new SqlDataAdapter(newCmd4);


            DataSet ds = new DataSet();
            da.Fill(ds, "class_time_table");


            return ds;
        }
        public bool addClass(String starttime, String endtime, String teacherid, String classid, String subjectid, String subno)
        {
            bool status = false;
            int subjectNo = Convert.ToInt16(subno);
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            String text = new classtimetable().getTabText();
            if (text == "TabPage: {MONDAY}")
            {
                newCmd.CommandText = "insert into class_time_table (week_day,class_id,sub_no,sub_name,start_time,end_time,teacher_id)values ('Monday','" + classid + "', '" + subjectNo + "','" + subjectid + "','" + starttime + "','" + endtime + "','" + teacherid + "')";


            }
            else if (text == "TabPage: {TUESDAY}")
            {
                newCmd.CommandText = "insert into class_time_table (week_day,class_id,sub_no,sub_name,start_time,end_time,teacher_id)values ('Tuesday','" + classid + "', '" + subjectNo + "','" + subjectid + "','" + starttime + "','" + endtime + "','" + teacherid + "')";
            }
            else if (text == "TabPage: {WENDSDAY}")
            {
                MessageBox.Show(text);
                newCmd.CommandText = "insert into class_time_table (week_day,class_id,sub_no,sub_name,start_time,end_time,teacher_id)values ('Wendsday','" + classid + "', " + subjectNo + ",'" + subjectid + "','" + starttime + "','" + endtime + "','" + teacherid + "')";
            }
            else if (text == "TabPage: {THURSDAY}")
            {
                newCmd.CommandText = "insert into class_time_table (week_day,class_id,sub_no,sub_name,start_time,end_time,teacher_id)values ('Thursday','" + classid + "', " + subjectNo + ",'" + subjectid + "','" + starttime + "','" + endtime + "','" + teacherid + "')";
            }
            else if (text == "TabPage: {FRIDAY}")
            {
                newCmd.CommandText = "insert into class_time_table (week_day,class_id,sub_no,sub_name,start_time,end_time,teacher_id)values ('Friday','" + classid + "', " + subjectNo + ",'" + subjectid + "','" + starttime + "','" + endtime + "','" + teacherid + "')";
            }



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



    }
}
