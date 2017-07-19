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
    public partial class MonitorUsers : MetroForm
    {
       
        public MonitorUsers()
        {
            InitializeComponent();
         
        }

        private void MonitorUsers_Load(object sender, EventArgs e)
        {
            String query = "SELECT * FROM login";
            dispTableLog(query);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ADMainMenu am = new ADMainMenu();
            am.Show();
            this.Hide();
        }

        void dispTableLog(String query) { 
        
            DataCon dc = new DataCon();
  
            SqlDataAdapter da = dc.selectTable(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGrid2.DataSource = dt;
            dc.closeCon();
        }
       
        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            new ADMainMenu().Show();
            this.Hide();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            String query = "SELECT * FROM login where username like '%" + metroTextBox1.Text + "%'";
            dispTableLog(query);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

            LoggedIn.logOut();
            Application.Restart();
        }

        private void MonitorUsers_FormClosed(object sender, FormClosedEventArgs e)
        {

            LoggedIn.logOut();
            Application.Exit();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            UsersLogInReport ur = new UsersLogInReport(metroTextBox2.Text);
            ur.Show();
        }
    }
}
