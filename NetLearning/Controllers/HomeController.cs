using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetLearning.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Section1()
        {
            ViewBag.Message = "Section I - Form Structure";

            return View();
        }

        public ActionResult Section2()
        {
            ViewBag.Message = "Section II - Building Forms";

            return View();
        }

        public ActionResult Section3()
        {
            ViewBag.Message = "Section III - Validation & POST Method";

            return View();
        }

        public ActionResult FinalQuiz()
        {
            ViewBag.Message = "Final Quiz";

            return View();
        }

        public ActionResult Chat()
        {
            return View();
        }
    }
}