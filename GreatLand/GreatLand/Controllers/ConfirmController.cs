using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreatLand.Models;

namespace GreatLand.Controllers
{
    public class ConfirmController : Controller
    {

        private Dal dal = new Dal();
        private BusinessLogic.BusinessLogic logic = new BusinessLogic.BusinessLogic();

        // GET: Confirm
        public ActionResult Index(long id)
        {
            var cust = new CustTaskModelBson();
            dal.ConfirmReservation(id);
            cust.Confirmation = id;
            return View(cust);
        }
    }
}