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

namespace ITP
{
    public partial class InventoryHome : MetroForm
    {
        DBAccessItemsTile dba = new DBAccessItemsTile();

        public InventoryHome()
        {
            InitializeComponent();
        }

        public InventoryHome(int log, String aL, String uid, String user)
        {
            LoggedIn.setInfo(log, aL, uid, user);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ItemsTile f1 = new ItemsTile();
            f1.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            SuppliersTile f2 = new SuppliersTile();
            f2.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            TransactionTile f3 = new TransactionTile();
            f3.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            dba.execInsert("INSERT INTO tempuser VALUES('" + LoggedIn.getlogin() + "', '" + LoggedIn.getUsername() + "','" + LoggedIn.getUID() + "','" + LoggedIn.getAL() + "')");

            Application.Restart();
        }


    }
}
