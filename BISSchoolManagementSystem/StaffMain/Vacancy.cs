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
using SQLServerDatabaseAccess;
using MetroFramework;

namespace StaffMain
{
    public partial class Vacancy : MetroForm
    {
        DBAccessVacancy dba = new DBAccessVacancy();
        /*SqlConnection con;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();*/

        public Vacancy()
        {
            InitializeComponent();
            
            /*con = ConnectionManager.getConnection();

            SqlCommand sc = new SqlCommand("SELECT * FROM vacancy", con);
            da.SelectCommand = sc;
            da.Fill(ds, "vacancy");

            bs.DataSource = ds.Tables["vacancy"];
            dgvVacancyDetails.DataSource = bs;
            
            SqlCommand uc = new SqlCommand("UPDATE vacancy SET position_applied = @position_applied, status = @status, salutation = @salute, first_name = @first_name, last_name = @last_name, date_of_birth = @date_of_birth, gender = @gender, applied_date = @applied_date, interview_date = @interview_date, contact_no = @contact_no, address = @address, email = @email , nic_no = @nic_no WHERE vacancy_no = @vacancy_no", con);
            uc.Parameters.Add("@position_applied", SqlDbType.VarChar).SourceColumn = "position_applied";
            uc.Parameters.Add("@status", SqlDbType.Bit).SourceColumn = "status";
            uc.Parameters.Add("@salute", SqlDbType.VarChar).SourceColumn = "salutation";
            uc.Parameters.Add("@first_name", SqlDbType.VarChar).SourceColumn = "first_name";
            uc.Parameters.Add("@last_name", SqlDbType.VarChar).SourceColumn = "last_name";
            uc.Parameters.Add("@date_of_birth", SqlDbType.Date).SourceColumn = "date_of_birth";
            uc.Parameters.Add("@gender", SqlDbType.VarChar).SourceColumn = "gender";
            uc.Parameters.Add("@applied_date", SqlDbType.VarChar).SourceColumn = "applied_date";
            uc.Parameters.Add("@interview_date", SqlDbType.VarChar).SourceColumn = "interview_date";
            uc.Parameters.Add("@contact_no", SqlDbType.VarChar).SourceColumn = "contact_no";
            uc.Parameters.Add("@address", SqlDbType.VarChar).SourceColumn = "address";
            uc.Parameters.Add("@email", SqlDbType.VarChar).SourceColumn = "email";
            uc.Parameters.Add("@nic_no", SqlDbType.VarChar).SourceColumn = "nic_no";
            uc.Parameters.Add("@vacancy_no", SqlDbType.VarChar).SourceColumn = "vacancy_no";
            da.UpdateCommand = uc;

            //SqlCommand dc = new SqlCommand("DELETE FROM vacancy WHERE vacancy_no = @vacancy_no", con);
            //dc.Parameters.Add("@vacancy_no", SqlDbType.VarChar).SourceColumn = "vacancy_no";
            //da.DeleteCommand = dc;
            */

        }

        #region UserMadeMethods

        private void setBindings()
        {
            /*txtAddress.DataBindings.Add("Text", bs, "address");
            txtContact.DataBindings.Add("Text", bs, "contact_no");
            txtEmail.DataBindings.Add("Text", bs, "email");
            txtFname.DataBindings.Add("Text", bs, "first_name");
            txtLname.DataBindings.Add("Text", bs, "last_name");
            txtNic.DataBindings.Add("Text", bs, "nic_no");
            txtVacancyNo.DataBindings.Add("Text", bs, "vacancy_no");
            if (dgvVacancyDetails.SelectedRows[0].Cells["gender"].Value.ToString() == "Male")
                rbMale.Checked = true;
            else if (dgvVacancyDetails.SelectedRows[0].Cells["gender"].Value.ToString() == "Female")
                rbFemale.Checked = true;
            //cmbPosition.DataBindings.Add("ValueMember", bs, "position_applied");
            //cmbSalutation.DataBindings.Add("SelectedText", bs, "salutation");
            dtApplied.DataBindings.Add("Value", bs, "applied_date");
            dtDob.DataBindings.Add("Value", bs, "date_of_birth");
            dtInterview.DataBindings.Add("Value", bs, "interview_date");
            cbStatus.DataBindings.Add("Checked", bs, "status");

            if (rbMale.Checked)
                rbMale.DataBindings.Add("Text", bs, "gender");
            else if (rbFemale.Checked)
                rbFemale.DataBindings.Add("Text", bs, "gender");*/
            
        }

