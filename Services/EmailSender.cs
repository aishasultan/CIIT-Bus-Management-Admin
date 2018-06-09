using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace testing.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string body)
        {
            var fromAddress = new MailAddress("myemail", "Aisha Sultan");
            var toAddress = new MailAddress(email);
            var mail = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            };
            ContentType mimeType = new ContentType("text/html");

            // Add the alternate body to the message.

            AlternateView alternate = AlternateView.CreateAlternateViewFromString(body, mimeType);
            mail.AlternateViews.Add(alternate);
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s,
                        System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                        System.Security.Cryptography.X509Certificates.X509Chain chain,
                        System.Net.Security.SslPolicyErrors sslPolicyErrors)
            {
                return true;
            };
            using (var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(fromAddress.Address, "password")
            })
            {
                client.Send(mail);
                return Task.CompletedTask;
            };
        }
    }
}
