using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP
{
    public partial class SuppliersTile : MetroForm
    {
        DBAccessSuppliersTile dba = new DBAccessSuppliersTile();
        public SuppliersTile()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usamaDataSet1.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.usamaDataSet1.supplier);

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }
        public void FillSupplier()
        {
            this.supplierTableAdapter.Fill(this.usamaDataSet1.supplier);

        }

        public void FilterDataGridsid(string a)
        {
            DataSet ds = dba.FilterSupplierId(a);
            dgv_supplier.DataSource = ds.Tables["supplier"].DefaultView;
        }

        public void FilterDataGridsname(string a)
        {
            DataSet ds = dba.FilterSupplierName(a);
            dgv_supplier.DataSource = ds.Tables["supplier"].DefaultView;
        }

        private void metroTextButton3_Click(object sender, EventArgs e)
        {
            supplierid.ResetText();
            suppliername.ResetText();
            contact.ResetText();
            address.ResetText();
            email.ResetText();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {

                if (dba.updateSupplier(supplierid.Text, suppliername.Text, Convert.ToInt32(contact.Text), address.Text, email.Text))
                {


                    MessageBox.Show("Successfully Updated");
                }
                else
                {
                    MessageBox.Show("Error occured");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Clear();

            FillSupplier();
        }
        public void Clear()
        {
            supplierid.Clear();
            FillSupplier();


            add.Enabled = false;
            update.Enabled = true;
        }

        private void dgv_supplier_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            supplierid.Text = dgv_supplier.Rows[e.RowIndex].Cells["supplieridDataGridViewTextBoxColumn"].Value.ToString();
            suppliername.Text = dgv_supplier.Rows[e.RowIndex].Cells["snameDataGridViewTextBoxColumn"].Value.ToString();
            contact.Text = dgv_supplier.Rows[e.RowIndex].Cells["scontactDataGridViewTextBoxColumn"].Value.ToString();
            address.Text = dgv_supplier.Rows[e.RowIndex].Cells["saddressDataGridViewTextBoxColumn"].Value.ToString();
            email.Text = dgv_supplier.Rows[e.RowIndex].Cells["semailDataGridViewTextBoxColumn"].Value.ToString();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.supplierTableAdapter.FillBy(this.usamaDataSet.item);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }



        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridsid(metroTextBox1.Text);
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
           // FilterDataGridsname(metroTextBox2.Text);
        }

        private void supplierid_Click(object sender, EventArgs e)
        {
            add.Enabled = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            {
                var result = MessageBox.Show(this, "DO YOU WANT TO DELETE THE RECORD", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {

                        if (dba.deleteitem(supplierid.Text))
                        {


                            MessageBox.Show("Successfully deleted");
                            ClearAllTextBox(this);
                            FillSupplier();
                        }
                        else
                        {
                            MessageBox.Show("Error occured");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    FillSupplier();
                }
            }
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

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridsname(metroTextBox2.Text);
        }

        private void add_Click_1(object sender, EventArgs e)
        {
             /*var va1 = new validatetext();
            * va1.validatetextBox(supplierid.Text);
            * va1.validatetextBox(suppliername.Text);
            * va1.validatetextBox(contact.Text);
            * va1.validatetextBox(address.Text);
             va1.validatetextBox(email.Text);
             */
            try
            {
                if (dba.addSupplier(supplierid.Text, suppliername.Text,Convert.ToInt32(contact.Text),address.Text,email.Text))
                {
                    MessageBox.Show("Successfully Added");
                }
                else
                {
                    MessageBox.Show("Error occured");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Clear();

            FillSupplier();
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        


        
        

    }
}
