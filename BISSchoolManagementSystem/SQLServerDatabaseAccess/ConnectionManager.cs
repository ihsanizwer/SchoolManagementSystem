using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServerDatabaseAccess
{
    public class ConnectionManager
    {
        //static SqlConnection conn;
        public static SqlConnection getConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=IHSANIZWER-PC\\IHSANSERVER;Initial Catalog=ITP_FINAL_DB;Integrated Security=True");
                return conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
