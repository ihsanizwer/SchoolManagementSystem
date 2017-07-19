using MetroFramework;
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

namespace AdministrativeCommunicationSystem
{
    public partial class ManageUsers : MetroForm
    {
        DataCon dc;
        String defQuery;
        int row = -1;
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
             dc = new DataCon();
             String defQuery = "SELECT * FROM users";
             fillGrid(defQuery);
             metroComboBox1.SelectedIndex = 0;
             setStaffCombo();
             metroComboBox2.SelectedIndex = 0;
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            ADMainMenu am = new ADMainMenu();
            am.Show();
            this.Hide();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            new ADMainMenu().Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void fillGrid(String query) {
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
        private void fillGrid2(String query)
        {
            dc.openCon();

            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGrid1.DataSource = dt;
            /*DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Delete";
            col.Name = "deleteUsr";
            metroGrid1.Columns.Add(col);*/
            dc.closeCon();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Columns[e.ColumnIndex].Name == "deleteUsr")
            {
                String username = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataCon d2 = new DataCon();
                String query = "delete from users where username like '"+username+"'";
                d2.execInsert(query);
            } 
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if(!((String.IsNullOrEmpty(metroTextBox2.Text) ||(String.IsNullOrEmpty(metroTextBox3.Text)) ))){
                DataCon dc2 = new DataCon();
                String command = "INSERT INTO users VALUES('"+metroTextBox2.Text+"', '"+Security.Encript(metroTextBox3.Text)+"', '"+Convert.ToString(metroComboBox1.SelectedItem)+"',NULL, '"+metroComboBox2.SelectedValue+"');";
                MetroMessageBox.Show(this, "Added!");
                dc2.execInsert(command);
                fillGrid("SELECT * FROM users");
            }else{
                MessageBox.Show("One or more fields are left empty. Please enter and try again!");
            }
            
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            
            if (!((String.IsNullOrEmpty(metroTextBox2.Text)) || (String.IsNullOrEmpty(metroTextBox3.Text)) ))
            {
                DataCon d3 = new DataCon();
                String command = "UPDATE users set password = '" + Security.Encript(metroTextBox3.Text) + "', access_level = '" + Convert.ToString(metroComboBox1.SelectedItem) + "', staff_id = '" + metroComboBox2.SelectedValue + "' where username like '" + metroTextBox2.Text + "'";
                d3.execInsert(command);
                MetroMessageBox.Show(this, "Updated!");
                fillGrid("SELECT * FROM users");
            }
            else {
                MessageBox.Show("One or More fields left empty. Please enter and try again!");
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void setStaffCombo() {
            String value = "staffID";
            String dName = "staffName";
            String query = "select staff_id, staff_id+' '+first_name +' '+ last_name as 'name' from staff";
            DataTable dt = dc.fillCombo(value,dName, query, false);
            metroComboBox2.ValueMember = value;
            metroComboBox2.DisplayMember = dName;
            metroComboBox2.DataSource = dt;
        
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MetroMessageBox.Show(this, Convert.ToString(metroComboBox2.SelectedValue));
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (row >= 0)
            {
                new DataCon().execInsert("update login set username =null where username like '" + metroGrid1.Rows[row].Cells[0].Value + "'; delete from users where username ='" + metroGrid1.Rows[row].Cells[0].Value + "'");
                MetroMessageBox.Show(this, "Deleted!");
            }
            else
                MetroMessageBox.Show(this, "Please select a record to delete");
            String query2 = "SELECT * FROM users";
            fillGrid(query2);
        }

        private void metroGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            String query = "SELECT * FROM users where  username like '%" + metroTextBox1.Text + "%'";
            fillGrid2(query);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            LoggedIn.logOut();
            Application.Restart();
        }

        private void ManageUsers_FormClosed(object sender, FormClosedEventArgs e)
        {

            LoggedIn.logOut();
            Application.Exit();
        }
    }


}
