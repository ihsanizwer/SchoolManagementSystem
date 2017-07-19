using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SQLServerDatabaseAccess;

namespace BOOK
{
    class DBAccessMember
    {
        public static SqlConnection conn;

        public DBAccessMember()
        {
            conn = ConnectionManager.getConnection();
        }

        public bool addMember(string memid ,string membarcode, string jdate, string vdate, double deposit, string type ,string name , int contact,string gender, string mstatus)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into member (member_id,member_barcode,join_date,valid_date,security_deposit,type_of_member,member_name,contact_no,gender,member_status)values ('" + memid + "','" + membarcode + "','" + jdate + "','" + vdate + "'," + deposit + ", '" + type + "','" + name + "'," + contact + ",'" + gender + "','" + mstatus + "')";
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
        public bool updateMember(string memid, string membarcode, string jdate, string vdate, double deposit, string type, string name, int contact, string gender, string mstatus)
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
                newCmd3.CommandText = "update  member set member_id='" + memid + "',member_barcode='" + membarcode + "',join_date='" + jdate + "',valid_date='" + vdate + "',security_deposit=" + deposit + ",type_of_member='" + type + "',member_name='" + name + "',contact_no=" + contact + " ,gender='" + gender + "',member_status='" + mstatus + "'  where member_id='" + memid + "' ";
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
        public bool deleteMember(string memid)
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

                newCmd.CommandText = "delete from member where member_id ='" + memid + "' ";

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
        public DataSet FilterMemberId(String text)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from member where member_id like '%" + text + "%' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "member");

            conn.Close();

            return ds;
        }

        public DataSet FilterMemberName(String text)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from member where member_name like '%" + text + "%' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "member");

            conn.Close();

            return ds;
        }
        public DataSet FilterMemberType(string text)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from member where type_of_member like '%" + text + "%' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "member");

            conn.Close();

            return ds;
        }
    }
}
