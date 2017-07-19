using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using MetroFramework;
using System.Windows.Forms;

namespace AdministrativeCommunicationSystem
{
    class Email
    {
        //private String smtpCli, email, password;
        //private int port;
        //private bool ssl;
        public Email(List<String> rec, String subject, String msg) {
           
            if (rec.Count <= 100)
            {
              
                try
                {
                    
                   MailMessage mail = new MailMessage();
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;
                    client.Credentials = new System.Net.NetworkCredential("sama.itpsliit@gmail.com","sama.itp@3");
                    client.EnableSsl = true;

                    mail.From = new MailAddress("sama.itpsliit@gmail.com");
                    for (int i = 0; i < rec.Count; i++ )
                    {
                        mail.To.Add(rec[i]);
                        MessageBox.Show( rec[i]);
                    }
                    mail.Subject = subject;
                    mail.Body = msg;

                    client.Send(mail);
                    MessageBox.Show("Email Sent successfully!");
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show( e.Message);
                }
            }
            else {
                MessageBox.Show("Gmail limits you from sending to more than 100 recipients. Please reduce the number of recipients and try again.");
            }
        
        }
        public Email(List<String> rec, String subject, String msg, String AttPath)
        {
            if (rec.Count <= 100)
            {

                try
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;
                    client.Credentials = new System.Net.NetworkCredential("sama.itpsliit@gmail.com", "sama.itp@3");
                    client.EnableSsl = true;

                    mail.From = new MailAddress("sama.itpsliit@gmail.com");
                    for (int i = 0; i < rec.Count; i++)
                    {
                        mail.To.Add(rec[i]);
                        MessageBox.Show(rec[i]);
                    }
                    mail.Subject = subject;
                    mail.Body = msg;
                    System.Net.Mail.Attachment att = new Attachment(AttPath);
                    mail.Attachments.Add(att);
                    client.Send(mail);
                    MessageBox.Show("Email Sent successfully!");

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                MessageBox.Show("Gmail limits you from sending to more than 100 recipients. Please reduce the number of recipients and try again.");
            }

        }
        public Email(String smtpCli, int port, String email, String password, bool ssl, List<String> rec, String subject, String msg)
        {


            if (rec.Count <= 100)
            {

                try
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient client = new SmtpClient(smtpCli);
                    client.Port = port;
                    client.Credentials = new System.Net.NetworkCredential(email, password);
                    client.EnableSsl = ssl;

                    mail.From = new MailAddress("sama.itpsliit@gmail.com");
                    for (int i = 0; i < rec.Count; i++)
                    {
                        mail.To.Add(rec[i]);
                        MessageBox.Show(rec[i]);
                    }
                    mail.Subject = subject;
                    mail.Body = msg;
                    //System.Net.Mail.Attachment att = new Attachment(AttPath);
                    //mail.Attachments.Add(att);
                    client.Send(mail);
                    MessageBox.Show("Email Sent successfully!");

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                MessageBox.Show("Gmail limits you from sending to more than 100 recipients. Please reduce the number of recipients and try again.");
            }
        }
        public Email(String smtpCli, int port, String email, String password, bool ssl, List<String> rec, String subject, String msg, String AttPath)
        {

            if (rec.Count <= 100)
            {

                try
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient client = new SmtpClient(smtpCli);
                    client.Port = port;
                    client.Credentials = new System.Net.NetworkCredential(email, password);
                    client.EnableSsl = ssl;

                    mail.From = new MailAddress("sama.itpsliit@gmail.com");
                    for (int i = 0; i < rec.Count; i++)
                    {
                        mail.To.Add(rec[i]);
                        MessageBox.Show(rec[i]);
                    }
                    mail.Subject = subject;
                    mail.Body = msg;
                    System.Net.Mail.Attachment att = new Attachment(AttPath);
                    mail.Attachments.Add(att);
                    client.Send(mail);
                    MessageBox.Show("Email Sent successfully!");

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                MessageBox.Show("Gmail limits you from sending to more than 100 recipients. Please reduce the number of recipients and try again.");
            }
        }
    }
}
