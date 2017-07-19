using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace performance
{
    public partial class ManageAwardsPrizes : MetroForm
    {
        DataCon dc;
        int row = -1;
        public ManageAwardsPrizes()
        {
            dc = new DataCon();
            InitializeComponent();
        }
        private void fillGrid(String query)
        {
            dc.openCon();

            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGrid1.DataSource = dt;
            //DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            //col.UseColumnTextForButtonValue = true;
            //col.Text = "Delete";
            //col.Name = "deleteUsr";
            //metroGrid1.Columns.Add(col);
            dc.closeCon();
        }
        private void ManageAwardsPrizes_Load(object sender, EventArgs e)
        {
            fillGrid("SELECT * FROM prize");
            setCompetitionCombo();
            setApplicantCombo();
            setCompetitionCombo2();
            metroComboBox7.SelectedIndex = 0;
            metroTabControl1.SelectedIndex =0;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton11_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            new PerformanceMenu().Show();
            this.Hide();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            
        }
        private void fillGrid2(String query)
        {
            dc.openCon();

            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGrid1.DataSource = dt;
            dc.closeCon();
        }

        private void ManageAwardsPrizes_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoggedIn.logOut();
            Application.Exit();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Columns[e.ColumnIndex].Name == "deleteUsr")
            {
                String pid = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
         
                DataCon d2 = new DataCon();
                String query = "delete from prize where prizeid like '"+pid+"'";
                d2.execInsert(query);
                String query2 = "SELECT * FROM prize";
                fillGrid2(query2);
            } 
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox1.Text) || (String.IsNullOrEmpty(metroTextBox3.Text)) || (String.IsNullOrEmpty(metroTextBox4.Text) || (String.IsNullOrEmpty(metroTextBox5.Text))))))
            {
                int id = Convert.ToInt32(metroTextBox1.Text);
                float price = (float)Convert.ToDouble(metroTextBox5.Text);
                String command = "INSERT INTO prize VALUES('" + id + "', '" + metroTextBox3.Text + "', '" + metroTextBox4.Text + "', '" + price + "');";
                new DataCon().execInsert(command);
                MetroMessageBox.Show(this, "Added!");
                fillGrid2("SELECT * FROM prize");
            }
            else {
                MessageBox.Show("Invalid or Inccomplete fields. please correct them and try again!");
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox1.Text) || (String.IsNullOrEmpty(metroTextBox3.Text)) || (String.IsNullOrEmpty(metroTextBox4.Text) || (String.IsNullOrEmpty(metroTextBox5.Text))))))
            {
                DataCon d3 = new DataCon();
                String command = "UPDATE prize set name='" + metroTextBox3.Text + "', price='" + Convert.ToDouble(metroTextBox5.Text) + "', sponsor = '" + metroTextBox4.Text + "' where prizeid ='" + metroTextBox1.Text + "'";
                d3.execInsert(command);
                MetroMessageBox.Show(this, "Updated");
                fillGrid2("SELECT * FROM prize");
                
            }
            else
            {
                MessageBox.Show("Invalid or Inccomplete fields. please correct them and try again!");
            }
        }

        private void setCompetitionCombo()
        {
            String value = "compID";
            String dName = "compName";
            String query = "select distinct c.compid, c.name from competition c,participate p where c.compid = p.compid";
            DataTable dt = dc.fillCombo2(value, dName, query, false);
          
                metroComboBox1.ValueMember = value;
                metroComboBox1.DisplayMember = dName;
                metroComboBox1.DataSource = dt;
                metroComboBox1.SelectedIndex = 0;
                metroComboBox6.ValueMember = value;
                metroComboBox6.DisplayMember = dName;
                metroComboBox6.DataSource = dt;
                metroComboBox6.SelectedIndex = 0;
            

                metroComboBox3.SelectedIndex = 0;
                metroComboBox5.SelectedIndex = 0;
            
        }
        private void setApplicantCombo()
        {
            String value = "appID";
            String dName = "appName";
            String query = "select distinct a.aid, s.admission_no+' '+s.name+' '+s.surname as 'name' from student s, applicant a, participate p where s.admission_no = a.studentid and a.aid = p.aid";
            DataTable dt = dc.fillCombo2(value, dName, query, false);

            metroComboBox4.ValueMember = value;
            metroComboBox4.DisplayMember = dName;
            metroComboBox4.DataSource = dt;
            metroComboBox4.SelectedIndex = 0;
        }

        private void setCompetitionCombo2()
        {
            String value = "compID";
            String dName = "compName";
            String query = "select c.compid, c.name from competition c,participate p where c.compid = p.compid and p.aid ='"+metroComboBox4.SelectedValue+"'";
            DataTable dt = dc.fillCombo2(value, dName, query, false);

            metroComboBox7.ValueMember = value;
            metroComboBox7.DisplayMember = dName;
            metroComboBox7.DataSource = dt;
            
        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCompetitionCombo2();
          
                metroComboBox7.SelectedIndex = 0;
           
        }

        private void metroButton11_Click_1(object sender, EventArgs e)
        {
            LoggedIn.logOut();
            Application.Restart();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            if (row >= 0)
            {
                new DataCon().execInsert("update participate set prizeid =null where prizeid= '" + Convert.ToInt32(metroGrid1.Rows[row].Cells[0].Value) + "';delete from prize where prizeid = '" + Convert.ToInt32(metroGrid1.Rows[row].Cells[0].Value) + "';");
                MetroMessageBox.Show(this, "Deleted");
            }
            else
                MetroMessageBox.Show(this, "Please select a record to delete");


            row = 0;
            fillGrid("SELECT * FROM prize");
        }

        private void metroGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = null;
           SqlDataReader dr2 = null;
            switch(Convert.ToString(metroComboBox3.SelectedItem)){
                case "1st place":
                     dr = new DataCon().execSelect("select COUNT(*) from participate where position =1 and compid ='"+metroComboBox1.SelectedValue+"'");
                     dr2 = new DataCon().execSelect("select price from participate p1, prize p where position =1 and compid ='" + metroComboBox1.SelectedValue + "' and p.prizeid = p1.prizeid");
                    break;
                case "1st, 2nd place":
                      dr = new DataCon().execSelect("select COUNT(*) from participate where position =1 and compid ='"+metroComboBox1.SelectedValue+"'");
                     dr2 = new DataCon().execSelect("select price from participate p1, prize p where position =1 and compid ='" + metroComboBox1.SelectedValue + "' and p.prizeid = p1.prizeid");
                   
                    break;
                case "1st, 2nd, 3rd place":
                     dr = new DataCon().execSelect("select COUNT(*) from participate where position =1 and compid ='"+metroComboBox1.SelectedValue+"'");
                    dr2 = new DataCon().execSelect("select price from participate p1, prize p where position =1 and compid ='" + metroComboBox1.SelectedValue + "' and p.prizeid = p1.prizeid");
                    
                    break;
            }
            try
            {
                while (dr.Read())
                {
                    metroLabel11.Text = dr[0] + "";
                }
                dr.Close();
                Double d =0.0;
                while(dr2.Read()){
                    d = d+Convert.ToDouble(dr2[0]);
                }
                dr2.Close();
                metroLabel13.Text = d+"";
            }catch(Exception e2){
                MessageBox.Show(e2.Message);
            }
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = null;
            
            switch (Convert.ToString(metroComboBox5.SelectedItem))
            {
                case "1st place":
                    dr = new DataCon().execSelect("select COUNT(*) from participate where position =1 and compid ='" + metroComboBox6.SelectedValue + "'");
                    
                    break;
                case "1st, 2nd place":
                    dr = new DataCon().execSelect("select COUNT(*) from participate where position =1 and compid ='" + metroComboBox6.SelectedValue + "'");
                    

                    break;
                case "1st, 2nd, 3rd place":
                    dr = new DataCon().execSelect("select COUNT(*) from participate where position =1 and compid ='" + metroComboBox6.SelectedValue + "'");
                    

                    break;
            }
            try
            {
                while (dr.Read())
                {
                    metroLabel16.Text = dr[0] + "";
                }
                dr.Close();
                
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
            
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            fillGrid2("SELECT * FROM prize where name like '%" + metroTextBox2.Text + "%'");
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            new Certificate(Convert.ToInt32(metroComboBox4.SelectedValue), Convert.ToInt32(metroComboBox7.SelectedValue)).Show();
        }
    }
}
