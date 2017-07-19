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

namespace StaffMain
{
    public partial class StaffMainForm : MetroForm
    {
        DBAccessVacancy dba = new DBAccessVacancy();

        public StaffMainForm()
        {
            InitializeComponent();
        }

        public StaffMainForm(int log, String aL, String uid, String user)
        {
            LoggedIn.setInfo(log, aL, uid, user);
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            var staffDet = new StaffDetail();
            staffDet.FormClosed += (s, args) => this.Close();
            staffDet.Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            var vacancy = new Vacancy();
            vacancy.FormClosed += (s, args) => this.Close();
            vacancy.Show();
            this.Hide();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            var leave = new LeaveRequest();
            leave.FormClosed += (s, args) => this.Close();
            leave.Show();
            this.Hide();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            var pay = new Payroll();
            pay.FormClosed += (s, args) => this.Close();
            pay.Show();
            this.Hide();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            var report = new Report();
            report.FormClosed += (s, args) => this.Close();
            report.Show();
            this.Hide();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            dba.execInsert("INSERT INTO tempuser VALUES('" + LoggedIn.getlogin() + "', '" + LoggedIn.getUsername() + "','" + LoggedIn.getUID() + "','" + LoggedIn.getAL() + "')");

            Application.Restart();
        }
    }
}
