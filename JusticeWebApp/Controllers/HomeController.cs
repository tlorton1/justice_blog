using JusticeWebApp.Models;
using JusticeWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JusticeWebApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IMessageService _mail;

        public HomeController(IMessageService mail)
        {
            _mail = mail;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Post()
        {
            ViewBag.Message = "Your blog post page.";

            return View();
        }

        public ActionResult Manage()
        {
            ViewBag.Message = "Manage Accounts page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactModel model)
        {
            var msg = string.Format("Name: {1}{0}Email:{2}{0}Message:{3}{0}", Environment.NewLine, 
                model.Name,
                model.Email,
                model.Message);

            if (_mail.SendMessage("Name", "test@email.com", "Message"))
            {
                ViewBag.MailSent = true;
            }

            return View();
        }

    }
}