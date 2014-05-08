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
        public String address { get; set; }
        public int size { get; set; }
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
                ss += String.Format("Address: {0}, Size: {1} \n", one.address, one.size);
            }

            System.Diagnostics.Trace.TraceInformation(ss);

            ViewBag.Message = ss;

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(string strInput)
        {
            if (!string.IsNullOrEmpty(strInput))
            {
                var MefCalcClient = new ServiceReference1.ServiceCalcClient();

                var strResult = MefCalcClient.MefCalculateIt(strInput);

                ViewBag.Message = string.Format("{0} = {1}", strInput, strResult);
            }

            return View();
        }
    }
}