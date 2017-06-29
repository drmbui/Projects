using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreatLand.Models;
using GreatLand;
using System.Configuration;

using System.Threading;
using System.Threading.Tasks;

namespace GreatLand.Controllers
{
    public class HomeController : Controller, IDisposable
    {
        private Dal dal = new Dal();
        private bool disposed = false;


        public ActionResult Index()
        {
            List<CustTaskModel> greatLand = new List<CustTaskModel>();
            return View(greatLand);
        }



        public ActionResult Home()
        {
            return Redirect("http://greatlandtours.com");
        }
        //
        // GET: /MyTask/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MyTask/Create

        [HttpPost]
        public ActionResult CreateCust(CustTaskModelBson task)
        {
            try
            {
                dal.CreateTask(task);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Charters()
        {
            return View();
        }

        public ActionResult Policy()
        {
            return View();
        }

        # region IDisposable

        new protected void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        new protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.dal.Dispose();
                }
            }

            this.disposed = true;
        }

        # endregion

    }
}