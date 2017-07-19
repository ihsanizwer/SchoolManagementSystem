using AdministrativeCommunicationSystem;
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
using System.Data.SqlTypes;
using Schedular;
using SMSystemNew;
using BOOK;
using performance;
using AMS_Final;
using StaffMain;
using ITP;


namespace Login
{
    public partial class Dashboard : MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            metroLabel2.Text = SignIn.getUsername();
            DataCon dc = new DataCon();
            SqlDataReader dr = dc.execSelect("SELECT subject, date from notification where staff_id like '"+SignIn.getUserID()+"'");
            try { 
                while(dr.Read()){
                    listBox1.Items.Add((String)dr[0]);
                    DateTime dt = (DateTime)dr[1];
                    String dat = dt.ToString("yyyy-MM-dd");
                    DateTime dt2 = DateTime.Now;
                    String dat2 = dt2.ToString("yyyy-MM-dd");
                    if (dat.Equals(dat2))
                    {
                        metroLabel9.Text = "You have new Notifications";
                        metroLabel9.BackColor = Color.Ivory;

                    }
                    else {
                        metroLabel9.Text = "You have no new Notifications";
                        metroLabel9.BackColor = Color.White;
                    }
                    controlAccessIH();
                }
            
            }catch(Exception exc){
                MessageBox.Show(exc.Message);
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SignIn.logOut();
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            SignIn.logOut();
            Application.Exit();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            int l = SignIn.getLogIn();
            String al = SignIn.getAccess();
            String uid = SignIn.getUserID();
            String usr = SignIn.getUsername();

            SMSystemNew.Form1 ad = new SMSystemNew.Form1(l, al, uid, usr);

            ad.Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            int l = SignIn.getLogIn();
            String al = SignIn.getAccess();
            String uid = SignIn.getUserID();
            String usr = SignIn.getUsername();

            StaffMainForm ad = new StaffMainForm(l, al, uid, usr);

            ad.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            int l = SignIn.getLogIn();
           String al = SignIn.getAccess();
           String uid = SignIn.getUserID();
           String usr = SignIn.getUsername();

           ADMainMenu ad = new ADMainMenu(l, al, uid, usr);
          
           ad.Show();
           this.Hide();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            DataCon dc = new DataCon();
            
            try
            {
                SqlDataReader dr = dc.execSelect("SELECT message, date from notification where staff_id like '" + SignIn.getUserID() + "' AND subject like '" + listBox1.SelectedItem.ToString() + "'");
                while (dr.Read())
                {
                    metroTextBox1.Text = (String)dr[0];
                    metroLabel8.Text = (String)dr[1].ToString();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("You dont have any messages");
            }
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            int l = SignIn.getLogIn();
            String al = SignIn.getAccess();
            String uid = SignIn.getUserID();
            String usr = SignIn.getUsername();

            SheduleHome ad = new SheduleHome(l, al, uid, usr);
            
            ad.Show();
            this.Hide();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            int l = SignIn.getLogIn();
            String al = SignIn.getAccess();
            String uid = SignIn.getUserID();
            String usr = SignIn.getUsername();

            LMSMAIN ad = new LMSMAIN(l, al, uid, usr);

            ad.Show();
            this.Hide();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            int l = SignIn.getLogIn();
            String al = SignIn.getAccess();
            String uid = SignIn.getUserID();
            String usr = SignIn.getUsername();

            PerformanceMenu ad = new PerformanceMenu(l, al, uid, usr);

            ad.Show();
            this.Hide();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            int l = SignIn.getLogIn();
            String al = SignIn.getAccess();
            String uid = SignIn.getUserID();
            String usr = SignIn.getUsername();

            Home ad = new Home(l, al, uid, usr);

            ad.Show();
            this.Hide();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            int l = SignIn.getLogIn();
            String al = SignIn.getAccess();
            String uid = SignIn.getUserID();
            String usr = SignIn.getUsername();

            InventoryHome ad = new InventoryHome(l, al, uid, usr);

            ad.Show();
            this.Hide();
        }

        private void controlAccessIH()
        {
            switch (SignIn.getAccess())
            {   
                case  "Clerk":
                case "Inventory Handler":
                case "Librarian":
                    metroTile5.Enabled = false;
                    break;
                default:

                    break;

            }
        }
    }
}
