﻿using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Spam01
{
    public class SpamBot
    {

        public void Spam()
        {
            MailAddress from = new MailAddress("spam.kabal.a@mail.ru", "Альфарий");
            MailAddress to = new MailAddress("dimakoval0198@gmail.com");
            MailMessage m = new MailMessage(from, to);
            m.Subject = "ОСТОРОЖНО";
            m.Body = "<h2>Человечки, не стоит обкашливать этот вопрос. Вы ровные, надежные, вам все легко. Это не то. Это не Кабанчик и даже не циферки. Сюда лучше не подскакивать. Серьезно, любой из вас будет жалеть. Лучше спрыгните с этой темы и забудьте что тут вентилировалось. Я вполне понимаю что данной позицией вызову дополнительное желание обмозговать, но хочу сразу предостеречь проверенных - отзвонитесь. Остальные просто не услышат.</h2>";
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 2525);
            smtp.Credentials = new NetworkCredential("spam.kabal.a@mail.ru", "0000Fkma");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}