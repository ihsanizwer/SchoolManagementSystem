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

namespace Schedular
{
    public partial class classtimetable : MetroForm

    {
        DBAccessClass dba = new DBAccessClass();
        public static String tabtext;

        public classtimetable()
        {
            InitializeComponent();
            //tabtext = "TabPage: {MONDAY}";

            
            

      
        }

        private void classtimetable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sudheesanDataSet2.scl_subject' table. You can move, or remove it, as needed.
            this.scl_subjectTableAdapter.Fill(this.sudheesanDataSet2.scl_subject);
            // TODO: This line of code loads data into the 'sudheesanDataSet._class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.sudheesanDataSet._class);
            tabtext = "TabPage: {MONDAY}";
           // FillClass();

            //FillClassTab();
            cmb_class_monday.SelectedItem = "G1";
            cmb_subno_monday.SelectedIndex = 0;
            cmb_class_tuesday.SelectedItem = "G1";
            cmb_subno_tuesday.SelectedIndex = 0;
            cmb_class_wendsday.SelectedItem = "G1";
            cmb_subno_wendsday.SelectedIndex = 0;
            cmb_class_thursday.SelectedItem = "G1";
            cmb_subno_thursday.SelectedIndex = 0;
            cmb_class_friday.SelectedItem = "G1";
            metroComboBox33.SelectedIndex = 0;
           

        }

        public  String getTabText()
        {

            
            return tabtext;
        }

        
        

        public void FillClassTab()
        {
           
            DataSet ds = dba.getClassTime();

            if (tabtext == "TabPage: {MONDAY}")
            {
                dgv_monday.DataSource = ds.Tables["class_time_table"].DefaultView;
                
            }
            else if (tabtext == "TabPage: {TUESDAY}")
            {
                dgv_tuesday.DataSource = ds.Tables["class_time_table"].DefaultView;
                
            }
            else if (tabtext == "TabPage: {WENDSDAY}")
            {
                dgv_wendsday.DataSource = ds.Tables["class_time_table"].DefaultView;
            }
            else if (tabtext == "TabPage: {THURSDAY}")
            {
                dgv_thursday.DataSource = ds.Tables["class_time_table"].DefaultView;
            }
            else if (tabtext == "TabPage: {FRIDAY}")
            {
                dgv_friday.DataSource = ds.Tables["class_time_table"].DefaultView;
            }
           
          }


        public void filterClassGrid(String a , String b )
        {
            
                DataSet ds = dba.getClassGrid(a,b);


                if (tabtext == "TabPage: {MONDAY}")
                {
                    dgv_monday.DataSource = ds.Tables["class_time_table"].DefaultView;

                }
                else if (tabtext == "TabPage: {TUESDAY}")
                {
                    dgv_tuesday.DataSource = ds.Tables["class_time_table"].DefaultView;

                }
                else if (tabtext == "TabPage: {WENDSDAY}")
                {
                    dgv_wendsday.DataSource = ds.Tables["class_time_table"].DefaultView;
                }
                else if (tabtext == "TabPage: {THURSDAY}")
                {
                    dgv_thursday.DataSource = ds.Tables["class_time_table"].DefaultView;
                }
                else if (tabtext == "TabPage: {FRIDAY}")
                {
                    dgv_friday.DataSource = ds.Tables["class_time_table"].DefaultView;
                }
            
            
        }


      /*  public void FillClass()
        {
            DataTable dt1 = dba.getClass();
            cmb_class_monday.DisplayMember = "CatName";
            cmb_class_monday.DataSource = dt1;
           
        }*/


