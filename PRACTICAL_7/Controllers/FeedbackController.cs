using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PRACTICAL_7.Models;

namespace PRACTICAL_7.Controllers
{
    public class FeedbackController : Controller
    {
        static List<Feedback> _feedbacks = new List<Feedback>();

        public ActionResult Index()
        {
            return View();

        }
        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            _feedbacks.Add(feedback);
            return RedirectToAction("List");

        }
        public ActionResult List()
        {
            return View(_feedbacks);
        }

    }
}