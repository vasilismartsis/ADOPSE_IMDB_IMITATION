using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace ADOPSE_IMDB_IMITATION
{
    public partial class Complaints : UserControl
    {
        public Complaints()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("vasilismartsis97@gmail.com");
                msg.To.Add("vasilismartsis@yahoo.gr");
                msg.Subject = SubjectTextBox.Text;
                msg.Body = BodyRichTextBox.Text;

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "therealdeal917@gmail.com";
                ntcd.Password = "B16301850b";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("Your Mail is sended");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
