using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    static class Program
    {
      
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                checkUser();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void checkUser() {
            DataCon dc, dc2;
            dc = new DataCon();
            dc.openCon();
            SqlDataReader dr = dc.execSelect("SELECT * FROM tempuser");
            int counter = 0;
            while (dr.Read())
            {
                SignIn.setDetails((int)dr[0], (String)dr[3], (String)dr[2], (String)dr[1]);
                counter++;
            }
            if (counter == 1)
            {
                dc2 = new DataCon();
                dc2.execInsert("DELETE  FROM tempuser where lid ='" + SignIn.getLogIn() + "'");
                new Dashboard().Show();
                Application.Run(new Login.Dashboard());
            }
            else
            {
                Application.Run(new Login.LogIn());
            }
        }
    }
}
