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
    public partial class book : MetroForm
    {

        DBAccessBook dba = new DBAccessBook();
        public book()
        {
            InitializeComponent();
        }

        private void book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sudheesanDataSet.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.sudheesanDataSet.book);
           
        }
        public void FillBook()
        {
            this.bookTableAdapter.Fill(this.sudheesanDataSet.book);
        }

        public void FilterDataGridAcc(String a)
        {
            DataSet ds = dba.FilterBookAcc(a);
            dgv_book.DataSource = ds.Tables["book"].DefaultView;

        }

        public void FilterDataGridTitle(String a)
        {
            DataSet ds = dba.FilterBookTitle(a);
            dgv_book.DataSource = ds.Tables["book"].DefaultView;

        }

        public bool validateBookBarcode(string a)
        {

                   String[] digits = a.Split('-');
                 

                  if (a.Length == 12 && Char.IsDigit(a.ElementAt(0)) && a.ElementAt(1).Equals('-')  && a.ElementAt(6).Equals('-')  && a.ElementAt(9).Equals('-') )
                  {

                      
                    
                      String[] difits = a.Split('-');


                      if (digits[1].All(char.IsDigit) && digits[2].All(char.IsDigit) && digits[3].All(char.IsDigit))
                      {
                          return true;
                      }
                      else
                      {
                          MetroMessageBox.Show(this, "INPUT THE BARCODE nUMBER IN x-xxxx-xx--xx FORMAT ");
                          txt_bookbarcode.Focus();
                          return false;

                      }
                  }
                  else
                  {
                      MetroMessageBox.Show(this, "INPUT THE BARCODE nUMBER IN x-xxxx-xx--xx FORMAT ");
                      txt_bookbarcode.Focus();
                      return false;
                  }

            
        }

        public bool ValidateisbnNumber( string a)
        {

            String[] digits = a.Split('-');


            if (a.Length == 19 && a.ElementAt(4).Equals('-') && a.ElementAt(9).Equals('-') && a.ElementAt(14).Equals('-'))
            {



                String[] difits = a.Split('-');


                if (digits[0].All(char.IsDigit) && digits[1].All(char.IsDigit) && digits[2].All(char.IsDigit) && digits[3].All(char.IsDigit))
                {
                    return true;
                }
                else
                {
                    MetroMessageBox.Show(this, "INPUT THE ISBN NUMBER IN xxxx-xxxx-xxxx-xxxx FORMAT ");
                    txt_isbn.Focus();
                    return false;

                }
            }
            else
            {
                MetroMessageBox.Show(this, "INPUT THE ISBN NUMBER IN xxxx-xxxx-xxxx-xxxx FORMAT ");
                txt_isbn.Focus();
                return false;
            }
        }

        public bool validateTextBoxNull(string a, string b,string c, string d,string e, string f,string g, string h,string i, string j,string k, string l)
        {
            if(!string.IsNullOrWhiteSpace(a) && !string.IsNullOrWhiteSpace(b) && !string.IsNullOrWhiteSpace(c) && !string.IsNullOrWhiteSpace(d) && !string.IsNullOrWhiteSpace(e) && !string.IsNullOrWhiteSpace(f) && !string.IsNullOrWhiteSpace(g) && !string.IsNullOrWhiteSpace(h) && !string.IsNullOrWhiteSpace(i) && !string.IsNullOrWhiteSpace(j) && !string.IsNullOrWhiteSpace(k) && !string.IsNullOrWhiteSpace(l) )
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(this, "CANNOT BE NULL");
                return false;
            }

            
        }

        public bool checkIsDigit(string a,string b ,string c,string d,string e,string f)
        {
           
            if (a.All(Char.IsDigit))
            {
                 if(b.All(Char.IsDigit))
                 {
                     if(c.All(Char.IsDigit))
                     {
                         if(d.All(Char.IsDigit))
                         {
                             if(e.All(Char.IsDigit))
                             {
                                 if(f.All(Char.IsDigit))
                                 {
                                     return true;
                                 }
                                 else
                                 {
                                    
                                     MetroMessageBox.Show(this, "ENTER A VALID ACCESSION NUMBER");
                                     txt_accessionnumber.Focus();
                                     return false;

                                 }
                             }
                             else
                             {
                                 
                                 MetroMessageBox.Show(this,"ENTER VALID NUMBER OF COPIES");
                                 txt_noofcopies.Focus();
                                 return false;
                             }
                         }
                         else
                         {
                            
                             MetroMessageBox.Show(this,"ENTER A VALID EDITION");
                             txt_edition.Focus();
                             return false;

                         }
                     }
                     else
                     {
                         
                         MetroMessageBox.Show(this, "ENTER VALID NUMBER OF PAGES");
                         txt_noofpages.Focus();
                         return false;
                     }
                 }
                 else
                 {
                     
                     MetroMessageBox.Show(this, "ENTER VALID PRICE");
                     txt_price.Focus();
                     return false;
                 }

            }
            else
            {
                
                MetroMessageBox.Show(this,"ENTER A VALIDPURCHASE ID ");
                txt_purchaseid.Focus();
                return false;
            }
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m1 = new LMSMAIN();
            m1.Closed += (s, args) => this.Close();
            m1.Show();
            
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            txt_accessionnumber.ResetText();
            txt_bookbarcode.ResetText();
            txt_isbn.ResetText();
            txt_title.ResetText();
            txt_author.ResetText();
            txt_categoryid.ResetText();
           // txt_booklanguage.ResetText();
            txt_publisher.ResetText();
            date_publishdate.ResetText();
            txt_noofcopies.ResetText();
            txt_edition.ResetText();
            txt_noofpages.ResetText();
            txt_price.ResetText();
            txt_purchaseid.ResetText();
            cmb_bookstatus.ResetText();
        }

        private void txt_accessionnumber_Click(object sender, EventArgs e)
        {
        
        }
        
        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (validateTextBoxNull(txt_accessionnumber.Text, txt_bookbarcode.Text, txt_isbn.Text, txt_title.Text, txt_author.Text, txt_categoryid.Text, txt_publisher.Text, txt_noofcopies.Text, txt_edition.Text, txt_noofpages.Text, txt_price.Text, txt_purchaseid.Text))
            {

                if (checkIsDigit(txt_purchaseid.Text, txt_price.Text, txt_noofpages.Text, txt_edition.Text, txt_noofcopies.Text, txt_accessionnumber.Text))
                {
                    if (validateBookBarcode(txt_bookbarcode.Text))
                    {

                        if (ValidateisbnNumber(txt_isbn.Text))
                        {




                            try
                            {
                                if (dba.addBook(txt_accessionnumber.Text, txt_bookbarcode.Text, txt_isbn.Text, txt_title.Text, txt_author.Text, txt_categoryid.Text, cmb_language.Text.ToString(), txt_publisher.Text, date_publishdate.Value.Date.ToString("MM/dd/yyyy"), Convert.ToInt32(txt_noofcopies.Text), Convert.ToInt32(txt_edition.Text), Convert.ToInt32(txt_noofpages.Text), Convert.ToDouble(txt_price.Text), cmb_bookstatus.Text.ToString(), Convert.ToInt32(txt_purchaseid.Text)))
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

                            FillBook();
                        }
                    }
                }
            }
      }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (validateTextBoxNull(txt_accessionnumber.Text, txt_bookbarcode.Text, txt_isbn.Text, txt_title.Text, txt_author.Text, txt_categoryid.Text, txt_publisher.Text, txt_noofcopies.Text, txt_edition.Text, txt_noofpages.Text, txt_price.Text, txt_purchaseid.Text))
            {

                if (checkIsDigit(txt_purchaseid.Text, txt_price.Text, txt_noofpages.Text, txt_edition.Text, txt_noofcopies.Text, txt_accessionnumber.Text))
                {
                    if (validateBookBarcode(txt_bookbarcode.Text))
                    {
                        if (ValidateisbnNumber(txt_isbn.Text))
                        {





                            try
                            {

                                if (dba.updateBook(txt_accessionnumber.Text, txt_bookbarcode.Text, txt_isbn.Text, txt_title.Text, txt_author.Text, txt_categoryid.Text, cmb_language.Text.ToString(), txt_publisher.Text, date_publishdate.Value.Date.ToString("MM/dd/yyyy"), Convert.ToInt32(txt_noofcopies.Text), Convert.ToInt32(txt_edition.Text), Convert.ToInt32(txt_noofpages.Text), Convert.ToDouble(txt_price.Text), cmb_bookstatus.SelectedValue.ToString(), Convert.ToInt32(txt_purchaseid.Text)))
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

                            FillBook();
                        }
                    }
                }
            }

                        

                        

        }


        public void Clear()
        {
            txt_accessionnumber.Clear();
            date_publishdate.Value = DateTime.Today;
            FillBook();
           

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }


        private void dgv_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {







        }

        private void dgv_book_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_accessionnumber.Text = dgv_book.Rows[e.RowIndex].Cells["accessionnoDataGridViewTextBoxColumn"].Value.ToString();
            txt_bookbarcode.Text = dgv_book.Rows[e.RowIndex].Cells["bookbarcodeDataGridViewTextBoxColumn"].Value.ToString();
            txt_isbn.Text = dgv_book.Rows[e.RowIndex].Cells["isbnDataGridViewTextBoxColumn"].Value.ToString();
            txt_title.Text = dgv_book.Rows[e.RowIndex].Cells["titleDataGridViewTextBoxColumn"].Value.ToString();
            txt_author.Text = dgv_book.Rows[e.RowIndex].Cells["authorDataGridViewTextBoxColumn"].Value.ToString();
            txt_categoryid.Text = dgv_book.Rows[e.RowIndex].Cells["categoryidDataGridViewTextBoxColumn"].Value.ToString();
            txt_publisher.Text = dgv_book.Rows[e.RowIndex].Cells["publisherDataGridViewTextBoxColumn"].Value.ToString();
            txt_noofcopies.Text = dgv_book.Rows[e.RowIndex].Cells["noofcopiesDataGridViewTextBoxColumn"].Value.ToString();
            txt_edition.Text = dgv_book.Rows[e.RowIndex].Cells["editionDataGridViewTextBoxColumn"].Value.ToString();
            txt_noofpages.Text = dgv_book.Rows[e.RowIndex].Cells["pagesDataGridViewTextBoxColumn"].Value.ToString();
            txt_price.Text = dgv_book.Rows[e.RowIndex].Cells["priceDataGridViewTextBoxColumn"].Value.ToString();
            txt_purchaseid.Text = dgv_book.Rows[e.RowIndex].Cells["purchaseidDataGridViewTextBoxColumn"].Value.ToString();
            date_publishdate.Value = (DateTime)dgv_book.Rows[e.RowIndex].Cells["publishdateDataGridViewTextBoxColumn"].Value;
            cmb_language.Text = dgv_book.Rows[e.RowIndex].Cells["booklanguageDataGridViewTextBoxColumn"].Value.ToString();
            cmb_bookstatus.Text = dgv_book.Rows[e.RowIndex].Cells["bookstatusDataGridViewTextBoxColumn"].Value.ToString();
           

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookTableAdapter.FillBy(this.sudheesanDataSet.book);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridAcc(metroTextBox1.Text);
        }

        private void txt_book_author_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridTitle(txt_book_author.Text);
        }

        private void txt_purchaseid_Click(object sender, EventArgs e)
        {

        }

        private void txt_accessionnumber_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
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
        private void metroButton3_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "DO YOU WANT TO DELETE THE RECORD", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {

                    if (dba.deleteBook(txt_accessionnumber.Text))
                    {


                        MetroMessageBox.Show(this,"Successfully deleted");
                        ClearAllTextBox(this);
                        FillBook();
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


                FillBook();
            }
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_book_author_Click(object sender, EventArgs e)
        {

        }

        public void FilterDataGridAuthor(string a)
        {
            DataSet ds = dba.FilterBookAuthor(a);
            dgv_book.DataSource = ds.Tables["book"].DefaultView;
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridAuthor(metroTextBox3.Text);
        }
       
    }
}
