using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace performance
{
    class LoggedIn
    {
        private static int loginID = 0;
        private static String accessLevel = "";
        private static String userID = "";
        private static String username = "";

        public static void setInfo(int lgID, String al, String uID, String user){
            loginID = lgID;
            accessLevel = al;
            userID = uID;
            username = user;
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
