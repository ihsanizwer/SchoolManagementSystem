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
    public partial class SheduleHome : MetroForm
    {
        DBAccessClass dba = new DBAccessClass();

        public SheduleHome()
        {
            InitializeComponent();
        }

        public SheduleHome(int log, String aL, String uid, String user)
        {
            LoggedIn.setInfo(log, aL, uid, user);
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var classtimetable = new classtimetable();
            classtimetable.Closed += (s, args) => this.Close();
            classtimetable.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            dba.execInsert("INSERT INTO tempuser VALUES('" + LoggedIn.getlogin() + "', '" + LoggedIn.getUsername() + "','" + LoggedIn.getUID() + "','" + LoggedIn.getAL() + "')");

            Application.Restart();
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var tt1 = new teachertimetable();
            tt1.Closed += (s, args) => this.Close();
            tt1.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var et1 = new examtimetable();
            et1.Closed += (s, args) => this.Close();
            et1.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var lr = new leaverequest();
            lr.Closed += (s, args) => this.Close();
            lr.Show();
        }
    }
}
