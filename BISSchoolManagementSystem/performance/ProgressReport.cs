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
    public partial class ProgressReport : MetroForm
    {
        SqlConnection conn;
        private String exam_id, admission_no;
        public ProgressReport(String pexam_id, String padmission_no)
        {
            exam_id = pexam_id;
            admission_no = padmission_no;
            conn = SQLServerDatabaseAccess.ConnectionManager.getConnection();
            InitializeComponent();
        }

        private void ProgressReport_Load(object sender, EventArgs e)
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
            newCmd.CommandText = "select * from exam_marks where admission_no ='"+admission_no+"' and exam_id ='"+exam_id+"'";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "exam_marks");

            CrystalReport2 cr4 = new CrystalReport2();
            cr4.SetDataSource(ds.Tables["exam_marks"]);

            crystalReportViewer1.ReportSource = cr4;

            crystalReportViewer1.Show();

            conn.Close();
        }
    }
}
