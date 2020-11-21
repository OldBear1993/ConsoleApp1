using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Spam01
{
    public class SpamBot
    {
        public string fmail;
        public string ps;
        public string tmail;
        public string sub;
        public string mes;
        public string log;
        public string pass;

        public void Spam()
        {
            MailAddress from = new MailAddress(fmail, ps);
            MailAddress to = new MailAddress(tmail);
            MailMessage m = new MailMessage(from, to);
            m.Subject = sub;
            m.Body = mes;
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 2525);
            smtp.Credentials = new NetworkCredential(log, pass);
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}
