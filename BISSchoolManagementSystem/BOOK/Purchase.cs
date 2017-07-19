using MetroFramework;
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
    public partial class Purchase : MetroForm
    {
        DBAccessPurchase dba = new DBAccessPurchase();
        public Purchase()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'sudheesanDataSet2.purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.sudheesanDataSet2.purchase);

        }
        public void Clear()
        {
            ClearAllTextBox(this);
            metroDateTime2.Value = DateTime.Today;
            FillPurchase();


            btn_purchase_add.Enabled = false;

        }
        public static void ClearAllTextBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var textBox = c as TextBox;
                if (textBox != null)
                    (textBox).Clear();
                if (c.HasChildren)
                    ClearAllTextBox(c);
            }
        }

        public void FillPurchase()
        {
            this.purchaseTableAdapter.Fill(this.sudheesanDataSet2.purchase);

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m1 = new LMSMAIN();
            m1.Closed += (s, args) => this.Close();
            m1.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void btn_purchase_add_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_purchase_add_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dba.addPurchase(Convert.ToInt32(metroTextBox2.Text), metroTextBox9.Text, metroDateTime2.Value.Date.ToString("MM/dd/yyyy"), metroTextBox3.Text, Convert.ToInt32(metroTextBox4.Text), Convert.ToDouble(metroTextBox5.Text), Convert.ToDouble (metroTextBox6.Text), metroTextBox8.Text, metroComboBox4.Text.ToString(), metroTextBox7.Text, metroTextBox11.Text, metroTextBox10.Text))
                {
                    MetroMessageBox.Show(this,"Successfully Added");
                }
                else
                {
                    MetroMessageBox.Show(this,"Error occured");
                }
            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this,ex.Message);
            }
            Clear();

            FillPurchase();
        }


        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            metroTextBox2.Text = metroGrid2.Rows[e.RowIndex].Cells["purchaseidDataGridViewTextBoxColumn"].Value.ToString();
            metroTextBox9.Text = metroGrid2.Rows[e.RowIndex].Cells["titleDataGridViewTextBoxColumn"].Value.ToString();
            metroTextBox6.Text = metroGrid2.Rows[e.RowIndex].Cells["totalcostDataGridViewTextBoxColumn"].Value.ToString();
            metroTextBox3.Text = metroGrid2.Rows[e.RowIndex].Cells["suppliernameDataGridViewTextBoxColumn"].Value.ToString();
            metroTextBox4.Text = metroGrid2.Rows[e.RowIndex].Cells["quantityDataGridViewTextBoxColumn"].Value.ToString();
            metroTextBox5.Text = metroGrid2.Rows[e.RowIndex].Cells["perbookrateDataGridViewTextBoxColumn"].Value.ToString();
            metroTextBox8.Text = metroGrid2.Rows[e.RowIndex].Cells["authorDataGridViewTextBoxColumn"].Value.ToString();
            metroTextBox7.Text = metroGrid2.Rows[e.RowIndex].Cells["editionDataGridViewTextBoxColumn"].Value.ToString();
            metroTextBox11.Text = metroGrid2.Rows[e.RowIndex].Cells["categorynameDataGridViewTextBoxColumn"].Value.ToString();
            metroTextBox10.Text = metroGrid2.Rows[e.RowIndex].Cells["publisherDataGridViewTextBoxColumn"].Value.ToString();
            metroComboBox4.Text = metroGrid2.Rows[e.RowIndex].Cells["booklanguageDataGridViewTextBoxColumn"].Value.ToString();
            metroDateTime2.Value = (DateTime)metroGrid2.Rows[e.RowIndex].Cells["purchasedateDataGridViewTextBoxColumn"].Value;
           
        }

        private void btn_purchase_update_Click(object sender, EventArgs e)
        {
            try
            {

                if (dba.updatePurchase(Convert.ToInt32(metroTextBox2.Text), metroTextBox9.Text, metroDateTime2.Value.Date.ToString("MM/dd/yyyy"), metroTextBox3.Text, Convert.ToInt32(metroTextBox4.Text), Convert.ToDouble(metroTextBox5.Text), Convert.ToDouble(metroTextBox6.Text), metroTextBox8.Text, metroComboBox4.Text.ToString(), metroTextBox7.Text, metroTextBox11.Text, metroTextBox10.Text))
                {


                    MetroMessageBox.Show(this,"Successfully Updated");
                }
                else
                {
                    MetroMessageBox.Show(this,"Error occured");
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,ex.Message);
            }
            Clear();

            FillPurchase();

        }
        public void FilterDataGridPurName(String a)
        {
            DataSet ds = dba.FilterPurchaseName(a);
            metroGrid2.DataSource = ds.Tables["purchase"].DefaultView;

        }

        public void FilterDataGridPurId(string  a)
        {
            DataSet ds = dba.FilterPurchaseId(a);
            metroGrid2.DataSource = ds.Tables["purchase"].DefaultView;

        }

        private void btn_purchase_delete_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "DO YOU WANT TO DELETE THE RECORD", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {

                    if (dba.deletePurchase(Convert.ToInt32(metroTextBox2.Text)))
                    {


                        MetroMessageBox.Show(this, "Successfully deleted");
                        ClearAllTextBox(this);
                        FillPurchase();
                    }
                    else
                    {
                        MetroMessageBox.Show(this,"Error occured");
                    }
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this,ex.Message);
                }
            }

            FillPurchase();
        }

        private void metroTextBox12_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridPurName(metroTextBox12.Text);
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(metroTextBox1.Text))
            {
                this.purchaseTableAdapter.Fill(this.sudheesanDataSet2.purchase);
            }
            else
            {
                FilterDataGridPurId(metroTextBox1.Text);
            }
           
        }

        private void metroTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
           // FilterDataGridPurId(metroTextBox1.Text);
        }

        private void metroTextBox12_Click(object sender, EventArgs e)
        {

        }
    }
}
