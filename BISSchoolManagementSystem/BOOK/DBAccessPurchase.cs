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
    class DBAccessPurchase
    {
        public static SqlConnection conn;
          public DBAccessPurchase()
        {
            conn = ConnectionManager.getConnection();
        }


          public bool addPurchase(int purid ,string title , string date ,string supname , int quan ,double perbook , double tcost ,string author , string booklang, string edition, string catname, string publisher)
          {
              bool status = false;

              if (conn.State.ToString() == "Closed")
              {
                  conn.Open();
              }

              SqlCommand newCmd = conn.CreateCommand();

              newCmd.Connection = conn;
              newCmd.CommandType = CommandType.Text;
              newCmd.CommandText = "insert into purchase (purchase_id,title,purchase_date,supplier_name,quantity,per_book_rate,total_cost,Author ,book_language,edition,category_name,publisher)values (" + purid + ", '" + title + "','" + date + "','" + supname + "'," + quan + "," + perbook + " ," + tcost + ",'" + author + "','" + booklang + "'," + edition + ",'" + catname + "','" + publisher + "')";
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

          public bool updatePurchase(int purid, string title, string date, string supname, int quan, double perbook, double tcost, string author, string booklang, string edition, string catname, string publisher)
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
                  newCmd3.CommandText = "update  dbo.purchase set purchase_id=" + purid + ",title='" + title + "',purchase_date='" + date + "',supplier_name='" + supname + "',quantity=" + quan + ",per_book_rate=" + perbook + ",total_cost=" + tcost + ",Author='" + author + "' ,book_language='" + booklang + "',edition=" + edition + ",category_name='" + catname+ "',publisher='" +publisher + "'  where purchase_id=" + purid + "";
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
          public bool deletePurchase(int purid)
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

                  newCmd.CommandText = "delete from dbo.purchase where purchase_id =" + purid + " ";

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
          public DataSet FilterPurchaseName(String text)
          {

              if (conn.State.ToString() == "Closed")
              {
                  conn.Open();
              }

              SqlCommand newCmd = conn.CreateCommand();
              newCmd.Connection = conn;
              newCmd.CommandType = CommandType.Text;
              newCmd.CommandText = "select * from Purchase where title like '%" + text + "%' ";

              SqlDataAdapter da = new SqlDataAdapter(newCmd);
              DataSet ds = new DataSet();
              da.Fill(ds, "purchase");

              conn.Close();

              return ds;
          }
          public DataSet FilterPurchaseId(string text)
          {
              int purid = Convert.ToInt16(text);
              if (conn.State.ToString() == null)
              {
                  conn.Open();
              }

              SqlCommand newCmd = conn.CreateCommand();
              newCmd.Connection = conn;
              newCmd.CommandType = CommandType.Text;
              newCmd.CommandText = "select * from purchase where purchase_id = " + purid + " ";

              SqlDataAdapter da = new SqlDataAdapter(newCmd);
              DataSet ds = new DataSet();
              da.Fill(ds, "purchase");

              conn.Close();

              return ds;
          }
    }
}
