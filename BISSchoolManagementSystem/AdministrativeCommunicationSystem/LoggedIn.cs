using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrativeCommunicationSystem
{
    class LoggedIn
    {
        private static int loginID = 0;
        private static String accessLevel = "";
        private static String userID = "";
        private static String username = "";

        public static String Encript(String value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF32Encoding utf8 = new UTF32Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        public static Boolean LogIn(String password)
        {
            String passwordE = Encript(password);
            SqlConnection con = SQLServerDatabaseAccess.ConnectionManager.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username like '" + username + "' and password like '" + passwordE + "'");
            cmd.Connection = con;
            SqlDataReader dr;
            int count = 0;
            try
            {
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //accessLevel = (String)dr[2];
                    //userID = (String)dr[4];
                    count++;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            con.Close();
            if (count == 1)
                return true;
            else
                return false;
        }
        public static void logOut()
        {
            SqlConnection con = SQLServerDatabaseAccess.ConnectionManager.getConnection();
            con.Open();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            try
            {
                cmd2.CommandText = "UPDATE login set end_time = GETDATE() where id = '" + loginID + "'";
                cmd2.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            username = "";
            userID = "";
            loginID = 0;
            accessLevel = "";
        }

        public static void setInfo(int lgID, String al, String uID, String user){
            loginID = lgID;
            accessLevel = al;
            userID = uID;
            username = user;
        }

        public static String getAL(){
            return accessLevel;
        }
        public static int getlogin()
        {
            return loginID;
        }
        public static String getUID()
        {
            return userID;
        }
        public static String getUsername()
        {
            return username;
        }
    }
}
