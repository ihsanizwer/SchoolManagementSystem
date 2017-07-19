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
    public partial class BackupRestore : MetroForm
    {
        DataCon dc;
        SqlCommand cmd;
        SqlDataReader rd;
        String sql;
        int counter1 = 0; 
        int counter2 =0;
        public BackupRestore()
        {
            
            dc = new DataCon();
            InitializeComponent();
        }

        private void BackupRestore_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dl = new FolderBrowserDialog();
            if(dl.ShowDialog()==DialogResult.OK){
                metroTextBox4.Text = dl.SelectedPath;
                counter1++;
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            
            if (!((String.IsNullOrEmpty(metroTextBox4.Text) || (String.IsNullOrEmpty(metroTextBox5.Text)))))
            {
                if (counter1 > 0)
                {
                    counter1 = 0;
                    if (LoggedIn.LogIn(metroTextBox6.Text) == true)
                    {
                        sql = "BACKUP DATABASE ITP_FINAL_DB TO DISK ='" + metroTextBox4.Text + "\\ITP_FINAL_DB-" + metroTextBox5.Text + ".bak'";
                        cmd = new SqlCommand(sql, dc.getCon());
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        dc.closeCon();
                        dc.dispCon();
                        MessageBox.Show("Successfully Backed up!");
                    }
                    else { MessageBox.Show("Invalid Password!"); }
                }
                else { MessageBox.Show("Please Pick Backup Location"); }
                }
                else
                {
                    MessageBox.Show("one or more empty fields. You cannot leave them blank!");
                }
            
        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Backup files (*.bak)|*.bak| All Files(*.*)|*.*";
            od.FilterIndex = 0;
            if(od.ShowDialog()==DialogResult.OK){
                metroTextBox1.Text = od.FileName;
                counter2++;
            }
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            ADMainMenu am = new ADMainMenu();
            am.Show();
            this.Hide();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            new ADMainMenu().Show();
            this.Hide();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(metroTextBox1.Text))))
            {
                if (counter2 > 0)
                {
                    counter2 = 0;
                    if (LoggedIn.LogIn(metroTextBox2.Text))
                    {
                        String command = "use master; ALTER DATABASE ITP_FINAL_DB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                        command += "RESTORE DATABASE ITP_FINAL_DB FROM DISK ='" + metroTextBox1.Text + "' WITH REPLACE;ALTER DATABASE ITP_FINAL_DB SET Multi_User";
                        DataCon dc4 = new DataCon();
                        dc4.openCon();
                        SqlCommand cmd = new SqlCommand(command, dc4.getCon());
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        dc4.closeCon();
                        dc4.dispCon();
                        MessageBox.Show("SuccessFully Restored");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password!");
                    }
                }
                else { MessageBox.Show("Please Pick Backup Location"); }
            }
            else {
                MessageBox.Show("one or more empty fields. You cannot leave them blank!");
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {

            LoggedIn.logOut();
            Application.Restart();
        }

        private void BackupRestore_FormClosed(object sender, FormClosedEventArgs e)
        {

            LoggedIn.logOut();
            Application.Restart();
        }
    }
}
