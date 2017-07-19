using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ITP
{
    public class ConnectionManager
    {
        public static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=YOUNGBLOODS-IDE;Initial Catalog=Usama;Persist Security Info=True;User ID=sa;Password=it15139122");
            return con;
        }
    }
}