        private void metroTextButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SheduleHome = new SheduleHome();
            SheduleHome.Closed += (s, args) => this.Close();
            SheduleHome.Show();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }        

        private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
  

        private void metroComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void metroComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        

        

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tab_Page_Monday_Click(object sender, EventArgs e)
        {
            
        }

        private void Tab_Page_tuesday_Click(object sender, EventArgs e)
        {
            
        }

        private void Tab_Page_Monday_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private  void metroTabControl1_Selected(object sender, TabControlEventArgs e)
        {


            tabtext = e.TabPage.ToString();
            FillClassTab();
            

        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void metroTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
           
        }

        private void dgv_monday_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            metroComboBox13.Text = dgv_monday.Rows[e.RowIndex].Cells["djv_class_to"].Value.ToString();
            metroComboBox17.Text = dgv_monday.Rows[e.RowIndex].Cells["djv_class_from"].Value.ToString();
            metroTextBox3.Text = dgv_monday.Rows[e.RowIndex].Cells["djv_class_teacher"].Value.ToString();


            metroComboBox1.Text = dgv_monday.Rows[e.RowIndex].Cells["djv_class_className"].Value.ToString();

            metroComboBox5.Text = dgv_monday.Rows[e.RowIndex].Cells["dgv_class_subjectName"].Value.ToString();
            metroComboBox16.Text = dgv_monday.Rows[e.RowIndex].Cells["djv_class_subject_No"].Value.ToString();

            btn_update_monday.Enabled = true;
            btn_add_monday.Enabled = false;            

        }

        private void dgv_tuesday_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            metroComboBox18.Text = dgv_tuesday.Rows[e.RowIndex].Cells["dgvClassCol_to"].Value.ToString();
            metroComboBox19.Text = dgv_tuesday.Rows[e.RowIndex].Cells["dgvClassCol_from"].Value.ToString();
            metroTextBox4.Text = dgv_tuesday.Rows[e.RowIndex].Cells["dgvClassCol_teacher"].Value.ToString();


            metroComboBox6.Text = dgv_tuesday.Rows[e.RowIndex].Cells["dgvClassCol_classname"].Value.ToString();

            metroComboBox2.Text = dgv_tuesday.Rows[e.RowIndex].Cells["dgvClassCol_subname"].Value.ToString();
            metroComboBox3.Text = dgv_tuesday.Rows[e.RowIndex].Cells["dgvClassCol_subno"].Value.ToString();

            btn_update_tuesday.Enabled = true;
            btn_add_tuesday.Enabled = false;  
        }

        private void dgv_wendsday_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            metroComboBox20.Text = dgv_wendsday.Rows[e.RowIndex].Cells["dgv_class_wed_to"].Value.ToString();
            metroComboBox21.Text = dgv_wendsday.Rows[e.RowIndex].Cells["dgv_class_wed_from"].Value.ToString();
            metroTextBox7.Text = dgv_wendsday.Rows[e.RowIndex].Cells["dgv_class_wed_teacher"].Value.ToString();


            metroComboBox8.Text = dgv_wendsday.Rows[e.RowIndex].Cells["dgv_class_wed_clname"].Value.ToString();

            metroComboBox7.Text = dgv_wendsday.Rows[e.RowIndex].Cells["dgv_class_wed_subname"].Value.ToString();
            metroComboBox4.Text = dgv_wendsday.Rows[e.RowIndex].Cells["dgv_class_wed_subno"].Value.ToString();

            btn_update_wendsday.Enabled = true;
            btn_add_wendsday.Enabled = false; 
        }

        private void dgv_thursday_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                metroComboBox22.Text = dgv_thursday.Rows[e.RowIndex].Cells["dgv_class_thu_day_to"].Value.ToString();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,ex.Message);
            }
            metroComboBox23.Text = dgv_thursday.Rows[e.RowIndex].Cells["dgv_class_thu_from"].Value.ToString();
            metroTextBox10.Text = dgv_thursday.Rows[e.RowIndex].Cells["dgv_class_thu_day_teacher"].Value.ToString();


            metroComboBox10.Text = dgv_thursday.Rows[e.RowIndex].Cells["dgv_class_thu_clname"].Value.ToString();

            metroComboBox9.Text = dgv_thursday.Rows[e.RowIndex].Cells["dgv_class_thu_subname"].Value.ToString();
            metroComboBox11.Text = dgv_thursday.Rows[e.RowIndex].Cells["dgv_class_thu_subno"].Value.ToString();

            btn_update_thursday.Enabled = true;
            btn_add_thursday.Enabled = false;
        }

        private void dgv_friday_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            
                metroComboBox24.Text = dgv_friday.Rows[e.RowIndex].Cells["dgv_class_fri_to"].Value.ToString();
            
            
            metroComboBox25.Text = dgv_friday.Rows[e.RowIndex].Cells["dgv_class_fri_from"].Value.ToString();
            metroTextBox13.Text = dgv_friday.Rows[e.RowIndex].Cells["dgv_class_fri_teacher"].Value.ToString();


            metroComboBox15.Text = dgv_friday.Rows[e.RowIndex].Cells["dgv_class_fri_clname"].Value.ToString();

            metroComboBox14.Text = dgv_friday.Rows[e.RowIndex].Cells["dgv_class_fri_subname"].Value.ToString();
            metroComboBox12.Text = dgv_friday.Rows[e.RowIndex].Cells["dgv_class_fri_subno"].Value.ToString();

            btn_update_friday.Enabled = true;
            btn_add_friday.Enabled = false;
        }

        private void metroComboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void FilterClassGridClassId(string a)
        {
            DataSet ds = dba.getClassTabClassId(a);


            if (tabtext == "TabPage: {MONDAY}")
            {
                dgv_monday.DataSource = ds.Tables["class_time_table"].DefaultView;

            }
            else if (tabtext == "TabPage: {TUESDAY}")
            {
                dgv_tuesday.DataSource = ds.Tables["class_time_table"].DefaultView;

            }
            else if (tabtext == "TabPage: {WENDSDAY}")
            {
                dgv_wendsday.DataSource = ds.Tables["class_time_table"].DefaultView;
            }
            else if (tabtext == "TabPage: {THURSDAY}")
            {
                dgv_thursday.DataSource = ds.Tables["class_time_table"].DefaultView;
            }
            else if (tabtext == "TabPage: {FRIDAY}")
            {
                dgv_friday.DataSource = ds.Tables["class_time_table"].DefaultView;
            }
        }

        private void btn_update_monday_Click(object sender, EventArgs e)
        {
            try
            {

                if (dba.updateClassTable(metroComboBox13.SelectedItem.ToString(), metroComboBox17.SelectedItem.ToString(), metroTextBox3.Text, metroComboBox1.SelectedItem.ToString(), metroComboBox5.SelectedItem.ToString(), metroComboBox16.SelectedItem.ToString()))
                {


                    MetroMessageBox.Show(this,"Successfully Updated");
                }
                else
                {
                    MetroMessageBox.Show(this,"Error occured");
                }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this,ex.Message);
            }
           // Clear();

            FillClassTab();

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "DO YOU WANT TO DELETE THE RECORD", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {

                    if (dba.deleteClassShedule(metroComboBox1.SelectedItem.ToString(), metroComboBox16.SelectedItem.ToString()))
                    {


                       MetroMessageBox.Show(this,"Successfully deleted");
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Error occured");
                    }
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this,ex.Message);
                }
              

                FillClassTab();
            }

        }

        private void metroTextBox16_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txt_subname_monday_TextChanged(object sender, EventArgs e)
        {
           // filterClassGrid();
        }

        private void cmb_class_monday_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterClassGrid(cmb_class_monday.SelectedItem.ToString(), cmb_subno_monday.SelectedIndex.ToString());
        }

        private void cmb_subno_monday_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterClassGrid(cmb_class_monday.SelectedItem.ToString(), cmb_subno_monday.SelectedIndex.ToString());
        }

        private void btn_view_monday_Click(object sender, EventArgs e)
        {
            FillClassTab();
        }

        private void metroComboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_class_tuesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterClassGrid(cmb_class_tuesday.SelectedItem.ToString(), cmb_subno_tuesday.SelectedIndex.ToString());

        }

        private void cm_subno_tuesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterClassGrid(cmb_class_tuesday.SelectedItem.ToString(), cmb_subno_tuesday.SelectedIndex.ToString());

        }

        private void cmb_class_wendsday_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterClassGrid(cmb_class_wendsday.SelectedItem.ToString(), cmb_subno_wendsday.SelectedIndex.ToString());

        }

        private void cmb_subno_wendsday_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterClassGrid(cmb_class_wendsday.SelectedItem.ToString(), cmb_subno_wendsday.SelectedIndex.ToString());

        }

        private void cmb_class_thursday_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterClassGrid(cmb_class_thursday.SelectedItem.ToString(), cmb_subno_thursday.SelectedIndex.ToString());

        }

        private void cmb_subno_thursday_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterClassGrid(cmb_class_thursday.SelectedItem.ToString(), cmb_subno_thursday.SelectedIndex.ToString());

        }

        private void cmb_class_friday_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterClassGrid(cmb_class_friday.SelectedItem.ToString(), cmb_subno_friday.SelectedIndex.ToString());

        }

        private void metroComboBox33_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterClassGrid(cmb_class_friday.SelectedItem.ToString(), metroComboBox33.SelectedIndex.ToString());

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
          //  FillClassTab();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FillClassTab();
        }

        private void btn_update_tuesday_Click(object sender, EventArgs e)
        {
            try
            {

                if (dba.updateClassTable(metroComboBox18.Text.ToString(), metroComboBox19.Text.ToString(), metroTextBox4.Text, metroComboBox6.SelectedItem.ToString(), metroComboBox2.SelectedItem.ToString(), metroComboBox3.SelectedItem.ToString()))
                {


                    MetroMessageBox.Show(this,"Successfully Updated");
                }
                else
                {
                    MetroMessageBox.Show(this, "Error occured");
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,ex.Message);
            }
            // Clear();

            FillClassTab();
        }

        private void btn_update_wendsday_Click(object sender, EventArgs e)
        {
            try
            {

                if (dba.updateClassTable(metroComboBox20.Text.ToString(), metroComboBox21.Text.ToString(), metroTextBox7.Text, metroComboBox8.SelectedItem.ToString(), metroComboBox7.SelectedItem.ToString(), metroComboBox4.SelectedItem.ToString()))
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
            // Clear();

            FillClassTab();
        }

        private void btn_update_thursday_Click(object sender, EventArgs e)
        {
            try
            {

                if (dba.updateClassTable(metroComboBox22.Text.ToString(), metroComboBox23.Text.ToString(), metroTextBox10.Text, metroComboBox10.SelectedItem.ToString(), metroComboBox9.SelectedItem.ToString(), metroComboBox11.SelectedItem.ToString()))
                {


                    MetroMessageBox.Show(this,"Successfully Updated");
                }
                else
                {
                    MetroMessageBox.Show(this, "Error occured");
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,ex.Message);
            }
            // Clear();

            FillClassTab();
        }

        private void btn_update_friday_Click(object sender, EventArgs e)
        {
            try
            {

                if (dba.updateClassTable(metroComboBox24.Text.ToString(), metroComboBox25.Text.ToString(), metroTextBox13.Text, metroComboBox15.SelectedItem.ToString(), metroComboBox14.SelectedItem.ToString(), metroComboBox12.SelectedItem.ToString()))
                {


                    MetroMessageBox.Show(this, "Successfully Updated");
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
            // Clear();

            FillClassTab();
        }

        private void btn_add_tuesday_Click(object sender, EventArgs e)
        {
            if (validateTeacherId(metroTextBox4.Text))
            {
                try
                {
                    if (dba.addClass(metroComboBox18.Text, metroComboBox19.Text, metroTextBox4.Text, metroComboBox6.SelectedItem.ToString(), metroComboBox2.SelectedItem.ToString(), metroComboBox3.SelectedItem.ToString()))
                    {
                        MetroMessageBox.Show(this, "Successfully Added");
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Error occured");
                    }
                }

                catch (Exception ex)
                {
                    MetroMessageBox.Show(this,ex.Message);
                }


                FillClassTab();
            }
        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "DO YOU WANT TO DELETE THE RECORD", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {

                    if (dba.deleteClassShedule(metroComboBox6.SelectedItem.ToString(), metroComboBox3.SelectedItem.ToString()))
                    {


                        MetroMessageBox.Show(this,"Successfully deleted");
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


                FillClassTab();
            }
        }

        private void btn_add_monday_Click(object sender, EventArgs e)
        {
            if (validateTeacherId(metroTextBox3.Text))
            {
                try
                {
                    if (dba.addClass(metroComboBox13.SelectedItem.ToString(), metroComboBox17.SelectedItem.ToString(), metroTextBox3.Text, metroComboBox1.SelectedItem.ToString(), metroComboBox5.SelectedItem.ToString(), metroComboBox16.SelectedItem.ToString()))
                    {
                        MetroMessageBox.Show(this, "Successfully Added");
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Error occured");
                    }
                }

                catch (Exception ex)
                {
                    MetroMessageBox.Show(this,ex.Message);
                }


                FillClassTab();
            }
        }


        

        

        

        

        

        public void Clear()
        {
            
           
            FillClassTab();

            
            
        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           btn_add_monday.Enabled = true;

        }

        private void metroComboBox6_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btn_add_tuesday.Enabled = true;
        }

        private void metroComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_add_wendsday.Enabled = true;
        }

        private void metroComboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_add_thursday.Enabled = true;

        }

        private void metroComboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_add_friday.Enabled = true;

        }

        private void btn_add_wendsday_Click(object sender, EventArgs e)
        {
            
            if(validateTeacherId(metroTextBox7.Text))
            {

            
             try
             {
                if (dba.addClass(metroComboBox20.Text.ToString(), metroComboBox21.Text.ToString(), metroTextBox7.Text, metroComboBox8.SelectedItem.ToString(), metroComboBox7.SelectedItem.ToString(), metroComboBox4.SelectedItem.ToString()))
                {
                    MetroMessageBox.Show(this, "Successfully Added");
                }
                else
                {
                    MetroMessageBox.Show(this, "Error occured");
                }
             }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this,ex.Message);
            }


            FillClassTab();
            
         }
        }

        private void btn_add_thursday_Click(object sender, EventArgs e)
        {
            if (validateTeacherId(metroTextBox10.Text))
            {
                try
                {
                    if (dba.addClass(metroComboBox22.Text.ToString(), metroComboBox23.Text.ToString(), metroTextBox10.Text, metroComboBox10.SelectedItem.ToString(), metroComboBox9.SelectedItem.ToString(), metroComboBox11.SelectedItem.ToString()))
                    {
                        MetroMessageBox.Show(this, "Successfully Added");
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Error occured");
                    }
                }

                catch (Exception ex)
                {
                    MetroMessageBox.Show(this,ex.Message);
                }


                FillClassTab();
            }

        }

        private void btn_add_friday_Click(object sender, EventArgs e)
        {
            if (validateTeacherId(metroTextBox13.Text))
            {
                try
                {
                    if (dba.addClass(metroComboBox24.Text.ToString(), metroComboBox25.Text.ToString(), metroTextBox13.Text, metroComboBox15.SelectedItem.ToString(), metroComboBox14.SelectedItem.ToString(), metroComboBox12.SelectedItem.ToString()))
                    {
                        MetroMessageBox.Show(this, "Successfully Added");
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Error occured");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            FillClassTab();
        }

        private void metroTextButton11_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "DO YOU WANT TO DELETE THE RECORD", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {

                    if (dba.deleteClassShedule(metroComboBox15.SelectedItem.ToString(), metroComboBox12.SelectedItem.ToString()))
                    {


                        MetroMessageBox.Show(this,"Successfully deleted");
                    }
                    else
                    {
                        MetroMessageBox.Show(this,"Error occured");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                FillClassTab();
            }
        }

        private void metroTextButton7_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "DO YOU WANT TO DELETE THE RECORD", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {

                    if (dba.deleteClassShedule(metroComboBox8.SelectedItem.ToString(), metroComboBox4.SelectedItem.ToString()))
                    {


                        MetroMessageBox.Show(this,"Successfully deleted");
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


                FillClassTab();
            }
        }

        private void metroTextButton8_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "DO YOU WANT TO DELETE THE RECORD", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {

                    if (dba.deleteClassShedule(metroComboBox10.SelectedItem.ToString(), metroComboBox11.SelectedItem.ToString()))
                    {


                        MetroMessageBox.Show(this,"Successfully deleted");
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


                FillClassTab();
            }
        }

        private void metroComboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterClassGridClassId(metroComboBox26.Text);
        }

        private void metroComboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterClassGridClassId(metroComboBox27.Text);
        }

        private void metroComboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterClassGridClassId(metroComboBox28.Text);
        }

        private void metroComboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterClassGridClassId(metroComboBox29.Text);
        }

        private void metroComboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterClassGridClassId(metroComboBox30.Text);
        }

        public bool validateTeacherId(string a)
        {
          //  string b = a.Substring(2,(a.Length-2));

            if(a.Length == 7)
            {
                if(   !string.IsNullOrWhiteSpace(a) && a.StartsWith("ST") )
                {
                    if( a.Substring(2,(a.Length-2)).All(char.IsDigit))
                    {
                        return true;
                    }
                    else
                    {
                        MetroMessageBox.Show(this,"PROVIDE CORRECT TEACHER ID");
                        metroTextBox13.Focus();
                        return false;
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "PROVIDE CORRECT TEACHER ID");
                    metroTextBox13.Focus();
                    return false;
                }
            }
            else
            {
                MetroMessageBox.Show(this, "PROVIDE CORRECT TEACHER ID");
                metroTextBox13.Focus();
                return false;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextButton13_Click(object sender, EventArgs e)
        {
            FillClassTab();
        }

        private void metroTextButton16_Click(object sender, EventArgs e)
        {
            FillClassTab();
        }

        private void metroTextButton17_Click(object sender, EventArgs e)
        {
            FillClassTab();
        }

        private void metroTextButton19_Click(object sender, EventArgs e)
        {
            FillClassTab();
        }

        private void metroTextButton20_Click(object sender, EventArgs e)
        {
            FillClassTab();
        }

        private void metroTextButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SheduleHome = new SheduleHome();
            SheduleHome.Closed += (s, args) => this.Close();
            SheduleHome.Show();
        }

        private void metroTextButton10_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SheduleHome = new SheduleHome();
            SheduleHome.Closed += (s, args) => this.Close();
            SheduleHome.Show();
        }

        private void metroTextButton14_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SheduleHome = new SheduleHome();
            SheduleHome.Closed += (s, args) => this.Close();
            SheduleHome.Show();
        }

        private void metroTextButton18_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SheduleHome = new SheduleHome();
            SheduleHome.Closed += (s, args) => this.Close();
            SheduleHome.Show();
        }


        

        

        

        
    }
}
