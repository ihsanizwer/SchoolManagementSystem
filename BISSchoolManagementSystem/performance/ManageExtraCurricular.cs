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
using SQLServerDatabaseAccess;
using MetroFramework;

namespace performance
{
    public partial class ManageExtraCurricular : MetroForm
    {
        int row = 0;
        DataCon dc;
        public ManageExtraCurricular()
        {
            dc = new DataCon();
            InitializeComponent();
        }

        private void ManageExtraCurricular_Load(object sender, EventArgs e)
        {
            metroDateTime3.Format = DateTimePickerFormat.Custom;
            metroDateTime3.CustomFormat = "HH:mm"; 
            metroDateTime3.ShowUpDown = true;
            metroDateTime4.Format = DateTimePickerFormat.Custom;
            metroDateTime4.CustomFormat = "HH:mm";
            metroDateTime4.ShowUpDown = true;
            metroTabControl2.SelectedIndex = 0;
            fillGrid("SELECT * FROM competition",4);
            fillGrid("select a.aid,studentid, s.name, teamid, teamleader,p.compid, category, prizeid, position from applicant a, participate p, student s where a.aid = p.aid AND a.studentid=s.admission_no", 2);
           // fillGrid("SELECT name,size,aid,teamleader,  studentid  from applicant a, team t where a.teamid=t.name AND a.teamleader=1", 3);
            fillGrid("select u.name, u.annual_fee,s1.name as 'president', s2.name as 'v. president', s3.name as 'secretary', s4.name as 'treasurer' from student s1, student s2, student s3, student s4, unions u where u.president=s1.admission_no AND u.v_president=s2.admission_no AND u.secretary = s3.admission_no AND u.treasurer = s4.admission_no", 1);
            setTeamCmb();
        }

        private void tableLayoutPanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillGrid(String query, int i)
        {
            dc.openCon();
            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (i == 1)
            {
                metroGrid1.DataSource = dt;
                //DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                //col.UseColumnTextForButtonValue = true;
                //col.Text = "Delete";
                //col.Name = "deleteUsr";
                //metroGrid1.Columns.Add(col);
                dc.closeCon();
            }
            else if (i == 2)
            {
                metroGrid2.DataSource = dt;
                //DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                //col.UseColumnTextForButtonValue = true;
                //col.Text = "Delete";
                //col.Name = "deleteUsr";
                //metroGrid2.Columns.Add(col);
                dc.closeCon();
            }
            else if (i == 3)
            {
            //    metroGrid3.DataSource = dt;
            //    DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            //    col.UseColumnTextForButtonValue = true;
            //    col.Text = "Delete";
            //    col.Name = "deleteUsr";
            //    metroGrid3.Columns.Add(col);
            //    dc.closeCon();
            }
            else
            {
                metroGrid4.DataSource = dt;
                //DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                //col.UseColumnTextForButtonValue = true;
                //col.Text = "Delete";
                //col.Name = "deleteUsr";
                //metroGrid4.Columns.Add(col);
                dc.closeCon();
            }
        }
        private void fillGrid(String query, int i, int j)
        {
            dc.openCon();
            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch(Exception er){
                MessageBox.Show(er.Message);
            }
            if (i == 1)
            {
                metroGrid1.DataSource = dt;
                dc.closeCon();
            }
            else if (i==2)
            {
                metroGrid2.DataSource = dt;
                dc.closeCon();
            }
            else if (i == 3)
            {
                //metroGrid3.DataSource = dt;
                //dc.closeCon();
            }
            else {
                metroGrid4.DataSource = dt;
                dc.closeCon();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new PerformanceMenu().Show();
            this.Hide();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            fillGrid("SELECT * FROM competition WHERE name like '%"+metroTextBox24.Text+"%'",4, 1);
            metroGrid4.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;
            metroGrid4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
 
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            fillGrid("SELECT a.aid,studentid, s.name, teamid, teamleader, category, prizeid, position from applicant a, participate p, student s where a.aid = p.aid AND a.studentid=s.admission_no AND s.name like '%"+metroTextBox2.Text+"%'", 2, 1);
        }

        //private void metroButton8_Click(object sender, EventArgs e)
        //{
        //    fillGrid("SELECT name,size,aid,teamleader,  studentid  from applicant a, team t where a.teamid=t.name AND a.teamleader=1 AND t.name like '%"+metroTextBox17.Text+"%'", 3, 1);
        //}

        private void metroButton2_Click(object sender, EventArgs e)
        {
            fillGrid("select u.name, u.annual_fee,s1.name as 'president', s2.name as 'v. president', s3.name as 'secretary', s4.name as 'treasurer' from student s1, student s2, student s3, student s4, unions u where u.president=s1.admission_no AND u.v_president=s2.admission_no AND u.secretary = s3.admission_no AND u.treasurer = s4.admission_no AND u.name like '%"+metroTextBox1.Text+"%'",1,1);
        }

        private void ManageExtraCurricular_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroGrid4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid4.Columns[e.ColumnIndex].Name == "deleteUsr")
            {
                String cid = metroGrid4.Rows[e.RowIndex].Cells[0].Value.ToString();
                
                DataCon d2 = new DataCon();
                String query = "delete from competition where compid like '"+cid+"'";
                d2.execInsert(query);
                String query2 = "SELECT * FROM competition";
                fillGrid(query2, 4, 2);
            } 
        }

