using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.StorageClient;
using System.Configuration;
using System.Data.Services.Client;

namespace git001.Controllers
{
    public class StateCounty
    {
        public String Address { get; set; }
        public int Size { get; set; }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            CloudStorageAccount sa = CloudStorageAccount.Parse(
                ConfigurationManager.ConnectionStrings["StorageConnectionString"].ConnectionString);

            CloudTableClient tc = sa.CreateCloudTableClient();

            TableServiceContext tsc = tc.GetDataServiceContext();

            CloudTableQuery<StateCounty> res =  tsc.CreateQuery<StateCounty>("tableExplore003").AsTableServiceQuery<StateCounty>();

            string ss = "";
            foreach( StateCounty one in res)
            {
                ss = String.Format("Address: {0}, Size: {1} \n", one.Address, one.Size);
            }

            System.Diagnostics.Trace.TraceInformation(ss);

            ViewBag.Message = ss;

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact kenan 00333 55555555.";

            string ss = System.Configuration.ConfigurationManager.AppSettings.Get("csckeyx");
            System.Diagnostics.Trace.TraceInformation("Contract is clicked. {0} at {1}", ss, DateTime.Now.ToString());
            return View();
        }
    }
}