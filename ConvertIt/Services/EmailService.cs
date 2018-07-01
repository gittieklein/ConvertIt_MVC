using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace ConvertIt.Services
{
    public class EmailService
    {
        readonly string email = "convertitconversions@gmail.com";
        readonly string fromPassword = "neumannklein";

        public void SendEmail(string name, string userEmail, string subject, string body)
        {
            SendEmailToConvertIt(name, userEmail, subject, body);
            SendEmailToUser(name, userEmail);     
        }

        public void SendEmailToConvertIt(string name, string userEmail, string subject, string body)
        {
            var fromAddress = new MailAddress(email, name + " " + userEmail);
            var toAddress = new MailAddress(email);

            body = body.Replace("---", "<br>");
            AlternateView alternateView = CreateEmailBody(body);
            Send(fromAddress, toAddress, alternateView, subject, body);
        }

        public void SendEmailToUser(string name, string userEmail)
        {
            var fromAddress = new MailAddress(email, "ConvertIt");
            var toAddress = new MailAddress(userEmail);

            string body = "<p>Thank you for reaching out to us. We will get back to you within the next 24 hours.</p>";
            AlternateView alternateView = CreateEmailBody(body);
            Send(fromAddress, toAddress, alternateView, "Thank you", body);
        }

        public AlternateView CreateEmailBody(string body)
        {
            var linkedResource = new LinkedResource("C:\\Users\\Gittie Klein\\OneDrive\\Documents\\Projects\\ConvertIt\\ConvertIt\\Images\\logo.jpg", MediaTypeNames.Image.Jpeg);

            var htmlBody = $"<p>{body}</p><br><p>The ConvertIt Team</p><br><img style='width:230px' src=\"cid:{linkedResource.ContentId}\"/>";

            var alternateView = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);
            alternateView.LinkedResources.Add(linkedResource);

            return alternateView;
        }

        public void Send(MailAddress fromAddress, MailAddress toAddress, AlternateView alternateView, string subject, string body)
        {
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
                AlternateViews = { alternateView }
            })
            {
                smtp.Send(message);
            }
        }

    }
}