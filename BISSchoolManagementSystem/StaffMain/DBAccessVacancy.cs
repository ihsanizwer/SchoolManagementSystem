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
    public class DBAccessVacancy
    {
        SqlConnection conn;

        public DBAccessVacancy()
        {
            conn = ConnectionManager.getConnection();
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

        public DataSet getVacancyDetailsForGridView()
        {
            string queryString = "SELECT vacancy_no, position_applied, status, first_name, applied_date, interview_date, nic_no FROM vacancy";
            SqlCommand command = new SqlCommand(queryString, conn);
            
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds,"vacancy");

            conn.Close();

            return ds;
        }

        public DataSet getVacancyDetailsAll()
        {
            string queryString = "SELECT * FROM vacancy";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet ds = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "vacancy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return ds;
        }

        public bool addVacancy(string vacancy, string pos, bool status, string salute, string fname, string lname, DateTime dob, string gender, DateTime applied, DateTime interview, int contact, string address, string email, string nic)
        {
            bool addStatus = false;

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                string queryString = "INSERT INTO vacancy (vacancy_no, position_applied, status, salutation, first_name, last_name, date_of_birth, gender, applied_date, interview_date, contact_no, address, email, nic_no) VALUES ('" + vacancy + "', '" + pos + "', '" + status + "', '" + salute + "', '" + fname + "', '" + lname + "', '" + dob + "', '" + gender + "', '" + applied + "', '" + interview + "', '" + contact + "', '" + address + "', '" + email + "', '" + nic + "' )";
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

        public bool updateVacancy(string vacancy, string pos, bool status, string salute, string fname, string lname, DateTime dob, string gender, DateTime applied, DateTime interview, int contact, string address, string email, string nic)
        {
            bool updateStatus = false;

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                string queryString = "UPDATE vacancy SET position_applied = '" + pos + "', status = '" + status + "', salutation = '" + salute + "', first_name = '" + fname + "', last_name = '" + lname + "', date_of_birth = '" + dob + "', gender = '" + gender + "', applied_date = '" + applied + "', interview_date = '" + interview + "', contact_no = '" + contact + "', address = '" + address + "', email = '" + email + "' , nic_no = '" + nic + "' WHERE vacancy_no = '" + vacancy + "'";
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

        public bool deleteVacancy(string vacancy)
        {
            bool deleteStatus = false;

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                string queryString = "DELETE FROM vacancy WHERE vacancy_no = '"+ vacancy +"'";
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

        public DataSet filterUsingVacancyNo(string vacancy)
        {
            string queryString = "SELECT * FROM vacancy WHERE vacancy_no LIKE '%' + '" + vacancy + "' + '%' ";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet ds = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "vacancy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return ds;
        }

        public DataSet filterUsingCandidate(string name)
        {
            string queryString = "SELECT * FROM vacancy WHERE first_name LIKE '%' + '" + name + "' + '%' or last_name LIKE '%' + '" + name + "' + '%'";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet ds = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "vacancy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return ds;
        }

        public DataSet filterUsingPosition(string pos)
        {
            string queryString = "SELECT * FROM vacancy WHERE position_applied = '"+ pos +"'";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet ds = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "vacancy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return ds;
        }

        public DataSet filterUsingNic(string nic)
        {
            string queryString = "SELECT * FROM vacancy WHERE nic_no LIKE '%' + '" + nic + "' + '%'";
            SqlCommand command = new SqlCommand(queryString, conn);
            DataSet ds = new DataSet();

            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "vacancy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return ds;
        }

        
    }
}
