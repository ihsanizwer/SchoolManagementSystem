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
    public partial class UsersReport : MetroForm
    {
        SqlConnection conn;
        public UsersReport()
        {
            //conn = ConncectionMananager
            InitializeComponent();
        }

        private void UsersReport_Load(object sender, EventArgs e)
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
            newCmd.CommandText = "select * from login  ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "admission");

            CrystalReport1 cr4 = new CrystalReport1();
            cr4.SetDataSource(ds.Tables["admission"]);

            crystalReportViewer1.ReportSource = cr4;

            crystalReportViewer1.Show();

            conn.Close();
        }
        }
    
}
