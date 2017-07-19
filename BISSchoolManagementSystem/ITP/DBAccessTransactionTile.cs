using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ITP
{
    class DBAccessTransactionTile
    {
        public static SqlConnection conn;
        public DBAccessTransactionTile()
        {
            conn = ConnectionManager.getConnection();
        }
      


    }
}
