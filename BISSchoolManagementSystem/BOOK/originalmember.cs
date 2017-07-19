using MetroFramework;
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

namespace BOOK
{
    public partial class originalmember : MetroForm
    {
        DBAccessMember dba = new DBAccessMember();
    
        public originalmember()
        {
            InitializeComponent();
        }

        private void originalmember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sudheesanDataSet4.member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.sudheesanDataSet4.member);
            // TODO: This line of code loads data into the 'sudheesanDataSet3.member' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'sudheesanDataSet3.member' table. You can move, or remove it, as needed.
         

        }
        public void Fillmember()
        {

            this.memberTableAdapter.Fill(this.sudheesanDataSet4.member);

        }

        public void Clear()
        {
            ClearAllTextBox(this);
            metroDateTime2.Value = DateTime.Today;
            metroDateTime1.Value = DateTime.Today;
            Fillmember();


            btn_member_add.Enabled = false;

        }
        public static void ClearAllTextBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var textBox = c as TextBox;
                if (textBox != null)
                    (textBox).Clear();
                if (c.HasChildren)
                    ClearAllTextBox(c);
            }
        }

        public bool validateMemberName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Any(Char.IsDigit))
            {
                MetroMessageBox.Show(this,"Please enter your First Name without digits");
                metroTextBox8.Select();
                return false;

            }
            else
            {
                return true;
            }
        }
        public bool validateNumber(string phone)
        {
            if(phone.Length ==9 && phone.All(char.IsDigit))
            {
               
                return true;
            }
            else
            {
                MetroMessageBox.Show(this, "INPUT PHONE NUMBER WITH NINE DIGITS");
                metroTextBox9.Focus();
                return false;
            }
        }

        public bool validateMemberId(string memID)
        {
           
          
                
               string last = memID.Substring(4,(memID.Length-4));
               
            
            
               MetroMessageBox.Show(this, last);
            if(memID.Length == 9 && memID.StartsWith("MEM_") && last.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(this, "INPUT MEMBER ID IN 'MEM_XXXXX' FORMAT");
                metroTextBox4.Focus();
                return false;
            }
          
          
          
        }
        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }

        

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m1 = new LMSMAIN();
            m1.Closed += (s, args) => this.Close();
            m1.Show();

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            metroTextBox4.Text = metroGrid2.Rows[e.RowIndex].Cells["memberidDataGridViewTextBoxColumn"].Value.ToString();
            metroTextBox5.Text = metroGrid2.Rows[e.RowIndex].Cells["memberbarcodeDataGridViewTextBoxColumn"].Value.ToString();
            metroComboBox4.Text = metroGrid2.Rows[e.RowIndex].Cells["genderDataGridViewTextBoxColumn"].Value.ToString();
            metroComboBox5.Text = metroGrid2.Rows[e.RowIndex].Cells["memberstatusDataGridViewTextBoxColumn"].Value.ToString();
            metroComboBox1.Text = metroGrid2.Rows[e.RowIndex].Cells["securitydepositDataGridViewTextBoxColumn"].Value.ToString();
            metroComboBox2.Text = metroGrid2.Rows[e.RowIndex].Cells["typeofmemberDataGridViewTextBoxColumn"].Value.ToString();
            metroTextBox8.Text = metroGrid2.Rows[e.RowIndex].Cells["membernameDataGridViewTextBoxColumn"].Value.ToString();
            metroTextBox9.Text = metroGrid2.Rows[e.RowIndex].Cells["contactnoDataGridViewTextBoxColumn"].Value.ToString();
            metroDateTime1.Value = (DateTime)metroGrid2.Rows[e.RowIndex].Cells["joindateDataGridViewTextBoxColumn"].Value;
            metroDateTime2.Value = (DateTime)metroGrid2.Rows[e.RowIndex].Cells["validdateDataGridViewTextBoxColumn"].Value;


        }

        private void btn_member_add_Click(object sender, EventArgs e)
        {
         if (validateMemberId(metroTextBox4.Text))
         {

         
          if(validateMemberName(metroTextBox8.Text))
          {
              if (validateNumber(metroTextBox9.Text))
              {

                  try
                  {
                      if (dba.addMember(metroTextBox4.Text, metroTextBox5.Text, metroDateTime1.Value.Date.ToString("MM/dd/yyyy"), metroDateTime2.Value.Date.ToString("MM/dd/yyyy"), Convert.ToDouble(metroComboBox1.Text), metroComboBox2.Text.ToString(), metroTextBox8.Text, Convert.ToInt32(metroTextBox9.Text), metroComboBox4.Text.ToString(), metroComboBox5.Text.ToString()))
                      {
                          MetroMessageBox.Show(this,"Successfully Added");
                      }
                      else
                      {
                          MetroMessageBox.Show(this,"Error occured");
                      }
                  }

                  catch (Exception ex)
                  {
                      MetroMessageBox.Show(this,ex.Message);
                  }
                  Clear();

                  Fillmember();
              }
              
          }
         }
        }

        private void metroTextBox4_TextChanged(object sender, EventArgs e)
        {
            btn_member_add.Visible = true;
        }

        private void btn_member_update_Click(object sender, EventArgs e)
        {
            try
            {

                if (dba.updateMember(metroTextBox4.Text, metroTextBox5.Text, metroDateTime1.Value.Date.ToString("MM/dd/yyyy"), metroDateTime2.Value.Date.ToString("MM/dd/yyyy"), Convert.ToDouble(metroComboBox1.Text), metroComboBox2.Text.ToString(), metroTextBox8.Text, Convert.ToInt32(metroTextBox9.Text), metroComboBox4.Text.ToString(), metroComboBox5.Text.ToString()))
                {


                    MetroMessageBox.Show(this,"Successfully Updated");
                }
                else
                {
                    MetroMessageBox.Show(this,"Error occured");
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,ex.Message);
            }
            Clear();

            Fillmember();
        }

        private void btn_member_delete_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "DO YOU WANT TO DELETE THE RECORD", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {

                    if (dba.deleteMember(metroTextBox4.Text))
                    {


                        MetroMessageBox.Show(this, "Successfully deleted");
                        ClearAllTextBox(this);
                        Fillmember();
                    }
                    else
                    {
                        MetroMessageBox.Show(this,"Error occured");
                    }
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this,ex.Message);
                }
            }
       
            Fillmember();
        }

        public void FilterDataGridMemId(String a)
        {
            DataSet ds = dba.FilterMemberId(a);
            metroGrid2.DataSource = ds.Tables["member"].DefaultView;

        }
        public void FilterDataGridMemName(String a)
        {
            DataSet ds = dba.FilterMemberName(a);
            metroGrid2.DataSource = ds.Tables["member"].DefaultView;

        }
        public void FilterDataGridMemType(String a)
        {
            DataSet ds = dba.FilterMemberType(a);
            metroGrid2.DataSource = ds.Tables["member"].DefaultView;

        }
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.btn_member_add.Visible = true;
            FilterDataGridMemId(metroTextBox1.Text);
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridMemName(metroTextBox3.Text);
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataGridMemType(metroComboBox3.Text);
        }

        

        private void metroTextBox4_KeyUp(object sender, KeyEventArgs e)
        {
            btn_member_add.Enabled = true;
        }
    }
}
