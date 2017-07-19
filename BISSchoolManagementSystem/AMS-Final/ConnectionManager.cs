using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS_Final
{
    public class ConnectionManager
    {
        static SqlConnection conn;

        public static SqlConnection getConnection()
        {
            try
            {
                conn = new SqlConnection("Data Source=HOME-PC;Initial Catalog=bisdb;Integrated Security=True");
                return conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
