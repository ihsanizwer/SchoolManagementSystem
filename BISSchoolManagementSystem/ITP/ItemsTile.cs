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

namespace ITP
{
    public partial class ItemsTile : MetroForm
    {
        DBAccessItemsTile dba = new DBAccessItemsTile();
        public ItemsTile()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Search_Enter(object sender, EventArgs e)
        {

        }

        private void ItemsTile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usamaDataSet3.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter2.Fill(this.usamaDataSet3.item);
            // TODO: This line of code loads data into the 'usamaDataSet2.item' table. You can move, or remove it, as needed.
           // this.itemTableAdapter1.Fill(this.usamaDataSet2.item);
            // TODO: This line of code loads data into the 'usamaDataSet.item' table. You can move, or remove it, as needed.
            //this.itemTableAdapter.Fill(this.usamaDataSet.item);

        }
        public void FillItem()
        {
            this.itemTableAdapter2.Fill(this.usamaDataSet3.item);

        }
        public void FilterDataGridic(string a)
        {
            DataSet ds = dba.FilterItemCode(a);
            dgv_item.DataSource = ds.Tables["item"].DefaultView;
        }
        public void FilterDataGridIname(string a)
        {
            DataSet ds= dba.FilterItemName(a);
            dgv_item.DataSource = ds.Tables["item"].DefaultView;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            itemcode.ResetText();
            itemname.ResetText();
            description.ResetText();
            unitprice.ResetText();
        }

        public bool validateItemCode(string itCode)
        {



            string last = itCode.Substring(3, (itCode.Length - 3));



            MetroMessageBox.Show(this, last);
            if (itCode.Length == 9 && itCode.StartsWith("it_") && last.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(this, "INPUT ITEM CODE SHOULD TYPE IN 'it_XXXXXX' FORMAT");
                itemcode.Focus();
                return false;
            }
        }
        
            public bool validateItemName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Any(Char.IsDigit))
            {
                MetroMessageBox.Show(this,"Item Name Cannot Contain digits Or White Spaces");
                itemname.Select();
                return false;

            }
            else
            {
                return true;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
             /*var va1 = new validatetext();
             * va1.validatetextBox(itemcode.Text);
             * va1.validatetextBox(itemname.Text);
             * va1.validatetextBox(descripton.Text);
             * va1.validatetextBox(unitprice.Text);*/


            if (validateItemCode(itemcode.Text))
            {


                if (validateItemName(itemname.Text))
                {






                    try
                    {
                        if (dba.addItem(itemcode.Text, itemname.Text, description.Text, Convert.ToInt32(unitprice.Text)))
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

                    FillItem();
                }
            }
            
        }

        private void update_Click(object sender, EventArgs e)
        {
             try
            {

                if (dba.updateItem(itemcode.Text,itemname.Text,description.Text,Convert.ToInt32(unitprice.Text)))
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

            FillItem();
        }
         public void Clear()
        {
            itemcode.Clear();
            FillItem();
           

            add.Enabled = false;
            update.Enabled = true;
        }

            private void dgv_item_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             itemcode.Text = dgv_item.Rows[e.RowIndex].Cells["itemcodeDataGridVewTextBoxColumn"].Value.ToString();
             itemname.Text = dgv_item.Rows[e.RowIndex].Cells["itemnameDataGridVewTextBoxColumn"].Value.ToString();
             description.Text = dgv_item.Rows[e.RowIndex].Cells["descriptionDataGridVewTextBoxColumn"].Value.ToString();
             unitprice.Text = dgv_item.Rows[e.RowIndex].Cells["unitpriceDataGridVewTextBoxColumn"].Value.ToString();
         }
                private void fillByToolStripButton_Click(object sender, EventArgs e)
            {
                try
                {
                    //this.itemTableAdapter.FillBy(this.UsamaDataSet1.item);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }

            private void ff(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void metroTextBox1_TextChanged(object sender, EventArgs e)
            {
                FilterDataGridic(metroTextBox1.Text);
            }

            private void metroTextBox2_TextChanged(object sender, EventArgs e)
            {
                FilterDataGridIname(metroTextBox2.Text);
            }

            private void itemcode_TextChanged(object sender, EventArgs e)
            {
                add.Enabled = true;
            }

            private void delete_Click(object sender, EventArgs e)
            {
                var result = MessageBox.Show(this, "DO YOU WANT TO DELETE THE RECORD", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {

                        if (dba.deleteitem(itemcode.Text))
                        {


                            MessageBox.Show("Successfully deleted");
                            ClearAllTextBox(this);
                            FillItem();
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


                    FillItem();
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

                private void dgv_item_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
                {
                    itemcode.Text = dgv_item.Rows[e.RowIndex].Cells["itemcodeDataGridViewTextBoxColumn"].Value.ToString();
                    itemname.Text = dgv_item.Rows[e.RowIndex].Cells["itemnameDataGridViewTextBoxColumn"].Value.ToString();
                    description.Text = dgv_item.Rows[e.RowIndex].Cells["itemdescriptionDataGridViewTextBoxColumn"].Value.ToString();
                    unitprice.Text = dgv_item.Rows[e.RowIndex].Cells["itempriceDataGridViewTextBoxColumn"].Value.ToString();
                }

                private void exit_Click(object sender, EventArgs e)
                {
                    this.Close();
                }
            




        
    }
}
