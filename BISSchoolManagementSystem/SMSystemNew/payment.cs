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
    public partial class payment : MetroForm
    {
        DBAccess dba = new DBAccess();
        // DBAccess dba = new DBAccess();
        SqlConnection cn = new SqlConnection(@"Data Source=(local);Initial Catalog=bisdb;User ID=sa;Password=***********");
        SqlDataAdapter da;
        DataTable dt = new DataTable();



        public payment()
        {
            InitializeComponent();
        }

        private void payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bisdbDataSet13.donation' table. You can move, or remove it, as needed.
            this.donationTableAdapter2.Fill(this.bisdbDataSet13.donation);
            // TODO: This line of code loads data into the 'bisdbDataSet12.fees' table. You can move, or remove it, as needed.
            this.feesTableAdapter3.Fill(this.bisdbDataSet12.fees);
            // TODO: This line of code loads data into the 'bisdbDataSet11.fees' table. You can move, or remove it, as needed.
            this.feesTableAdapter2.Fill(this.bisdbDataSet11.fees);
            // TODO: This line of code loads data into the 'bisdbDataSet10.fees' table. You can move, or remove it, as needed.
            //  this.feesTableAdapter1.Fill(this.bisdbDataSet10.fees);
            // TODO: This line of code loads data into the 'bisdbDataSet9.donation' table. You can move, or remove it, as needed.
            // this.donationTableAdapter1.Fill(this.bisdbDataSet9.donation);
            // TODO: This line of code loads data into the 'bisdbDataSet8.donation' table. You can move, or remove it, as needed.
            //this.donationTableAdapter.Fill(this.bisdbDataSet8.donation);
            // TODO: This line of code loads data into the 'bisdbDataSet4.fees' table. You can move, or remove it, as needed.
            //this.feesTableAdapter.Fill(this.bisdbDataSet4.fees);

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnPaymentAdd_Click(object sender, EventArgs e)
        {
            String message = "Please provide";

            try
            {
                String dadmissionno = txtfeesadmission.Text;
                String dname = txtfeesname.Text;
                String dpaymentid = txtfeespaymentid.Text;
                String dtype = txtfeestype.Text;
                double dvalue = 0;
                String ddate = txtfeesdate.Text;
                int dreceipt = 0;
                if (radbtnfeespro.Checked)
                    dreceipt = 1;
                //MessageBox.Show(dadmissionno);

                if ((dadmissionno == "") || (dadmissionno[0] != 'B') || (dadmissionno[1] != 'I') || (dadmissionno[2] != 'S'))
                {
                    message += "\nvalid admission number";
                }

                if (!Regex.IsMatch(dname, @"[a-zA-Z]"))
                {
                    message += "\nname";
                }

                if ((dpaymentid == "") || dpaymentid[0] != 'P')
                {
                    message += "\nPayment ID";
                }

                if ((dtype == "money") || (dtype == "Extra" || (dtype == "exams"))) //I think we cannot check NOT EQUAL in string values
                {
                }
                else
                    message += "\nfees Type";
                String val = txtfeesamount.Text;
                if (IsDigit(val))
                {
                    // int i = val.IndexOfAny(new char[] {'.'} );
                    if (val.Length > 10)
                    {
                        message += "\nfees value";
                    }
                    // else if (i >= 0)
                    //   dvalue = Convert.ToDouble(txtdvalue.Text);
                    else
                        dvalue = Convert.ToDouble(txtfeesamount.Text);
                }
                else
                    message += "\nfees value";


                if (ddate[4] == '-' && ddate[7] == '-')
                {
                }
                else
                    message += "\nvalid date (yyyy-mm-dd)";


                if (!radbtnfeespro.Checked && !radbtnfeesnotpro.Checked)
                {
                    message += "\nReceipt";
                }

                if (message == "Please provide")
                {

                    if (dba.addfeesdetails(dadmissionno, dname, dpaymentid, dtype, dvalue, ddate,dreceipt))
                    {
                        MessageBox.Show("Fees Details Added ");

                        txtfeesadmission.Clear();
                        txtfeesamount.Clear();
                        txtfeesdate.Clear();
                        txtfeesname.Clear();
                        txtfeespaymentid.Clear();
                        txtfeestype.Clear();
                        radbtnfeesnotpro.ResetText();
                        radbtnfeespro.ResetText();

                }

                    else
                        MessageBox.Show("Failed");
                }
                else
                {
                    MessageBox.Show(message);
                }

            }

            catch (System.IndexOutOfRangeException)
            {
                message += "\nvalid date (yyyy-mm-dd)";
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*
            String fadmissionno = txtadmissionno.Text;
            String fname = txtname.Text;
            String fpaymentid = txtpaymentid.Text;
            String ftype = txttype.Text;
            double famount = Convert.ToDouble(txtamount.Text);
            String fdate = txtfeesdate.Text;
            int freceipt = 0;
            if (radbtnpro.Checked)
                freceipt = 1;
            //else
            //  freceipt="0";


            if (dba.addfeesdetails(fadmissionno, fname, fpaymentid, ftype, famount, fdate, freceipt))
                MessageBox.Show("Fees Details Added ");

            else
                MessageBox.Show("Failed");*/
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String message = "Please provide";

            try
            {
                String dadmissionno = txtdaddmission.Text;
                String dname = txtdname.Text;
                String dpaymentid = txtdpaymentid.Text;
                String dtype = txtdtype.Text;
                double dvalue = 0;
                String ddate = txtddate.Text;
                int dreceipt = 0;
                if (radbtnfeespro.Checked)
                    dreceipt = 1;
                //MessageBox.Show(dadmissionno);

                if ((dadmissionno == "") || (dadmissionno[0] != 'B') || (dadmissionno[1] != 'I') || (dadmissionno[2] != 'S'))
                {
                    message += "\nvalid admission number";
                }

                if (!Regex.IsMatch(dname, @"[a-zA-Z]"))
                {
                    message += "\nname";
                }

                if ((dpaymentid == "") || dpaymentid[0] != 'P')
                {
                    message += "\nPayment ID";
                }

                if ((dtype == "") || (dtype == "money") || (dtype == "things")) //I think we cannot check NOT EQUAL in string values
                {
                }
                else
                    message += "\ndonation Type";
                String val = txtdvalue.Text;
                if (IsDigit(val))
                {
                   // int i = val.IndexOfAny(new char[] {'.'} );
                    if (val.Length > 10)
                    {
                        message += "\ndonation value";
                    }
                   // else if (i >= 0)
                     //   dvalue = Convert.ToDouble(txtdvalue.Text);
                    else
                        dvalue = Convert.ToDouble(txtdvalue.Text);
                }
                else
                    message += "\ndonation value";


                if (ddate[4] == '-' && ddate[7] == '-')
                {
                }
                else
                    message += "\nvalid date (yyyy-mm-dd)";


                if (!radDpro.Checked && !radDNotPro.Checked)
                {
                    message += "\nReceipt";
                }

                if (message == "Please provide")
                {

                    if (dba.adddonationdetails(dadmissionno, dname, dpaymentid, dtype, dvalue, ddate, dreceipt))
                    {

                       
                        MessageBox.Show("Donation Details Added ");

                        txtdaddmission.Clear();
                        txtddate.Clear();
                        txtdname.Clear();
                        txtdtype.Clear();
                        txtdvalue.Clear();
                        txtdpaymentid.Clear();
                        radDNotPro.ResetText();
                        radDpro.ResetText();
                    }
                    else
                        MessageBox.Show("Failed");
                }
                else 
                {
                    MessageBox.Show(message);
                }

            }

            catch (System.IndexOutOfRangeException)
            {
                message += "\nvalid date (yyyy-mm-dd)";
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            String regKey = metroTextBox1.Text;
            String aTable = "non";

            try
            {
                if (radfees.Checked)
                {
                    aTable = "fees";
                    DBAccess temp = new DBAccess();
                    DataSet ds = temp.getPaymentDetail(regKey, aTable);

                    metroGrid2.DataSource = ds.Tables["ss"].DefaultView;
                }

                else if (raddonation.Checked)
                {
                    aTable = "donation";
                    DBAccess temp = new DBAccess();
                    DataSet ds = temp.getPaymentDetail(regKey, aTable);

                    metroGrid1.DataSource = ds.Tables["ss"].DefaultView;
                }




            }

            catch
            {
                MessageBox.Show("No record");

            }


        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public bool IsDigit(String temp)
        {
            bool result = false;
            for (int i = 0; i < temp.Length; i++)
            {
                char c = temp[i];
                if (c >= '0' && c <= '9')
                    result = true;

                else
                {
                    result = false;
                    break;
                }


            }
            return result;
            //return false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            update ud = new update();
            ud.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            update ud = new update();
            ud.Show();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            this.donationTableAdapter2.Fill(this.bisdbDataSet13.donation);
            
            this.feesTableAdapter3.Fill(this.bisdbDataSet12.fees);
          
            this.feesTableAdapter2.Fill(this.bisdbDataSet11.fees);
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            txtdaddmission.Clear();
            txtddate.Clear();
            txtdname.Clear();
            txtdtype.Clear();
            txtdvalue.Clear();
            txtdpaymentid.Clear();
            radDNotPro.ResetText();
            radDpro.ResetText();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

            txtfeesadmission.Clear();
            txtfeesamount.Clear();
            txtfeesdate.Clear();
            txtfeesname.Clear();
            txtfeespaymentid.Clear();
            txtfeestype.Clear();
            radbtnfeesnotpro.ResetText();
            radbtnfeespro.ResetText();
        }

        private void metroPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
