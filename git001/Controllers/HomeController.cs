using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace git001.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "kenan 0012";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact kenan 00333 55555555.";

            string ss = System.Configuration.ConfigurationManager.AppSettings.Get("csckeyx");
            System.Diagnostics.Trace.TraceInformation( "Contract is clicked. {0} at {1}", ss, DateTime.Now.ToString())
            return View();
        }
    }
}