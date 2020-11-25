using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Spam01
{
    public class SpamBot
    {
        public async void SpamAsync(string fmail, string ps, string tmail, string sub, string mes, string log, string pass)
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
            await smtp.SendMailAsync(m);
            Console.WriteLine("Письмо отправлено " + fmail);
            
        }
    }
}
