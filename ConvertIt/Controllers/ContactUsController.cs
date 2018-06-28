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

        //[HttpPost]
        public void SendEmail(string name, string email, string subject, string message = "")
        {
            EmailService.SendEmail(name, email, subject, message);
        }
    }
}