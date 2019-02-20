using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp_first_app.Models;
namespace asp_first_app.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return View();
        }
        //http://localhost:51623/Article/Lire?id=3&title=sgdfg
        [Route("lire/{id}/{title}")]
        public ActionResult Lire(int id,string title)
        {
            if(!string.IsNullOrEmpty(title))
            {
                var titre = Request.Params["title"];
            }
            

            ViewBag.ArticleID = id;
            ViewBag.ArticleTitle = title;
            return View();
        }

       
        public ActionResult Ecrire(int id,string title)
        {
            var model = new EcrireModel();
            model.id=id;
            model.title = title;


            return View(model);
        }
    }
}