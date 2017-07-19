using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ITP
{
    class DBAccessItemsTile
    {
        public static SqlConnection conn;
        public DBAccessItemsTile()
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

        public bool addItem(string itemcode, string itemname,string description, double unitprice)
        {

            
            double Unitprice = Convert.ToDouble(unitprice);


            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into item(item_code,item_name,item_description,item_price)values ('" + itemcode + "', '" + itemname + "', '" +description +"'," + unitprice + ")";
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
        public bool updateItem(string itemcode, string itemname, string description, double unitprice)
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

                newCmd3.CommandText = "update  dbo.item set item_code ='" + itemcode + "', item_name='" + itemname + "',item_description='" + description +"',item_price="+unitprice +" where item_code ='" + itemcode + "'  ";

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


        public bool deleteitem(String itemcode)
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

                newCmd.CommandText = "delete from dbo.item where item_code ='" + itemcode + "' ";

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
        public DataSet FilterItemCode(String text)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from item where item_code like '%" + text + "%' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"item");

            conn.Close();

            return ds;
        }
        public DataSet FilterItemName(String text)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from item where item_name like '" + text + "%'";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");

            conn.Close();

            return ds;
        }
    }
}
