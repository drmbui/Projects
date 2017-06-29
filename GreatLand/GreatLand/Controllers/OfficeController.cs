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

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using Microsoft.AspNet.Identity;


using GreatLand.BusinessLogic;
namespace GreatLand.Controllers
{





    //[AdminSuperAdmin]
    //[CustomAttribute]
    [Authorize]
    public class OfficeController : BaseController
    {
        private Dal dal = new Dal();
        private bool disposed = false;
        private BusinessLogic.BusinessLogic logic = new BusinessLogic.BusinessLogic();
        string email = "";

        [Authorize]
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //if (Session["UserID"] == "" || Session["UserID"] == null)
            //{
            //    var user = Session["UserID"];
            //    //we can'f find the user session. send him to relogin
            //    Response.Redirect("~/Account/Login");

            //}
            var id = HttpContext.GetOwinContext();
            var claim = id.Authentication.User.Claims;
            foreach(var i in claim)
            {
                email = i.Value;
            }
            if (email ==  null || email == "")
            {
                //we can find his credential send hime to login
                RedirectToAction("LogIn", "Account", new { area = "" });
            }
            base.OnActionExecuting(filterContext);
        }


        [HttpPost]
        public ActionResult GoldenNuggetEdit(CustTaskModelBson cust)
        {
            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.GoldenNugget));
            List<SelectListItem> li = new List<SelectListItem>();

            //in case they submit before choosing a location
            if (cust.Country == "0")
            {
                foreach (var l in routes)
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }

                li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });
            }
            else
            {
                //The dropdown will retain the selected
                foreach (var l in routes)
                {
                    if (cust.Country == l.Value)
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                    }
                    else
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                    }
                }
            }


            ViewData["Country"] = li;


            ViewData["PickupTime"] = null;

            //get all of the route for at pickup - and selected = true on the route

            List<SelectListItem> states = new List<SelectListItem>();
            var loc = new List<Routes>();
            loc = dal.GetPickupLocationDB(Convert.ToInt16(cust.Country), Convert.ToInt16(Miscellaneous.CasinoDBNumber.GoldenNugget));
            //TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            //in case they submit before choosing a location
            if (cust.Country == "0")
            {
                states.Add(new SelectListItem { Text = "Select schedule", Value = "0", Selected = true });
            }
            else
            {

                foreach (var i in loc)
                {
                    if (i.Route == cust.State)
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route, Selected = true });
                    }
                    else
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route });
                    }
                }
            }



            ViewData["PickupTime"] = states;

            if (logic.IsValidDate(cust.Date))
            {
                var tr = Request["State"].ToString();
                cust.Route = tr;
   

                if (email != null)
                {
                    cust.PersonUpdate = email;
                }
                else
                {
                    cust.PersonUpdate = "NA";
                }

                dal.EditTask(cust);


                ViewData["route"] = cust;
                return RedirectToAction("Confirm", cust);
            }
            else
            {
                //return false and post it to the user
                return View();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeltaDownEdit(CustTaskModelBson cust)
        {
            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.DeltaDown));
            List<SelectListItem> li = new List<SelectListItem>();

            //in case they submit before choosing a location
            if (cust.Country == "0")
            {
                foreach (var l in routes)
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }

                li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });
            }
            else
            {
                //The dropdown will retain the selected
                foreach (var l in routes)
                {
                    if (cust.Country == l.Value)
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                    }
                    else
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                    }
                }
            }


            ViewData["Country"] = li;


            ViewData["PickupTime"] = null;

            //get all of the route for at pickup - and selected = true on the route

            List<SelectListItem> states = new List<SelectListItem>();
            var loc = new List<Routes>();
            loc = dal.GetPickupLocationDB(Convert.ToInt16(cust.Country), Convert.ToInt16(Miscellaneous.CasinoDBNumber.DeltaDown));
            //TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            //in case they submit before choosing a location
            if (cust.Country == "0")
            {
                states.Add(new SelectListItem { Text = "Select schedule", Value = "0", Selected = true });
            }
            else
            {

                foreach (var i in loc)
                {
                    if (i.Route == cust.State)
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route, Selected = true });
                    }
                    else
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route });
                    }
                }
            }



            ViewData["PickupTime"] = states;

            if (logic.IsValidDate(cust.Date))
            {
                var tr = Request["State"].ToString();
                cust.Route = tr;
        

                if (email != null)
                {
                    cust.PersonUpdate = email;
                }
                else
                {
                    cust.PersonUpdate = "NA";
                }


                dal.EditTask(cust);


                ViewData["route"] = cust;
                return RedirectToAction("Confirm", cust);
            }
            else
            {
                //return false and post it to the user
                return View();
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult CoushattaEdit(CustTaskModelBson cust)
        {
            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.Coushatta));
            List<SelectListItem> li = new List<SelectListItem>();

            //in case they submit before choosing a location
            if (cust.Country == "0")
            {
                foreach (var l in routes)
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }

                li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });
            }
            else
            {
                //The dropdown will retain the selected
                foreach (var l in routes)
                {
                    if (cust.Country == l.Value)
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                    }
                    else
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                    }
                }
            }


            ViewData["Country"] = li;


            ViewData["PickupTime"] = null;

            //get all of the route for at pickup - and selected = true on the route

            List<SelectListItem> states = new List<SelectListItem>();
            var loc = new List<Routes>();
            loc = dal.GetPickupLocationDB(Convert.ToInt16(cust.Country), Convert.ToInt16(Miscellaneous.CasinoDBNumber.Coushatta));
            //TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            //in case they submit before choosing a location
            if (cust.Country == "0")
            {
                states.Add(new SelectListItem { Text = "Select schedule", Value = "0", Selected = true });
            }
            else
            {

                foreach (var i in loc)
                {
                    if (i.Route == cust.State)
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route, Selected = true });
                    }
                    else
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route });
                    }
                }
            }



            ViewData["PickupTime"] = states;

            if (logic.IsValidDate(cust.Date))
            {
                var tr = Request["State"].ToString();
                cust.Route = tr;


                if (email != null)
                {
                    cust.PersonUpdate = email;
                }
                else
                {
                    cust.PersonUpdate = "NA";
                }



                dal.EditTask(cust);


                ViewData["route"] = cust;
                return RedirectToAction("Confirm", cust);
            }
            else
            {
                //return false and post it to the user
                return View();
            }
            return RedirectToAction("Index");
        }



        [HttpPost]
        public ActionResult LaubergeEdit(CustTaskModelBson cust)
        {
            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.Lauberge));
            List<SelectListItem> li = new List<SelectListItem>();

            //in case they submit before choosing a location
            if (cust.Country == "0")
            {
                foreach (var l in routes)
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }

                li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });
            }
            else
            {
                //The dropdown will retain the selected
                foreach (var l in routes)
                {
                    if (cust.Country == l.Value)
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                    }
                    else
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                    }
                }
            }


            ViewData["Country"] = li;


            ViewData["PickupTime"] = null;

            //get all of the route for at pickup - and selected = true on the route

            List<SelectListItem> states = new List<SelectListItem>();
            var loc = new List<Routes>();
            loc = dal.GetPickupLocationDB(Convert.ToInt16(cust.Country), Convert.ToInt16(Miscellaneous.CasinoDBNumber.Lauberge));
            //TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            //in case they submit before choosing a location
            if (cust.Country == "0")
            {
                states.Add(new SelectListItem { Text = "Select schedule", Value = "0", Selected = true });
            }
            else
            {

                foreach (var i in loc)
                {
                    if (i.Route == cust.State)
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route, Selected = true });
                    }
                    else
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route });
                    }
                }
            }



            ViewData["PickupTime"] = states;

            if (logic.IsValidDate(cust.Date))
            {
                var tr = Request["State"].ToString();
                cust.Route = tr;

                if (email != null)
                {
                   cust.PersonUpdate = email;
                }
                else
                {
                   cust.PersonUpdate = "NA";
                }

                dal.EditTask(cust);
                

                ViewData["route"] = cust;
                return RedirectToAction("Confirm", cust);
            }
            else
            {
                //return false and post it to the user
                return View();
            }
            return RedirectToAction("Index");
        }




        // GET: Office
        public async Task<ActionResult> Index()
        {

            //1st string is letter of Route
            List<CustReportModel> customer = new List<CustReportModel>();
            //CustTaskModelBson cust = new CustTaskModelBson();
            //customer = dal.GetTask(cust);

            return View(customer);
            //return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(string confirmationID)
        {
            var lastName = Request["LastName"].ToString();
            //1st string is letter of Route
            List<CustReportModel> customer = new List<CustReportModel>();
            CustTaskModelBson cust = new CustTaskModelBson();
            if (confirmationID.Length > 1)
            {
                //there is a confirmationID so we convert
                cust.Confirmation = Convert.ToInt64(confirmationID);
            }
            
            customer = dal.GetTask(cust,lastName);

            return View(customer);
            //return View();
        }


    



        public ActionResult Route12Report()
        {
            //List<RouteReport> route = new RouteReport();
            var route = dal.GetRouteReport(12);
            return View(route);
        }

        public ActionResult OfficeDelete(string id)
        {          
            var  customer = dal.DeleteOfficeTask(Convert.ToInt64(id));

            return RedirectToAction("Index", "Office");
        }


        public ActionResult ManagerPageBlock(int id)
        {
            var managerRoute = dal.GetManagerRoute(id);
            

            return View(managerRoute);
        }
        public ActionResult ManagerPage()
        {
            var managerRoute = dal.GetManagerRoute();
            return View(managerRoute);
        }

        // GET: Golden Nugget/Create
        [HttpPost]
        public ActionResult GoldenNuggetCreate(CustTaskModelBson item)
        {

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.GoldenNugget));
            List<SelectListItem> li = new List<SelectListItem>();

            //in case they submit before choosing a location
            if (item.Country == "0")
            {
                foreach (var l in routes)
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }

                li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });
            }
            else
            {
                //The dropdown will retain the selected
                foreach (var l in routes)
                {
                    if (item.Country == l.Value)
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                    }
                    else
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                    }
                }
            }


            ViewData["Country"] = li;

            ViewData["PickupTime"] = null;

            //get all of the route for at pickup - and selected = true on the route

            List<SelectListItem> states = new List<SelectListItem>();
            var loc = new List<Routes>();
            loc = dal.GetPickupLocationDB(Convert.ToInt16(item.Country), Convert.ToInt16(Miscellaneous.CasinoDBNumber.GoldenNugget));
            //TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            //in case they submit before choosing a location
            if (item.Country == "0")
            {
                states.Add(new SelectListItem { Text = "Select schedule", Value = "0", Selected = true });
            }
            else
            {

                foreach (var i in loc)
                {
                    if (i.Route == item.State)
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route, Selected = true });
                    }
                    else
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route });
                    }
                }
            }



            ViewData["PickupTime"] = states;

            //List<SelectListItem> pickupTime = new List<SelectListItem>();
            //pickupTime.Add(new SelectListItem { Text = routeDescription, Value = customer[0].Route, Selected = true });

            //ViewData["PickupTime"] = pickupTime;


            if (!ModelState.IsValid)
            {
                var custTaskModelBson = new CustTaskModelBson();
                var greatLandRoute = new List<Routes>();
                custTaskModelBson.Date = DateTime.Now;
                return View(item);
            }

            string route = Request.Form["State"].ToString();
            item.Route = route;

            if (logic.IsValidDate(item.Date))
            {
                //somebody forgot to select the schedule
                if (item.State != null && item.Route != "0")
                {

                    if (email != null)
                    {
                        item.PersonUpdate = email;
                    }
                    else
                    {
                        item.PersonUpdate = "NA";
                    }
                  
                    dal.CreateTask(item);
                    return RedirectToAction("Confirm", item);
                }

            }
            return View();
        }

        [HttpGet]
        public ActionResult GoldenNuggetEdit(string id)
        {

            //We have to parse the id

            string idNew = id.Split('|').Last();


            List<CustReportModel> customer = new List<CustReportModel>();
            customer = dal.GetTaskForEdit(Convert.ToInt64(idNew));

            var route = customer[0].Route.ToString();
            var r = dal.GetRouteDescription(route.Substring(0, 5));
            List<SelectListItem> pickupTime = new List<SelectListItem>();
            foreach (var i in r)
            {
                if (i.Route == route.Substring(0, 5))
                {
                    pickupTime.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route, Selected = true });
                }
                else
                {
                    pickupTime.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route });
                }
            }

            //pickupTime.Add(new SelectListItem { Text = routeDescription, Value = customer[0].Route, Selected = true });

            ViewData["PickupTime"] = pickupTime;

            //Get the selectedListItem
            var rt = (from oute in r select oute.SelectedParameter).First();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.GoldenNugget));
            List<SelectListItem> li = new List<SelectListItem>();


            //The dropdown will retain the selected
            foreach (var l in routes)
            {
                if (l.Key.ToString() == rt.ToString())
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                }
                else
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }

            }

            ViewData["Country"] = li;





            //Translate to the customer model
            var custTaskModelBson = new CustTaskModelBson();

            ViewData["route"] = customer[0].Route.ToString();
            custTaskModelBson.Id = Convert.ToInt64(idNew);
            custTaskModelBson.Route = customer[0].Route;
            custTaskModelBson.LastName = customer[0].LastName;
            custTaskModelBson.FirstName = customer[0].FirstName;
            custTaskModelBson.Email = customer[0].Email;
            custTaskModelBson.Phone = customer[0].Phone;
            custTaskModelBson.SeatsNumber = customer[0].SeatsNumber;
            custTaskModelBson.Notes = customer[0].Notes;
            custTaskModelBson.Traveler1Name = customer[0].Traveler1Name;
            custTaskModelBson.Traveler2Name = customer[0].Traveler2Name;
            custTaskModelBson.Traveler3Name = customer[0].Traveler3Name;
            custTaskModelBson.Traveler4Name = customer[0].Traveler4Name;
            custTaskModelBson.Traveler5Name = customer[0].Traveler5Name;
            custTaskModelBson.Traveler6Name = customer[0].Traveler6Name;
            custTaskModelBson.TravelDisclosure = customer[0].TravelDisclosure;
            custTaskModelBson.Confirmation = Convert.ToInt64(customer[0].Confirmation);
            custTaskModelBson.Date = customer[0].Date;

            return View(custTaskModelBson);
        }

        // GET: Golden Nugget/Create
        [HttpGet]
        public ActionResult GoldenNuggetCreate()
        {
            var custTaskModelBson = new CustTaskModelBson();
            var greatLandRoute = new List<Routes>();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.GoldenNugget));
            List<SelectListItem> li = new List<SelectListItem>();

            //The dropdown will retain the selected
            foreach (var l in routes)
            {
                li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
            }
            li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });
            ViewData["Country"] = li;
            custTaskModelBson.Date = DateTime.Now;
            custTaskModelBson.Casino = Convert.ToInt16(Miscellaneous.CasinoDBNumber.Lauberge);

            return View(custTaskModelBson);
        }

        [HttpPost]
        public ActionResult ManagerBlock()
        {

            var active = Request["Status"];

            if (active == "Enable")
            {
                active = "1";
            }
            else
            {
                active = "0";
            }

            var startBlock = Request["StartBlock"];
            var endBlock = Request["EndBlock"];
            var routeID = Request["RouteId"];
            dal.SaveBlockRoute(routeID, startBlock, endBlock, active);

            return RedirectToAction("ManagerPage", "Office");
     
        }

        /// <summary>
        /// Golden Nugget GROUP 1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult GoldenNuggetIndex(int? id)
        {
            List<SelectListItem> li = new List<SelectListItem>();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.GoldenNugget));
            foreach (var l in routes)
            {
                li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
            }
            li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });

            ViewData["Location"] = li;
            var greatLandRoute = new List<Routes>();

            //foreach (var doc in LookupData.Laub_SouthHouston)
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
            //                                    doc.SelectedParameter
            //                                    ,
            //                                     1, //ROUTE PLACE HOLDER
            //                                    ""
            //                                    ));

            //    if (descCount == 0)
            //    {
            //        TempData["LocationDesc"] = doc.DescriptionH + ": " + doc.DescriptionD;
            //    }
            //    descCount++;
            //}
            TempData["LocationDesc"] = "N/A";
            return View(greatLandRoute);
        }

        /// <summary>
        /// Golden Nugget GROUP 2
        /// </summary>
        /// <param name="SearchValue"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GoldenNuggetIndex(int SearchValue)
        {


            List<SelectListItem> li = new List<SelectListItem>();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.GoldenNugget));
            foreach (var l in routes)
            {
                if (SearchValue == Convert.ToInt16(l.Key.ToString()))
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                }
                else
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }
            }

            ViewData["Location"] = li;
            var greatLandRoute = new List<Routes>();

            var location = dal.GetPickupLocationDBReport(SearchValue, Convert.ToInt16(Miscellaneous.CasinoDBNumber.GoldenNugget));

            //var location = dal.GetLaubergePickupLocation(SearchValue);
            TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            return View(location);
        }







        // GET: Isle Capri/Create
        [HttpPost]
        public ActionResult IsleCapriEdit(CustTaskModelBson cust)
        {
            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.Lauberge));
            List<SelectListItem> li = new List<SelectListItem>();

            //in case they submit before choosing a location
            if (cust.Country == "0")
            {
                foreach (var l in routes)
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }

                li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });
            }
            else
            {
                //The dropdown will retain the selected
                foreach (var l in routes)
                {
                    if (cust.Country == l.Value)
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                    }
                    else
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                    }
                }
            }


            ViewData["Country"] = li;


            ViewData["PickupTime"] = null;

            //get all of the route for at pickup - and selected = true on the route

            List<SelectListItem> states = new List<SelectListItem>();
            var loc = new List<Routes>();
            loc = dal.GetPickupLocationDB(Convert.ToInt16(cust.Country), Convert.ToInt16(Miscellaneous.CasinoDBNumber.Lauberge));
            //TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            //in case they submit before choosing a location
            if (cust.Country == "0")
            {
                states.Add(new SelectListItem { Text = "Select schedule", Value = "0", Selected = true });
            }
            else
            {

                foreach (var i in loc)
                {
                    if (i.Route == cust.State)
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route, Selected = true });
                    }
                    else
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route });
                    }
                }
            }



            ViewData["PickupTime"] = states;

            if (logic.IsValidDate(cust.Date))
            {
                var tr = Request["State"].ToString();
                cust.Route = tr;
           
                if (email != null)
                {
                    cust.PersonUpdate = email;
                }
                else
                {
                    cust.PersonUpdate = "NA";
                }
                dal.EditTask(cust);


                ViewData["route"] = cust;
                return RedirectToAction("Confirm", cust);
            }
            else
            {
                //return false and post it to the user
                return View();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult IsleCapriEdit(string id)
        {

            //We have to parse the id

            string idNew = id.Split('|').Last();


            List<CustReportModel> customer = new List<CustReportModel>();
            customer = dal.GetTaskForEdit(Convert.ToInt64(idNew));

            var route = customer[0].Route.ToString();
            var r = dal.GetRouteDescription(route.Substring(0, 5));
            List<SelectListItem> pickupTime = new List<SelectListItem>();
            foreach (var i in r)
            {
                if (i.Route == route.Substring(0, 5))
                {
                    pickupTime.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route, Selected = true });
                }
                else
                {
                    pickupTime.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route });
                }
            }

            //pickupTime.Add(new SelectListItem { Text = routeDescription, Value = customer[0].Route, Selected = true });

            ViewData["PickupTime"] = pickupTime;

            //Get the selectedListItem
            var rt = (from oute in r select oute.SelectedParameter).First();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.IsleofCapri));
            List<SelectListItem> li = new List<SelectListItem>();


            //The dropdown will retain the selected
            foreach (var l in routes)
            {
                if (l.Key.ToString() == rt.ToString())
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                }
                else
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }

            }

            ViewData["Country"] = li;





            //Translate to the customer model
            var custTaskModelBson = new CustTaskModelBson();

            ViewData["route"] = customer[0].Route.ToString();
            custTaskModelBson.Id = Convert.ToInt64(idNew);
            custTaskModelBson.Route = customer[0].Route;
            custTaskModelBson.LastName = customer[0].LastName;
            custTaskModelBson.FirstName = customer[0].FirstName;
            custTaskModelBson.Email = customer[0].Email;
            custTaskModelBson.Phone = customer[0].Phone;
            custTaskModelBson.SeatsNumber = customer[0].SeatsNumber;
            custTaskModelBson.Notes = customer[0].Notes;
            custTaskModelBson.Traveler1Name = customer[0].Traveler1Name;
            custTaskModelBson.Traveler2Name = customer[0].Traveler2Name;
            custTaskModelBson.Traveler3Name = customer[0].Traveler3Name;
            custTaskModelBson.Traveler4Name = customer[0].Traveler4Name;
            custTaskModelBson.Traveler5Name = customer[0].Traveler5Name;
            custTaskModelBson.Traveler6Name = customer[0].Traveler6Name;
            custTaskModelBson.TravelDisclosure = customer[0].TravelDisclosure;
            custTaskModelBson.Confirmation = Convert.ToInt64(customer[0].Confirmation);
            custTaskModelBson.Date = customer[0].Date;

            return View(custTaskModelBson);
        }

        // GET: Horse Shoe/Create
        [HttpGet]
        public ActionResult IsleCapriCreate()
        {
            var custTaskModelBson = new CustTaskModelBson();
            var greatLandRoute = new List<Routes>();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.IsleofCapri));
            List<SelectListItem> li = new List<SelectListItem>();

            //The dropdown will retain the selected
            foreach (var l in routes)
            {
                li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
            }
            li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });
            ViewData["Country"] = li;
            custTaskModelBson.Date = DateTime.Now;
            return View(custTaskModelBson);
        }



        /// <summary>
        /// Isle of Capri GROUP 1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult IsleCapriIndex(int? id)
        {
            List<SelectListItem> li = new List<SelectListItem>();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.IsleofCapri));
            foreach (var l in routes)
            {
                li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
            }
            li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });

            ViewData["Location"] = li;
            var greatLandRoute = new List<Routes>();

            //foreach (var doc in LookupData.Laub_SouthHouston)
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
            //                                    doc.SelectedParameter
            //                                    ,
            //                                     1, //ROUTE PLACE HOLDER
            //                                    ""
            //                                    ));

            //    if (descCount == 0)
            //    {
            //        TempData["LocationDesc"] = doc.DescriptionH + ": " + doc.DescriptionD;
            //    }
            //    descCount++;
            //}
            TempData["LocationDesc"] = "N/A";
            return View(greatLandRoute);
        }

        /// <summary>
        /// Isla Capri GROUP 2
        /// </summary>
        /// <param name="SearchValue"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult IsleCapriIndex(int SearchValue)
        {
            List<SelectListItem> li = new List<SelectListItem>();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.IsleofCapri));
            foreach (var l in routes)
            {
                if (SearchValue == Convert.ToInt16(l.Key.ToString()))
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                }
                else
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }
            }

            ViewData["Location"] = li;
            var greatLandRoute = new List<Routes>();

            var location = dal.GetPickupLocationDBReport(SearchValue, Convert.ToInt16(Miscellaneous.CasinoDBNumber.IsleofCapri));

            //var location = dal.GetLaubergePickupLocation(SearchValue);
            TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            return View(location);
        }

        /// <summary>
        /// Delta Dow GROUP 1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult DeltaDownsIndex(int? id)
        {
            List<SelectListItem> li = new List<SelectListItem>();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.DeltaDown));
            foreach (var l in routes)
            {
                li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
            }
            li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });

            ViewData["Location"] = li;
            var greatLandRoute = new List<Routes>();

            //foreach (var doc in LookupData.Laub_SouthHouston)
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
            //                                    doc.SelectedParameter
            //                                    ,
            //                                     1, //ROUTE PLACE HOLDER
            //                                    ""
            //                                    ));

            //    if (descCount == 0)
            //    {
            //        TempData["LocationDesc"] = doc.DescriptionH + ": " + doc.DescriptionD;
            //    }
            //    descCount++;
            //}
            TempData["LocationDesc"] = "N/A";
            return View(greatLandRoute);
        }

        /// <summary>
        /// Delta Down GROUP 2
        /// </summary>
        /// <param name="SearchValue"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult DeltaDownsIndex(int SearchValue)
        {

            List<SelectListItem> li = new List<SelectListItem>();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.DeltaDown));
            foreach (var l in routes)
            {
                if (SearchValue == Convert.ToInt16(l.Key.ToString()))
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                }
                else
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }
            }

            ViewData["Location"] = li;
            var greatLandRoute = new List<Routes>();

            var location = dal.GetPickupLocationDBReport(SearchValue, Convert.ToInt16(Miscellaneous.CasinoDBNumber.DeltaDown));

            //var location = dal.GetLaubergePickupLocation(SearchValue);
            TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            return View(location);
        }

        /// <summary>
        /// COUSHATTA GROUP 1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult CoushattaIndex(int? id)
        {
            List<SelectListItem> li = new List<SelectListItem>();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.Coushatta));
            foreach (var l in routes)
            {
                li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
            }
            li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });

            ViewData["Location"] = li;
            var greatLandRoute = new List<Routes>();

            //foreach (var doc in LookupData.Laub_SouthHouston)
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
            //                                    doc.SelectedParameter
            //                                    ,
            //                                     1, //ROUTE PLACE HOLDER
            //                                    ""
            //                                    ));

            //    if (descCount == 0)
            //    {
            //        TempData["LocationDesc"] = doc.DescriptionH + ": " + doc.DescriptionD;
            //    }
            //    descCount++;
            //}
            TempData["LocationDesc"] = "N/A";
            return View(greatLandRoute);
        }

        /// <summary>
        /// COUSHATTA GROUP 2
        /// </summary>
        /// <param name="SearchValue"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CoushattaIndex(int SearchValue)
        {
            List<SelectListItem> li = new List<SelectListItem>();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.Coushatta));
            foreach (var l in routes)
            {
                if (SearchValue == Convert.ToInt16(l.Key.ToString()))
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                }
                else
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }
            }

            ViewData["Location"] = li;
            var greatLandRoute = new List<Routes>();

            var location = dal.GetPickupLocationDBReport(SearchValue, Convert.ToInt16(Miscellaneous.CasinoDBNumber.Coushatta));

            //var location = dal.GetLaubergePickupLocation(SearchValue);
            TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            return View(location);
        }




        /// <summary>
        /// LAUBERGE GROUP 1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult LaubergeIndex(int? id)
        {
            List<SelectListItem> li = new List<SelectListItem>();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.Lauberge));     
            foreach (var l in routes)
            {
                li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
            }
            li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });
           
            ViewData["Location"] = li;
            var greatLandRoute = new List<Routes>();

            //foreach (var doc in LookupData.Laub_SouthHouston)
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
            //                                    doc.SelectedParameter
            //                                    ,
            //                                     1, //ROUTE PLACE HOLDER
            //                                    ""
            //                                    ));

            //    if (descCount == 0)
            //    {
            //        TempData["LocationDesc"] = doc.DescriptionH + ": " + doc.DescriptionD;
            //    }
            //    descCount++;
            //}
            TempData["LocationDesc"] = "N/A";
            return View(greatLandRoute);
        }

        /// <summary>
        /// LAUBERGE GROUP 2
        /// </summary>
        /// <param name="SearchValue"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult LaubergeIndex(int SearchValue)
        {

            List<SelectListItem> li = new List<SelectListItem>();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.Lauberge));
            foreach (var l in routes)
            {
                if (SearchValue == Convert.ToInt16(l.Key.ToString()))
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                }
                else
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }
            }

            ViewData["Location"] = li;
            var greatLandRoute = new List<Routes>();

            var location = dal.GetPickupLocationDBReport(SearchValue, Convert.ToInt16(Miscellaneous.CasinoDBNumber.Lauberge));

            //var location = dal.GetLaubergePickupLocation(SearchValue);
            TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            return View(location);
        }

        public ActionResult ReportMainParm()
        {
            Session["email"] = email;
            return Redirect("~/Reports/MainReport.aspx");
        }

     
        public ActionResult CoushattaReport(string id)
        {
            Session["email"] = email;
            return Redirect("~/Reports/CoushattaReport.aspx?ID=" + id);

        }

        public ActionResult IsleCapriReport(string id)
        {
            Session["email"] = email;
            return Redirect("~/Reports/IsleofCapri.aspx?ID=" + id);
           
        }


        public ActionResult GoldenNuggetReport(string id)
        {
            Session["email"] = email;
            return Redirect("~/Reports/GoldenNugget.aspx?ID=" + id);

        }
  

        public ActionResult DeltaDownsReport(string id)
        {
            Session["email"] = email;
            return Redirect("~/Reports/DeltaDowns.aspx?ID=" + id);
      
        }


        public ActionResult LaubergeReport(string id)
        {
            Session["email"] = email;
            return Redirect("~/Reports/LaubergeReport.aspx?ID=" + id);

        }




        [HttpPost]
        public ActionResult AddLauberge(CustTaskModelBson cust)
        {

            if (logic.IsValidDate(cust.Date))
            {
                cust.PersonUpdate = "System";
                dal.CreateTask(cust);

                ViewData["route"] = cust;
                return RedirectToAction("Confirm");
            }
            else
            {
                //return false and post it to the user
                return RedirectToAction("Create");
            }

            
            //this.PopulateTypes(connect);
            return RedirectToAction("Index");
        }
        public JsonResult GetLAPick(string id)

        {
            List<SelectListItem> states = new List<SelectListItem>();

            var loc = new List<Routes>();

            loc = dal.GetPickupLocationDB(Convert.ToInt16(id), Convert.ToInt16(Miscellaneous.CasinoDBNumber.Lauberge));
            //TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            foreach (var item in loc)
            {
                states.Add(new SelectListItem { Text = "Route: " + item.Route + " - Day: " + item.Day + " -  Depart: " + item.Depart + " -  ArriveCasino: " + item.ArriveCasino + " -  DepartCasino: " + item.DepartCasino + " -  ReturnTime: " + item.ReturnTime, Value = item.Route });
            }

            return Json(new SelectList(states, "Value", "Text"));

        }


        // GET: Lauberge/Create
        [HttpGet]
        public ActionResult LaubergeCreate()
        {
            var custTaskModelBson = new CustTaskModelBson();
            var greatLandRoute = new List<Routes>();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.Lauberge));
            List<SelectListItem> li = new List<SelectListItem>();

            //The dropdown will retain the selected
            foreach (var l in routes)
            {
                li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
            }
            li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });
            ViewData["Country"] = li;
            custTaskModelBson.Date = DateTime.Now;
            custTaskModelBson.Casino = Convert.ToInt16(Miscellaneous.CasinoDBNumber.Lauberge);

            return View(custTaskModelBson);
        }

        [HttpPost]
        public ActionResult IsleCapriCreate(CustTaskModelBson item)
        {

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.IsleofCapri));
            List<SelectListItem> li = new List<SelectListItem>();

            //in case they submit before choosing a location
            if (item.Country == "0")
            {
                foreach (var l in routes)
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }

                li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });
            }
            else
            {
                //The dropdown will retain the selected
                foreach (var l in routes)
                {
                    if (item.Country == l.Value)
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                    }
                    else
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                    }
                }
            }


            ViewData["Country"] = li;

            ViewData["PickupTime"] = null;

            //get all of the route for at pickup - and selected = true on the route

            List<SelectListItem> states = new List<SelectListItem>();
            var loc = new List<Routes>();
            loc = dal.GetPickupLocationDB(Convert.ToInt16(item.Country), Convert.ToInt16(Miscellaneous.CasinoDBNumber.IsleofCapri));
            //TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            //in case they submit before choosing a location
            if (item.Country == "0")
            {
                states.Add(new SelectListItem { Text = "Select schedule", Value = "0", Selected = true });
            }
            else
            {

                foreach (var i in loc)
                {
                    if (i.Route == item.State)
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route, Selected = true });
                    }
                    else
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route });
                    }
                }
            }



            ViewData["PickupTime"] = states;

            //List<SelectListItem> pickupTime = new List<SelectListItem>();
            //pickupTime.Add(new SelectListItem { Text = routeDescription, Value = customer[0].Route, Selected = true });

            //ViewData["PickupTime"] = pickupTime;


            if (!ModelState.IsValid)
            {
                var custTaskModelBson = new CustTaskModelBson();
                var greatLandRoute = new List<Routes>();
                custTaskModelBson.Date = DateTime.Now;
                return View(item);
            }

            string route = Request.Form["State"].ToString();
            item.Route = route;

            if (logic.IsValidDate(item.Date))
            {
                //somebody forgot to select the schedule
                if (item.State != null && item.Route != "0")
                {
                    if (email != null)
                    {
                        item.PersonUpdate = email;
                    }
                    else
                    {
                        item.PersonUpdate = "NA";
                    }
                    dal.CreateTask(item);
                    return RedirectToAction("Confirm", item);
                }

            }
            return View();
        }

        // GET: Lauberge/Create
        [HttpPost]
        public ActionResult LaubergeCreate(CustTaskModelBson item)
        {

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.Lauberge));
            List<SelectListItem> li = new List<SelectListItem>();

            //in case they submit before choosing a location
            if (item.Country == "0")
            {
                foreach (var l in routes)
                {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }

                li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });
            }
            else
            {
                //The dropdown will retain the selected
                foreach (var l in routes)
                {
                    if (item.Country == l.Value)
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                    }
                    else
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                    }
                }
            }

            
            ViewData["Country"] = li;

            ViewData["PickupTime"] = null;

            //get all of the route for at pickup - and selected = true on the route

            List<SelectListItem> states = new List<SelectListItem>();
            var loc = new List<Routes>();
            loc = dal.GetPickupLocationDB(Convert.ToInt16(item.Country), Convert.ToInt16(Miscellaneous.CasinoDBNumber.Lauberge));
            //TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            //in case they submit before choosing a location
            if (item.Country == "0")
            {
                states.Add(new SelectListItem { Text = "Select schedule", Value = "0", Selected = true });
            }
            else
            {

                foreach (var i in loc)
                {
                    if (i.Route == item.State)
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route, Selected = true });
                    }
                    else
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route });
                    }
                }
            }
         


            ViewData["PickupTime"] = states;

            //List<SelectListItem> pickupTime = new List<SelectListItem>();
            //pickupTime.Add(new SelectListItem { Text = routeDescription, Value = customer[0].Route, Selected = true });

            //ViewData["PickupTime"] = pickupTime;


            if (!ModelState.IsValid)
            {
                var custTaskModelBson = new CustTaskModelBson();
                var greatLandRoute = new List<Routes>();
                custTaskModelBson.Date = DateTime.Now;
                return View(item);
            }

            string route = Request.Form["State"].ToString();
            item.Route = route;

            if (logic.IsValidDate(item.Date))
            {         
                //somebody forgot to select the schedule
                if (item.State != null && item.Route != "0")
                {
                    if (email != null)
                    {
                        item.PersonUpdate = email;
                    }
                    else
                    {
                        item.PersonUpdate = "NA";
                    }

                    dal.CreateTask(item);
                    return RedirectToAction("Confirm", item);
                }       
      
            }
            return View();
        }


        public ActionResult GenericEdit(string id)
        {
            switch (id.Substring(0,1))
            {
                case "L":
                    return RedirectToAction("LaubergeEdit", new { ID = id });

                case "I":
                    return RedirectToAction("IsleCapriEdit", new { ID = id });

                case "G":
                    return RedirectToAction("GoldenNuggetEdit", new { ID = id });

                case "C":
                    return RedirectToAction("CoushattaEdit", new { ID = id });

                case "D":
                    return RedirectToAction("DeltaDownsEdit", new { ID = id });
            }

            //There was an error return the default view
            return View();            
        }

        [HttpGet]
        public ActionResult LaubergeEdit(string id)
        {

            //We have to parse the id

            string idNew = id.Split('|').Last();

              
            List<CustReportModel> customer = new List<CustReportModel>();
                customer = dal.GetTaskForEdit(Convert.ToInt64(idNew));

            var route = customer[0].Route.ToString();
            var r = dal.GetRouteDescription(route.Substring(0,5));
            List<SelectListItem> pickupTime = new List<SelectListItem>();
            foreach (var i in r)
            {
                if (i.Route == route.Substring(0, 5))
                {
                    pickupTime.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route, Selected = true });
                }
                else
                {
                    pickupTime.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route });
                }
            }

            //pickupTime.Add(new SelectListItem { Text = routeDescription, Value = customer[0].Route, Selected = true });

            ViewData["PickupTime"] = pickupTime;

            //Get the selectedListItem
            var rt = (from oute in r select oute.SelectedParameter).First();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.Lauberge));
            List<SelectListItem> li = new List<SelectListItem>();


            //The dropdown will retain the selected
            foreach (var l in routes)
            {
                if (l.Key.ToString() == rt.ToString())
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                }
                else
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }
                
            }
           
            ViewData["Country"] = li;





            //Translate to the customer model
            var custTaskModelBson = new CustTaskModelBson();

            ViewData["route"] = customer[0].Route.ToString();
            custTaskModelBson.Id = Convert.ToInt64(idNew);
            custTaskModelBson.Route = customer[0].Route;
            custTaskModelBson.LastName = customer[0].LastName;
            custTaskModelBson.FirstName = customer[0].FirstName;
            custTaskModelBson.Email = customer[0].Email;
            custTaskModelBson.Phone = customer[0].Phone;
            custTaskModelBson.SeatsNumber = customer[0].SeatsNumber;
            custTaskModelBson.Notes = customer[0].Notes;
            custTaskModelBson.Traveler1Name = customer[0].Traveler1Name;
            custTaskModelBson.Traveler2Name = customer[0].Traveler2Name;
            custTaskModelBson.Traveler3Name = customer[0].Traveler3Name;
            custTaskModelBson.Traveler4Name = customer[0].Traveler4Name;
            custTaskModelBson.Traveler5Name = customer[0].Traveler5Name;
            custTaskModelBson.Traveler6Name = customer[0].Traveler6Name;
            custTaskModelBson.TravelDisclosure = customer[0].TravelDisclosure;
            custTaskModelBson.Confirmation = Convert.ToInt64(customer[0].Confirmation);            
            custTaskModelBson.Date = customer[0].Date;

            return View(custTaskModelBson);
        }

  




        // GET: Delta Downs/Create
        [HttpPost]
        public ActionResult DeltaDownsCreate(CustTaskModelBson item)
        {

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.DeltaDown));
            List<SelectListItem> li = new List<SelectListItem>();

            //in case they submit before choosing a location
            if (item.Country == "0")
            {
                foreach (var l in routes)
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }

                li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });
            }
            else
            {
                //The dropdown will retain the selected
                foreach (var l in routes)
                {
                    if (item.Country == l.Value)
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                    }
                    else
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                    }
                }
            }


            ViewData["Country"] = li;

            ViewData["PickupTime"] = null;

            //get all of the route for at pickup - and selected = true on the route

            List<SelectListItem> states = new List<SelectListItem>();
            var loc = new List<Routes>();
            loc = dal.GetPickupLocationDB(Convert.ToInt16(item.Country), Convert.ToInt16(Miscellaneous.CasinoDBNumber.DeltaDown));
            //TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            //in case they submit before choosing a location
            if (item.Country == "0")
            {
                states.Add(new SelectListItem { Text = "Select schedule", Value = "0", Selected = true });
            }
            else
            {

                foreach (var i in loc)
                {
                    if (i.Route == item.State)
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route, Selected = true });
                    }
                    else
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route });
                    }
                }
            }



            ViewData["PickupTime"] = states;

            //List<SelectListItem> pickupTime = new List<SelectListItem>();
            //pickupTime.Add(new SelectListItem { Text = routeDescription, Value = customer[0].Route, Selected = true });

            //ViewData["PickupTime"] = pickupTime;


            if (!ModelState.IsValid)
            {
                var custTaskModelBson = new CustTaskModelBson();
                var greatLandRoute = new List<Routes>();
                custTaskModelBson.Date = DateTime.Now;
                return View(item);
            }

            string route = Request.Form["State"].ToString();
            item.Route = route;

            if (logic.IsValidDate(item.Date))
            {
                //somebody forgot to select the schedule
                if (item.State != null && item.Route != "0")
                {
                

                    if (email != null)
                    {
                        item.PersonUpdate = email;
                    }
                    else
                    {
                        item.PersonUpdate = "NA";
                    }


                    dal.CreateTask(item);
                    return RedirectToAction("Confirm", item);
                }

            }
            return View();
        }

        [HttpGet]
        public ActionResult DeltaDownsEdit(string id)
        {

            //We have to parse the id

            string idNew = id.Split('|').Last();


            List<CustReportModel> customer = new List<CustReportModel>();
            customer = dal.GetTaskForEdit(Convert.ToInt64(idNew));

            var route = customer[0].Route.ToString();
            var r = dal.GetRouteDescription(route.Substring(0, 5));
            List<SelectListItem> pickupTime = new List<SelectListItem>();
            foreach (var i in r)
            {
                if (i.Route == route.Substring(0, 5))
                {
                    pickupTime.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route, Selected = true });
                }
                else
                {
                    pickupTime.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route });
                }
            }

            //pickupTime.Add(new SelectListItem { Text = routeDescription, Value = customer[0].Route, Selected = true });

            ViewData["PickupTime"] = pickupTime;

            //Get the selectedListItem
            var rt = (from oute in r select oute.SelectedParameter).First();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.DeltaDown));
            List<SelectListItem> li = new List<SelectListItem>();


            //The dropdown will retain the selected
            foreach (var l in routes)
            {
                if (l.Key.ToString() == rt.ToString())
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                }
                else
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }

            }

            ViewData["Country"] = li;





            //Translate to the customer model
            var custTaskModelBson = new CustTaskModelBson();

            ViewData["route"] = customer[0].Route.ToString();
            custTaskModelBson.Id = Convert.ToInt64(idNew);
            custTaskModelBson.Route = customer[0].Route;
            custTaskModelBson.LastName = customer[0].LastName;
            custTaskModelBson.FirstName = customer[0].FirstName;
            custTaskModelBson.Email = customer[0].Email;
            custTaskModelBson.Phone = customer[0].Phone;
            custTaskModelBson.SeatsNumber = customer[0].SeatsNumber;
            custTaskModelBson.Notes = customer[0].Notes;
            custTaskModelBson.Traveler1Name = customer[0].Traveler1Name;
            custTaskModelBson.Traveler2Name = customer[0].Traveler2Name;
            custTaskModelBson.Traveler3Name = customer[0].Traveler3Name;
            custTaskModelBson.Traveler4Name = customer[0].Traveler4Name;
            custTaskModelBson.Traveler5Name = customer[0].Traveler5Name;
            custTaskModelBson.Traveler6Name = customer[0].Traveler6Name;
            custTaskModelBson.TravelDisclosure = customer[0].TravelDisclosure;
            custTaskModelBson.Confirmation = Convert.ToInt64(customer[0].Confirmation);
            custTaskModelBson.Date = customer[0].Date;

            return View(custTaskModelBson);
        }

        // GET: Delta Downs/Create
        [HttpGet]
        public ActionResult DeltaDownsCreate()
        {
            var custTaskModelBson = new CustTaskModelBson();
            var greatLandRoute = new List<Routes>();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.DeltaDown));
            List<SelectListItem> li = new List<SelectListItem>();

            //The dropdown will retain the selected
            foreach (var l in routes)
            {
                li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
            }
            li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });
            ViewData["Country"] = li;
            custTaskModelBson.Date = DateTime.Now;
            return View(custTaskModelBson);
        }


        // POST: Office/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Confirm", collection);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult SearchIndex( string ConfirmationID)
        {
            //1st string is letter of Route
            List<CustReportModel> customer = new List<CustReportModel>();
            CustTaskModelBson cust = new CustTaskModelBson();
            cust.Confirmation = Convert.ToInt64(ConfirmationID);
                customer = dal.GetTask(cust, "");

            return RedirectToAction("Index", customer);

        }

        public ActionResult Confirm(CustTaskModelBson cust)
        { 

            return View(cust);
        }

        // GET: Office/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Office/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Office/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Office/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Coushatta/Create
  
        [HttpPost]
        public ActionResult CoushattaCreate(CustTaskModelBson item)
        {

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.Coushatta));
            List<SelectListItem> li = new List<SelectListItem>();

            //in case they submit before choosing a location
            if (item.Country == "0")
            {
                foreach (var l in routes)
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }

                li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });
            }
            else
            {
                //The dropdown will retain the selected
                foreach (var l in routes)
                {
                    if (item.Country == l.Value)
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                    }
                    else
                    {
                        li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                    }
                }
            }


            ViewData["Country"] = li;

            ViewData["PickupTime"] = null;

            //get all of the route for at pickup - and selected = true on the route

            List<SelectListItem> states = new List<SelectListItem>();
            var loc = new List<Routes>();
            loc = dal.GetPickupLocationDB(Convert.ToInt16(item.Country), Convert.ToInt16(Miscellaneous.CasinoDBNumber.Coushatta));
            //TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            //in case they submit before choosing a location
            if (item.Country == "0")
            {
                states.Add(new SelectListItem { Text = "Select schedule", Value = "0", Selected = true });
            }
            else
            {

                foreach (var i in loc)
                {
                    if (i.Route == item.State)
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route, Selected = true });
                    }
                    else
                    {
                        states.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route });
                    }
                }
            }



            ViewData["PickupTime"] = states;

            //List<SelectListItem> pickupTime = new List<SelectListItem>();
            //pickupTime.Add(new SelectListItem { Text = routeDescription, Value = customer[0].Route, Selected = true });

            //ViewData["PickupTime"] = pickupTime;


            if (!ModelState.IsValid)
            {
                var custTaskModelBson = new CustTaskModelBson();
                var greatLandRoute = new List<Routes>();
                custTaskModelBson.Date = DateTime.Now;
                return View(item);
            }

            string route = Request.Form["State"].ToString();
            item.Route = route;

            if (logic.IsValidDate(item.Date))
            {
                //somebody forgot to select the schedule
                if (item.State != null && item.Route != "0")
                {

                    if (email != null)
                    {
                        item.PersonUpdate = email;
                    }
                    else
                    {
                        item.PersonUpdate = "NA";
                    }
 
                    dal.CreateTask(item);
                    return RedirectToAction("Confirm", item);
                }

            }
            return View();
        }

        [HttpGet]
        public ActionResult CoushattaEdit(string id)
        {

            //We have to parse the id

            string idNew = id.Split('|').Last();


            List<CustReportModel> customer = new List<CustReportModel>();
            customer = dal.GetTaskForEdit(Convert.ToInt64(idNew));

            var route = customer[0].Route.ToString();
            var r = dal.GetRouteDescription(route.Substring(0, 5));
            List<SelectListItem> pickupTime = new List<SelectListItem>();
            foreach (var i in r)
            {
                if (i.Route == route.Substring(0, 5))
                {
                    pickupTime.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route, Selected = true });
                }
                else
                {
                    pickupTime.Add(new SelectListItem { Text = "Route: " + i.Route + " - Day: " + i.Day + " -  Depart: " + i.Depart + " -  ArriveCasino: " + i.ArriveCasino + " -  DepartCasino: " + i.DepartCasino + " -  ReturnTime: " + i.ReturnTime, Value = i.Route });
                }
            }

            //pickupTime.Add(new SelectListItem { Text = routeDescription, Value = customer[0].Route, Selected = true });

            ViewData["PickupTime"] = pickupTime;

            //Get the selectedListItem
            var rt = (from oute in r select oute.SelectedParameter).First();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.Coushatta));
            List<SelectListItem> li = new List<SelectListItem>();


            //The dropdown will retain the selected
            foreach (var l in routes)
            {
                if (l.Key.ToString() == rt.ToString())
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString(), Selected = true });
                }
                else
                {
                    li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
                }

            }

            ViewData["Country"] = li;





            //Translate to the customer model
            var custTaskModelBson = new CustTaskModelBson();

            ViewData["route"] = customer[0].Route.ToString();
            custTaskModelBson.Id = Convert.ToInt64(idNew);
            custTaskModelBson.Route = customer[0].Route;
            custTaskModelBson.LastName = customer[0].LastName;
            custTaskModelBson.FirstName = customer[0].FirstName;
            custTaskModelBson.Email = customer[0].Email;
            custTaskModelBson.Phone = customer[0].Phone;
            custTaskModelBson.SeatsNumber = customer[0].SeatsNumber;
            custTaskModelBson.Notes = customer[0].Notes;
            custTaskModelBson.Traveler1Name = customer[0].Traveler1Name;
            custTaskModelBson.Traveler2Name = customer[0].Traveler2Name;
            custTaskModelBson.Traveler3Name = customer[0].Traveler3Name;
            custTaskModelBson.Traveler4Name = customer[0].Traveler4Name;
            custTaskModelBson.Traveler5Name = customer[0].Traveler5Name;
            custTaskModelBson.Traveler6Name = customer[0].Traveler6Name;
            custTaskModelBson.TravelDisclosure = customer[0].TravelDisclosure;
            custTaskModelBson.Confirmation = Convert.ToInt64(customer[0].Confirmation);
            custTaskModelBson.Date = customer[0].Date;

            return View(custTaskModelBson);
        }

        // GET: Coushatta/Create
        [HttpGet]
        public ActionResult CoushattaCreate()
        {
            var custTaskModelBson = new CustTaskModelBson();
            var greatLandRoute = new List<Routes>();

            var routes = logic.GetBusRouteOffice(Convert.ToInt16(Miscellaneous.CasinoDBNumber.Coushatta));
            List<SelectListItem> li = new List<SelectListItem>();

            //The dropdown will retain the selected
            foreach (var l in routes)
            {
                li.Add(new SelectListItem { Text = l.Value, Value = l.Key.ToString() });
            }
            li.Add(new SelectListItem { Text = "Please select Location", Value = "0", Selected = true });
            ViewData["Country"] = li;
            custTaskModelBson.Date = DateTime.Now;
            return View(custTaskModelBson);
        }

        public JsonResult GetCOPick(string id)

        {
            List<SelectListItem> states = new List<SelectListItem>();
            var loc = new List<Routes>();

            loc = dal.GetPickupLocationDB(Convert.ToInt16(id), Convert.ToInt16(Miscellaneous.CasinoDBNumber.Coushatta));
            //TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            foreach (var item in loc)
            {
                states.Add(new SelectListItem { Text = "Route: " + item.Route + " - Day: " + item.Day + " -  Depart: " + item.Depart + " -  ArriveCasino: " + item.ArriveCasino + " -  DepartCasino: " + item.DepartCasino + " -  ReturnTime: " + item.ReturnTime, Value = item.Route });
            }

            return Json(new SelectList(states, "Value", "Text"));
        }

        public JsonResult GetGGPick(string id)

        {
            List<SelectListItem> states = new List<SelectListItem>();
            var loc = new List<Routes>();

            loc = dal.GetPickupLocationDB(Convert.ToInt16(id), Convert.ToInt16(Miscellaneous.CasinoDBNumber.GoldenNugget));
            //TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            foreach (var item in loc)
            {
                states.Add(new SelectListItem { Text = "Route: " + item.Route + " - Day: " + item.Day + " -  Depart: " + item.Depart + " -  ArriveCasino: " + item.ArriveCasino + " -  DepartCasino: " + item.DepartCasino + " -  ReturnTime: " + item.ReturnTime, Value = item.Route });
            }

            return Json(new SelectList(states, "Value", "Text"));
        }


        public JsonResult GetDDPick(string id)

        {
            List<SelectListItem> states = new List<SelectListItem>();
            var loc = new List<Routes>();

            loc = dal.GetPickupLocationDB(Convert.ToInt16(id), Convert.ToInt16(Miscellaneous.CasinoDBNumber.DeltaDown));
            //TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            foreach (var item in loc)
            {
                states.Add(new SelectListItem { Text = "Route: " + item.Route + " - Day: " + item.Day + " -  Depart: " + item.Depart + " -  ArriveCasino: " + item.ArriveCasino + " -  DepartCasino: " + item.DepartCasino + " -  ReturnTime: " + item.ReturnTime, Value = item.Route });
            }

            return Json(new SelectList(states, "Value", "Text"));
        }


        public JsonResult GetISPick(string id)
        {
            List<SelectListItem> states = new List<SelectListItem>();
            var loc = new List<Routes>();

            loc = dal.GetPickupLocationDB(Convert.ToInt16(id), Convert.ToInt16(Miscellaneous.CasinoDBNumber.IsleofCapri));
            //TempData["LocationDesc"] = (from values in location select values.DescriptionH + ": " + values.DescriptionD).First();

            foreach (var item in loc)
            {
                states.Add(new SelectListItem { Text = "Route: " + item.Route + " - Day: " + item.Day + " -  Depart: " + item.Depart + " -  ArriveCasino: " + item.ArriveCasino + " -  DepartCasino: " + item.DepartCasino + " -  ReturnTime: " + item.ReturnTime, Value = item.Route });
            }

            return Json(new SelectList(states, "Value", "Text"));

        }
    }
}
