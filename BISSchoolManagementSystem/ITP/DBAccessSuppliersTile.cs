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
    class DBAccessSuppliersTile
    {
    public static SqlConnection conn;
        public DBAccessSuppliersTile()
        {
            conn = ConnectionManager.getConnection();
        }

        public bool addSupplier(string supplierid, string suppliername,int contact,string address, string email)
        {

            
            int Contact = Convert.ToInt32(contact);
            


            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into supplier(supplier_id,s_name,s_contact,s_address,s_email)values ('" + supplierid + "', '" + suppliername + "', " +contact +",'" + address + "','" + email + "')";
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
        public bool updateSupplier(string supplierid, string suppliername, int contact, string address, string email)
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

                newCmd3.CommandText = "update  dbo.supplier set supplier_id ='" + supplierid + "', s_name='" + suppliername + "',s_contact=" + contact +",s_address='"+ address +"', s_email='" +email+"' where supplier_id ='" + supplierid + "'  ";

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


        public bool deleteitem(String supplierid)
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

                newCmd.CommandText = "delete from dbo.supplier where supplier_id ='" + supplierid + "' ";

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
        public DataSet FilterSupplierId(String text)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from supplier where supplier_id like '%" + text + "%' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"supplier");

            conn.Close();

            return ds;
        }
        public DataSet FilterSupplierName(String text)
        {

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from supplier where s_name like '%" + text + "%' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "supplier");

            conn.Close();

            return ds;
        }
    }
}

