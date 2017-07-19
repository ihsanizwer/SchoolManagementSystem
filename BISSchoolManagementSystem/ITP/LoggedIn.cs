using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP
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
