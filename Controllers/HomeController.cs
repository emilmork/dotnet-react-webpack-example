using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var routes = new List<KeyValuePair<string, string>>();
            routes.Add(new KeyValuePair<string, string>("/home", "Home"));
            routes.Add(new KeyValuePair<string, string>("/home/about", "About"));
            routes.Add(new KeyValuePair<string, string>("/home/contact", "Contact"));

            ViewBag.Routes = routes;
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
    }
}