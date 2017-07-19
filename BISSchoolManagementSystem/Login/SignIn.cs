using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SQLServerDatabaseAccess;
namespace Login
{
    class SignIn
    {
        private static int loginID = 0;
        private static String accessLevel = "";
        private static String userID = "";
        private static String username = "";
        public static String Encript(String value){
            using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider()){
                UTF32Encoding utf8 = new UTF32Encoding();
                byte [] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        public static Boolean LogIn(String username, String password) {
            String passwordE = Encript(password);
            SqlConnection con = SQLServerDatabaseAccess.ConnectionManager.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username like '"+username+"' and password like '"+passwordE+"'");
            cmd.Connection = con;
            SqlDataReader dr;
            int count = 0;
            try
            {
                dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    accessLevel = (String)dr[2];
                    userID = (String)dr[4];
                    count++;
                }

            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
            con.Close();
            if(count==1)
                return true;
            else
                return false;
        }
        public static void makeSession(String pusername) {
            username = pusername;
            SqlConnection con =  SQLServerDatabaseAccess.ConnectionManager.getConnection();
            SqlConnection con2 = SQLServerDatabaseAccess.ConnectionManager.getConnection();
            con.Open();
            con2.Open();
            SqlCommand cmd = new SqlCommand("select top 1 id from login order by id desc");
            SqlCommand cmd2 = con2.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            
            cmd.Connection = con;
            SqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    loginID = dr.GetInt32(dr.GetOrdinal("id"));
                }
                loginID++;
                cmd2.CommandText = "INSERT INTO login VALUES('" + loginID + "','" + username + "', GETDATE(), NULL, '" + userID + "');";
                cmd2.ExecuteNonQuery();
                con.Close();
                con2.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        public static void logOut(){
            SqlConnection con =  SQLServerDatabaseAccess.ConnectionManager.getConnection();
            con.Open();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            try {
                cmd2.CommandText = "UPDATE login set end_time = GETDATE() where id = '"+loginID+"'";
                cmd2.ExecuteNonQuery();
                con.Close();
                
            }catch(Exception e){
                MessageBox.Show(e.Message);
            }

            username = "";
            userID = "";
            loginID = 0;
            accessLevel = "";
        }

        public static String getUsername() {
            return username;
        }
        public static String getUserID() {
            return userID;
        }
        public static String getAccess() {
            return accessLevel;
        }
        public static int getLogIn() {
            return loginID;
        }
        public static void setDetails(int l, String a, String ui, String us){
            loginID = l;
            accessLevel = a;
            userID = ui;
            username = us;

        }
    }
}
