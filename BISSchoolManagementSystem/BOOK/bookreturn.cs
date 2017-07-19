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
    public partial class bookreturn : MetroForm
    {
        public bookreturn()
        {
            InitializeComponent();
        }

        private void bookreturn_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m1 = new LMSMAIN();
            m1.Closed += (s, args) => this.Close();
            m1.Show();
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            txt_memberbarcode.ResetText();
        }
    }
}
