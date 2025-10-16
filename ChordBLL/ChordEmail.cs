using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace ChordBLL
{
    class ChordEmail
    {
        public void SendEmail(string toEmail, string subject, string body)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Musical Chord Application", "no-reply@musicalchordapp.com"));
            message.To.Add(new MailboxAddress("User", toEmail));
            message.Subject = "Chord Progression";
            message.Body = new TextPart("plain")
            {
                Text = body
            };

            using (var client = new SmtpClient())
            {
                var smtpHost = "sandbox.smtp.mailtrap.io";
                var smtpPort = 25;
                var tls = MailKit.Security.SecureSocketOptions.StartTls;
                client.Connect(smtpHost, smtpPort, tls);

                var smtpUsername = "dcc2c311f42c4a";
                var smtpPassword = "10e29fa88509e5";

                client.Authenticate(smtpUsername, smtpPassword);
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
