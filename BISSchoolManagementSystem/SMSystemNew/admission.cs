using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SMSystemNew
{
    public partial class admission : MetroForm
    {

        DBAccess dba = new DBAccess();
        // DBAccess dba = new DBAccess();
        SqlConnection cn = new SqlConnection(@"Data Source=(local);Initial Catalog=bisdb;User ID=sa;Password=***********");
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public admission()
        {
            InitializeComponent();
        }

        private void admission_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bisdbDataSet5.admission' table. You can move, or remove it, as needed.
            this.admissionTableAdapter.Fill(this.bisdbDataSet5.admission);

        }

        private void metroPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            String message = "Please provide";

            try
            {
                String aapplicationno = txtapplicationno.Text;
                String aname = txtstudentname.Text;
                String asurname = txtsurname.Text;
                String aapplieddate = txtapplieddate.Text;
                String ainterviewdate = txtinterviewdate.Text;
                String astatus = "0";
                //MessageBox.Show(aapplieddate);
                if (radSelected.Checked)
                    astatus = "1";
                //else
                   // astatus = "Not selected";

                if (aapplicationno == "" || aapplicationno[0] != 'A' || aapplicationno[1] != 'P')
                {
                    message += ("\nvalid application number");
                }

                if (!Regex.IsMatch(aname, @"[a-zA-Z]"))
                {
                    message += "\nstudent name";
                }

                if (!Regex.IsMatch(asurname, @"[a-zA-Z]"))
                {
                    message += "\nSurname";
                }

                if (aapplieddate[4] != '-' && aapplieddate[7] != '-')
                {
                    message += "\nvalid DOB (yyyy-mm-dd)";
                }

                if (ainterviewdate[4] != '-' && ainterviewdate[7] != '-')
                {
                    message += "\nvalid DOB (yyyy-mm-dd)";
                }
                if (!radSelected.Checked && !RadNotselected.Checked)
                {
                    message += "\ninterview status";
                }

                if (message == "Please provide")
                {
                    if ((dba.addAdmissionDetails(aapplicationno, aname, asurname,
                                         aapplieddate, ainterviewdate, astatus) == true))
                    {
                        MessageBox.Show("Admission Details added");

                        txtapplicationno.Clear();
                        txtapplieddate.Clear();
                        txtinterviewdate.Clear();
                        txtstudentname.Clear();
                        txtsurname.Clear();
                        radSelected.ResetText();
                    }

                    else
                        MessageBox.Show("Error");
                }
                else
                    MessageBox.Show(message);
            }

            catch (System.IndexOutOfRangeException)
            {
                message += "\nvalid date (yyyy-mm-dd)";
                MessageBox.Show(message);
            }

        }

        private void View_admission_Click(object sender, EventArgs e)
        {
            String key = keyApplication.Text;

            try
            {
                DBAccess temp = new DBAccess();
                DataSet ds = temp.viewadmissiondetails(key);

                metroGridAdmission.DataSource = ds.Tables["ss"].DefaultView;
            }

            catch
            {
                MessageBox.Show("No record");
            }
        }

        private void Btnupdateadmission_Click(object sender, EventArgs e)
        {
            update up = new update();
            up.Show();
        }

        private void dateapplied_ValueChanged(object sender, EventArgs e)
        {

        }

        private void interviewdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            update up = new update();
            up.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.admissionTableAdapter.Fill(this.bisdbDataSet5.admission);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            txtapplicationno.Clear();
            txtapplieddate.Clear();
            txtinterviewdate.Clear();
            txtstudentname.Clear();
            txtsurname.Clear();
            //radSelected.ResetText();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroGridAdmission_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGridAdmission_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtapplicationno.Text = metroGridAdmission.Rows[e.RowIndex].Cells["applicationnoDataGridViewTextBoxColumn"].Value.ToString();
            txtstudentname.Text = metroGridAdmission.Rows[e.RowIndex].Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
            txtsurname.Text = metroGridAdmission.Rows[e.RowIndex].Cells["surnameDataGridViewTextBoxColumn"].Value.ToString();
            appliedDate.Value = (DateTime)metroGridAdmission.Rows[e.RowIndex].Cells["applieddateDataGridViewTextBoxColumn"].Value;
            interviewDate.Value = (DateTime)metroGridAdmission.Rows[e.RowIndex].Cells["interviewdateDataGridViewTextBoxColumn"].Value; 
            //radSelected.Text = metroGridAdmission.Rows[e.RowIndex].Cells["interviewstatusDataGridViewCheckBoxColumn"].Value.ToString();

            if (metroGridAdmission.SelectedRows[0].Cells["interviewstatusDataGridViewCheckBoxColumn"].Value.ToString() == "True")
                radSelected.Checked = true;
            else if (metroGridAdmission.SelectedRows[0].Cells["interviewstatusDataGridViewCheckBoxColumn"].Value.ToString() == "False")
                RadNotselected.Checked = true;
        }
    }
}
