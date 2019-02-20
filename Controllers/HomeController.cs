using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_first_app.Controllers
{
    public class HomeController : Controller
    {
        //http://domaine/Home/Index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //sac pou mettre les données pour les afficher a partir de la vue
            ViewBag.Message = "Your application description page.";
            ViewBag.Test = "test";
            //type int
            ViewBag.Number = 2;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}