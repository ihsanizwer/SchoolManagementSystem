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


namespace SMSystemNew
{
    public partial class Form1 : MetroForm
    {
        DBAccess dba = new DBAccess();

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int log, String aL, String uid, String user)
        {
            LoggedIn.setInfo(log, aL, uid, user);
            InitializeComponent();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            studentDetails sd = new studentDetails();
            sd.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
          

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            studentDetails sd = new studentDetails();
            sd.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
             admission ad = new admission();
             ad.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            dba.execInsert("INSERT INTO tempuser VALUES('" + LoggedIn.getlogin() + "', '" + LoggedIn.getUsername() + "','" + LoggedIn.getUID() + "','" + LoggedIn.getAL() + "')");

            Application.Restart();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            payment pd = new payment();
            pd.Show();
        }
    }
}
