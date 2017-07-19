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
using SQLServerDatabaseAccess;
using MetroFramework.Forms;

namespace StaffMain
{
    public partial class AARALK : MetroForm
    {
        SqlConnection con;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();


        public AARALK()
        {
            InitializeComponent();
            con = ConnectionManager.getConnection();
            con.Open();

            SqlCommand sc = new SqlCommand("select * from vacancy",con);
            da.SelectCommand = sc;



            SqlCommand uc = new SqlCommand("UPDATE vacancy SET first_name = @first_name WHERE vacancy_no = @vacancy_no",con);
            uc.Parameters.Add("@first_name",SqlDbType.VarChar,200,"first_name");
            uc.Parameters.Add("@vacancy_no", SqlDbType.VarChar, 200, "vacancy_no");
            da.UpdateCommand = uc;



            SqlCommand dc = new SqlCommand("DELETE FROM vacancy WHERE vacancy_no = @vacancy_no", con);
            dc.Parameters.Add("@vacancy_no", SqlDbType.VarChar).SourceColumn = "vacancy_no";
            da.DeleteCommand= dc;



            da.Fill(ds,"vacancy");
            bs.DataSource = ds.Tables["vacancy"];
            
            metroGrid1.DataSource = bs;
            
            metroTextBox1.DataBindings.Add("Text", bs, "first_name");
        }

        private void SetBindings()
        {
            metroTextBox1.DataBindings.Add("Text", bs, "first_name");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            da.Update(ds.Tables["vacancy"]);
            MessageBox.Show("Saved");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
            bs.EndEdit();
            da.DeleteCommand.ExecuteNonQuery();
            da.Update(ds.Tables["vacancy"]);
            MessageBox.Show("Deleted");
        }

        private void AARALK_Load(object sender, EventArgs e)
        {

        }
    }
}
