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
using System.Data;
using System.Data.SqlClient;
using MetroFramework;

namespace AdministrativeCommunicationSystem
{
    public partial class Communication : MetroForm
    {
        List<String> recList;
        DataCon dc;
        int counter2 = 0;
        Boolean ssl = true;
        int row = -1;
        public Communication()
        {
            InitializeComponent();
        }
        public Communication(List<String> precList)
        {
            
            InitializeComponent();
            recList = precList;
            metroLabel10.Text = "<Recipients List>";
        }

        private void Communication_Load(object sender, EventArgs e)
        {
            dc = new DataCon();
            metroTabControl1.SelectedIndex = 0;
            metroTabControl2.SelectedIndex = 0;
            metroComboBox2.SelectedIndex = 0;
            String query = "SELECT * FROM notification";
            String query2 = "SELECT * FROM email";
            fillGrid(query, 1);
            fillGrid(query2, 2);
            controlAccess();
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        
        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            List<String> rec = new List<string>();
            if(!((DateTime.Compare(Convert.ToDateTime(metroDateTime1.Text), DateTime.Now)<0) || (String.IsNullOrEmpty(metroTextBox2.Text)||(String.IsNullOrEmpty(metroTextBox3.Text) )))){
            String fd = metroDateTime1.Value.ToString("yyyy-MM-dd");
            DataCon dc1 = new DataCon();
            if (metroCheckBox2.Checked == false)
            {
                SqlDataReader dr = dc1.execSelect("SELECT staff_id from users where access_level like '" + Convert.ToString(metroComboBox1.SelectedItem) + "'");

                 
                try
                {
                    while (dr.Read())
                    {
                        rec.Add((String)dr[0]);
                        //MessageBox.Show("Read :Line");
                    }

                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message);
                }

                dc1.closeCon();
            }
            else {
                rec.Add(metroTextBox13.Text);
            }
            
            for (int i = 0; i < rec.Count; i++ )
            {
                
                String command = "INSERT INTO notification VALUES ('" + fd + "',GETDATE(), '" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','"+rec[i]+"')";
                new DataCon().execInsert(command);
                MetroMessageBox.Show(this,"Added");
                fillGrid("SELECT * FROM notification", 1, 1);
            }
        }else{
            MessageBox.Show("Empty or Invalid fields. Please Correct and try again!");
        
        }
        }
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            ADMainMenu am = new ADMainMenu();
            am.Show();
            this.Hide();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            metroTabControl2.SelectedTab = tabPage3;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {

        }

        private void htmlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click_2(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
        }

        private void metroButton6_Click_1(object sender, EventArgs e)
        {
            RecipientSelection rs = new RecipientSelection();
            rs.Show();
            this.Hide();
        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            ADMainMenu ad = new ADMainMenu();
            ad.Show();
            this.Hide();
        }

