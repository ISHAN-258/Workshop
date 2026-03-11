using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mailer mailer = new Mailer();   
            Console.WriteLine("Enter the email address to send to:");
            string sendto = Console.ReadLine();
            Console.WriteLine("Enter the subject of the email:");
            string subject = Console.ReadLine();
            Console.WriteLine("Enter the message of the email:");
            string message = Console.ReadLine();
            bool result = mailer.SendMyEmail(sendto, subject, message);
            if (result)
            {
                Console.WriteLine("Email sent successfully!");
            }
            else
            {
                Console.WriteLine("Failed to send email.");
            }
        }
    }
}
