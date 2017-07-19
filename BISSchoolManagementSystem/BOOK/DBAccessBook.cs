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
    
    class DBAccessBook
    {
        public static SqlConnection conn;

        public DBAccessBook()
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


        public bool addBook(string accno, string bookbarcode, string isbn, string title, string author, string catid, string language, string publisher, string date, int noofcopies, int edition, int noofpages, double price, string bookstatus, int purchaseid)
        {

            int  Nocop = Convert.ToInt32(noofcopies);
            int Pages = Convert.ToInt32(noofpages);
            int Purchaseid = Convert.ToInt32(purchaseid);
            double Price = Convert.ToDouble(price);


            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into book(accession_no,book_barcode,isbn,title,author,category_id,book_language,publisher,publish_date,no_of_copies,edition,pages,price,book_status,purchase_id)values ('" + accno + "', '" + bookbarcode + "','" + isbn + "','" + title + "','" + author + "','" + catid + "','" + language + "','" + publisher + "','" + date + "'," + Nocop + "," + edition + "," + Pages + "," + Price + ",'" + bookstatus + "'," + Purchaseid + ")";
            try
            {
                newCmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            status = true;

            return status;

        }

        public bool updateBook(string accno, string bookbarcode, string isbn, string title, string author, string catid, string language, string publisher, string date, int noofcopies, int edition, int noofpages, double price, string bookstatus, int purchaseid)
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
                    
                    newCmd3.CommandText = "update  dbo.book set accession_no ='" + accno + "', book_barcode='" +bookbarcode + "', isbn='" + isbn + "', title='" + title + "', author='" + author + "', category_id='" + catid + "', book_language='" + language + "', publisher ='" + publisher + "',publish_date='" + date+ "', no_of_copies=" + noofcopies + ", edition=" + edition + ", pages=" + noofpages + ", price=" + price + ", book_status='" + bookstatus + "', purchase_id=" + purchaseid + " where accession_no ='" + accno + "'  ";

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


        public bool deleteBook(String accno)
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
                   
                    newCmd.CommandText = "delete from dbo.book where accession_no ='" + accno + "' ";

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
       public DataSet FilterBookAcc(String text)
        {
           
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from book where accession_no like '"+text+"'";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "book");

            conn.Close();

            return ds;
        }

       public DataSet FilterBookTitle(String text)
       {

           if (conn.State.ToString() == "Closed")
           {
               conn.Open();
           }

           SqlCommand newCmd = conn.CreateCommand();
           newCmd.Connection = conn;
           newCmd.CommandType = CommandType.Text;
           newCmd.CommandText = "select * from book where title like '%" + text + "%'";

           SqlDataAdapter da = new SqlDataAdapter(newCmd);
           DataSet ds = new DataSet();
           da.Fill(ds, "book");

           conn.Close();

           return ds;
       }
       public DataSet FilterBookAuthor(String text)
       {

           if (conn.State.ToString() == "Closed")
           {
               conn.Open();
           }

           SqlCommand newCmd = conn.CreateCommand();
           newCmd.Connection = conn;
           newCmd.CommandType = CommandType.Text;
           newCmd.CommandText = "select * from book where author like '%" + text + "%'";

           SqlDataAdapter da = new SqlDataAdapter(newCmd);
           DataSet ds = new DataSet();
           da.Fill(ds, "book");

           conn.Close();

           return ds;
       }



        public DataSet getAllCategory()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select category_id,category_name,rack_no ,added_date,no_of_books ,cat_status from category";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "category");

            conn.Close();

            return ds;
        }



        public bool addcategory(string catid,string catname,string rackno,string addeddate,int noofbooks,string catstatus)
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



    }
}
