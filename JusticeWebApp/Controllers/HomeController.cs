using JusticeWebApp.Data;
using JusticeWebApp.Models;
using JusticeWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JusticeWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IPostRepository _repo;

        public HomeController(IPostRepository repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult Post()
        {
            ViewBag.Message = "Your blog post page.";

            var comments = _repo.GetComments()
                                .OrderByDescending(t => t.Created)
                                .Take(10)
                                .ToList();

            return View(comments);
        }

        [Authorize]
        public ActionResult Manage()
        {
            ViewBag.Message = "Manage Accounts page.";

            return View();
        }

        //[HttpPost]
        //public ActionResult Contact(ContactModel model)
        //{
        //    var msg = string.Format("Name: {1}{0}Email:{2}{0}Message:{3}{0}", Environment.NewLine, 
        //        model.Name,
        //        model.Email,
        //        model.Message);

        //    if (_mail.SendMessage("Name", "test@email.com", "Message"))
        //    {
        //        ViewBag.MailSent = true;
        //    }

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult PostComment()
        //{
        //    var comments = _repo.GetComments()
        //                        .OrderByDescending(t => t.Created)
        //                        .Take(10)
        //                        .ToList();

        //    return View("../Views/Home/Post", model);
        //}

    }
}