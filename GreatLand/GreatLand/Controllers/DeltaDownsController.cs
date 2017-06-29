using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreatLand.Models;
using GreatLand.BusinessLogic;
using System.Threading;
using System.Threading.Tasks;


using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace GreatLand.Controllers
{
    public class DeltaDownsController : Controller
    {

        private Dal dal = new Dal();
        private BusinessLogic.BusinessLogic logic = new BusinessLogic.BusinessLogic();


        // GET: Delta Downs
        public ActionResult Index(int? id)
        {

            List<SelectListItem> travelDate = new List<SelectListItem>();
            var days = logic.Get7Days();



            foreach (var i in days)
            {
                travelDate.Add(new SelectListItem { Text = i.Value, Value = i.Key.ToString() });
            }

            travelDate.Add(new SelectListItem { Text = "", Value = "", Selected = true });
            ViewData["TravelDate"] = travelDate;

            //2-Go get list of bus route departures for today (1) is always today

            //var d = (from i in days select i.Key).First();

            //logic.GetBusRouteDepartureToday(d, 1);   day and 1 is casino number = tb_casino
            //var routes = logic.GetBusRouteDepartureToday(d, Convert.ToInt16(Miscellaneous.CasinoDBNumber.Lauberge));

            //List<SelectListItem> li = new List<SelectListItem>();
            //foreach(var l in routes)
            //{
            //    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
            //}

            ViewData["Location"] = "";

            //3-Go get the route for the current pickup location
            //var greatLandRoute = new List<Routes>();
            //var loc = (from o in routes select o.Key).First();
            //var locDetail = logic.GetBusRouteDepartureDetails(Convert.ToInt32(loc), Convert.ToInt16(Miscellaneous.CasinoDBNumber.Lauberge));

            //foreach (var doc in LookupData.Laub_SouthHouston)
            //foreach (var doc in locDetail)
            //{

            //    //put an increment here to add the description 1 time
            //    int descCount = 0;

            //    greatLandRoute.Add(new Routes(doc.Route,
            //                                    doc.Day,
            //                                    doc.Depart,
            //                                    doc.ArriveCasino,
            //                                    doc.DepartCasino,
            //                                    doc.ReturnTime,
            //                                    doc.YouPay,
            //                                    doc.YouReceive,
            //                                    doc.DescriptionH,
            //                                    doc.DescriptionD,
            //                                    doc.SelectedParameter,
            //                                    doc.ManagerRouteNumber,
            //                                    doc.Route + "|" + d  // on the initial load - it will always load the today
            //                                    //doc.Id //ROUTE PLACE HOLDER
            //                                    )); 

            //    if (descCount == 0)
            //    {
            //        TempData["LocationDesc"] = doc.DescriptionH + ": " + doc.DescriptionD;
            //    }

            //    descCount++;
            //}

            TempData["LocationDesc"] = "";
            return View();
        }

        [HttpPost]
        public ActionResult Index()
        {
            //repopulate the travelDate
            var travelDateValue = Request["TravelDateValue"].ToString();
            List<SelectListItem> travelDate = new List<SelectListItem>();
            List<SelectListItem> li = new List<SelectListItem>();

            var days = logic.Get7Days();
            //1-The dropdowndate will retain the selected
            foreach (var i in days)
            {
                if (i.Key.ToString() == travelDateValue)
                {
                    travelDate.Add(new SelectListItem { Text = i.Value, Value = i.Key.ToString(), Selected = true });
                }
                else
                {
                    travelDate.Add(new SelectListItem { Text = i.Value, Value = i.Key.ToString() });
                }
            }
            ViewData["TravelDate"] = travelDate;
            var routes = logic.GetBusRouteDepartureToday(Convert.ToInt16(travelDateValue), Convert.ToInt16(Miscellaneous.CasinoDBNumber.DeltaDown));

            //there is a route so we process
            if (routes.Count() > 0 )
            {
                string searchValue = "";
                if (Request["SearchValue"] != null)
                {
                    //Go get list of bus route departures for the current travel date
                    //logic.GetBusRouteDepartureToday(d, 1);   day and 1 is casino number = tb_casino

                    searchValue = Request["SearchValue"].ToString();
                }



                //The dropdown will retain the selected
                foreach (var l in routes)
                {
                    if (l.Key.ToString() == searchValue)
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                    }
                    else
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                    }

                }

                ViewData["Location"] = li;

                //This is the 1st pass so we chose the default search value
                if (searchValue == "" && li != null)
                {
                    searchValue = li[0].Value;
                }


                //check to make sure the search value is in the new departure list since the date might have changed.
                var search = li.Find(item => item.Value.Equals(searchValue));

                List<Routes> location = new List<Routes>();
                if (search != null)
                {
                    location = dal.GetPickupLocationDB2(searchValue, travelDateValue, Convert.ToInt16(Miscellaneous.CasinoDBNumber.DeltaDown));
                }
                else
                {
                    //null because the original search value has nothing from the new list            
                    var loc = (from o in routes select o.Key).First();
                    location = dal.GetPickupLocationDB2(loc, travelDateValue, Convert.ToInt16(Miscellaneous.CasinoDBNumber.DeltaDown));

                    //logic.GetBusRouteDepartureDetails(Convert.ToInt32(loc)).ToList();
                }



                TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

                return View(location);
            }


            List<Routes> locationdefault = new List<Routes>();
            return View(locationdefault);
        }

        public ActionResult Confirm(CustTaskModelBson cust)
        {


            //Get the route for the heading

            //parse the id field
            string[] strArray = cust.Route.Split('|');
            //route
            var r = strArray[0];

            //day
            var d = strArray[1];

            var dayofWeek = logic.CalculateDayofWeekByNumber(Convert.ToInt16(d));


            var custTaskModelBson = new CustTaskModelBson();
            var greatLandRoute = new List<Routes>();

            var route = dal.GetLaubergePickupLocationDB(r);

            //var test = (from values in route where values.Route == id select values);

            foreach (var doc in route)
            {

                //var greatLa = BsonSerializer.Deserialize<CustTaskModel>(doc);
                greatLandRoute.Add(new Routes(doc.Route,
                                                dayofWeek.ToShortDateString(), //doc.Day,
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

                TempData["Courses"] = doc.DescriptionH + ": " + doc.DescriptionD;




            }

            ViewData["route"] = greatLandRoute;

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

        public ActionResult Sub(CustTaskModelBson cust)
        {
            cust.PersonUpdate = "System";
            var retCust = dal.CreateTask(cust);
            logic.SendMail(cust.Email, cust.LastName + "," + cust.FirstName, Convert.ToString(cust.Confirmation));
            return View(retCust);
        }
        public async Task<ActionResult> Create(string id)
        {

            //Make seat dropdown
            List<SelectListItem> seats = new List<SelectListItem>();
            var s = logic.GetSeats();

            foreach (var i in s)
            {
                seats.Add(new SelectListItem { Text = i.Value, Value = i.Key });
            }

            ViewData["Seats"] = seats;


            //parse the id field
            string[] strArray = id.Split('|');
            //route
            var r = strArray[0];

            //day
            var d = strArray[1];

            var dayofWeek = logic.CalculateDayofWeekByNumber(Convert.ToInt16(d));


            var custTaskModelBson = new CustTaskModelBson();
            var greatLandRoute = new List<Routes>();

            var route = dal.GetLaubergePickupLocationDB(r);

            //var test = (from values in route where values.Route == id select values);

            foreach (var doc in route)
            {

                //var greatLa = BsonSerializer.Deserialize<CustTaskModel>(doc);
                greatLandRoute.Add(new Routes(doc.Route,
                                                dayofWeek.ToShortDateString(), //doc.Day,
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

                TempData["Courses"] = doc.DescriptionH + ": " + doc.DescriptionD;




            }

            ViewData["route"] = greatLandRoute;            /*
            var test = (from values in location where values.Route == id select values);
            ViewData["route"] = (from values in location where values.Route == id select values);
            //TempData["Courses"] = Convert.ToString(doc["DescriptionH"]) + ": " + Convert.ToString(doc["DescriptionD"]);    */

            //var greatLa = BsonSerializer.Deserialize<CustTaskModel>(doc);
            custTaskModelBson.Route = id;
            custTaskModelBson.Date = dayofWeek;

            return View(custTaskModelBson);
        }

                [HttpPost]
        public ActionResult Create(CustTaskModelBson cust)
        {
            if (!ModelState.IsValid)
            {
                //Make seat dropdown
                List<SelectListItem> seats = new List<SelectListItem>();
                var s = logic.GetSeats();

                foreach (var i in s)
                {
                    seats.Add(new SelectListItem { Text = i.Value, Value = i.Key });
                }

                ViewData["Seats"] = seats;

                //parse the id field
                string[] strArray = cust.Route.Split('|');
                //route
                var r = strArray[0];

                //day
                var d = strArray[1];

                var dayofWeek = logic.CalculateDayofWeekByNumber(Convert.ToInt16(d));

                var custTaskModelBson = new CustTaskModelBson();
                var greatLandRoute = new List<Routes>();

                var route = dal.GetLaubergePickupLocationDB(r);

                foreach (var doc in route)
                {
                    //put an increment here to add the description 1 time
                    int descCount = 0;
                    //var greatLa = BsonSerializer.Deserialize<CustTaskModel>(doc);
                    greatLandRoute.Add(new Routes(doc.Route,
                                                    dayofWeek.ToShortDateString(), //doc.Day,
                                                    doc.Depart,
                                                    doc.ArriveCasino,
                                                    doc.DepartCasino,
                                                    doc.ReturnTime,
                                                    doc.YouPay,
                                                    doc.YouReceive,
                                                    doc.DescriptionH,
                                                    doc.DescriptionD,
                                                    1
                                                    ,
                                                     1, //ROUTE PLACE HOLDER
                                                ""
                                                    ));
                    
                    
                        TempData["Courses"] = doc.DescriptionH + ": " + doc.DescriptionD;
                   

                }

                ViewData["route"] = greatLandRoute;
                return View(cust);
            }

                cust.PersonUpdate = "System";
                return RedirectToAction("Confirm", cust);

        }

    }
}
