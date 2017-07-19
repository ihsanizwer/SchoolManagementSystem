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
    public partial class update : MetroForm
    {
        DBAccess dba = new DBAccess();
        // DBAccess dba = new DBAccess();
        SqlConnection cn = new SqlConnection(@"Data Source=(local);Initial Catalog=bisdb;User ID=sa;Password=nahanaa8");
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public update()
        {
            InitializeComponent();
        }

        private void update_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


            String ukey = txtprimarykey.Text;
            String uValue = txtvalue.Text;
            String ucolumn = txtcolumnname.Text;
            String utable = txttablename.Text;


            if (dba.updatestudentdetails(ukey, uValue, ucolumn, utable))
            {
                MessageBox.Show("SUccess");

            }

            else
            {
                MessageBox.Show("Error");
            }




        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            String dkey = txtprimarykey.Text;
            String dtable = txttablename.Text;


            if (dba.deletestudentdetails(dkey, dtable))
            {
                MessageBox.Show("Record deleted from the database");

            }

            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}

