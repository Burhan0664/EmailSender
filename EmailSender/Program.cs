using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fromEmail = "burhan064@hotmail.com";
            string fromPassword = "pswd";

            string toEmail = "bedirhan.yasin06@gmail.com";

            string subject = "Merhaba!";
            string body = "Bu bir test e-postasıdır.";

            SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(fromEmail, fromPassword);

            try
            {
                MailMessage mail = new MailMessage(fromEmail, toEmail, subject, body);
                smtpClient.Send(mail);
                Console.WriteLine("E-posta gönderildi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("E-posta gönderme hatası: " + ex.Message);
            }

            smtpClient.Dispose();
            Console.WriteLine("Çıkış yapmak için bir tuşa basın.");
            Console.ReadKey();
           
        }
       
    }
}