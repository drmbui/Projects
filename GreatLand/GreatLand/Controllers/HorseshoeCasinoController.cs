using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreatLand;
using GreatLand.Models;

using System.Threading;
using System.Threading.Tasks;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace GreatLand.Controllers
{
    public class HorseshoeCasinoController : Controller
    {

        private Dal dal = new Dal();
        private BusinessLogic.BusinessLogic logic = new BusinessLogic.BusinessLogic();


        // GET: HG
        public ActionResult Index(int? id)
        {
            List<SelectListItem> li = new List<SelectListItem>();

            li.Add(new SelectListItem { Text = "Southwest Houston", Value = "1" });
            li.Add(new SelectListItem { Text = "South Houston", Value = "2" });
            li.Add(new SelectListItem { Text = "45 North Little York, Houston", Value = "3" });
            li.Add(new SelectListItem { Text = "Lufkin, TX", Value = "4" });

            ViewData["Location"] = li;
            var greatLandRoute = new List<Routes>();

            foreach (var doc in LookupData.HS_SWH)
            {

                //put an increment here to add the description 1 time
                int descCount = 0;

                greatLandRoute.Add(new Routes(doc.Route,
                                                doc.Day,
                                                doc.Depart,
                                                doc.ArriveCasino,
                                                doc.DepartCasino,
                                                doc.ReturnTime,
                                                doc.YouPay,
                                                doc.YouReceive,
                                                doc.DescriptionH,
                                                doc.DescriptionD,
                                                doc.SelectedParameter
                                                ,
                                                 1, //ROUTE PLACE HOLDER
                                                ""
                                                ));

                if (descCount == 0)
                {
                    TempData["LocationDesc"] = doc.DescriptionH + ": " + doc.DescriptionD;
                }

                descCount++;
            }


            return View(greatLandRoute);
        }

        [HttpPost]
        public ActionResult Index(int SearchValue)
        {

            List<SelectListItem> li = new List<SelectListItem>();

            li.Add(new SelectListItem { Text = "Southwest Houston", Value = "1" });
            li.Add(new SelectListItem { Text = "South Houston", Value = "2" });
            li.Add(new SelectListItem { Text = "45 North Little York, Houston", Value = "3" });
            li.Add(new SelectListItem { Text = "Lufkin, TX", Value = "4" });

            ViewData["Location"] = li;

            var location = dal.GetHSPickupLocation(SearchValue);
            TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            return View(location);
        }

        public ActionResult Confirm(CustTaskModelBson cust)
        {
            var confirm = new CustTaskModel(cust.Route,
                                            cust.LastName,
                                            cust.FirstName,
                                            cust.Email,
                                            cust.Phone,
                                            cust.SeatsNumber,
                                            cust.Date,
                                            cust.CreatedDate,
                                            cust.UpDate,
                                            cust.PersonUpdate,
                                            cust.Notes,
                                            cust.Confirmation,
                                              cust.Traveler1Name,
                                            cust.Traveler2Name,
                                            cust.Traveler3Name,
                                            cust.Traveler4Name,
                                            cust.Traveler5Name,
                                            cust.Traveler6Name,
                                            cust.TravelDisclosure);


            return View(confirm);
        }

        // GET: GGN/Create
        public async Task<ActionResult> Create(string id)
        {
            var custTaskModelBson = new CustTaskModelBson();
            var greatLandRoute = new List<Routes>();

            var route = dal.GetHSPickupLocation(id.Substring(0, 2));
            var test = (from values in route where values.Route == id select values);

            foreach (var doc in test)
            {
                //put an increment here to add the description 1 time
                int descCount = 0;
                //var greatLa = BsonSerializer.Deserialize<CustTaskModel>(doc);
                greatLandRoute.Add(new Routes(doc.Route,
                                                doc.Day,
                                                doc.Depart,
                                                doc.ArriveCasino,
                                                doc.DepartCasino,
                                                doc.ReturnTime,
                                                doc.YouPay,
                                                doc.YouReceive,
                                                doc.DescriptionH,
                                                doc.DescriptionD,
                                                1,
                                                 1, //ROUTE PLACE HOLDER
                                                ""
                                                ));
                if (descCount == 0)
                {
                    TempData["Courses"] = doc.DescriptionH + ": " + doc.DescriptionD;
                }
                descCount++;

            }

            ViewData["route"] = greatLandRoute;


            /*
            var test = (from values in location where values.Route == id select values);

            ViewData["route"] = (from values in location where values.Route == id select values);

            //TempData["Courses"] = Convert.ToString(doc["DescriptionH"]) + ": " + Convert.ToString(doc["DescriptionD"]);

    */

            //var greatLa = BsonSerializer.Deserialize<CustTaskModel>(doc);
            custTaskModelBson.Route = id;
            custTaskModelBson.Date = DateTime.Now;

            return View(custTaskModelBson);
        }


        [HttpPost]
        public ActionResult Create(CustTaskModelBson cust)
        {
            //if (ModelState.IsValid)
            if (logic.IsValidDate(cust.Date))
            {
                cust.PersonUpdate = "System";
                dal.CreateTask(cust);
                return RedirectToAction("Confirm", cust);

            }


            //if (logic.IsValidDate(cust.Date))
            //{


            //ViewData["route"] = cust;
            //return RedirectToAction("Confirm");
            //}
            //else
            //{
            //return false and post it to the user
            // return RedirectToAction("Create");
            //}
            var greatLandRoute = new List<Routes>();
            var route = dal.GetHSPickupLocation(cust.Route.Substring(0, 2));
            var test = (from values in route where values.Route == cust.Route select values);

            foreach (var doc in test)
            {
                //put an increment here to add the description 1 time
                int descCount = 0;
                //var greatLa = BsonSerializer.Deserialize<CustTaskModel>(doc);
                greatLandRoute.Add(new Routes(doc.Route,
                                                doc.Day,
                                                doc.Depart,
                                                doc.ArriveCasino,
                                                doc.DepartCasino,
                                                doc.ReturnTime,
                                                doc.YouPay,
                                                doc.YouReceive,
                                                doc.DescriptionH,
                                                doc.DescriptionD,
                                                1,
                                                 1, //ROUTE PLACE HOLDER
                                                ""
                                                ));
                if (descCount == 0)
                {
                    TempData["Courses"] = doc.DescriptionH + ": " + doc.DescriptionD;
                }
                descCount++;

            }

            ViewData["route"] = greatLandRoute;


            return View(cust);

        }
    }
}
