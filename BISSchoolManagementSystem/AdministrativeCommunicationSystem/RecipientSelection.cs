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
using System.Data.SqlClient;

namespace AdministrativeCommunicationSystem
{
    public partial class RecipientSelection : MetroForm
    {
        Boolean all = false;
        DataCon dc;
        public RecipientSelection()
        {
            dc = new DataCon();
            InitializeComponent();
        }

        private void RecipientSelection_Load(object sender, EventArgs e)
        {
           // metroComboBox1.SelectedIndex = 0;
        }

        private void RecipientSelection_FormClosed(object sender, FormClosedEventArgs e)
        {
            Communication cm = new Communication();
            cm.Show();
            this.Hide();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Communication cm = new Communication();
            cm.Show();
            this.Hide();
        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String value, dName, query;
            value = ""; dName = ""; query = "";
            switch (Convert.ToString(metroComboBox1.SelectedItem)) { 
                case "Principal":
                     value = "col1";
                     dName = "col2";
                     query = "select email, first_name+' '+last_name+' '+email from staff where designation = 'Principal' and email not like ''";
                    break;
                case "Teacher":
                    value = "col1";
                     dName = "col2";
                     query = "select email, first_name+' '+last_name+' '+email from staff where designation = 'Teacher' and email not like ''";
                    break;
                case "Supplier":
                    value = "col1";
                    dName = "col2";
                    query = "select s_email, s_name+' '+s_email as 'name' from supplier where s_email not like ''";

                    break;
                case "Parent":
                    value = "col1";
                     dName = "col2";
                     query = "select email, name+' '+email as 'name' from parent_details where email not like ''";
                    break;
                case "Sectional Head":
                    value = "col1";
                     dName = "col2";
                     query = "select email, first_name+' '+last_name+' '+email from staff where designation = 'Sectional Head' and email not like ''";
                    break;
                case "Librarian":
                    value = "col1";
                     dName = "col2";
                     query = "select email, first_name+' '+last_name+' '+email from staff where designation = 'Librarian' and email not like ''";
                    break;
                case "Clerk":
                    value = "col1";
                     dName = "col2";
                     query = "select email, first_name+' '+last_name+' '+email from staff where designation = 'Clerk' and email not like ''";
                    break;
                case "DEO":
                    value = "col1";
                     dName = "col2";
                     query = "select email, first_name+' '+last_name+' '+email from staff where designation = 'Data Entry Operator' and email not like ''";
                    break;
                case "Inventory Handler":
                    value = "col1";
                     dName = "col2";
                     query = "select email, first_name+' '+last_name+' '+email from staff where designation = 'Principal' and email not like ''";
                    break;
                case "Admin":
                    value = "col1";
                     dName = "col2";
                     query = "select email, first_name+' '+last_name+' '+email from staff where designation = 'Inventory Handler' and email not like ''";
                    break;

            }
            unCheck();
            DataTable dt = dc.fillCombo(value, dName, query, false);
            checkedListBox1.DataSource = dt;
            checkedListBox1.ValueMember = value;
            checkedListBox1.DisplayMember = dName;
            
           

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            List<String> rec = new List<string>();
            for (int i = 0; i < listBox1.Items.Count;i++ )
            {
                listBox1.SelectedIndex = i;
                rec.Add(Convert.ToString(listBox1.SelectedItem));
            }
           Communication cm = new Communication(rec);
           cm.Show();
            this.Hide();
        }

        private void unCheck() {
            for (int i = 0; i < checkedListBox1.Items.Count;i++ )
            {
                checkedListBox1.SetItemChecked(i, false);

            }
        }
        private void check()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);

            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked){
                all = true;
                check();
                for (int i = 0; i < checkedListBox1.Items.Count;i++ )
                {
                    checkedListBox1.SelectedIndex =i;
                    if ((listBox1.Items.IndexOf(checkedListBox1.SelectedValue) < 0))
                        listBox1.Items.Add(checkedListBox1.SelectedValue);
                    
                }
            }    
            else
                unCheck();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            String item = Convert.ToString(checkedListBox1.SelectedValue);

            if (e.NewValue == CheckState.Checked && all==false)
            {
                if ((listBox1.Items.IndexOf(item) < 0))
                    listBox1.Items.Add(item);
            }
            
                
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