        public void fillGridVacancy()
        {
            DataSet ds = dba.getVacancyDetailsAll();
            dgvVacancyDetails.DataSource = ds.Tables["vacancy"].DefaultView;
        }

        public void filterGridByVacancyNo(string v)
        {
            try
            {
                DataSet ds = dba.filterUsingVacancyNo(v);
                dgvVacancyDetails.DataSource = ds.Tables["vacancy"].DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void filterGridByCandidateName(string c)
        {
            try
            {
                DataSet ds = dba.filterUsingCandidate(c);
                dgvVacancyDetails.DataSource = ds.Tables["vacancy"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void filterGridByPosition(string p)
        {
            try
            {
                DataSet ds = dba.filterUsingPosition(p);
                dgvVacancyDetails.DataSource = ds.Tables["vacancy"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void filterGridByNic(string n)
        {
            try
            {
                DataSet ds = dba.filterUsingNic(n);
                dgvVacancyDetails.DataSource = ds.Tables["vacancy"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearAllControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var textBox = c as TextBox;
                if (textBox != null)
                    (textBox).Clear();
                if (c.HasChildren)
                    ClearAllControls(c);
            }

            cmbPosition.SelectedItem = null;
            cmbPositionSearch.SelectedItem = null;
            cmbSalutation.SelectedItem = null;
            cbStatus.CheckState = CheckState.Unchecked;
            rbFemale.Checked = false;
            rbMale.Checked = false;

            fillGridVacancy();
        }




        #endregion

        private void Vacancy_Load(object sender, EventArgs e)
        {
            fillGridVacancy();
            //setBindings();

        }

        private void dgvStaffDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void dgvVacancyDetails_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgvVacancyDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvVacancyDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtAddress.Text = dgvVacancyDetails.SelectedRows[0].Cells["address"].Value.ToString();
                txtContact.Text = dgvVacancyDetails.SelectedRows[0].Cells["contact_no"].Value.ToString();
                txtEmail.Text = dgvVacancyDetails.SelectedRows[0].Cells["email"].Value.ToString();
                txtFname.Text = dgvVacancyDetails.SelectedRows[0].Cells["first_name"].Value.ToString();
                txtLname.Text = dgvVacancyDetails.SelectedRows[0].Cells["last_name"].Value.ToString();
                txtNic.Text = dgvVacancyDetails.SelectedRows[0].Cells["nic_no"].Value.ToString();
                txtVacancyNo.Text = dgvVacancyDetails.SelectedRows[0].Cells["vacancy_no"].Value.ToString();
                dtApplied.Value = Convert.ToDateTime(dgvVacancyDetails.SelectedRows[0].Cells["applied_date"].Value.ToString());
                dtDob.Value = Convert.ToDateTime(dgvVacancyDetails.SelectedRows[0].Cells["date_of_birth"].Value.ToString());
                dtInterview.Value = Convert.ToDateTime(dgvVacancyDetails.SelectedRows[0].Cells["interview_date"].Value.ToString());
                cmbPosition.Text = dgvVacancyDetails.SelectedRows[0].Cells["position_applied"].Value.ToString();
                cmbSalutation.Text = dgvVacancyDetails.SelectedRows[0].Cells["salutation"].Value.ToString();

                if (dgvVacancyDetails.SelectedRows[0].Cells["status"].Value.ToString() == "True")
                    cbStatus.CheckState = CheckState.Checked;
                else
                    cbStatus.CheckState = CheckState.Unchecked;

                if (dgvVacancyDetails.SelectedRows[0].Cells["gender"].Value.ToString() == "Male")
                    rbMale.Checked = true;
                else if (dgvVacancyDetails.SelectedRows[0].Cells["gender"].Value.ToString() == "Female")
                    rbFemale.Checked = true;

                txtAge.Text = (DateTime.Now.Subtract(dtDob.Value).TotalDays/365).ToString("#");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++){}
            //foreach (DataRow dr in ds.Tables[0].Rows){}
        }

        
        private void txtVacancyNoSearch_TextChanged(object sender, EventArgs e)
        {
            filterGridByVacancyNo(txtVacancyNoSearch.Text);
        }

        private void txtCandidate_TextChanged(object sender, EventArgs e)
        {
            filterGridByCandidateName(txtCandidate.Text);
        }

        private void cmbPositionSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            filterGridByPosition(cmbPositionSearch.Text);
        }

        private void txtNicSearch_TextChanged(object sender, EventArgs e)
        {
            filterGridByNic(txtNicSearch.Text);
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAllControls(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            

            try
            {
                string faddress = txtAddress.Text;
                int fcontact = Convert.ToInt32(txtContact.Text);
                string femail = txtEmail.Text;
                string ffname = txtFname.Text;
                string flname = txtLname.Text;
                string fnic = txtNic.Text;
                string fvacancy = txtVacancyNo.Text;
                string fposition = cmbPosition.Text;
                string fsalute = cmbSalutation.Text;
                string fgender = null;
                bool fstatus = false;
                DateTime fdayBirth = dtDob.Value;
                DateTime fdayApplied = dtApplied.Value;
                DateTime fdayInterview = dtInterview.Value;

                if (rbMale.Checked)
                    fgender = "Male";
                if (rbFemale.Checked)
                    fgender = "Female";
                if (cbStatus.Checked)
                    fstatus = true;
                else
                    fstatus = false;

                DialogResult dr;

                dr = MetroMessageBox.Show(this, "Are you sure you want to Update?", "Confirm Updation", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dr == DialogResult.Yes)
                {
                    if (dba.updateVacancy(fvacancy, fposition, fstatus, fsalute, ffname, flname, fdayBirth, fgender, fdayApplied, fdayInterview, fcontact, faddress, femail, fnic))
                        MessageBox.Show("Successfully Updated!");
                    else
                        MessageBox.Show("Unsuccessful!");
                }
                else
                    MessageBox.Show("Cancelled");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            fillGridVacancy();
            ClearAllControls(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string fvacancy = txtVacancyNo.Text;
            
            try
            {
                DialogResult dr;

                dr = MetroMessageBox.Show(this, "Are you sure you want to Delete?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dr == DialogResult.Yes)
                {
                    if (dba.deleteVacancy(fvacancy))
                        MessageBox.Show("Successfully Deleted!");
                    else
                        MessageBox.Show("Unsuccessful!");
                }
                else
                    MessageBox.Show("Cancelled");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            fillGridVacancy();
            ClearAllControls(this);
        }

        public Boolean isNumber(string w)
        {
            foreach (char c in w)
            {
                if (!Char.IsNumber(c))
                    return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string faddress = txtAddress.Text;
            string contact = txtContact.Text;
            string femail = txtEmail.Text;
            string ffname = txtFname.Text;
            string flname = txtLname.Text;
            string fnic = txtNic.Text;
            string fvacancy = txtVacancyNo.Text;
            string fposition = cmbPosition.Text;
            string fsalute = cmbSalutation.Text;
            string fgender = null;
            bool fstatus = false;
            DateTime fdayBirth = dtDob.Value;
            DateTime fdayApplied = dtApplied.Value;
            DateTime fdayInterview = dtInterview.Value;

            if (rbMale.Checked)
                fgender = "Male";
            if (rbFemale.Checked)
                fgender = "Female";
            if (cbStatus.Checked)
                fstatus = true;
            else
                fstatus = false;

            if (faddress == null || faddress == "" || contact == null || contact == "" || femail == null || femail == "" || ffname == null || ffname == "" || flname == null || flname == "" || fnic == null || fnic == "" || fposition == null || fposition == "" || fsalute == null || fsalute == "" )
            {
                MetroMessageBox.Show(this, "Cannot Leave Empty Fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!(fvacancy.StartsWith("VC") || fvacancy.StartsWith("vc")))
            {
                MetroMessageBox.Show(this, "Vacancy no should start with either VC or vc", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!isNumber(contact)) 
            {
                MetroMessageBox.Show(this, "Contact no should be an integer number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    int fcontact = Convert.ToInt32(txtContact.Text);
                    DialogResult dr;

                    dr = MetroMessageBox.Show(this, "Are you sure you want to Save?", "Confirm Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                    if (dr == DialogResult.Yes)
                    {
                        if (dba.addVacancy(fvacancy, fposition, fstatus, fsalute, ffname, flname, fdayBirth, fgender, fdayApplied, fdayInterview, fcontact, faddress, femail, fnic))
                            MessageBox.Show("Successfully Saved!");
                        else
                            MessageBox.Show("Unsuccessful!");
                    }
                    else
                        MessageBox.Show("Cancelled");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                fillGridVacancy();
                ClearAllControls(this);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var staffMain = new StaffMainForm();
            staffMain.FormClosed += (s, args) => this.Close();
            staffMain.Show();
            this.Hide();
        }

        private void txtCandidate_Click(object sender, EventArgs e)
        {
            
        }



    }
}
