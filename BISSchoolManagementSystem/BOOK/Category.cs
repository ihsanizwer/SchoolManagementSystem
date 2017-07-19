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
    public partial class Category : MetroForm
    {


        DBAccessCat dba = new DBAccessCat();
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sudheesanDataSet2.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.sudheesanDataSet2.category);
            
           // Fillcategory();
        }

        private void FillCategory()
        {
            this.categoryTableAdapter.Fill(this.sudheesanDataSet2.category);
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m1 = new LMSMAIN();
            m1.Closed += (s, args) => this.Close();
            m1.Show();
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (dba.addcategory(txt_catID.Text, metroTextBox1.Text, cmb_racknumber.Text.ToString(), picker_date.Value.Date.ToString("MM/dd/yyyy"), Convert.ToInt32(txt_noofbooks.Text), cmb_catstatus.Text.ToString()))
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

            FillCategory();
            
        }

      /*  public void Fillcategory()
        {
            DataSet ds = dba.getAllCategory();
            dgv_category.DataSource = ds.Tables["category"].DefaultView;
        }*/


           
        

        public void Clear()
        {
            ClearAllTextBox(this);
            picker_date.Value = DateTime.Today;
            FillCategory();
           

            btn_Add_category.Enabled = false;
           
        }

        private void dgv_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_update_category_Click(object sender, EventArgs e)
        {
            try
            {

                if (dba.updateCategory(txt_catID.Text, metroTextBox1.Text, cmb_racknumber.Text.ToString(), picker_date.Value.Date.ToString("MM/dd/yyyy"), Convert.ToInt32(txt_noofbooks.Text), cmb_catstatus.Text.ToString()))
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

            FillCategory();
        }

        private void dgv_category_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_catID.Text = dgv_category.Rows[e.RowIndex].Cells["categoryidDataGridViewTextBoxColumn"].Value.ToString();
            metroTextBox1.Text = dgv_category.Rows[e.RowIndex].Cells["categorynameDataGridViewTextBoxColumn"].Value.ToString();
            txt_noofbooks.Text = dgv_category.Rows[e.RowIndex].Cells["noofbooksDataGridViewTextBoxColumn"].Value.ToString();
            cmb_racknumber.Text = dgv_category.Rows[e.RowIndex].Cells["racknoDataGridViewTextBoxColumn"].Value.ToString();
            cmb_catstatus.Text = dgv_category.Rows[e.RowIndex].Cells["catstatusDataGridViewTextBoxColumn"].Value.ToString();
            picker_date.Value = (DateTime)dgv_category.Rows[e.RowIndex].Cells["addeddateDataGridViewTextBoxColumn"].Value;

        }

        private void btn_clear_category_Click(object sender, EventArgs e)
        {

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

        private void txt_catID_Click(object sender, EventArgs e)
        {

        }

        private void txt_catID_TextChanged(object sender, EventArgs e)
        {
            btn_Add_category.Enabled = true;
        }

        private void btn_delete_category_Click(object sender, EventArgs e)
        {
             var result = MetroMessageBox.Show(this, "DO YOU WANT TO DELETE THE RECORD", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
             if (result == DialogResult.Yes)
             {
                 try
                 {

                     if (dba.deleteCategory(txt_catID.Text))
                     {


                         MetroMessageBox.Show(this,"Successfully deleted","SUCCESS",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                         ClearAllTextBox(this);
                         FillCategory();
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

                FillCategory();
         }

        public void FilterDataGridCatName(String a)
        {
            DataSet ds = dba.FilterCatName(a);
            dgv_category.DataSource = ds.Tables["category"].DefaultView;

        }

        public void FilterDataGridCatId(String a)
        {
            DataSet ds = dba.FilterCatId(a);
            dgv_category.DataSource = ds.Tables["category"].DefaultView;

        }



        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridCatName(metroTextBox3.Text);
        }

        private void txt_search_catid_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridCatId(txt_search_catid.Text);
        }
        

    }
}
