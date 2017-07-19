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
using System.Data;
using MetroFramework;

namespace performance
{
    public partial class ManageTeam : MetroForm
    {
        DataCon dc;
        int row = -1;
        public ManageTeam()
        {
            dc = new DataCon();

            InitializeComponent();
        }

        private void ManageTeam_Load(object sender, EventArgs e)
        {
            fillGrid("select t.name,t.size,aid,teamleader, s.name from team t, applicant a, student s where t.name = a.teamid and s.admission_no = a.studentid");
            setApplicantCombo();
            setTeamCmb();
            
        }

        public void fillGrid(String query) {
            dc = new DataCon(); 
            dc.openCon();
            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGrid3.DataSource = dt;
            //DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            //col.UseColumnTextForButtonValue = true;
            //col.Text = "Delete";
            //col.Name = "deleteUsr";
            //metroGrid3.Columns.Add(col);
            dc.closeCon();
        
        }
        public void fillGrid2(String query)
        {
            dc = new DataCon(); 
            dc.openCon();
            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGrid3.DataSource = dt;
            //DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            //col.UseColumnTextForButtonValue = true;
            //col.Text = "Delete";
            //col.Name = "deleteUsr";
            //metroGrid3.Columns.Add(col);
            dc.closeCon();

        }
        private void metroButton14_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox15.Text) || (String.IsNullOrEmpty(metroTextBox13.Text)))))
            {
                String command = "INSERT INTO team VALUES('" + metroTextBox15.Text + "', '" + Convert.ToInt32(metroTextBox13.Text) + "');";
                //String command2 = "update applicant set teamid ='" + metroTextBox15.Text + "', teamleader=1 where aid like '" + metroTextBox14.Text + "'";
                new DataCon().execInsert(command);
                //new DataCon().execInsert(command2);
                MetroMessageBox.Show(this,"Added");
                fillGrid("select t.name,t.size,aid,teamleader, s.name from team t, applicant a, student s where t.name = a.teamid and s.admission_no = a.studentid");
            }
            else
            {

                MessageBox.Show("Invalid or incomplete fields. Please correct and try again!");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox15.Text) || (String.IsNullOrEmpty(metroTextBox13.Text)))))
            {
                String command = "update team set size ='" + Convert.ToInt32(metroTextBox13.Text) + "' where name like '" + metroTextBox15.Text + "'";
                //String command2 = "update applicant set teamid ='" + metroTextBox15.Text + "', teamleader=1 where aid like '" + metroTextBox14.Text + "'";
                new DataCon().execInsert(command);
                //new DataCon().execInsert(command2);
                MetroMessageBox.Show(this, "Updated!");
                fillGrid("select t.name,t.size,aid,teamleader, s.name from team t, applicant a, student s where t.name = a.teamid and s.admission_no = a.studentid");
            }
            else
            {

                MessageBox.Show("Invalid or incomplete fields. Please correct and try again!");
            }
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {


            String command2 = "update applicant set teamid ='" + null + "'  where aid like '" + Convert.ToInt32(metroComboBox1.SelectedValue) + "';update applicant set teamid ='" + metroComboBox2.SelectedValue + "'  where aid like '" + Convert.ToInt32(metroComboBox1.SelectedValue) + "';";

                new DataCon().execInsert(command2);

                fillGrid("select t.name,t.size,aid,teamleader, s.name from team t, applicant a, student s where t.name = a.teamid and s.admission_no = a.studentid");
                MetroMessageBox.Show(this, "Updated!");
        }

        private void metroButton16_Click(object sender, EventArgs e)
        {

            String command2 = "update applicant set teamid =NULL  where aid like '" + Convert.ToInt32(metroComboBox1.SelectedValue) + "'";

            new DataCon().execInsert(command2); 

            fillGrid("select t.name,t.size,aid,teamleader, s.name from team t, applicant a, student s where t.name = a.teamid and s.admission_no = a.studentid");
            MetroMessageBox.Show(this, "Deleted");
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void setTeamCmb()
        {
            SqlDataReader dr = dc.execSelect("select name from team");
            while (dr.Read())
            {
                metroComboBox2.Items.Add(Convert.ToString(dr[0]));
            }
            metroComboBox2.SelectedIndex = 0;
        }

        private void setApplicantCombo() {
            String value = "applicantID";
            String dName = "applicantName";
            String query = "select a.aid, s.admission_no+' '+s.name+' '+s.surname as 'name' from student s, applicant a where s.admission_no = a.studentid";
            DataTable dt = dc.fillCombo(value, dName, query);
            metroComboBox1.ValueMember = value;
            metroComboBox1.DisplayMember = dName;
            metroComboBox1.DataSource = dt;
            metroComboBox1.SelectedIndex = 0;
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this, Convert.ToString(metroComboBox2.SelectedItem));
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox17_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox17_TextChanged(object sender, EventArgs e)
        {
            fillGrid2("select t.name,t.size,aid,teamleader, s.name from team t, applicant a, student s where t.name = a.teamid and s.admission_no = a.studentid and t.name like '%" + metroTextBox17 .Text+ "%'");
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (row >= 0)
            {
                new DataCon().execInsert("update applicant set teamid = null, teamleader=0 where teamid like '" + metroGrid3.Rows[row].Cells[0].Value + "';delete from team where name like '" + metroGrid3.Rows[row].Cells[0].Value + "'; ");
                MetroMessageBox.Show(this, "Deleted");
            }
            else
                MetroMessageBox.Show(this, "Please select a record to delete");


            row = 0;
            String query = "select t.name,t.size,aid,teamleader, s.name from team t, applicant a, student s where t.name = a.teamid and s.admission_no = a.studentid";
            fillGrid(query);
        }

        private void metroGrid3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }

        private void ManageTeam_FormClosed(object sender, FormClosedEventArgs e)
        {
            new ManageExtraCurricular().Show();
            this.Hide();
        }
    }
}
