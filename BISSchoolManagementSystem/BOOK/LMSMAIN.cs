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

namespace BOOK
{
    public partial class LMSMAIN : MetroForm
    {
        DBAccessBook dba = new DBAccessBook();

        public LMSMAIN()
        {
            InitializeComponent();
        }
        public LMSMAIN(int log, String aL, String uid, String user)
        {
            LoggedIn.setInfo(log, aL, uid, user);
            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m1 = new book();
            m1.Closed += (s, args) => this.Close();
            m1.Show();
            
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m1 = new originalmember();
            m1.Closed += (s, args) => this.Close();
            m1.Show();
            
        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m1 = new Category();
            m1.Closed += (s, args) => this.Close();
            m1.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m1 = new Purchase();
            m1.Closed += (s, args) => this.Close();
            m1.Show();
            
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m1 = new Lending();
            m1.Closed += (s, args) => this.Close();
            m1.Show();
            
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m1 = new bookreturn();
            m1.Closed += (s, args) => this.Close();
            m1.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var sr1 = new StaffReservation();
            sr1.Closed += (s, args) => this.Close();
            sr1.Show();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m1 = new report();
            m1.Closed += (s, args) => this.Close();
            m1.Show();
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            dba.execInsert("INSERT INTO tempuser VALUES('" + LoggedIn.getlogin() + "', '" + LoggedIn.getUsername() + "','" + LoggedIn.getUID() + "','" + LoggedIn.getAL() + "')");

            Application.Restart();
        }
    }
}
