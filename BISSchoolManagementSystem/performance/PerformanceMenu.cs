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

namespace performance
{
    public partial class PerformanceMenu : MetroForm
    {

        DataCon dc = new DataCon();

        public PerformanceMenu()
        {
            InitializeComponent();
        }

        public PerformanceMenu(int log, String aL, String uid, String user)
        {
            LoggedIn.setInfo(log, aL, uid, user);
            InitializeComponent();
        }

        private void PerformanceMenu_Load(object sender, EventArgs e)
        {
            controlAccess();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ManagePerformance mp = new ManagePerformance();
            mp.Show();
            this.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ManageExtraCurricular me = new ManageExtraCurricular();
            me.Show();
            this.Hide();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ManageAwardsPrizes ma = new ManageAwardsPrizes();
            ma.Show();
            this.Hide();
        }

        private void PerformanceMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoggedIn.logOut();
            Application.Exit();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            dc.execInsert("INSERT INTO tempuser VALUES('" + LoggedIn.getlogin() + "', '" + LoggedIn.getUsername() + "','" + LoggedIn.getUID() + "','" + LoggedIn.getAL() + "')");

            Application.Restart();
        }

        private void controlAccess()
        {
            switch (LoggedIn.getAL())
            {
                case "Teacher":
                case "DEO":
                    metroTile3.Enabled = false;
                    break;
                default:

                    break;

            }
        }
        
    }
}
