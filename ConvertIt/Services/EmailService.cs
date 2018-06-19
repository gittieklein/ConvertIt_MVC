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
        readonly string emailFrom = "convertitconversions@gmail.com";
        readonly string fromPassword = "neumannklein";

        public void SendEmail(string emailTo, string subject, string body)
        {                 
            var fromAddress = new MailAddress(emailFrom, "ConvertIt");
            var toAddress = new MailAddress(emailTo);

            AlternateView alternateView = CreateEmailBody(body);         

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

        public AlternateView CreateEmailBody(string body)
        {
            var linkedResource = new LinkedResource("C:\\Users\\Gittie Klein\\OneDrive\\Documents\\Projects\\ConvertIt\\ConvertIt\\Images\\logo.jpg", MediaTypeNames.Image.Jpeg);

            var htmlBody = $"<p>{body}</p><br><p>The ConvertIt Team</p><br><img style='width:230px' src=\"cid:{linkedResource.ContentId}\"/>";

            var alternateView = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);
            alternateView.LinkedResources.Add(linkedResource);

            return alternateView;
        }



    }
}