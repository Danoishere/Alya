using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace Alya.MailEngine
{


    public class MailClient
    {
        public string SenderAddress { get; set; }
        public string Password { get; set; }
        public string Host { get; set; } = "smtp.gmail.com";

        public MailClient(string senderAddress, string password)
        {
            SenderAddress = senderAddress;
            Password = password;
        }

        public async Task SendEmail(string toEmailAddresses, string emailSubject, string emailMessage)
        {
            await SendEmail(new string[] { toEmailAddresses }, emailSubject, emailMessage);
        }

        public async Task SendEmail(string[] toEmailAddresses, string emailSubject, string emailMessage)
        {
            var message = new MailMessage();
            foreach (var receiver in toEmailAddresses)
            {
                message.To.Add(receiver);
            }
            message.IsBodyHtml = true;
            message.Subject = emailSubject;
            message.Body = emailMessage;
            message.From = new MailAddress(SenderAddress);

            using (var smtp = new SmtpClient(Host))
            {
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential(SenderAddress, Password);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                
                await smtp.SendMailAsync(message);
            }
        }
    }
}