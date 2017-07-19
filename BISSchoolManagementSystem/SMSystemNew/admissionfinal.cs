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

namespace SMSystemNew
{
    public partial class admissionfinal : MetroForm
    {

        DBAccess dba = new DBAccess();
        // DBAccess dba = new DBAccess();
        SqlConnection cn = new SqlConnection(@"Data Source=(local);Initial Catalog=bisdb;User ID=sa;Password=***********");
        SqlDataAdapter da;
        DataTable dt = new DataTable();


        public admissionfinal()
        {
            InitializeComponent();
        }

        private void admissionfinal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bisdbDataSet15.admission' table. You can move, or remove it, as needed.
           // this.admissionTableAdapter.Fill(this.bisdbDataSet15.admission);
            // TODO: This line of code loads data into the 'bisdbDataSet14.admission' table. You can move, or remove it, as needed.
           // this.admissionTableAdapter.Fill(this.bisdbDataSet14.admission);

        }

        private void View_admission_Click(object sender, EventArgs e)
        {

            String key = keyApplication.Text;

            try
            {
                DBAccess temp = new DBAccess();
                DataSet ds = temp.viewadmissiondetails(key);

                metroGrid1.DataSource = ds.Tables["ss"].DefaultView;
            }

            catch
            {
                MessageBox.Show("No record");
            }
        }

        private void Btnupdateadmission_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtinterviewdate_Click(object sender, EventArgs e)
        {

        }

        private void txtapplieddate_Click(object sender, EventArgs e)
        {

        }

        private void RadNotselected_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radSelected_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtsurname_Click(object sender, EventArgs e)
        {

        }

        private void txtstudentname_Click(object sender, EventArgs e)
        {

        }

        private void txtapplicationno_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void keyApplication_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
