using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SQLServerDatabaseAccess;
using System.Windows.Forms;
namespace Login
{
    class DataCon
    {   
        private SqlConnection sc;

        public DataCon(){
            sc = ConnectionManager.getConnection();
             //sc = new SqlConnection("Data Source=IHSANIZWER-PC\\IHSANSERVER;Initial Catalog=bisdb;Integrated Security=True");
            try
            {
                sc.Open();
            }catch(Exception s){
                MessageBox.Show(s.Message);
            }
        
        }
           public SqlDataReader execSelect(String query) {
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
            SqlCommand cmd = sc.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            return da;
        }

        public void execInsert(String command) {
            SqlCommand cmd = sc.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = command;
            try
            {
                cmd.ExecuteNonQuery();
            }catch(Exception e1){
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
    }
    
}
