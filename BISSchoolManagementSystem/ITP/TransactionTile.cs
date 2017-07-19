using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using MetroFramework;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP
{
    public partial class TransactionTile : MetroForm
    {
        DBAccessTransactionTile dba = new DBAccessTransactionTile();
        public TransactionTile()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usamaDataSet7.purchase_inv' table. You can move, or remove it, as needed.
            this.purchase_invTableAdapter2.Fill(this.usamaDataSet7.purchase_inv);
            // TODO: This line of code loads data into the 'usamaDataSet6.purchase_inv' table. You can move, or remove it, as needed.
            //this.purchase_invTableAdapter1.Fill(this.usamaDataSet6.purchase_inv);
            // TODO: This line of code loads data into the 'usamaDataSet5.purchase_inv' table. You can move, or remove it, as needed.
           // this.purchase_invTableAdapter.Fill(this.usamaDataSet5.purchase_inv);
            // TODO: This line of code loads data into the 'usamaDataSet4.stock_out' table. You can move, or remove it, as needed.
            this.stock_outTableAdapter.Fill(this.usamaDataSet4.stock_out);
            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
       

        

        

        
    }
}
