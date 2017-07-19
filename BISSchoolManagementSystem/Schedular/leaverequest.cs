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
    public partial class leaverequest : MetroForm
    {
        public leaverequest()
        {
            InitializeComponent();
        }

        private void leaverequest_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTextButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SheduleHome = new SheduleHome();
            SheduleHome.Closed += (s, args) => this.Close();
            SheduleHome.Show();
        }
    }
}
