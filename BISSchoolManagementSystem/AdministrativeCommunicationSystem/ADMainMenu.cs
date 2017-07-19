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

namespace AdministrativeCommunicationSystem
{
    public partial class ADMainMenu : MetroForm
    {
        DataCon dc;
        public ADMainMenu()
        {
            InitializeComponent();
            controlAccess();
        }
        public ADMainMenu(int log, String aL, String uid, String user)
        {
            LoggedIn.setInfo(log, aL, uid, user);
            InitializeComponent();
            controlAccess();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dc = new DataCon();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            BackupRestore mu = new BackupRestore();
            mu.Show();
            this.Hide();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            dc.execInsert("INSERT INTO tempuser VALUES('"+LoggedIn.getlogin()+"', '"+LoggedIn.getUsername()+"','"+LoggedIn.getUID()+"','"+LoggedIn.getAL()+"')");
            
            Application.Restart();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ManageUsers mu = new ManageUsers();
            mu.Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            MonitorUsers mu = new MonitorUsers();
            mu.Show();
            this.Hide();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Communication mu = new Communication();
            mu.Show();
            this.Hide();
        }

        private void ADMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoggedIn.logOut();
            Application.Exit();
        }
        private void controlAccess() { 
        switch(LoggedIn.getAL()){
            case "Admin":
            case "Principal":
                break;
            default:
                metroTile1.Enabled = false;
                metroTile2.Enabled = false;
                metroTile3.Enabled = false;
                break;
            
            }
        }
        
        }

    
}