        private void fillGrid(String query, int i)
        {
            dc.openCon();
            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(i==1){
                metroGrid1.DataSource = dt;
                //DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                //col.UseColumnTextForButtonValue = true;
                //col.Text = "Delete";
                //col.Name = "deleteUsr";
                //metroGrid1.Columns.Add(col);
                dc.closeCon();
            }else{
                   metroGrid2.DataSource = dt;
                //DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                //col.UseColumnTextForButtonValue = true;
                //col.Text = "Delete";
                //col.Name = "deleteUsr";
                //metroGrid2.Columns.Add(col);
                dc.closeCon();
            }
        }
        private void fillGrid(String query, int i, int j)
        {
            dc.openCon();
            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (i == 1)
            {
                metroGrid1.DataSource = dt;
                dc.closeCon();
            }
            else
            {
                metroGrid2.DataSource = dt;
                dc.closeCon();
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            //if (metroGrid1.Columns[e.ColumnIndex].Name == "deleteUsr")
            //{
            //    String nid1 = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    int nid = 0;
            //    try
            //    {
            //         nid = System.Convert.ToInt32(nid1);
            //    }catch(Exception e0){
            //        MessageBox.Show(e0.Message);
            //    }
               
            //} 
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            //if (metroGrid2.Columns[e.ColumnIndex].Name == "deleteUsr")
            //{
            //    String nid1 = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    int id = System.Convert.ToInt32(nid1);
            //    DataCon d2 = new DataCon();
            //    String query = "delete from email where id like '" + id + "'";
            //    d2.execInsert(query);
            //    String query2 = "SELECT * FROM email";
            //    fillGrid(query2, 2, 2);
            //} 
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            List<String> rec = new List<string>();
            if (!((DateTime.Compare(Convert.ToDateTime(metroDateTime1.Text), DateTime.Now) < 0) || (String.IsNullOrEmpty(metroTextBox2.Text) || (String.IsNullOrEmpty(metroTextBox12.Text) ||(String.IsNullOrEmpty(metroTextBox2.Text) )))))
            {
                String fd = metroDateTime1.Value.ToString("yyyy-MM-dd");
                DataCon dc1 = new DataCon();
                if (metroCheckBox2.Checked == false)
                {
                    SqlDataReader dr = dc1.execSelect("SELECT staff_id from users where access_level like '" + Convert.ToString(metroComboBox1.SelectedItem) + "'");


                    try
                    {
                        while (dr.Read())
                        {
                            rec.Add((String)dr[0]);
                            //MessageBox.Show("Read :Line");
                        }

                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show(ex2.Message);
                    }

                    dc1.closeCon();
                }
                else
                {
                    rec.Add(metroTextBox13.Text);
                }
                for (int i = 0; i < rec.Count; i++)
                {

                    String command = "UPDATE notification set date = '" + fd + "', subject = '" + metroTextBox2.Text + "', message = '" + metroTextBox3.Text + "', staff_id = '" + rec[i] + "' WHERE nid = '" + System.Convert.ToInt32(metroTextBox12.Text) + "'";
                    new DataCon().execInsert(command);
                    MetroMessageBox.Show(this, "Updated");
                }
                fillGrid("SELECT * from notification", 1, 1);
            }
            else {
                MessageBox.Show("Invalid or incomplete fields. Please complete and try agian.");
            }
        }

        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox4.Text) || (String.IsNullOrEmpty(metroTextBox5.Text)))))
            {
                if (metroCheckBox1.Checked == false)
                { 
                    if (String.IsNullOrEmpty(metroTextBox6.Text))
                    {
                        Email email = new Email(recList, metroTextBox5.Text, metroTextBox4.Text);
                    }
                    else {

                        if (counter2 > 0)
                        {
                            counter2 = 0;
                            Email email = new Email(recList, metroTextBox5.Text, metroTextBox4.Text,metroTextBox6.Text);
                        }
                    }
                    } else {

                        if (String.IsNullOrEmpty(metroTextBox6.Text))
                        {
                            Email email = new Email(metroTextBox8.Text, Convert.ToInt32(metroTextBox9.Text), metroTextBox10.Text, metroTextBox11.Text, ssl, recList, metroTextBox5.Text, metroTextBox4.Text);
                        }
                        else
                        {

                            if (counter2 > 0)
                            {
                                counter2 = 0;
                                Email email = new Email(metroTextBox8.Text, Convert.ToInt32(metroTextBox9.Text), metroTextBox10.Text, metroTextBox11.Text, ssl, recList, metroTextBox5.Text, metroTextBox4.Text, metroTextBox6.Text);
                            }
                        }
                
                }
                }
               
            
            else
            {
                MessageBox.Show("one or more empty fields. You cannot leave them blank!");
            }

            metroLabel10.Text = "";
            metroTextBox5.Text = "";
            metroTextBox6.Text = "";
            metroTextBox4.Text = "";
        }

        private void metroButton4_Click_3(object sender, EventArgs e)
        {
            
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked == true)
            {
                metroTextBox8.Enabled = true;
                metroTextBox9.Enabled = true;
                metroTextBox10.Enabled = true;
                metroTextBox11.Enabled = true;
                metroComboBox2.Enabled = true;
            }
            else {
                metroTextBox8.Enabled = false;
                metroTextBox9.Enabled = false;
                metroTextBox10.Enabled = false;
                metroTextBox11.Enabled = false;
                metroComboBox2.Enabled = false;
            
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            //od.Filter = "Backup files (*.bak)|*.bak| All Files(*.*)|*.*";
           // od.FilterIndex = 0;
            if (od.ShowDialog() == DialogResult.OK)
            {
                metroTextBox6.Text = od.FileName;
                counter2++;
            }
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox2.SelectedIndex == 1)

                ssl = false;
            else
                ssl = true;
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            if (row >= 0)
                new DataCon().execInsert("delete from recipients where id = '" + Convert.ToInt32(metroGrid2.Rows[row].Cells[0].Value) + "';delete from email where id ='" + Convert.ToInt32(metroGrid2.Rows[row].Cells[0].Value) + "'");
            else
                MetroMessageBox.Show(this, "Please select a record to delete");
         String query2 = "SELECT * FROM email";
         fillGrid(query2, 2, 2);
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox7_TextChanged(object sender, EventArgs e)
        {

            String query = "SELECT * FROM email where subject like '%" + metroTextBox7.Text + "%'";
            fillGrid(query, 2, 1);
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox2.Checked)
            {
                metroTextBox13.Enabled = true;
                metroComboBox1.Enabled = false;
            }
            else {
                metroTextBox13.Enabled = false;
                metroComboBox1.Enabled = true;
            }

        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            if (row >= 0)
            {
                new DataCon().execInsert("delete from notification where nid like '" + Convert.ToInt32(metroGrid1.Rows[row].Cells[0].Value) + "'");
                MetroMessageBox.Show(this, "Deleted");
            }
            else
                MetroMessageBox.Show(this, "Please select a record to delete");

            
            row = 0;
            String query2 = "SELECT * FROM notification";
            fillGrid(query2, 1, 2);
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {

            LoggedIn.logOut();
            Application.Restart();
        }

        private void Communication_FormClosed(object sender, FormClosedEventArgs e)
        {

            LoggedIn.logOut();
            Application.Exit();
        }
        private void controlAccess()
        {
            switch (LoggedIn.getAL())
            {
                case "Admin":
                case "Principal":
                    break;
                default:
                    tabPage5.Enabled = false;
                    tabPage3.Enabled = false;
                    metroButton12.Enabled = false;
                    metroButton13.Enabled = false;
                    break;

            }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            String query = "SELECT * FROM notification where subject like '%" + metroTextBox1.Text + "%'";
            fillGrid(query, 1, 1);
        }
      
    }
}
