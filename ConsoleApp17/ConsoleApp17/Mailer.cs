using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Mailer
    {
        string MyEmail = "Ishan2004tripathi@gmail.com";
        string MyPassword = "cfox cbgy qwrd havc";

        public bool SendMyEmail(string sendto, string subject, string message)
        {
            try
            {


                MailMessage msg = new MailMessage();
                MailAddress from = new MailAddress(MyEmail);
                msg.From = from;
                msg.Subject = subject;
                msg.To.Add(sendto);
                msg.Body = message;
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                NetworkCredential nc = new NetworkCredential(MyEmail, MyPassword);
                client.Credentials = nc;
                client.Send(msg);
                return true;
            }
            catch
            {
                return false;
            }
        }
        

    }
}
