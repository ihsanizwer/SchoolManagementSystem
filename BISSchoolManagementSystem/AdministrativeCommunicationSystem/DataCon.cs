using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SQLServerDatabaseAccess;

namespace AdministrativeCommunicationSystem
{
    class DataCon
    {
        private SqlConnection sc;

        public DataCon() {
            sc = ConnectionManager.getConnection();
             //sc = new SqlConnection("Data Source=IHSANIZWER-PC\\IHSANSERVER;Initial Catalog=bisdb;Integrated Security=True");
             sc.Open();
        }

        
        public SqlDataReader execSelect(String query) {
            openCon();
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = sc;
            SqlDataReader dr = null;

            try { 
                dr = cmd.ExecuteReader();
            }catch(Exception e){
                MessageBox.Show(e.Message);
            }

            return dr;
        }

        public SqlDataAdapter selectTable(String query) {
            openCon();
            SqlCommand cmd = sc.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            return da;
        }

        public void execInsert(String command) {
            openCon();
            SqlCommand cmd = sc.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = command;
            try
            {
                cmd.ExecuteNonQuery();
            }catch(SqlException e1){
                if (e1.Number == 2627)
                    MessageBox.Show("There is already a record in the database with the same ID. Enter a different one.");
                else
                     MessageBox.Show(e1.Message);
            }
            closeCon();
        }

        public void openCon() {
            if (sc.State.ToString() == "Closed")
            {
                sc.Open();
            }
        }
        public void closeCon() {
            sc.Close();
        }

        public void dispCon() {
            sc.Dispose();
        }

        public SqlConnection getCon() {
            return sc;
        }

        public DataTable fillCombo(String id, String value, String query, Boolean type)
        {
            DataTable dt = new DataTable();
            if (type == true)
                dt.Columns.Add(id, typeof(int));
            else
                dt.Columns.Add(id, typeof(string));
            dt.Columns.Add(value, typeof(string));

            if (sc.State.ToString() == "Closed")
                sc.Open();
            SqlCommand cmd = myCommand(query);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr[0], dr[1]);
            }
            sc.Close();
            return dt;

        }


        public SqlCommand myCommand(String command)
        {

            SqlCommand cmd = sc.CreateCommand();
            cmd.Connection = sc;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = command;
            return cmd;

        }
    }
}
