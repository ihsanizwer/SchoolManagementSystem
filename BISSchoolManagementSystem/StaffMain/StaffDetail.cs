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
    public partial class StaffDetail : MetroForm
    {
        DBAccessStaff dba = new DBAccessStaff();

        public StaffDetail()
        {
            InitializeComponent();

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void fillGrids()
        {
            DataSet dsStaff = dba.getStaffDetailsAll();
            dgvStaffDetails.DataSource = dsStaff.Tables["staff"].DefaultView;

            DataSet dsHealth = dba.getStaffHealth();
            dgvHealth.DataSource = dsHealth.Tables["health_issues"].DefaultView;

            DataSet dsAddress = dba.getStaffAddress();
            dgvAddress.DataSource = dsAddress.Tables["address"].DefaultView;

            DataSet dsFamily = dba.getStaffFamily();
            dgvFamily.DataSource = dsFamily.Tables["family"].DefaultView;

            DataSet dsQualification = dba.getStaffQualification();
            dgvQualification.DataSource = dsQualification.Tables["qualification"].DefaultView;
            
        }

        private void StaffDetail_Load(object sender, EventArgs e)
        {
            try
            {
                fillGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void filterGridByStaffId(string i)
        {
            try
            {
                DataSet ds = dba.filterUsingStaffIdForStaffTable(i);
                dgvStaffDetails.DataSource = ds.Tables["staff"].DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void filterGridByStaffName(string s)
        {
            try
            {
                DataSet ds = dba.filterUsingStaffName(s);
                dgvStaffDetails.DataSource = ds.Tables["staff"].DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void filterGridByDesignation(string d)
        {
            try
            {
                DataSet ds = dba.filterUsingDesignation(d);
                dgvStaffDetails.DataSource = ds.Tables["staff"].DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void filterGridByStaffNic(string n)
        {
            try
            {
                DataSet ds = dba.filterUsingStaffNic(n);
                dgvStaffDetails.DataSource = ds.Tables["staff"].DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtsid_TextChanged(object sender, EventArgs e)
        {
            filterGridByStaffId(txtSidSearch.Text);
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            filterGridByStaffName(txtNameSearch.Text);
        }

        private void cmbDesigSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            filterGridByDesignation(cmbDesigSearch.Text);
        }

        private void txtNicSearch_TextChanged(object sender, EventArgs e)
        {
            filterGridByStaffNic(txtNicSearch.Text);
        }

        public void ClearAllTextBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var textBox = c as TextBox;
                if (textBox != null)
                    (textBox).Clear();
                if (c.HasChildren)
                    ClearAllTextBox(c);
            }


            fillGrids();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAllTextBox(this);
        }

        public void setBindingsFromDataSets()
        {
            //try
            //{
            //    DataSet dsStaff = dba.getStaffDetailsAll();
            //    DataSet dsAcademic = dba.getStaffQualification();
            //    DataSet dsAddress = dba.getStaffAddress();
            //    DataSet dsFamily = dba.getStaffFamily();
            //    DataSet dsHealth = dba.getStaffHealth();

            //    BindingSource bsStaff = new BindingSource();
            //    BindingSource bsAcademic = new BindingSource();
            //    BindingSource bsAddress = new BindingSource();
            //    BindingSource bsFamily = new BindingSource();
            //    BindingSource bsHealth = new BindingSource();

            //    bsStaff.DataSource = dsStaff.Tables["staff"];
            //    bsAcademic.DataSource = dsAcademic.Tables["academic_staff"];
            //    bsAddress.DataSource = dsAddress.Tables["address"];
            //    bsFamily.DataSource = dsFamily.Tables["family"];
            //    bsHealth.DataSource = dsHealth.Tables["health_issues"];



            //    //txtAllergy.DataBindings.Add("Text", bsHealth, "allergy");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void dgvStaffDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataSet dsStaff = dba.getStaffDetailsAll();
            //DataSet dsAcademic = dba.getStaffQualification();
            //DataSet dsAddress = dba.getStaffAddress();
            //DataSet dsFamily = dba.getStaffFamily();
            //DataSet dsHealth = dba.getStaffHealth();

            //BindingSource bsStaff = new BindingSource();
            //BindingSource bsAcademic = new BindingSource();
            //BindingSource bsAddress = new BindingSource();
            //BindingSource bsFamily = new BindingSource();
            //BindingSource bsHealth = new BindingSource();

            //bsStaff.DataSource = dsStaff.Tables["staff"];
            //bsAcademic.DataSource = dsAcademic.Tables["academic_staff"];
            //bsAddress.DataSource = dsAddress.Tables["address"];
            //bsFamily.DataSource = dsFamily.Tables["family"];
            //bsHealth.DataSource = dsHealth.Tables["health_issues"];
            
            //try
            //{
            //    //txtAllergy.DataBindings.Add("Text", bsHealth, "allergy");

            //    //txtFname.DataBindings.Add("Text", bsStaff, "first_name");
                
            //}
            //catch (Exception ex)
            //{
            //    MetroMessageBox.Show(this, ex.Message, "ERROR!");
            //}
        }

        private void dgvQualification_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbQualiType.Text = dgvQualification.SelectedRows[0].Cells["qualification_type"].Value.ToString();
            txtQualiCollege.Text = dgvQualification.SelectedRows[0].Cells["college"].Value.ToString();
            txtQualiCompleted.Text = dgvQualification.SelectedRows[0].Cells["completion_year"].Value.ToString();
            txtQualiDesc.Text = dgvQualification.SelectedRows[0].Cells["description"].Value.ToString();
            txtQualiDuration.Text = dgvQualification.SelectedRows[0].Cells["duration"].Value.ToString();
            txtQualiUni.Text = dgvQualification.SelectedRows[0].Cells["university"].Value.ToString();
            txtQualiName.Text = dgvQualification.SelectedRows[0].Cells["qualification_name"].Value.ToString();
            txtSidQual.Text = dgvQualification.SelectedRows[0].Cells["staff_id"].Value.ToString();
        }

        private void dgvAddress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSidAddress.Text = dgvAddress.SelectedRows[0].Cells["staff_id"].Value.ToString();
            txtCity1.Text = dgvAddress.SelectedRows[0].Cells["city"].Value.ToString();
            txtStreet1.Text = dgvAddress.SelectedRows[0].Cells["street"].Value.ToString();
            txtState1.Text = dgvAddress.SelectedRows[0].Cells["province"].Value.ToString();
            txtPCode1.Text = dgvAddress.SelectedRows[0].Cells["postal_code"].Value.ToString();
        }

        private void dgvHealth_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSidHealth.Text = dgvHealth.SelectedRows[0].Cells["staff_id"].Value.ToString();
            txtHealthId.Text = dgvHealth.SelectedRows[0].Cells["health_id"].Value.ToString();
            txtAllergy.Text = dgvHealth.SelectedRows[0].Cells["allergy"].Value.ToString();
            txtMedicalHistory.Text = dgvHealth.SelectedRows[0].Cells["medical_history"].Value.ToString();
        }

        private void dgvFamily_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSidFamily.Text = dgvFamily.SelectedRows[0].Cells["staff_id"].Value.ToString();
            cmbGuardianType.Text = dgvFamily.SelectedRows[0].Cells["guardian_type"].Value.ToString();
            txtGuardianAddress.Text = dgvFamily.SelectedRows[0].Cells["address"].Value.ToString();
            txtGuardianFname.Text = dgvFamily.SelectedRows[0].Cells["first_name"].Value.ToString();
            txtGuardianLname.Text = dgvFamily.SelectedRows[0].Cells["last_name"].Value.ToString();
            txtGuardianOccupation.Text = dgvFamily.SelectedRows[0].Cells["occupation"].Value.ToString();
            txtGuardianPhone.Text = dgvFamily.SelectedRows[0].Cells["phone_no"].Value.ToString();

            if (dgvFamily.SelectedRows[0].Cells["is_emergency_contact"].Value.ToString() == "True")
                cbIsEmergency.CheckState = CheckState.Checked;
            else
                cbIsEmergency.CheckState = CheckState.Unchecked;
        }

        private void dgvStaffDetails_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtEmail.Text = dgvStaffDetails.SelectedRows[0].Cells["email"].Value.ToString();
            txtFname.Text = dgvStaffDetails.SelectedRows[0].Cells["first_name"].Value.ToString();
            txtInCharge.Text = dgvStaffDetails.SelectedRows[0].Cells["union_name"].Value.ToString();
            txtInChargePos.Text = dgvStaffDetails.SelectedRows[0].Cells["union_position"].Value.ToString();
            txtLname.Text = dgvStaffDetails.SelectedRows[0].Cells["last_name"].Value.ToString();
            txtNational.Text = dgvStaffDetails.SelectedRows[0].Cells["nationality"].Value.ToString();
            txtPNo1.Text = dgvStaffDetails.SelectedRows[0].Cells["phone_no_1"].Value.ToString();
            txtPNo2.Text = dgvStaffDetails.SelectedRows[0].Cells["phone_no_2"].Value.ToString();
            txtReligion.Text = dgvStaffDetails.SelectedRows[0].Cells["religion"].Value.ToString();
            txtSidJob.Text = dgvStaffDetails.SelectedRows[0].Cells["staff_id"].Value.ToString();
            txtSummaryDesig.Text = dgvStaffDetails.SelectedRows[0].Cells["designation"].Value.ToString();
            txtSummaryEmail.Text = dgvStaffDetails.SelectedRows[0].Cells["staff_id"].Value.ToString();
            txtSummaryFname.Text = dgvStaffDetails.SelectedRows[0].Cells["first_name"].Value.ToString();
            txtSummaryLname.Text = dgvStaffDetails.SelectedRows[0].Cells["last_name"].Value.ToString();
            txtSummaryReligion.Text = dgvStaffDetails.SelectedRows[0].Cells["religion"].Value.ToString();
            txtSummarySid.Text = dgvStaffDetails.SelectedRows[0].Cells["staff_id"].Value.ToString();
            txtNIC.Text = dgvStaffDetails.SelectedRows[0].Cells["nic_no"].Value.ToString();

            cmbMarry.Text = dgvStaffDetails.SelectedRows[0].Cells["marital_status"].Value.ToString();
            cmbHouse.Text = dgvStaffDetails.SelectedRows[0].Cells["house"].Value.ToString();
            cmbPerm.Text = dgvStaffDetails.SelectedRows[0].Cells["permanency"].Value.ToString();
            cmbSalute.Text = dgvStaffDetails.SelectedRows[0].Cells["salutation"].Value.ToString();
            cmbDesigJob.Text = dgvStaffDetails.SelectedRows[0].Cells["designation"].Value.ToString();

            dtAppoint.Value = Convert.ToDateTime(dgvStaffDetails.SelectedRows[0].Cells["appointment_date"].Value.ToString());
            dtDob.Value = Convert.ToDateTime(dgvStaffDetails.SelectedRows[0].Cells["date_of_birth"].Value.ToString());
            dtStart.Value = Convert.ToDateTime(dgvStaffDetails.SelectedRows[0].Cells["start_date"].Value.ToString());

            if (dgvStaffDetails.SelectedRows[0].Cells["gender"].Value.ToString() == "Male")
                rbMale.Checked = true;
            else if (dgvStaffDetails.SelectedRows[0].Cells["gender"].Value.ToString() == "Female")
                rbFemale.Checked = true;

            txtAge.Text = (DateTime.Now.Subtract(dtDob.Value).TotalDays / 365).ToString("#");
            txtSummaryAge.Text = (DateTime.Now.Subtract(dtDob.Value).TotalDays / 365).ToString("#");
            txtService.Text = (DateTime.Now.Subtract(dtStart.Value).TotalDays / 365).ToString("#");
            
        }

        private void metroTextButton12_Click(object sender, EventArgs e)
        {
            string allergy = txtAllergy.Text;
            string hid = txtHealthId.Text;
            string medical = txtMedicalHistory.Text;
            string sid = txtSidHealth.Text;

            try
            {
                DialogResult dr;

                dr = MetroMessageBox.Show(this, "Are you sure you want to Save?", "Confirm Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dr == DialogResult.Yes)
                {
                    if (dba.addHealth(sid, hid, allergy, medical))
                        MessageBox.Show("Successfully Added!");
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

            fillGrids();
            ClearAllTextBox(this);
        }

        private void metroTextButton11_Click(object sender, EventArgs e)
        {
            string allergy = txtAllergy.Text;
            string hid = txtHealthId.Text;
            string medical = txtMedicalHistory.Text;
            string sid = txtSidHealth.Text;

            try
            {
                DialogResult dr;

                dr = MetroMessageBox.Show(this, "Are you sure you want to Update?", "Confirm Updation", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dr == DialogResult.Yes)
                {
                    if (dba.updateHealth(sid,hid,allergy,medical))
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

            fillGrids();
            ClearAllTextBox(this);
        }

        private void metroTextButton15_Click(object sender, EventArgs e)
        {
            ClearAllTextBox(this);
        }

        private void metroTextButton14_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTextButton17_Click(object sender, EventArgs e)
        {
            string sid = txtSidAddress.Text;
            string city = txtCity1.Text;
            string state = txtState1.Text;
            string street = txtStreet1.Text;
            int postal = int.Parse(txtPCode1.Text);

            try
            {
                DialogResult dr;

                dr = MetroMessageBox.Show(this, "Are you sure you want to Update?", "Confirm Updation", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dr == DialogResult.Yes)
                {
                    if (dba.updateAddress(sid, street, city, state, postal))
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

            fillGrids();
            ClearAllTextBox(this);
        }

        private void metroTextButton18_Click(object sender, EventArgs e)
        {
            string sid = txtSidAddress.Text;
            string city = txtCity1.Text;
            string state = txtState1.Text;
            string street = txtStreet1.Text;
            int postal = int.Parse(txtPCode1.Text);

            try
            {
                DialogResult dr;

                dr = MetroMessageBox.Show(this, "Are you sure you want to Save?", "Confirm Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dr == DialogResult.Yes)
                {
                    if (dba.addAddress(sid, street, city, state, postal))
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

            fillGrids();
            ClearAllTextBox(this);
        }

        private void metroTextButton9_Click(object sender, EventArgs e)
        {
            ClearAllTextBox(this);
        }

        private void metroTextButton21_Click(object sender, EventArgs e)
        {
            ClearAllTextBox(this);
        }

        private void metroTextButton23_Click(object sender, EventArgs e)
        {
            int qDuration = Convert.ToInt32(txtQualiDuration.Text);
            int qComplete = Convert.ToInt32(txtQualiCompleted.Text);
            string qType = cmbQualiType.Text;
            string qCollege = txtQualiCollege.Text;
            string qDesc = txtQualiDesc.Text;
            string qName = txtQualiName.Text;
            string qUni = txtQualiUni.Text;
            string sid = txtSidQual.Text;

            try
            {
                DialogResult dr;

                dr = MetroMessageBox.Show(this, "Are you sure you want to Save?", "Confirm Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dr == DialogResult.Yes)
                {
                    if (dba.addQualification(sid, qType, qName, qDesc, qCollege, qUni, qDuration, qComplete))
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

            fillGrids();
            ClearAllTextBox(this);
        }

        private void metroTextButton24_Click(object sender, EventArgs e)
        {
            int qDuration = Convert.ToInt32(txtQualiDuration.Text);
            int qComplete = Convert.ToInt32(txtQualiCompleted.Text);
            string qType = cmbQualiType.Text;
            string qCollege = txtQualiCollege.Text;
            string qDesc = txtQualiDesc.Text;
            string qName = txtQualiName.Text;
            string qUni = txtQualiUni.Text;
            string sid = txtSidQual.Text;

            try
            {
                DialogResult dr;

                dr = MetroMessageBox.Show(this, "Are you sure you want to Update?", "Confirm Updation", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dr == DialogResult.Yes)
                {
                    if (dba.updateQualification(sid, qType, qName, qDesc, qCollege, qUni, qDuration, qComplete))
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

            fillGrids();
            ClearAllTextBox(this);
        }

        private void metroTextButton5_Click(object sender, EventArgs e)
        {
            string sid = txtSidFamily.Text;
            string guardAddress = txtGuardianAddress.Text;
            string guardName = txtGuardianFname.Text;
            string guardLname = txtGuardianLname.Text;
            string guardOcc = txtGuardianOccupation.Text;
            int guardPhone = Convert.ToInt32(txtGuardianPhone.Text);
            string guardType = cmbGuardianType.Text;
            bool emergency = false;
            if (cbIsEmergency.Checked)
                emergency = true;
            else
                emergency = false;

            try
            {
                DialogResult dr;

                dr = MetroMessageBox.Show(this, "Are you sure you want to Save?", "Confirm Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dr == DialogResult.Yes)
                {
                    if (dba.addFamily(sid, guardType, guardName, guardName, guardOcc, guardPhone, guardAddress, emergency))
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

            fillGrids();
            ClearAllTextBox(this);
        }

        private void metroTextButton6_Click(object sender, EventArgs e)
        {
            string sid = txtSidFamily.Text;
            string guardAddress = txtGuardianAddress.Text;
            string guardName = txtGuardianFname.Text;
            string guardLname = txtGuardianLname.Text;
            string guardOcc = txtGuardianOccupation.Text;
            int guardPhone = Convert.ToInt32(txtGuardianPhone.Text);
            string guardType = cmbGuardianType.Text;
            bool emergency = false;
            if (cbIsEmergency.Checked)
                emergency = true;
            else
                emergency = false;

            try
            {
                DialogResult dr;

                dr = MetroMessageBox.Show(this, "Are you sure you want to Update?", "Confirm Updation", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dr == DialogResult.Yes)
                {
                    if (dba.updateFamily(sid, guardType, guardName, guardName, guardOcc, guardPhone, guardAddress, emergency))
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

            fillGrids();
            ClearAllTextBox(this);
        }

        private void metroTextButton3_Click(object sender, EventArgs e)
        {
            ClearAllTextBox(this);
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string salute = cmbSalute.Text;
            string religion = txtReligion.Text;
            string marry = cmbMarry.Text;
            string national = txtNational.Text;
            string email = txtEmail.Text;
            string sid = txtSidJob.Text;
            string desig = cmbDesigJob.Text;
            string house = cmbHouse.Text;
            string perm = cmbPerm.Text;
            string inCharge = txtInCharge.Text;
            string nic = txtNIC.Text;
            string inChargePos = txtInChargePos.Text;
            int pNo1 = Convert.ToInt32(txtPNo1.Text);
            int pNo2 = Convert.ToInt32(txtPNo2.Text);
            DateTime dDob = dtDob.Value;
            DateTime dAppoint = dtAppoint.Value;
            DateTime dStart = dtStart.Value;
            string gender = null;
            if (rbMale.Checked)
                gender = "Male";
            if (rbFemale.Checked)
                gender = "Female";

            try
            {
                DialogResult dr;

                dr = MetroMessageBox.Show(this, "Are you sure you want to Update?", "Confirm Updation", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dr == DialogResult.Yes)
                {
                    if (dba.updateStaff(sid,salute,fname,lname,dDob,gender,marry, dAppoint, dStart, perm, desig, email, religion, national,nic,pNo1,pNo2))
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

            fillGrids();
            ClearAllTextBox(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string salute = cmbSalute.Text;
            string religion = txtReligion.Text;
            string marry = cmbMarry.Text;
            string national = txtNational.Text;
            string email = txtEmail.Text;
            string sid = txtSidJob.Text;
            string desig = cmbDesigJob.Text;
            string house = cmbHouse.Text;
            string perm = cmbPerm.Text;
            string inCharge = txtInCharge.Text;
            string nic = txtNIC.Text;
            string inChargePos = txtInChargePos.Text;
            int pNo1 = Convert.ToInt32(txtPNo1.Text);
            int pNo2 = Convert.ToInt32(txtPNo2.Text);
            DateTime dDob = dtDob.Value;
            DateTime dAppoint = dtAppoint.Value;
            DateTime dStart = dtStart.Value;
            string gender = null;
            if (rbMale.Checked)
                gender = "Male";
            if (rbFemale.Checked)
                gender = "Female";

            try
            {
                DialogResult dr;

                dr = MetroMessageBox.Show(this, "Are you sure you want to Save?", "Confirm Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (dr == DialogResult.Yes)
                {
                    if (dba.addStaff(sid, salute, fname, lname, dDob, gender, marry, dAppoint, dStart, perm, desig, email, religion, national, nic, pNo1, pNo2))
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

            fillGrids();
            ClearAllTextBox(this);
        }

        private void txtTerminate_Click(object sender, EventArgs e)
        {
            DialogResult dr;

            dr = MetroMessageBox.Show(this, "Are you sure you want to Terminate this Staff Member?", "Termination", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (dr == DialogResult.Yes)
            {
                var sTerminate = new Termination();
                sTerminate.Show();
            }
            else
                MessageBox.Show("Cancelled");
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            var staffMain = new StaffMainForm();
            staffMain.FormClosed += (s, args) => this.Close();
            staffMain.Show();
            this.Hide();
        }

        public void filterGridByStaffIdFamily(string a)
        {
            try
            {
                DataSet ds = dba.filterUsingStaffIdForFamilyTable(a);
                dgvFamily.DataSource = ds.Tables["family"].DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            filterGridByStaffIdFamily(txtSidSearchFamily.Text);
        }

        public void filterGridByStaffIdHealth(string a)
        {
            try
            {
                DataSet ds = dba.filterUsingStaffIdForHealthTable(a);
                dgvHealth.DataSource = ds.Tables["health_issues"].DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSidSearchHealth_TextChanged(object sender, EventArgs e)
        {
            filterGridByStaffIdHealth(txtSidSearchHealth.Text);
        }

        public void filterGridByStaffIdAddress(string a)
        {
            try
            {
                DataSet ds = dba.filterUsingStaffIdForAddressTable(a);
                dgvAddress.DataSource = ds.Tables["address"].DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSidSearchAddress_TextChanged(object sender, EventArgs e)
        {
            filterGridByStaffIdAddress(txtSidSearchAddress.Text);
        }

        public void filterGridByStaffIdQualification(string a)
        {
            try
            {
                DataSet ds = dba.filterUsingStaffIdForQualificationTable(a);
                dgvQualification.DataSource = ds.Tables["qualification"].DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSidSearchQual_TextChanged(object sender, EventArgs e)
        {
            filterGridByStaffIdQualification(txtSidSearchQual.Text);
        }
    }
}
