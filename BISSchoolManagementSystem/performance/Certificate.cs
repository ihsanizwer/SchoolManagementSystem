using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace performance
{
    public partial class Certificate : MetroForm
    {
        SqlConnection conn;
        int aid, compid;
        public Certificate(int paid, int pcompid)
        {
            aid = paid;
            compid = pcompid;
            conn = SQLServerDatabaseAccess.ConnectionManager.getConnection();
            InitializeComponent();
        }

        private void Certificate_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from participate where compid ='"+compid+"' and aid = '"+aid+"'";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "participate");

            CrystalReport4 cr4 = new CrystalReport4();
            cr4.SetDataSource(ds.Tables["participate"]);

            crystalReportViewer1.ReportSource = cr4;

            crystalReportViewer1.Show();

            conn.Close();
        }
    }
}
