using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreatLand.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GenerateReport(string param1, int param2)
        {
            Session["ReportData"] = "FakeDB Data";
            ViewBag.ShowIFRame = true;

            return View();
        }
    }
}