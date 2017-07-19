using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLServerDatabaseAccess;
using System.Data;
using System.Windows.Forms;

namespace StaffMain
{
    class DBAccessStaff
    {
        SqlConnection conn;

        public DBAccessStaff()
        {
            conn = ConnectionManager.getConnection();
        }



        #region getMethods

        public DataSet getStaffDetailsAll()
        {
            string queryString = "SELECT staff_id, salutation, first_name, last_name, date_of_birth, gender, marital_status, vacancy_no, appointment_date, start_date, permanency, designation, email, religion, nationality, nic_no, bank_account_no, phone_no_1, phone_no_2, house, union_name, union_position FROM staff";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet dsStaff = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dsStaff, "staff");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return dsStaff;
        }

        public DataSet getStaffHealth()
        {
            string queryString = "SELECT * FROM health_issues";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet dsHealth = new DataSet();
            

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dsHealth, "health_issues");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return dsHealth;
        }

        public DataSet getStaffFamily()
        {
            string queryString = "SELECT * FROM family";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet dsFamily = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dsFamily, "family");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return dsFamily;
        }

        public DataSet getStaffAddress()
        {
            string queryString = "SELECT * FROM address";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet dsAddress = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dsAddress, "address");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return dsAddress;
        }

        public DataSet getStaffQualification()
        {
            string queryString = "SELECT * FROM qualification";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet dsQualification = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dsQualification, "qualification");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return dsQualification;
        }

        #endregion



        #region addMethods

        public bool addStaff(string sid, string salute, string fname, string lname, DateTime dob, string gender, string marry, DateTime appoint, DateTime start, string permanency, string designation, string email, string religion, string national, string nic, int pNo1, int pNo2)
        {
            bool addStatus = false;

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                string queryString = "INSERT INTO staff (staff_id, salutation, first_name, last_name, date_of_birth, gender, marital_status, appointment_date, start_date, permanency, designation, email, religion, nationality, nic_no, phone_no_1, phone_no_2) VALUES ('"+sid+"', '"+salute+"', '"+fname+"', '"+lname+"', '"+dob+"', '"+gender+"', '"+marry+"', '"+appoint+"', '"+start+"', '"+permanency+"', '"+designation+"', '"+email+"', '"+religion+"', '"+national+"', '"+nic+"', '"+pNo1+"', '"+pNo2+"')";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.ExecuteNonQuery();

                addStatus = true;
                return addStatus;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return addStatus;
        }

        public bool addFamily(string sid, string guard, string fname, string lname, string occupation, int pNo, string address, bool emergency)
        {
            bool addStatus = false;

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                string queryString = "INSERT INTO family (staff_id, guardian_type, first_name, last_name, occupation, phone_no, address, is_emergency_contact) VALUES ('" + sid + "', '" + guard + "', '" + fname + "', '" + lname + "', '" + occupation + "', '" + pNo + "', '" + address + "', '" + emergency + "')";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.ExecuteNonQuery();

                addStatus = true;
                return addStatus;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return addStatus;
        }

        public bool addHealth(string sid, string hid, string allergy, string medical)
        {
            bool addStatus = false;

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                string queryString = "INSERT INTO health_issues (staff_id, health_id, allergy, medical_history) VALUES ('" + sid + "', '" + hid + "', '" + allergy + "', '" + medical + "')";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.ExecuteNonQuery();

                addStatus = true;
                return addStatus;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return addStatus;
        }

        public bool addQualification(string sid, string qualType, string qualName, string desc, string college, string uni, int duration, int year)
        {
            bool addStatus = false;

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                string queryString = "INSERT INTO qualification (staff_id, qualification_type, qualification_name, description, college, university, duration, completion_year) VALUES ('" + sid + "', '" + qualType + "', '" + qualName + "', '" + desc + "', '" + college + "', '" + uni + "', '" + duration + "', '" + year + "')";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.ExecuteNonQuery();

                addStatus = true;
                return addStatus;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return addStatus;
        }

        public bool addAddress(string sid, string street, string city, string prov, int postCode)
        {
            bool addStatus = false;

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                string queryString = "INSERT INTO address (staff_id, street, city, province, postal_code) VALUES ('" + sid + "', '" + street + "', '" + city + "', '" + prov + "', '" + postCode + "')";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.ExecuteNonQuery();

                addStatus = true;
                return addStatus;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return addStatus;
        }

        #endregion



        #region updateMethods

        public bool updateStaff(string sid, string salute, string fname, string lname, DateTime dob, string gender, string marry, DateTime appoint, DateTime start, string permanency, string designation, string email, string religion, string national, string nic, int pNo1, int pNo2)
        {
            bool updateStatus = false;

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                string queryString = "UPDATE staff SET salutation = '" + salute + "', first_name = '" + fname + "', last_name = '" + lname + "', date_of_birth = '" + dob + "', gender = '" + gender + "', marital_status = '" + marry + "', appointment_date = '" + appoint + "', start_date = '" + start + "', permanency = '" + permanency + "', designation = '" + designation + "' , email = '" + email + "', religion = '" + religion + "', nationality = '" + national + "', nic_no = '" + nic + "', phone_no_1 = '" + pNo1 + "', phone_no_2 = '" + pNo2 + "' WHERE staff_id = '" + sid + "'";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.ExecuteNonQuery();

                updateStatus = true;
                return updateStatus;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return updateStatus;
        }

        public bool updateHealth(string sid, string hid, string allergy, string medical)
        {
            bool updateStatus = false;

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                string queryString = "UPDATE health_issues SET allergy = '" + allergy + "', medical_history = '" + medical + "' WHERE health_id = '" + hid + "'";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.ExecuteNonQuery();

                updateStatus = true;
                return updateStatus;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return updateStatus;
        }

        public bool updateFamily(string sid, string guard, string fname, string lname, string occupation, int pNo, string address, bool emergency)
        {
            bool updateStatus = false;

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                string queryString = "UPDATE family SET first_name = '" + fname + "', last_name = '" + lname + "', occupation = '" + occupation + "', phone_no = '" + pNo + "', address = '" + address + "', is_emergency_contact = '" + emergency + "' WHERE staff_id = '" + sid + "' AND guardian_type = '" + guard + "'";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.ExecuteNonQuery();

                updateStatus = true;
                return updateStatus;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return updateStatus;
        }

        public bool updateAddress(string sid, string street, string city, string prov, int postCode)
        {
            bool updateStatus = false;

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                string queryString = "UPDATE address SET city ='" + city + "', province ='" + prov + "', postal_code ='" + postCode + "' WHERE staff_id ='" + sid + "' AND street = '" + street + "'";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.ExecuteNonQuery();

                updateStatus = true;
                return updateStatus;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return updateStatus;
        }

        public bool updateQualification(string sid, string qualType, string qualName, string desc, string college, string uni, int duration, int year)
        {
            bool updateStatus = false;

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                string queryString = "UPDATE qualification SET qualification_name = '" + qualName + "', description = '" + desc + "', college = '" + college + "', university = '" + uni + "', duration = '" + duration + "', completion_year = '" + year + "' WHERE staff_id = '" + sid + "' AND qualification_type = '" + qualType + "'";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.ExecuteNonQuery();

                updateStatus = true;
                return updateStatus;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return updateStatus;
        }


        #endregion



        #region deleteMethods

        public bool deleteStaff(string staff)
        {
            bool deleteStatus = false;

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                string queryString = "DELETE FROM staff WHERE staff_id = '" + staff + "'";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.ExecuteNonQuery();

                deleteStatus = true;
                return deleteStatus;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return deleteStatus;
        }




        #endregion



        #region filter

        public DataSet filterUsingStaffIdForStaffTable(string staff)
        {
            string queryString = "SELECT * FROM staff WHERE staff_id LIKE '%' + '" + staff + "' + '%' ";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet ds = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "staff");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return ds;
        }

        public DataSet filterUsingStaffName(string name)
        {
            string queryString = "SELECT * FROM staff WHERE first_name LIKE '%' + '" + name + "' + '%' or last_name LIKE '%' + '" + name + "' + '%'";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet ds = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "staff");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return ds;
        }

        public DataSet filterUsingDesignation(string desig)
        {
            string queryString = "SELECT * FROM staff WHERE designation = '" + desig + "'";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet ds = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "staff");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return ds;
        }

        public DataSet filterUsingStaffNic(string nic)
        {
            string queryString = "SELECT * FROM staff WHERE nic_no LIKE '%' + '" + nic + "' + '%'";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet ds = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "staff");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return ds;
        }

        public DataSet filterUsingStaffIdForHealthTable(string staff)
        {
            string queryString = "SELECT * FROM health_issues WHERE staff_id LIKE '%' + '" + staff + "' + '%' ";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet ds = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "health_issues");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return ds;
        }

        public DataSet filterUsingStaffIdForAddressTable(string staff)
        {
            string queryString = "SELECT * FROM address WHERE staff_id LIKE '%' + '" + staff + "' + '%' ";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet ds = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "address");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return ds;
        }

        public DataSet filterUsingStaffIdForFamilyTable(string staff)
        {
            string queryString = "SELECT * FROM family WHERE staff_id LIKE '%' + '" + staff + "' + '%' ";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet ds = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "family");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return ds;
        }

        public DataSet filterUsingStaffIdForQualificationTable(string staff)
        {
            string queryString = "SELECT * FROM qualification WHERE staff_id LIKE '%' + '" + staff + "' + '%' ";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet ds = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "qualification");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return ds;
        }

        #endregion

    }
}
