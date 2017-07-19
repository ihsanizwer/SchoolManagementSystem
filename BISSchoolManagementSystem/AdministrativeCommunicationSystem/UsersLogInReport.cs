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

namespace AdministrativeCommunicationSystem
{
    public partial class UsersLogInReport : MetroForm
    {
        private String username;
        SqlConnection conn;
        public UsersLogInReport()
        {
            conn = SQLServerDatabaseAccess.ConnectionManager.getConnection();
            InitializeComponent();
        }
        public UsersLogInReport(String un)
        {
            username = un;
            conn = SQLServerDatabaseAccess.ConnectionManager.getConnection();
            InitializeComponent();
        }

        private void UsersLogInReport_Load(object sender, EventArgs e)
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
            newCmd.CommandText = "select * from login where username='" + username + "'";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "login");

            CrystalReport2 cr4 = new CrystalReport2();
            cr4.SetDataSource(ds.Tables["login"]);

            crystalReportViewer1.ReportSource = cr4;

            crystalReportViewer1.Show();

            conn.Close();
        }

        }
    
}
