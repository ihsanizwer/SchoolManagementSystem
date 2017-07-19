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
    public partial class StaffReservation : MetroForm
    {
        public StaffReservation()
        {
            InitializeComponent();
        }

        private void StaffReservation_Load(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m1 = new LMSMAIN();
            m1.Closed += (s, args) => this.Close();
            m1.Show();
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
