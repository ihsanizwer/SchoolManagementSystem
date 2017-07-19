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

    class DBAccessCat
    {
        public static SqlConnection conn;
         public DBAccessCat()
        {
            conn = ConnectionManager.getConnection();
        }


         public bool updateCategory(string catid, string catname, string rackno, string date, int noofbooks, string catstatus)
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
                 newCmd3.CommandText = "update  dbo.category set category_id= '" + catid + "', category_name= '" + catname + "', rack_no= '" + rackno + "', added_date= '" + date + "', no_of_books= " + noofbooks + ", cat_status= '" + catstatus + "'   where category_id  = '" + catid + "' ";
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

         public bool addcategory(string catid, string catname, string rackno, string addeddate, int noofbooks, string catstatus)
         {
             bool status = false;

             if (conn.State.ToString() == "Closed")
             {
                 conn.Open();
             }

             SqlCommand newCmd = conn.CreateCommand();

             newCmd.Connection = conn;
             newCmd.CommandType = CommandType.Text;
             newCmd.CommandText = "insert into category (category_id,category_name,rack_no ,added_date,no_of_books ,cat_status)values ('" + catid + "', '" + catname + "'," + rackno + ",'" + addeddate + "'," + noofbooks + ",'" + catstatus + "')";
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

         public bool deleteCategory(String catid)
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

                 newCmd.CommandText = "delete from dbo.category where category_id ='" + catid + "' ";

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

         public DataSet FilterCatName(String text)
         {

             if (conn.State.ToString() == "Closed")
             {
                 conn.Open();
             }

             SqlCommand newCmd = conn.CreateCommand();
             newCmd.Connection = conn;
             newCmd.CommandType = CommandType.Text;
             newCmd.CommandText = "select * from category where category_name like '%" + text + "%' ";

             SqlDataAdapter da = new SqlDataAdapter(newCmd);
             DataSet ds = new DataSet();
             da.Fill(ds, "category");

             conn.Close();

             return ds;
         }
         public DataSet FilterCatId(String text)
         {

             if (conn.State.ToString() == "Closed")
             {
                 conn.Open();
             }

             SqlCommand newCmd = conn.CreateCommand();
             newCmd.Connection = conn;
             newCmd.CommandType = CommandType.Text;
             newCmd.CommandText = "select * from category where category_id like '%" + text + "%' ";

             SqlDataAdapter da = new SqlDataAdapter(newCmd);
             DataSet ds = new DataSet();
             da.Fill(ds, "category");

             conn.Close();

             return ds;
         }


    }
}
