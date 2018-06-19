using ConvertIt.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConvertIt.Controllers
{
    public class ContactUsController : Controller
    {
        EmailService EmailService = new EmailService();

        // GET: ContactUs
        public ActionResult Index()
        {
            return View();
        }

        public void SendEmail()
        {
            EmailService.SendEmail("gittiekay@gmail.com", "testemail", "dear blank<br>This is a test email lol<br>hope it works");
        }
    }
}