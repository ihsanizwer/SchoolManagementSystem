using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SMSystemNew
{
    class DBAccess
    {

        //studentdetails 
        private String applicationno; //common
        private String admissionno;   //common
        private String name;
        private String surname;
        private String dateofbirth;
        private String gender;
        private String contact;
        private String address;
        private String presentgrade;
        private String age;
        private String nationality;
        private String classenrolled;
        private String yearenrolled;
        private String email;
        private String bloodgroup;


        //ParentDetails
        private String parentid;
        private String parenttype;
        private String parentname;
        private String parentcontact;
        private String occupation;
        private String workcontact;
        private String workaddress;
        private String parentemail;

        //healthdetails
        private String studentname;
        private String vaccineddate;
        private String healthid;
        private String vaccinedtype;
        private String issues;

        //admissiondetails
        //applicationo
        //name
        //surname
        private String applieddate;
        private String interviewdate;
        private string status;


        //fees attributes

        private String paymentid;
        private String type;
        private double amount;
        private String paiddate;
        private int receipt;



        SqlConnection conn;

        public DBAccess()
        {
            conn = ConnectionManager.GetConnection();
        }

        public void execInsert(String command)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = command;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e1)
            {
                if (e1.Number == 2627)
                    MessageBox.Show("There is already a record in the database with the same ID. Enter a different one.");
                else
                    MessageBox.Show(e1.Message);
            }
            conn.Close();
        }


        //add student details
        public bool addStudentDetails(String sapplicationno, String sadmissionno, String sname, String ssurname,
                                    String sdateofbirth, String sgender, String scontact, String saddress, String spresentgrade,
                                    String sage, String snationality, String sclassenrolled, String syearenrolled, String semail,
                                    String sbloodgroup)
        {

            this.applicationno = sapplicationno;
            this.admissionno = sadmissionno;
            this.name = sname;
            this.surname = ssurname;
            this.dateofbirth = sdateofbirth;
            this.gender = sgender;
            this.contact = scontact;
            this.address = saddress;
            this.presentgrade = spresentgrade;
            this.age = sage;
            this.nationality = snationality;
            this.classenrolled = sclassenrolled;
            this.yearenrolled = syearenrolled;
            this.email = semail;
            this.bloodgroup = sbloodgroup;
            // this.birthcertificate = sbirthcertificate;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {

                SqlCommand query = conn.CreateCommand();
                query.Connection = conn;
                query.CommandType = CommandType.Text;
                query.CommandText = "INSERT INTO dbo.student(application_no, admission_no, name, surname, date_of_birth, gender, contact, address, present_grade, age, nationality, class_enrolled, year_enrolled, email, blood_group) VALUES (@1, @2, @3, @4,@5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15)";

                query.Parameters.AddWithValue("@1", this.applicationno);
                query.Parameters.AddWithValue("@2", this.admissionno);
                query.Parameters.AddWithValue("@3", this.name);
                query.Parameters.AddWithValue("@4", this.surname);
                query.Parameters.AddWithValue("@5", this.dateofbirth);
                query.Parameters.AddWithValue("@6", this.gender);
                query.Parameters.AddWithValue("@7", this.contact);
                query.Parameters.AddWithValue("@8", this.address);
                query.Parameters.AddWithValue("@9", this.presentgrade);
                query.Parameters.AddWithValue("@10", this.age);
                query.Parameters.AddWithValue("@11", this.nationality);
                query.Parameters.AddWithValue("@12", this.classenrolled);
                query.Parameters.AddWithValue("@13", this.yearenrolled);
                query.Parameters.AddWithValue("@14", this.email);
                query.Parameters.AddWithValue("@15", this.bloodgroup);
                //query.Parameters.AddWithValue("@16", this.birthcertificate);

                query.ExecuteNonQuery();

                conn.Close();
                return true;
            }

            catch (Exception)
            {
                return false;
            }


        }

        public DataSet viewDetail(String key, String sTable)
        {

            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=bisdb;User ID=sa;Password=nahanaa8");//connection name

            con.Open();


            SqlCommand cmd = new SqlCommand("select * from " + sTable + " where admission_no='" + key + "'", con);

            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "ss");

            //metroGrid1.DataSource = ds.Tables["ss"];

            return ds;
        }


        //view student details 
        public DataSet getStudentDetail(String key)
        {
            //bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            Console.WriteLine(key);
            newCmd.CommandText = "select * from student where admission_no = '" + key + "' ";
            //newCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Close();
            return ds;
        }



        //view admission details
        public DataSet viewadmissiondetails(String key)
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=bisdb;User ID=sa;Password=nahanaa8");//connection name

            con.Open();


            SqlCommand cmd = new SqlCommand("select * from admission where application_no='" + key + "'", con);

            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "ss");
            return ds;

        }



        //add parent details
        public bool addParentDetails(String sparentid, String sadmissionno, String sparenttype, String sparentname,
                                      String sparentcontact, String soccupation,
                                     String sworkcontact, String sworkaddress, String semail)
        {
            this.parentid = sparentid;
            this.admissionno = sadmissionno;
            this.parenttype = sparenttype;
            this.parentcontact = sparentcontact;
            this.parentname = sparentname;
            this.occupation = soccupation;
            this.workcontact = sworkcontact;
            this.workaddress = sworkaddress;
            this.parentemail = semail;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {

                SqlCommand query = conn.CreateCommand();
                query.Connection = conn;
                query.CommandType = CommandType.Text;
                query.CommandText = "INSERT INTO dbo.parent_details(guardian_id, guardian_type, name, admission_no, email,contact, occupation, work_address, work_contact_no) VALUES (@1, @2, @3, @4,@5, @6, @7, @8, @9)";

                query.Parameters.AddWithValue("@1", this.parentid);
                query.Parameters.AddWithValue("@2", this.parenttype);
                query.Parameters.AddWithValue("@3", this.parentname);
                query.Parameters.AddWithValue("@4", this.admissionno);
                query.Parameters.AddWithValue("@5", this.parentemail);
                query.Parameters.AddWithValue("@6", this.parentcontact);
                query.Parameters.AddWithValue("@7", this.occupation);
                query.Parameters.AddWithValue("@8", this.workaddress);
                query.Parameters.AddWithValue("@9", this.workcontact);

                query.ExecuteNonQuery();

                conn.Close();
                return true;
            }

            catch (Exception)
            {
                return false;
            }

        }


        //healh details
        public bool addHealthDetails(String sadmissionno, String hstudentname, String hvaccineddate, String healthid,
                                    String hvaccinedtype, String hissues)
        {

            this.admissionno = sadmissionno;
            this.studentname = hstudentname;
            this.healthid = healthid;
            this.vaccineddate = hvaccineddate;
            this.vaccinedtype = hvaccinedtype;
            this.issues = hissues;
            MessageBox.Show(vaccineddate);

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {

                SqlCommand query = conn.CreateCommand();
                query.Connection = conn;
                query.CommandType = CommandType.Text;
                query.CommandText = "INSERT INTO dbo.heath_details(admission_no, name, health_id,vaccined_date,vaccied_type, issue) VALUES (@1, @2, @3, @4,@5, @6)";

                query.Parameters.AddWithValue("@1", this.admissionno);
                query.Parameters.AddWithValue("@2", this.studentname);
                query.Parameters.AddWithValue("@3", this.healthid);
                query.Parameters.AddWithValue("@4", this.vaccineddate);
                query.Parameters.AddWithValue("@5", this.vaccinedtype);
                query.Parameters.AddWithValue("@6", this.issues);

                query.ExecuteNonQuery();

                conn.Close();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }


        }

        // add admission details
        public bool addAdmissionDetails(String aapplicationno, String aname, String asurname,
                                        String aapplieddate, String ainterviewdate, String astatus)
        {
            this.applicationno = aapplicationno;
            this.name = aname;
            this.surname = asurname;
            this.applieddate = aapplieddate;
            this.interviewdate = ainterviewdate;
            this.status = astatus;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {

                SqlCommand query = conn.CreateCommand();
                query.Connection = conn;
                query.CommandType = CommandType.Text;
                query.CommandText = "INSERT INTO dbo.admission(application_no, name, surname ,applied_date,interview_date, interview_status) VALUES (@1, @2, @3, @4,@5, @6)";

                query.Parameters.AddWithValue("@1", this.applicationno);
                query.Parameters.AddWithValue("@2", this.name);
                query.Parameters.AddWithValue("@3", this.surname);
                query.Parameters.AddWithValue("@4", this.applieddate);
                query.Parameters.AddWithValue("@5", this.interviewdate);
                query.Parameters.AddWithValue("@6", this.status);

                query.ExecuteNonQuery();

                conn.Close();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }




        }

        private String key;
        private String value;
        private String column;
        private String table;

        private String donationtype;
        private double donationvalue;

        //update all
        public bool updatestudentdetails(String ukey, String uValue, String ucolumn, String utable)
        {
            this.key = ukey;
            this.value = uValue;
            this.column = ucolumn;
            this.table = utable;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();

                try
                {
                    SqlCommand query = conn.CreateCommand();
                    query.Connection = conn;
                    query.CommandType = CommandType.Text;
                    if (utable == "student")

                        query.CommandText = "UPDATE student SET " + ucolumn + " = '" + uValue + "' WHERE admission_no = '" + ukey + "'";

                    else if (utable == "parent_details")
                        query.CommandText = "UPDATE parent_details SET " + ucolumn + " = '" + uValue + "' WHERE guardian_id = '" + ukey + "'";

                    else if (utable == "heath_details")
                        query.CommandText = "UPDATE heath_details SET " + ucolumn + " = '" + uValue + "' WHERE health_id = '" + ukey + "'";//Update Query 

                    else if(utable=="donation")
                        query.CommandText = "UPDATE donation SET " + ucolumn + " = '" + uValue + "' WHERE payment_id = '" + ukey + "'";//Update Query 

                    else if(utable=="fees")
                    query.CommandText = "UPDATE fees SET " + ucolumn + " = '" + uValue + "' WHERE payment_id = '" + ukey + "'";


                    else if (utable == "admission")
                        query.CommandText = "UPDATE admission SET " + ucolumn + " = '" + uValue + "' WHERE application_no = '" + ukey + "'";  
                    
                    else
                        MessageBox.Show("Please provide a valid table name");//Update <tablename> SET <attributename> = <value> WHERE <condition>
                    //query.Parameters.AddWithValue("@1", this.applicationno);
                    query.ExecuteNonQuery();

                    conn.Close();
                    return true;
                }

                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        //delete all

        public bool deletestudentdetails(String dkey, String dtable)
        {
            this.key = dkey;
            //this.value = dValue;k
            //this.column = dcolumn;
            this.table = dtable;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();

            }
            try
            {
                SqlCommand query1 = conn.CreateCommand();
                query1.Connection = conn;
                query1.CommandType = CommandType.Text;
                query1.CommandText = "delete from heath_details where admission_no = '" + key + "' ";
                query1.ExecuteNonQuery();

                SqlCommand query2 = conn.CreateCommand();
                query2.Connection = conn;
                query2.CommandType = CommandType.Text;
                query2.CommandText = "delete from parent_details where admission_no = '" + key + "' ";
                query2.ExecuteNonQuery();

                SqlCommand query3 = conn.CreateCommand();
                query3.Connection = conn;
                query3.CommandType = CommandType.Text;
                query3.CommandText = "delete from cerificate where admission_no = '" + key + "' ";
                query3.ExecuteNonQuery();

                SqlCommand query4 = conn.CreateCommand();
                query4.Connection = conn;
                query4.CommandType = CommandType.Text;
                query4.CommandText = "delete from fees where admission_no = '" + key + "' ";
                query4.ExecuteNonQuery();

                SqlCommand query5 = conn.CreateCommand();
                query5.Connection = conn;
                query5.CommandType = CommandType.Text;
                query5.CommandText = "delete from donation where admission_no = '" + key + "' ";
                query5.ExecuteNonQuery();

                SqlCommand queryFinDel = conn.CreateCommand();
                queryFinDel.Connection = conn;
                queryFinDel.CommandType = CommandType.Text;
                queryFinDel.CommandText = "delete from " + table + " where admission_no = '" + key + "' ";
                queryFinDel.ExecuteNonQuery();

                conn.Close();
                return true;
            }

            catch
            {
                return false;
            }
        }

        //add fees details
        public bool addfeesdetails(String fadmissionno, String fname,
            String fpaymentid, String ftype, double famount, String fdate, int freceipt)
        {

            this.admissionno = fadmissionno;
            this.name = fname;
            this.paymentid = fpaymentid;
            this.paiddate = fdate;
            this.amount = famount;
            this.type = ftype;
            this.receipt = freceipt;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {

                SqlCommand query = conn.CreateCommand();
                query.Connection = conn;
                query.CommandType = CommandType.Text;
                query.CommandText = "INSERT INTO dbo.fees( admission_no, name, payment_id, paid_date, receipt, amount, feestype) VALUES (@1, @2, @3, @4,@5, @6, @7)";

                query.Parameters.AddWithValue("@1", this.admissionno);
                query.Parameters.AddWithValue("@2", this.name);
                query.Parameters.AddWithValue("@3", this.paymentid);
                query.Parameters.AddWithValue("@4", this.paiddate);
                query.Parameters.AddWithValue("@5", this.receipt);
                query.Parameters.AddWithValue("@6", this.amount);
                query.Parameters.AddWithValue("@7", this.type);


                query.ExecuteNonQuery();

                conn.Close();
                return true;
            }

            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                return false;
            }

        }
        //add donation details


        public bool adddonationdetails(String dadmissionno, String dname,
        String dpaymentid, String dtype, double dvalue, String ddate, int dreceipt)
        {

            this.admissionno = dadmissionno;
            this.name = dname;
            this.paymentid = dpaymentid;
            this.paiddate = ddate;
            this.donationvalue = dvalue;
            this.donationtype = dtype;
            this.receipt = dreceipt;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {

                SqlCommand query = conn.CreateCommand();
                query.Connection = conn;
                query.CommandType = CommandType.Text;
                query.CommandText = "INSERT INTO dbo.donation( admission_no, name, payment_id, paid_date, receipt, donationtype, donationvalue) VALUES (@1, @2, @3, @4,@5, @6, @7)";

                query.Parameters.AddWithValue("@1", this.admissionno);
                query.Parameters.AddWithValue("@2", this.name);
                query.Parameters.AddWithValue("@3", this.paymentid);
                query.Parameters.AddWithValue("@4", this.paiddate);
                query.Parameters.AddWithValue("@5", this.receipt);
                query.Parameters.AddWithValue("@6", this.donationtype);
                query.Parameters.AddWithValue("@7", this.donationvalue);


                query.ExecuteNonQuery();

                conn.Close();
                return true;
            }

            catch (Exception)
            {
                return false;
            }


        }

        public DataSet getPaymentDetail(String key, String tableName)
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=bisdb;User ID=sa;Password=nahanaa8");//connection name

            con.Open();
            this.key = key;
            this.table = tableName;


            SqlCommand cmd = new SqlCommand("select * from "+table+" where payment_id='" + key + "'", con);

            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "ss");
            return ds;
        }

        public bool updateAdmission(String aapplicationno, String aname, String asurname,
                                      String aapplieddate, String ainterviewdate, String astatus)
        {
            this.applicationno = aapplicationno;
            this.name = aname;
            this.surname = asurname;
            this.applieddate = aapplieddate;
            this.interviewdate = ainterviewdate;
            this.status = astatus;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {

                SqlCommand query = conn.CreateCommand();
                query.Connection = conn;
                query.CommandType = CommandType.Text;
               // query.CommandText = "INSERT INTO dbo.admission(application_no, name, surname ,applied_date,interview_date, interview_status) VALUES (@1, @2, @3, @4,@5, @6)";
                query.CommandText = "UPDATE admission SET name='" + aname + "' , applied_date= '" + aapplieddate + "' , interview_date= '" + ainterviewdate + "' WHERE application_no= '" + aapplicationno + "'";  
                query.Parameters.AddWithValue("@1", this.applicationno);
                query.Parameters.AddWithValue("@2", this.name);
                query.Parameters.AddWithValue("@3", this.surname);
                query.Parameters.AddWithValue("@4", this.applieddate);
                query.Parameters.AddWithValue("@5", this.interviewdate);
                query.Parameters.AddWithValue("@6", this.status);

                query.ExecuteNonQuery();

                conn.Close();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }




        }


    }

}




