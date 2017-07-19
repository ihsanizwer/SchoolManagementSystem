using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLServerDatabaseAccess;
using MetroFramework;

namespace StaffMain
{
    public partial class Termination : MetroForm
    {
        public Termination()
        {
            InitializeComponent();
        }

        private void txtTerminate_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