        private void metroGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            //String aid = metroGrid2.Rows[e.RowIndex].Cells[0].Value.ToString();

            //DataCon d2 = new DataCon();
            //String query = "delete from applicant where aid like '" + aid + "'";
            //d2.execInsert(query);
            //String query2 = "SELECT * FROM applicant";
            //fillGrid(query2, 2, 2);
        }

        //private void metroGrid3_CellClick(object sender, DataGridViewCellEventArgs e)
        ////{
        ////    String name = metroGrid3.Rows[e.RowIndex].Cells[0].Value.ToString();

        ////    DataCon d2 = new DataCon();
        ////    String query = "delete from team where name like '" + name + "'";
        ////    d2.execInsert(query);
        ////    String query2 = "SELECT name,size,aid,teamleader,  studentid  from applicant a, team t where a.teamid=t.name AND a.teamleader=1";
        ////    fillGrid(query2, 3, 2);
        ////}

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            //String name = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();

            //DataCon d2 = new DataCon();
            //String query = "delete from unions where name like '" + name + "'";
            //d2.execInsert(query);
            //String query2 = "select u.name, u.annual_fee,s1.name as 'president', s2.name as 'v. president', s3.name as 'secretary', s4.name as 'treasurer' from student s1, student s2, student s3, student s4, unions u where u.president=s1.admission_no AND u.v_president=s2.admission_no AND u.secretary = s3.admission_no AND u.treasurer = s4.admission_no";
            //fillGrid(query2, 1, 2);
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {

            metroDateTime1.Format = DateTimePickerFormat.Custom;
            metroDateTime1.CustomFormat = "yyyy-MM-dd";
            metroDateTime2.Format = DateTimePickerFormat.Custom;
            metroDateTime2.CustomFormat = "yyyy-MM-dd";
            String st = metroDateTime1.Text + " " + metroDateTime3.Text;
            String st2 = metroDateTime2.Text + " " + metroDateTime4.Text;

            if (!((DateTime.Compare(Convert.ToDateTime(st), DateTime.Now) < 0) || (DateTime.Compare(Convert.ToDateTime(st2), DateTime.Now) < 0) || (DateTime.Compare(Convert.ToDateTime(st), Convert.ToDateTime(st2)) > 0) || (String.IsNullOrEmpty(metroTextBox22.Text) || (String.IsNullOrEmpty(metroTextBox20.Text) ))))
            {

                String command = "INSERT INTO competition VALUES('" + Convert.ToInt32(metroTextBox22.Text) + "','" + metroTextBox20.Text + "', '" + st + "', '" + st2 + "');";
                new DataCon().execInsert(command);
                MessageBox.Show("Added");
                fillGrid("SELECT * FROM competition", 4, 1);
            }
            else {
                MessageBox.Show("Invalid or Incomplete fields. Please correct and try again!");
            }
            }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox19.Text) || (String.IsNullOrEmpty(metroTextBox21.Text)))))
            {String command;
            if (metroCheckBox2.Checked == false)
            {   
                command = "INSERT INTO applicant VALUES('" + Convert.ToInt32(metroTextBox19.Text) + "', NULL, 0, '" + metroTextBox21.Text + "');";
            }
            else
            {
                if (metroCheckBox1.Checked == false)
                    command = "INSERT INTO applicant VALUES('" + Convert.ToInt32(metroTextBox19.Text) + "','" + Convert.ToString(metroComboBox1.SelectedItem) + "', 0, '" + metroTextBox21.Text + "');";
                else {
                    command = "INSERT INTO applicant VALUES('" + Convert.ToInt32(metroTextBox19.Text) + "','" + Convert.ToString(metroComboBox1.SelectedItem) + "', 1, '" + metroTextBox21.Text + "');";
                }
            }
                new DataCon().execInsert(command);
                MessageBox.Show("Added");
                fillGrid("select a.aid,studentid, s.name, teamid, teamleader,p.compid, category, prizeid, position from applicant a, participate p, student s where a.aid = p.aid AND a.studentid=s.admission_no", 2, 1);
            }
            else {
                MessageBox.Show("Invalid or incomplete fields. Please correct and try again!");
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox3.Text) || (String.IsNullOrEmpty(metroTextBox11.Text)) || (String.IsNullOrEmpty(metroTextBox29.Text) || (String.IsNullOrEmpty(metroTextBox4.Text)) || (String.IsNullOrEmpty(metroTextBox12.Text))))))
            {
                String command = "INSERT INTO participate VALUES('" + Convert.ToInt32(metroTextBox11.Text) + "','" + Convert.ToInt32(metroTextBox3.Text) + "','" + metroTextBox29.Text + "', '" + Convert.ToInt32(metroTextBox4.Text) + "', '" + Convert.ToInt32(metroTextBox12.Text) + "');";
                new DataCon().execInsert(command);
                MessageBox.Show("Added");
                fillGrid("select a.aid,studentid, s.name, teamid, teamleader,p.compid, category, prizeid, position from applicant a, participate p, student s where a.aid = p.aid AND a.studentid=s.admission_no", 2, 1);
            }
            else {

                MessageBox.Show("Invalid or incomplete fields. Please correct and try again!");
            }

        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox5.Text) || (String.IsNullOrEmpty(metroTextBox6.Text)) || (String.IsNullOrEmpty(metroTextBox7.Text) || (String.IsNullOrEmpty(metroTextBox8.Text)) || (String.IsNullOrEmpty(metroTextBox9.Text) || (String.IsNullOrEmpty(metroTextBox10.Text)))))))
            {
                String command = "INSERT INTO unions VALUES( '" + metroTextBox7.Text + "','" + metroTextBox5.Text + "','" + metroTextBox6.Text + "','" + metroTextBox8.Text + "','" + metroTextBox9.Text + "','" + metroTextBox10.Text + "');";

                new DataCon().execInsert(command);

                MessageBox.Show("Added");
                fillGrid("select u.name, u.annual_fee,s1.name as 'president', s2.name as 'v. president', s3.name as 'secretary', s4.name as 'treasurer' from student s1, student s2, student s3, student s4, unions u where u.president=s1.admission_no AND u.v_president=s2.admission_no AND u.secretary = s3.admission_no AND u.treasurer = s4.admission_no", 1, 1);
            }
            else {
                MessageBox.Show("Invalid or incomplete fields. Please correct and try again!");
            }
        }

        private void metroButton17_Click(object sender, EventArgs e)
        {
          

                metroDateTime1.Format = DateTimePickerFormat.Custom;
                metroDateTime1.CustomFormat = "yyyy-MM-dd";
                metroDateTime2.Format = DateTimePickerFormat.Custom;
                metroDateTime2.CustomFormat = "yyyy-MM-dd";
                String st = metroDateTime1.Text + " " + metroDateTime3.Text;
                String st2 = metroDateTime2.Text + " " + metroDateTime4.Text;
                if (!((DateTime.Compare(Convert.ToDateTime(st), DateTime.Now) < 0) || (DateTime.Compare(Convert.ToDateTime(st2), DateTime.Now) < 0) || (DateTime.Compare(Convert.ToDateTime(st), Convert.ToDateTime(st2)) > 0) || (String.IsNullOrEmpty(metroTextBox22.Text) || (String.IsNullOrEmpty(metroTextBox20.Text)))))
                {

                String command = "Update competition set name='" + metroTextBox20.Text + "',start_time='" + st + "',end_time='" + st2 + "' where compid like '" + metroTextBox22.Text + "';";
                new DataCon().execInsert(command);
                fillGrid("SELECT * FROM competition", 4, 1);

            }
            else {
                MessageBox.Show("Invalid or Incomplete fields please complete and try again!");
            }
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox19.Text) || (String.IsNullOrEmpty(metroTextBox21.Text)))))
            {
                String command;
                if (metroCheckBox2.Checked == false)
                {
                    command = "UPDATE applicant set teamid = NULL,teamleader = 'false', studentid ='" + metroTextBox21.Text + "' where aid ='" + Convert.ToInt32(metroTextBox19.Text) + "';";
                }
                else
                {
                    if (metroCheckBox1.Checked == false)
                        command = "UPDATE applicant set teamid = '"+Convert.ToString(metroComboBox1.SelectedItem)+"', teamleader='false',  studentid ='" + metroTextBox21.Text + "' where aid ='"+Convert.ToInt32(metroTextBox19.Text)+"';";
                    else
                    {
                        command = "UPDATE applicant set teamid = '" + Convert.ToString(metroComboBox1.SelectedItem) + "', teamleader='true',  studentid ='" + metroTextBox21.Text + "' where aid ='" + Convert.ToInt32(metroTextBox19.Text) + "';";
                    }
                }
                new DataCon().execInsert(command);
                MessageBox.Show("Updated!");
                fillGrid("select a.aid,studentid, s.name, teamid, teamleader, category, prizeid, position from applicant a, participate p, student s where a.aid = p.aid AND a.studentid=s.admission_no", 2, 1);
            }
            else
            {
                MessageBox.Show("Invalid or incomplete fields. Please correct and try again!");
            }
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox3.Text) || (String.IsNullOrEmpty(metroTextBox11.Text)) || (String.IsNullOrEmpty(metroTextBox29.Text) || (String.IsNullOrEmpty(metroTextBox4.Text)) || (String.IsNullOrEmpty(metroTextBox12.Text))))))
            {
                String command = "UPDATE participate set position='" + Convert.ToInt32(metroTextBox4.Text) + "', category='" + metroTextBox29.Text + "', prizeid='" + Convert.ToInt32(metroTextBox12.Text) + "' where compid='" + Convert.ToInt32(metroTextBox11.Text) + "' and aid ='" + Convert.ToInt32(metroTextBox3.Text) + "'";
                new DataCon().execInsert(command);

                fillGrid("select a.aid,studentid, s.name, teamid, teamleader,p.compid, category, prizeid, position from applicant a, participate p, student s where a.aid = p.aid AND a.studentid=s.admission_no", 2, 1);
            }
            else {

                MessageBox.Show("Invalid or incomplete fields please complete and try again!");
            }
        
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton16_Click(object sender, EventArgs e)
        {
        
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox5.Text) || (String.IsNullOrEmpty(metroTextBox6.Text)) || (String.IsNullOrEmpty(metroTextBox7.Text) || (String.IsNullOrEmpty(metroTextBox8.Text)) || (String.IsNullOrEmpty(metroTextBox9.Text) || (String.IsNullOrEmpty(metroTextBox10.Text)))))))
            {

                String command = "update unions set president='" + metroTextBox6.Text + "', v_president='" + metroTextBox8.Text + "', secretary='" + metroTextBox9.Text + "', treasurer='" + metroTextBox10.Text + "', annual_fee='" + Convert.ToInt32(metroTextBox5.Text) + "' where name like '" + metroTextBox7.Text + "';";

                new DataCon().execInsert(command);


                fillGrid("select u.name, u.annual_fee,s1.name as 'president', s2.name as 'v. president', s3.name as 'secretary', s4.name as 'treasurer' from student s1, student s2, student s3, student s4, unions u where u.president=s1.admission_no AND u.v_president=s2.admission_no AND u.secretary = s3.admission_no AND u.treasurer = s4.admission_no", 1, 1);
            }
            else {

                MessageBox.Show("Invalid or incomplete fields please complete and try again!");
            }
        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton18_Click(object sender, EventArgs e)
        {

        }

        private void metroButton18_Click_1(object sender, EventArgs e)
        {
            new ManageTeam().Show();
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //MetroMessageBox.Show(this, Convert.ToString(metroComboBox1.SelectedItem));

        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (metroCheckBox1.Checked == true)
            {
                metroCheckBox2.Checked = true;
                metroComboBox1.Enabled = true;
            }
            else
                metroComboBox1.Enabled = false;
        }

        private void setTeamCmb() {
            
            SqlDataReader dr = dc.execSelect("select name from team");
            while(dr.Read()){
                metroComboBox1.Items.Add(Convert.ToString(dr[0]));
             }
            metroComboBox1.SelectedIndex = 0;
            dc.closeCon();
        }

        private void metroButton22_Click(object sender, EventArgs e)
        {
            if (row >= 0)
            {
                new DataCon().execInsert("delete from participate where compid like '" + Convert.ToInt32(metroGrid4.Rows[row].Cells[0].Value) + "';delete from competition where compid like '" + Convert.ToInt32(metroGrid4.Rows[row].Cells[0].Value) + "';");
                MetroMessageBox.Show(this, "Deleted");
            }
            else
                MetroMessageBox.Show(this, "Please select a record to delete");


            row = 0;
            fillGrid("SELECT * FROM competition", 4);
        }

        private void metroGrid4_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }

        private void metroButton21_Click(object sender, EventArgs e)
        {
            if (row >= 0)
            {
                new DataCon().execInsert("delete from unions where name like '" + metroGrid1.Rows[row].Cells[0].Value + "';");
                MetroMessageBox.Show(this, "Deleted");
            }
            else
                MetroMessageBox.Show(this, "Please select a record to delete");


            row = 0;
            fillGrid("select u.name, u.annual_fee,s1.name as 'president', s2.name as 'v. president', s3.name as 'secretary', s4.name as 'treasurer' from student s1, student s2, student s3, student s4, unions u where u.president=s1.admission_no AND u.v_president=s2.admission_no AND u.secretary = s3.admission_no AND u.treasurer = s4.admission_no", 1);
        }

        private void metroButton20_Click(object sender, EventArgs e)
        {

        }

        private void metroButton19_Click(object sender, EventArgs e)
        {
            if (row >= 0)
            {
                new DataCon().execInsert("delete from participate where aid like '" + Convert.ToInt32(metroGrid2.Rows[row].Cells[0].Value) + "';delete from applicant where aid like '" + Convert.ToInt32(metroGrid2.Rows[row].Cells[0].Value) + "';");
                MetroMessageBox.Show(this, "Deleted");
            }
            else
                MetroMessageBox.Show(this, "Please select a record to delete");


            row = 0;
            fillGrid("select a.aid,studentid, s.name, teamid, teamleader,p.compid, category, prizeid, position from applicant a, participate p, student s where a.aid = p.aid AND a.studentid=s.admission_no", 2);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (metroCheckBox2.Checked == true)
                metroComboBox1.Enabled = true;
            else
                metroComboBox1.Enabled = false;
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            LoggedIn.logOut();
            Application.Restart();
        }

        private void ManageExtraCurricular_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoggedIn.logOut();
            Application.Exit();
        }

        private void metroTextBox24_TextChanged(object sender, EventArgs e)
        {
            fillGrid("SELECT * FROM competition WHERE name like '%" + metroTextBox24.Text + "%'", 4, 1);
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            fillGrid("SELECT a.aid,studentid, s.name, teamid, teamleader, category, prizeid, position from applicant a, participate p, student s where a.aid = p.aid AND a.studentid=s.admission_no AND s.name like '%" + metroTextBox2.Text + "%'", 2, 1);
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            fillGrid("select u.name, u.annual_fee,s1.name as 'president', s2.name as 'v. president', s3.name as 'secretary', s4.name as 'treasurer' from student s1, student s2, student s3, student s4, unions u where u.president=s1.admission_no AND u.v_president=s2.admission_no AND u.secretary = s3.admission_no AND u.treasurer = s4.admission_no AND u.name like '%" + metroTextBox1.Text + "%'", 1, 1);
        }
       
    }


}
