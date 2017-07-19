using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SMSystemNew
{

    public partial class studentDetails : MetroForm
    {
        DBAccess dba = new DBAccess();
        // DBAccess dba = new DBAccess();
        SqlConnection cn = new SqlConnection(@"Data Source=(local);Initial Catalog=bisdb;User ID=sa;Password=***********");
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public studentDetails()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {


            // TODO: This line of code loads data into the 'bisdbDataSet7.parent_details' table. You can move, or remove it, as needed.
            this.parent_detailsTableAdapter1.Fill(this.bisdbDataSet7.parent_details);
            // TODO: This line of code loads data into the 'bisdbDataSet6.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.bisdbDataSet6.student);
            // TODO: This line of code loads data into the 'bisdbDataSet3.heath_details' table. You can move, or remove it, as needed.
            this.heath_detailsTableAdapter.Fill(this.bisdbDataSet3.heath_details);
            // TODO: This line of code loads data into the 'bisdbDataSet3.heath_details' table. You can move, or remove it, as needed.
            //this.heath_detailsTableAdapter.Fill(this.bisdbDataSet3.heath_details);
            // TODO: This line of code loads data into the 'bisdbDataSet2.health_issues' table. You can move, or remove it, as needed.
            //this.health_issuesTableAdapter.Fill(this.bisdbDataSet2.health_issues);
            // TODO: This line of code loads data into the 'bisdbDataSet1.parent_details' table. You can move, or remove it, as needed.
            this.parent_detailsTableAdapter.Fill(this.bisdbDataSet1.parent_details);
            // TODO: This line of code loads data into the 'bisdbDataSet.student' table. You can move, or remove it, as needed.
            // this.studentTableAdapter.Fill(this.bisdbDataSet.student);
            // TODO: This line of code loads data into the 'bisdbDataSet.student' table. You can move, or remove it, as needed.
            // this.studentTableAdapter.Fill(this.bisdbDataSet.student);




        }

        private void metroTextBox14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            String regKey = regKeyNo.Text;
            String aTable = "non";

            try
            {
                if (metroRadioButton1.Checked)
                {
                    aTable = "student";
                    DBAccess temp = new DBAccess();
                    DataSet ds = temp.viewDetail(regKey, aTable);

                    metroGrid1.DataSource = ds.Tables["ss"].DefaultView;
                }

                else if (metroRadioButton2.Checked)
                {
                    aTable = "parent_details";
                    DBAccess temp = new DBAccess();
                    DataSet ds = temp.viewDetail(regKey, aTable);

                    metroGrid4.DataSource = ds.Tables["ss"].DefaultView;
                }

                else if (metroRadioButton3.Checked)
                {
                    aTable = "heath_details";
                    DBAccess temp = new DBAccess();
                    DataSet ds = temp.viewDetail(regKey, aTable);

                    metroGrid3.DataSource = ds.Tables["ss"].DefaultView;
                }


            }

            catch
            {
                MessageBox.Show("No record");

            }


        }

        private void metroTextBox24_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            txtAddNo.Clear();
            txtAppNo.Clear();
            txtStudentName.Clear();
            txtSurname.Clear();
            txtAge.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtNationality.Clear();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            String message = "Please provide";



            try
            {
                String sadmission = txtAddNo.Text;
                String sapplication = txtAppNo.Text;
                String sname = txtStudentName.Text;
                String surname = txtSurname.Text;
                String sdateofbirth = txtdateofbirth.Text;
                String sgender = " ";
                if (radBtnMale.Checked)
                    sgender = "Male";
                else
                    sgender = "Female";
                String scontact = txtContact.Text;
                String saddress = txtAddress.Text;
                String spresentgrade = txtPresentGrade.Text;
                String sage = txtAge.Text;
                String snationality = txtNationality.Text;
                String sclassenrolled = txtClassEnrolled.Text;
                String syearenrolled = txtEnrolled.Text;
                String semail = txtEmail.Text;
                String sbloodgroup = cmbBlood.SelectedItem.ToString();




                if ((sadmission == "") || (sadmission[0] != 'B') || (sadmission[1] != 'I') || (sadmission[2] != 'S'))
                {
                    message += "\nvalid admission number";
                }

                if (sapplication == "" || sapplication[0] != 'A' || sapplication[1] != 'P')
                {
                    message += ("\nvalid application number");
                }

                if (!Regex.IsMatch(sname, @"[a-zA-Z]"))
                {
                    message += "\nstudent name";
                }


                if (!Regex.IsMatch(surname, @"[a-zA-Z]"))
                {
                    message += "\nSurname";
                }
                if (sdateofbirth[4] == '-' && sdateofbirth[7] == '-')
                {

                }
                else
                    message += "\nvalid DOB (yyyy-mm-dd)";

                if (IsDigit(sage))
                {
                    int i = Convert.ToInt32(sage);
                    if (i <= 21 && i >= 0)
                    {

                    }
                    else
                        message += "\nage";
                }
                else
                    message += "\nage";


                //|| saddress.Any(char.IsDigit)
                if (String.IsNullOrWhiteSpace(saddress))
                {
                    message += "\naddress";
                }

                if (String.IsNullOrWhiteSpace(snationality))
                {
                    message += "\nnationality";
                }

                if (IsDigit(syearenrolled))
                {
                    if (syearenrolled.Length > 4)
                    {
                        message += "\nyear enrolled";
                    }
                }
                else
                    message += "\nyear enrolled";


                if (sclassenrolled.Length > 2)
                {
                    message += "\nclass enrolled";
                }

                if (spresentgrade.Length > 2)
                {
                    message += "\npresent grade";
                }

                if (IsDigit(scontact))
                {
                    if (scontact.Length > 10)
                    {
                        message += "\ncontact";
                    }
                }
                else
                    message += "\ncontact";
                int atpos = semail.IndexOf('@');    //getting the index of @ to a integer variable call atpos (@ position)
                int fulpos = semail.IndexOf('.');   //getting the index of . to a integer variable call fulpos (fullstop position)
                if (atpos > 0 && fulpos > 0)        //if the given email address contains @ and . their index must be greater than 0 for a valid email address
                {

                }
                else
                    message += "\nemail";

                if (!RadFemale.Checked && !radBtnMale.Checked)
                {
                    message += "\nGender";
                }

                if (cmbBlood.SelectedIndex == -1)
                {
                    message += "\nBlood";
                }
                if (message == "Please provide")
                {
                    MessageBox.Show("Valid Information");
                }
                else
                    MessageBox.Show(message);


                if (message == "Please provide")
                {
                    if (dba.addStudentDetails(sapplication, sadmission, sname, surname, sdateofbirth, sgender, scontact, saddress, spresentgrade, sage, snationality, sclassenrolled, syearenrolled, semail, sbloodgroup) == true)
                    {
                        MessageBox.Show("Student Details Added ");
                        txtAddNo.Clear();
                        txtAppNo.Clear();
                        txtStudentName.Clear();
                        txtSurname.Clear();
                        txtAge.Clear();
                        txtContact.Clear();
                        txtAddress.Clear();
                        txtEmail.Clear();
                        txtNationality.Clear();
                        txtClassEnrolled.Clear();
                        txtPresentGrade.Clear();
                        txtdateofbirth.Clear();

                    }

                    else
                        MessageBox.Show("Failed");
                }

            }
            catch (System.NullReferenceException)
            {
                message += " a blood group";
                MessageBox.Show(message);
            }

            catch (System.IndexOutOfRangeException)
            {
                message += "\nvalid DOB (yyyy-mm-dd)";
                MessageBox.Show(message);
            }



        }

        private void txtAddNo_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                this.SelectNextControl(txtAddNo, true, true, true, true);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFd = new OpenFileDialog();
            OpenFd.Filter = "Images only.| *.jpg; *.jpeg; *.png; *.gif; ";

            DialogResult dr = OpenFd.ShowDialog();
            pictureBox1.Image = Image.FromFile(OpenFd.FileName);

        }

        private void metroLabel22_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox18_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox15_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroGrid1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void metroGrid1_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void metroGrid1_DataError_2(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void metroRadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {


        }

        private void metroGrid1_DataError_3(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnParentAdd_Click(object sender, EventArgs e)
        {

            String message="Please provide";

            try {String sparentid = txtparentid.Text;
            String sadmissionno = txtparentadno.Text;
            String sparenttype = cmbparenttype.SelectedItem.ToString();
            String sparentname = txtparentName.Text;
            String semail = txtparentemail.Text;
            // String sparentaddress = txtparentaddress.Text;
            String sparentcontact = txtparentcontact.Text;
            String soccupation = txtoccupation.Text;
            String sworkcontact = txtworkcontact.Text;
            String sworkaddress = txtworkaddress.Text;

                if ((sparentid == "") || (sparentid[0] != 'G'))
                {
                    message += "\nvalid parentId number";
                }


                if (IsDigit(sparentcontact))
                {
                    if (sparentcontact.Length > 10)
                    {
                        message += "\nparent contact";
                    }
                }
                else
                    message += "\nparent contact";


                if ((sadmissionno == "") || (sadmissionno[0] != 'B') || (sadmissionno[1] != 'I') || (sadmissionno[2] != 'S'))
                {
                    message += "\nvalid admission number";
                }


                if (!Regex.IsMatch(sparentname, @"[a-zA-Z]"))
                {
                    message += "\nname";
                }

                if (IsDigit(sworkcontact))
                {
                    if (sworkcontact.Length > 10)
                    {
                        message += "\nwork contact";
                    }
                }
                else
                    message += "\nwork contact";

                if (soccupation == "")
                {
                    message += "\nOccupation";
                }

                if (sworkaddress == "")
                {
                    message += "\nWorkaddress";

                }
                
                if (message == "Please provide")
                {
                    if (dba.addParentDetails(sparentid, sadmissionno, sparenttype, sparentname,
                                           sparentcontact, soccupation,
                                          sworkcontact, sworkaddress, semail) == true)
                    {
                        MessageBox.Show("Parent Details added");

                        //txtAddNo.Clear();
                        txtparentid.Clear();
                        txtparentName.Clear();
                        txtparentcontact.Clear();
                        txtparentemail.Clear();
                        txtparentadno.Clear();
                        txtoccupation.Clear();
                        txtworkaddress.Clear();
                        cmbparenttype.ResetText();
                    }
                }

                else
                    MessageBox.Show(message);
            }

            catch (System.NullReferenceException)
            {
                message += " a parent type";
                MessageBox.Show(message); //this is only for a null reference
            
           }
            
       }

        private void txtworkcontact_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {

            String message = "please provide";

            try
            {
                String sadmissionno = txthealthadmission.Text;
                String hstudentname = txtnamthealth.Text;
                String healthid = txthealthid.Text;
                String hvaccineddate = txtvaccineddate.Text;
                String hvaccinedtype = txtvaccinedtype.Text;
                String hissues = txtissues.Text;

                 if ((sadmissionno == "") || (sadmissionno[0] != 'B') || (sadmissionno[1] != 'I') || (sadmissionno[2] != 'S'))
                {
                    message += "\nvalid admission number";
                }

                
                if (!Regex.IsMatch(hstudentname, @"[a-zA-Z]"))
                {
                    message += "\nname";
                }

                if((healthid=="" ) || (healthid[0]!='H'))
                {
                    message += "\nhealth ID";
                
                }

                 if (hvaccineddate[4] == '-' && hvaccineddate[7] == '-')
                {
                }
                else
                    message += "\nvalid DOB (yyyy-mm-dd)";

                if (String.IsNullOrWhiteSpace(hvaccinedtype))
                {
                    message +="\nVaccined Type";
                }

                if (String.IsNullOrWhiteSpace(hissues))
                {
                    message+= "\nIssues";
                }

                if (message == "please provide")
                {

                    if ((dba.addHealthDetails(sadmissionno, hstudentname, hvaccineddate, healthid,
                                            hvaccinedtype, hissues)) == true)
                    {
                        MessageBox.Show("Health Details added");

                        txthealthadmission.Clear();
                        txthealthid.Clear();
                        txtnamthealth.Clear();
                        txtissues.Clear();
                        txtvaccineddate.Clear();
                        txtvaccinedtype.Clear();
                    }
                    else
                        MessageBox.Show("Error in adding to the database");
                }
                else
                    MessageBox.Show(message);


            }

            catch (System.IndexOutOfRangeException)
            {
                message += "\nWrong date format (yyy-mm-dd)";
                MessageBox.Show(message);
            }


            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            update ud = new update();
            ud.Show();




        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            update ud = new update();
            ud.Show();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            this.parent_detailsTableAdapter.Fill(this.bisdbDataSet1.parent_details);
            this.heath_detailsTableAdapter.Fill(this.bisdbDataSet3.heath_details);
            this.studentTableAdapter1.Fill(this.bisdbDataSet6.student);
        }

        public bool IsDigit(String temp)
        {
            bool result = false;
            for (int i = 0 ; i < temp.Length ; i++)
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

        private void metroButton7_Click_1(object sender, EventArgs e)
        {
            txtparentid.Clear();
            txtparentName.Clear();
            txtparentcontact.Clear();
            txtparentemail.Clear();
            txtparentadno.Clear();
            txtoccupation.Clear();
            txtworkaddress.Clear();
            cmbparenttype.ResetText();
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {

            txthealthadmission.Clear();
            txthealthid.Clear();
            txtnamthealth.Clear();
            txtissues.Clear();
            txtvaccineddate.Clear();
            txtvaccinedtype.Clear();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }



}
