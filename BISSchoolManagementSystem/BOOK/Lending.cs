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
    public partial class Lending : MetroForm
    {
        public Lending()
        {
            InitializeComponent();
        }

        private void Lending_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel20_Click(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m1 = new LMSMAIN();
            m1.Closed += (s, args) => this.Close();
            m1.Show();
            
        }
    }
}
