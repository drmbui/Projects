using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GreatLand.Models;
using GreatLand.DAL;
using GreatLand.Interface;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using System.Configuration;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace GreatLand
{
    public class Dal : IDalLauberge, IDalCoushatta, IDalDeltaDown, IDisposable, IDalManager
    {
        DalLauberge lauberge = new DalLauberge();
        DalCoushatta coushatta = new DalCoushatta();
        DalDeltaDown deltadown = new DalDeltaDown();
        DalManager manager = new DalManager();

        private bool disposed = false;

        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Active"].ToString();

        // Default constructor.        
        public Dal()
        {
        }

        public List<Routes> GetBusRouteDepartureDetailsDB(int loc, int casino)
        {
            var r = new List<Routes>();
            var con = new SqlConnection(connectionString);
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetBusRouteDepartureDetailsDB", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", loc);
                cmd.Parameters.AddWithValue("@Casino", casino);

                SqlDataReader myReader = null;

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    r.Add(new Routes(myReader["Route"].ToString(),
                                                myReader["Day"].ToString(),
                                                myReader["Depart"].ToString(),
                                                myReader["ArriveCasino"].ToString(),
                                                myReader["DepartCasino"].ToString(),
                                                myReader["ReturnTime"].ToString(),
                                                myReader["YouPay"].ToString(),
                                                myReader["YouReceive"].ToString(),
                                                myReader["DescriptionH"].ToString(),
                                                myReader["DescriptionD"].ToString(),
                                                Convert.ToInt32(myReader["SelectedListItem"]),
                                                Convert.ToInt32(myReader["ManagerRouteNumber"].ToString()),
                                                ""));
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);

            }
            finally
            {
                con.Close();
            }

            return r;
        }

        public List<Routes> GetCoushattaPickupLocationDB2(string loc, string travelDateValue)
        {
            var r = new List<Routes>();
            var con = new SqlConnection(connectionString);
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetCoushattaPickupLocationDB", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SelectedItem", Convert.ToInt32(loc));
                cmd.Parameters.AddWithValue("@Day", Convert.ToInt32(travelDateValue));

                SqlDataReader myReader = null;

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    r.Add(new Routes(myReader["Route"].ToString(),
                                                myReader["Day"].ToString(),
                                                myReader["Depart"].ToString(),
                                                myReader["ArriveCasino"].ToString(),
                                                myReader["DepartCasino"].ToString(),
                                                myReader["ReturnTime"].ToString(),
                                                myReader["YouPay"].ToString(),
                                                myReader["YouReceive"].ToString(),
                                                myReader["DescriptionH"].ToString(),
                                                myReader["DescriptionD"].ToString(),
                                                Convert.ToInt32(myReader["SelectedListItem"]),
                                                Convert.ToInt32(myReader["ManagerRouteNumber"].ToString()),
                                                myReader["Route"].ToString() + "|" + travelDateValue));
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);

            }
            finally
            {
                con.Close();
            }

            return r;
        }


        public List<Routes> GetPickupLocationDBReport(int loc, int casino)
        {
            var r = new List<Routes>();
            var con = new SqlConnection(connectionString);
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetPickupLocationDBReport", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SelectedItem", loc);
                cmd.Parameters.AddWithValue("@Casino", casino);
                SqlDataReader myReader = null;

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    r.Add(new Routes(myReader["Route"].ToString(),
                                                myReader["Day"].ToString(),
                                                myReader["Depart"].ToString(),
                                                myReader["ArriveCasino"].ToString(),
                                                myReader["DepartCasino"].ToString(),
                                                myReader["ReturnTime"].ToString(),
                                                myReader["YouPay"].ToString(),
                                                myReader["YouReceive"].ToString(),
                                                myReader["DescriptionH"].ToString(),
                                                myReader["DescriptionD"].ToString(),
                                                Convert.ToInt32(myReader["SelectedListItem"]),
                                                Convert.ToInt32(myReader["ManagerRouteNumber"].ToString()),
                                                myReader["Route"].ToString() + "|" + myReader["DescriptionH"].ToString()));
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);

            }
            finally
            {
                con.Close();
            }

            return r;
        }




        public List<Routes> GetPickupLocationDB2(string loc, string travelDateValue, int casino)
        {
            var r = new List<Routes>();
            var con = new SqlConnection(connectionString);
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetPickupLocationDB", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SelectedItem", Convert.ToInt32(loc));
                cmd.Parameters.AddWithValue("@Day", Convert.ToInt32(travelDateValue));
                cmd.Parameters.AddWithValue("@Casino", casino);
                SqlDataReader myReader = null;

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    r.Add(new Routes(myReader["Route"].ToString(),
                                                myReader["Day"].ToString(),
                                                myReader["Depart"].ToString(),
                                                myReader["ArriveCasino"].ToString(),
                                                myReader["DepartCasino"].ToString(),
                                                myReader["ReturnTime"].ToString(),
                                                myReader["YouPay"].ToString(),
                                                myReader["YouReceive"].ToString(),
                                                myReader["DescriptionH"].ToString(),
                                                myReader["DescriptionD"].ToString(),
                                                Convert.ToInt32(myReader["SelectedListItem"]),
                                                Convert.ToInt32(myReader["ManagerRouteNumber"].ToString()),
                                                myReader["Route"].ToString() + "|" + travelDateValue));
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);

            }
            finally
            {
                con.Close();
            }

            return r;
        }

        public List<CasinoReport> GetCasinoReport(string route, DateTime beginDate, DateTime endDate)
        {
            var c = new List<CasinoReport>();
            var con = new SqlConnection(connectionString);
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetCasinoRouteReport", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Route", route);
                cmd.Parameters.AddWithValue("@BeginDate", beginDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                SqlDataReader myReader = null;

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    c.Add(new CasinoReport(myReader["Casino"].ToString(),
                                                myReader["Reservation_Route"].ToString(),
                                                myReader["Reservation_NumberofSeats"].ToString(),
                                                myReader["Reservation_TravelDate"].ToString(),
                                                myReader["Reservation_FirstName"].ToString(),
                                                myReader["Reservation_LastName"].ToString(),
                                                myReader["Reservation_Email"].ToString(),
                                                myReader["Reservation_Phone"].ToString(),
                                                myReader["Reservation_Notes"].ToString(),
                                                myReader["Reservation_Confirmation"].ToString(),


                                                myReader["Reservation_Traveler1Name"].ToString(),
                                                myReader["Reservation_Traveler2Name"].ToString(),

                                                myReader["Reservation_Traveler3Name"].ToString(),
                                                myReader["Reservation_Traveler4Name"].ToString(),

                                                myReader["Reservation_Traveler5Name"].ToString(),
                                                myReader["Reservation_Traveler6Name"].ToString()));

                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);

            }
            finally
            {
                con.Close();
            }

            return c;
        }
        public List<CasinoReport> GetMainReport(string casino, DateTime beginDate, DateTime endDate)
        {
            var c = new List<CasinoReport>();
            var con = new SqlConnection(connectionString);
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetCasinoReport", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Casino", casino);
                cmd.Parameters.AddWithValue("@BeginDate", beginDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                SqlDataReader myReader = null;

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    c.Add(new CasinoReport(myReader["Casino"].ToString(),
                                                myReader["Reservation_Route"].ToString(),
                                                myReader["Reservation_NumberofSeats"].ToString(),
                                                myReader["Reservation_TravelDate"].ToString(),
                                                myReader["Reservation_FirstName"].ToString(),
                                                myReader["Reservation_LastName"].ToString(),
                                                myReader["Reservation_Email"].ToString(),
                                                myReader["Reservation_Phone"].ToString(),
                                                myReader["Reservation_Notes"].ToString(),
                                                myReader["Reservation_Confirmation"].ToString(),


                                                myReader["Reservation_Traveler1Name"].ToString(),
                                                myReader["Reservation_Traveler2Name"].ToString(),

                                                myReader["Reservation_Traveler3Name"].ToString(),
                                                myReader["Reservation_Traveler4Name"].ToString(),

                                                myReader["Reservation_Traveler5Name"].ToString(),
                                                myReader["Reservation_Traveler6Name"].ToString()));

                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);

            }
            finally
            {
                con.Close();
            }

            return c;
        }

        //We get bus route for the office
        public List<BusRouteDepartureToday> GetBusRouteOffice(int casino)
        {
            var pickup = new List<BusRouteDepartureToday>();
            var con = new SqlConnection(connectionString);
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetBusRouteOffice", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Casino", casino);
                SqlDataReader myReader = null;

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    pickup.Add(new BusRouteDepartureToday(myReader["DescriptionH"].ToString(),
                                                myReader["SelectedListItem"].ToString()));
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);

            }
            finally
            {
                con.Close();
            }

            return pickup;

        }
        //We get active bus route based upon days
        public List<BusRouteDepartureToday> GetBusRouteByDay(int day, int casino)
        {
            var pickup = new List<BusRouteDepartureToday>();
            var con = new SqlConnection(connectionString);
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetBusRouteByDay", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@Casino", casino);
                SqlDataReader myReader = null;

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    pickup.Add(new BusRouteDepartureToday(myReader["DescriptionH"].ToString(),
                                                myReader["SelectedListItem"].ToString()));
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);

            }
            finally
            {
                con.Close();
            }

            return pickup;

        }




        public List<GreatLand.Models.CasinoReport> GetCasinoReport(string locPickup)
        {

            var report = new List<CasinoReport>();
            var con = new SqlConnection(connectionString);
            try
            {

                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetCasinoReport", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Route", locPickup);

                SqlDataReader myReader = null;

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    report.Add(new CasinoReport(myReader["Casino"].ToString(),
                                                myReader["Reservation_Route"].ToString(),
                                                myReader["Reservation_NumberofSeats"].ToString(),
                                                myReader["Reservation_TravelDate"].ToString(),
                                                myReader["Reservation_FirstName"].ToString(),
                                                myReader["Reservation_LastName"].ToString(),
                                                myReader["Reservation_Email"].ToString(),
                                                myReader["Reservation_Phone"].ToString(),
                                                myReader["Reservation_Notes"].ToString(),                                       
                                                myReader["Reservation_Confirmation"].ToString(),
                                                myReader["Reservation_Traveler1Name"].ToString(),
                                                myReader["Reservation_Traveler2Name"].ToString(),
                                                myReader["Reservation_Traveler3Name"].ToString(),
                                                myReader["Reservation_Traveler4Name"].ToString(),
                                                myReader["Reservation_Traveler5Name"].ToString(),
                                                myReader["Reservation_Traveler6Name"].ToString()));
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);

            }
            finally
            {
                con.Close();
            }

            return report;
        }

        public List<Routes> GetDeltaDownPickupLocation(int LocID)
        {
            return deltadown.GetDeltaDownPickupLocation(LocID);
        }

        public List<Routes> GetDeltaDownPickupLocation(string LocID)
        {
            return deltadown.GetDeltaDownPickupLocation(LocID);
        }

        public List<Routes> GetCoushataPickupLocation(int LocID)
        {
            return coushatta.GetCoushataPickupLocation(LocID);
        }

        public List<Routes> GetCoushataPickupLocation(string LocID)
        {
            return coushatta.GetCoushataPickupLocation(LocID);
        }

        public List<Routes> GetLaubergePickupLocation(int LocID)
        {
            return lauberge.GetLaubergePickupLocation(LocID);
        }

        //public List<Routes> GetLaubergePickupLocation(string LocID)
        //{
        //    return lauberge.GetLaubergePickupLocation(LocID);
  
        //}

        public List<Routes> GetLaubergePickupLocationDB(string LocID)
        {
            return lauberge.GetLaubergePickupLocationDB(LocID);
           // return GetLaubergePickupLocationDB(LocID, travelDateValue);
        }

        public List<Routes> GetPickupLocationDB(int selectedListItem, int casino)
        {
            return lauberge.GetPickupLocationDB(selectedListItem,casino);
        }

        public List<Routes> GetLaubergePickupLocationDB(string LocID, string travelDateValue)
        {
            //return lauberge.GetLaubergePickupLocation(LocID);
            return GetLaubergePickupLocationDB(LocID, travelDateValue);
        }


        public List<ManagerView> GetManagerRoute()
        {
            return manager.GetManagerRoute();
        }

        public List<ManagerView> GetManagerRoute(int id)
        {
            return manager.GetManagerRoute(id);
        }







        /// <summary>
        /// Get GGN pickup
        /// </summary>
        /// <param name="LocID"></param>
        /// <returns></returns>
        public List<Routes> GetGGNPickupLocation(int LocID)
        {


            switch (LocID)
            {
                case 1:
                    return LookupData.GN_SWH;

                case 2:
                    return LookupData.GN_SouthHouston;

                case 3:
                    return LookupData.GN_EastHouston;

                case 4:
                    return LookupData.GN_Baytown;

                case 5:
                    return LookupData.GN_PearlandHouston;

                case 6:
                    return LookupData.GN_PasadenaHouston;

                case 7:
                    return LookupData.GN_45NLittleYork;

                case 8:
                    return LookupData.GN_NorthwestHouston;

            }

            return LookupData.GN_SWH;
        }

        /// <summary>
        /// Get GGN pickup based on ID
        /// </summary>
        /// <param name="LocID"></param>
        /// <returns></returns>
        public List<Routes> GetGGNPickupLocation(string LocID)
        {


            switch (LocID)
            {
                case "GA":
                    return LookupData.GN_SWH;

                case "GB":
                    return LookupData.GN_SouthHouston;

                case "GC":
                    return LookupData.GN_EastHouston;

                case "GD":
                    return LookupData.GN_PearlandHouston;

                case "GE":
                    return LookupData.GN_PasadenaHouston;

                case "GF":
                    return LookupData.GN_NorthwestHouston;

                case "GG":
                    return LookupData.GN_45NLittleYork;

                case "GH":
                    return LookupData.GN_Baytown;

            }

            return LookupData.GN_SWH;
        }




        /// <summary>
        /// Get HS pickup
        /// </summary>
        /// <param name="LocID"></param>
        /// <returns></returns>
        public List<Routes> GetHSPickupLocation(int LocID)
        {


            switch (LocID)
            {
                case 1:
                    return LookupData.HS_SWH;

                case 2:
                    return LookupData.HS_SouthHouston;

                case 3:
                    return LookupData.HS_45NLittleYork;

                case 4:
                    return LookupData.HS_Lufkin;     

            }

            return LookupData.HS_SWH;
        }

        /// <summary>
        /// Get HS pickup based on ID
        /// </summary>
        /// <param name="LocID"></param>
        /// <returns></returns>
        public List<Routes> GetHSPickupLocation(string LocID)
        {


            switch (LocID)
            {
                case "HB":
                    return LookupData.HS_SWH;

                case "HA":
                    return LookupData.HS_SouthHouston;

                case "HC":
                    return LookupData.HS_45NLittleYork;

                case "HD":
                    return LookupData.HS_Lufkin;         
            }

            return LookupData.HS_SWH;
        }



        /// <summary>
        /// Get IC pickup
        /// </summary>
        /// <param name="LocID"></param>
        /// <returns></returns>
        public List<Routes> GetICPickupLocation(int LocID)
        {


            switch (LocID)
            {
                case 1:
                    return LookupData.IC_SWH;

                case 2:
                    return LookupData.IC_SouthHouston;

                case 3:
                    return LookupData.IC_EastHouston;

                case 4:
                    return LookupData.IC_Baytown;

            }

            return LookupData.IC_SWH;
        }

        /// <summary>
        /// Get IC pickup based on ID
        /// </summary>
        /// <param name="LocID"></param>
        /// <returns></returns>
        public List<Routes> GetICPickupLocation(string LocID)
        {


            switch (LocID)
            {
                case "IA":
                    return LookupData.IC_SWH;

                case "IB":
                    return LookupData.IC_SouthHouston;

                case "IC":
                    return LookupData.IC_EastHouston;

                case "ID":
                    return LookupData.IC_Baytown;
            }

            return LookupData.IC_SWH;
        }

        // Gets all Task items from the MongoDB server.        
        //public Task<List<BsonDocument>> GetAllTasks()
        //{

        //    var collection = GetTasksCollection();

        //    return collection;


        //}

        //public Task<List<BsonDocument>> GetRoute(string id)
        //{

        //    var collection = GetRouteCollection(id);

        //    return collection;


        //}

        //public Task<List<BsonDocument>> GetRoute()
        //{

        //    var collection = GetRouteCollection();

        //    return collection;


        //}

        ///// <summary>
        ///// get specific route (MongoDB)
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //private async Task<List<BsonDocument>> GetRouteCollection(string id)
        //{
        //    var client = new MongoClient(connectionString);
        //    var database = client.GetDatabase("GreateLand");
        //    var collection = database.GetCollection<BsonDocument>("Route");
        //    var filter = Builders<BsonDocument>.Filter.Eq("Route", id);
        //    //var filter = new BsonDocument();

        //    var list = await collection.Find(filter).ToListAsync();


        //    return list;
        //}

        /// <summary>
        /// get all route
        /// </summary>
        /// <returns></returns>
        //private async Task<List<BsonDocument>> GetRouteCollection()
        //{
        //    var client = new MongoClient(connectionString);
        //    var database = client.GetDatabase("GreateLand");
        //    var collection = database.GetCollection<BsonDocument>("Route");
        //    //var filter = Builders<BsonDocument>.Filter.Eq("Route", id);
        //    var filter = new BsonDocument();

        //    var list = await collection.Find(filter).ToListAsync();


        //    return list;
        //}



        public List<GreatLand.Models.CustReportModel> GetTask(string location)
        {

            var customer = new List<CustReportModel>();
            var con = new SqlConnection(connectionString);
            try
            {

                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetTask", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Route", location.TrimEnd());

                SqlDataReader myReader = null;

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string test = myReader["Route"].ToString();
                    customer.Add(new CustReportModel(myReader["ID"].ToString(),
                                                    myReader["Route"].ToString(),
                                                    myReader["LastName"].ToString(),
                                                        myReader["FirstName"].ToString(),
                                                        myReader["email"].ToString(),
                                                        myReader["Phone"].ToString(),
                                                        Convert.ToInt16(myReader["NumberofSeats"].ToString()),
                                                        Convert.ToDateTime(myReader["TravelDate"].ToString()),
                                                        Convert.ToDateTime(myReader["CreateDate"].ToString()),
                                                        Convert.ToDateTime(myReader["LastUpDate"].ToString()),
                                                        myReader["PersonUpdate"].ToString(),
                                                        myReader["Notes"].ToString(),
                                                        myReader["Confirmation"].ToString(),
                                                        myReader["Traveler1Name"].ToString(),
                                                        myReader["Traveler2Name"].ToString(),
                                                        myReader["Traveler3Name"].ToString(),
                                                        myReader["Traveler4Name"].ToString(),
                                                        myReader["Traveler5Name"].ToString(),
                                                        myReader["Traveler6Name"].ToString(),
                                                        myReader["TravelDisclosure"].ToString()));


                    cmd.Dispose();


                }

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);

            }
            finally
            {
                con.Close();
            }



            return customer;
        }

        public List<GreatLand.Models.MainReportModel> GetMainReport()
        {
            var mainReport = new List<MainReportModel>();
            return mainReport;
        }

        public List<GreatLand.Models.RouteReport> GetRouteReport(int routeNumber)
        {

            var report = new List<RouteReport>();
            var con = new SqlConnection(connectionString);
            try
            {

                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetRouteReport", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Route", routeNumber);

                SqlDataReader myReader = null;

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
       
                    report.Add(new RouteReport(myReader["Reservation_Route"].ToString(),
                                                myReader["Reservation_NumberofSeats"].ToString(),
                                                myReader["Reservation_TravelDate"].ToString(),
                                                myReader["Reservation_FirstName"].ToString(),
                                                myReader["Reservation_LastName"].ToString(),
                                                myReader["Reservation_Email"].ToString(),
                                                myReader["Reservation_Phone"].ToString(),
                                                myReader["Reservation_Notes"].ToString(),
                                                myReader["Reservation_CreateDate"].ToString(),
                                                myReader["Reservation_LastUpdate"].ToString(),
                                                myReader["Reservation_PersonUpdate"].ToString(),
                                                myReader["Reservation_Cancel"].ToString(),
                                                myReader["Reservation_Confirmation"].ToString(),
                                                myReader["Reservation_Traveler1Name"].ToString(),
                                                myReader["Reservation_Traveler2Name"].ToString(),
                                                myReader["Reservation_Traveler3Name"].ToString(),
                                                myReader["Reservation_Traveler4Name"].ToString(),
                                                myReader["Reservation_Traveler5Name"].ToString(),
                                                myReader["Reservation_TravelDisclosure"].ToString(),
                                                myReader["RoutePickup_Route"].ToString(),
                                                myReader["Route_Active"].ToString(),
                                                myReader["Route_DayOfTheWeek"].ToString(),
                                                myReader["Route_RouteNumber"].ToString(),
                                                myReader["Route_PickUpLocations"].ToString()));              
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);

            }
            finally
            {
                con.Close();
            }

            return report;
        }


        public List<GreatLand.Models.CustReportModel> GetTask(CustTaskModelBson cust, string lastName)
        {

            var customer = new List<CustReportModel>();
            var con = new SqlConnection(connectionString);
            try
            {

                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetTaskIndex", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Confirmation", cust.Confirmation);
                cmd.Parameters.AddWithValue("@LastName", lastName);

                SqlDataReader myReader = null;
                 
                myReader = cmd.ExecuteReader();
                while(myReader.Read())
                {
                    string test = myReader["Route"].ToString();
                    customer.Add(new CustReportModel(myReader["ID"].ToString(),
                                                    myReader["Route"].ToString(),
                                                    myReader["LastName"].ToString(),
                                                        myReader["FirstName"].ToString(),
                                                        myReader["email"].ToString(),
                                                        myReader["Phone"].ToString(),
                                                        Convert.ToInt16(myReader["NumberofSeats"].ToString()),
                                                        Convert.ToDateTime(myReader["TravelDate"].ToString()),
                                                        Convert.ToDateTime(myReader["CreateDate"].ToString()),
                                                        Convert.ToDateTime(myReader["LastUpDate"].ToString()),
                                                        myReader["PersonUpdate"].ToString(),
                                                        myReader["Notes"].ToString(),
                                                        myReader["Confirmation"].ToString(),
                                                        myReader["Traveler1Name"].ToString(),
                                                        myReader["Traveler2Name"].ToString(),
                                                        myReader["Traveler3Name"].ToString(),
                                                        myReader["Traveler4Name"].ToString(),
                                                        myReader["Traveler5Name"].ToString(),
                                                        myReader["Traveler6Name"].ToString(),
                                                        myReader["TravelDisclosure"].ToString()));


                    cmd.Dispose();

                                
                }
             
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);

            }
            finally
            {
                con.Close();
            }

          

            return customer;
        }



        public List<Routes> GetRouteDescription(string route)
        {
            var r = new List<Routes>();
            var con = new SqlConnection(connectionString);
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetOfficeRouteByRoute", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Route", route);

                SqlDataReader myReader = null;

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    r.Add(new Routes(myReader["Route"].ToString(),
                                                myReader["Day"].ToString(),
                                                myReader["Depart"].ToString(),
                                                myReader["ArriveCasino"].ToString(),
                                                myReader["DepartCasino"].ToString(),
                                                myReader["ReturnTime"].ToString(),
                                                myReader["YouPay"].ToString(),
                                                myReader["YouReceive"].ToString(),
                                                myReader["DescriptionH"].ToString(),
                                                myReader["DescriptionD"].ToString(),
                                                Convert.ToInt32(myReader["SelectedListItem"]),
                                                Convert.ToInt32(myReader["ManagerRouteNumber"].ToString()),
                                                ""));
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);

            }
            finally
            {
                con.Close();
            }

            return r;
        }

        //public string GetRouteDescription(string route)
        //{

        //    var routeR = "";
        //    var con = new SqlConnection(connectionString);
        //    try
        //    {

        //        con = new SqlConnection(connectionString);
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("dbo.GetOfficeRouteByRoute", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@Route", route);

        //        SqlDataReader myReader = null;

        //        myReader = cmd.ExecuteReader();
        //        while (myReader.Read())
        //        {
        //            routeR = myReader["RouteDesc"].ToString();
        //            cmd.Dispose();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        string msg = ex.Message;
        //        throw new System.ArgumentOutOfRangeException("Error", ex);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //    return routeR;
        //}

        public List<GreatLand.Models.CustReportModel> GetTaskForEdit(Int64 id)
        {

            var customer = new List<CustReportModel>();
            var con = new SqlConnection(connectionString);
            try
            {

                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetTaskForEdit", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader myReader = null;

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string test = myReader["Route"].ToString();
                    customer.Add(new CustReportModel(myReader["ID"].ToString(),
                                                    myReader["Route"].ToString(),
                                                    myReader["LastName"].ToString(),
                                                        myReader["FirstName"].ToString(),
                                                        myReader["email"].ToString(),
                                                        myReader["Phone"].ToString(),
                                                        Convert.ToInt16(myReader["NumberofSeats"].ToString()),
                                                        Convert.ToDateTime(myReader["TravelDate"].ToString()),
                                                        Convert.ToDateTime(myReader["CreateDate"].ToString()),
                                                        Convert.ToDateTime(myReader["LastUpDate"].ToString()),
                                                        myReader["PersonUpdate"].ToString(),
                                                        myReader["Notes"].ToString(),
                                                        myReader["Confirmation"].ToString(),
                                                        myReader["Traveler1Name"].ToString(),
                                                        myReader["Traveler2Name"].ToString(),
                                                        myReader["Traveler3Name"].ToString(),
                                                        myReader["Traveler4Name"].ToString(),
                                                        myReader["Traveler5Name"].ToString(),
                                                        myReader["Traveler6Name"].ToString(),
                                                        myReader["TravelDisclosure"].ToString()));
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);
            }
            finally
            {
                con.Close();
            }
            return customer;
        }

        public List<GreatLand.Models.CustReportModel> DeleteOfficeTask(Int64 id)
        {

            var customer = new List<CustReportModel>();
            var con = new SqlConnection();
                         

                try
                {
                    con = new SqlConnection(connectionString);
        con.Open();
                    SqlCommand cmd = new SqlCommand("dbo.DeleteTask", con);
        cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader myReader = null;

        myReader = cmd.ExecuteReader();
                
                while (myReader.Read())
                {            
                        customer.Add(new CustReportModel(myReader["ID"].ToString(),
                                                        myReader["Route"].ToString(),
                                                        myReader["LastName"].ToString(),
                                                            myReader["FirstName"].ToString(),
                                                            myReader["Email"].ToString(),
                                                            myReader["Phone"].ToString(),
                                                            Convert.ToInt16(myReader["NumberofSeats"].ToString()),
                                                            Convert.ToDateTime(myReader["TravelDate"].ToString()),
                                                            Convert.ToDateTime(myReader["CreateDate"].ToString()),
                                                            Convert.ToDateTime(myReader["LastUpDate"].ToString()),
                                                            myReader["PersonUpdate"].ToString(),
                                                            myReader["Notes"].ToString(),
                                                            myReader["Confirmation"].ToString(),
                                                            myReader["Traveler1Name"].ToString(),
                                                            myReader["Traveler2Name"].ToString(),
                                                            myReader["Traveler3Name"].ToString(),
                                                            myReader["Traveler4Name"].ToString(),
                                                            myReader["Traveler5Name"].ToString(),
                                                            myReader["Traveler6Name"].ToString(),
                                                            myReader["TravelDisclosure"].ToString()));                    
                    cmd.Dispose();
                }
}
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);

            }
            finally
            {                
                con.Close();
            }

            return customer;
        }
        public List<GreatLand.Models.CustReportModel> DeleteTask(Int64 id)
        {

            var customer = new List<CustReportModel>();
            var con = new SqlConnection();                 

                try
                {
                    con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("dbo.DeleteTask", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader myReader = null;

                myReader = cmd.ExecuteReader();
                
                while (myReader.Read())
                {            
                        customer.Add(new CustReportModel(myReader["ID"].ToString(),
                                                        myReader["Route"].ToString(),
                                                        myReader["LastName"].ToString(),
                                                            myReader["FirstName"].ToString(),
                                                            myReader["Email"].ToString(),
                                                            myReader["Phone"].ToString(),
                                                            Convert.ToInt16(myReader["NumberofSeats"].ToString()),
                                                            Convert.ToDateTime(myReader["TravelDate"].ToString()),
                                                            Convert.ToDateTime(myReader["CreateDate"].ToString()),
                                                            Convert.ToDateTime(myReader["LastUpDate"].ToString()),
                                                            myReader["PersonUpdate"].ToString(),
                                                            myReader["Notes"].ToString(),
                                                            myReader["Confirmation"].ToString(),
                                                            myReader["Traveler1Name"].ToString(),
                                                            myReader["Traveler2Name"].ToString(),
                                                            myReader["Traveler3Name"].ToString(),
                                                            myReader["Traveler4Name"].ToString(),
                                                            myReader["Traveler5Name"].ToString(),
                                                            myReader["Traveler6Name"].ToString(),
                                                            myReader["TravelDisclosure"].ToString()));                    
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);

            }
            finally
            {                
                con.Close();
            }

            return customer;
        }

        public string CreateConfirmation(CustTaskModelBson task)
        {
            string travelDate = task.Date.ToString("MMdd");
               
            //var getD = new Confirmation();
            //var i = getD.Military(task.d)
           // string confirm = "";
            //List<Routes> list = new List<Routes>();
            //var confirm = "1" + getD.RouteDetails(list, task.Route) + task.Date.ToShortDateString();
            //Casino | Time | Month | Day | Reservation count
            //    8    11     02      06     001

            //LB-01
            //switch (task.Route.Substring(0, 1))
            //{

            //    case "L":

            //        list = GetLaubergePickupLocation(task.Route.Substring(0, 2));
            //        //get = new Confirmation();
            //        var getL = new Confirmation();
            //       confirm = "8" + getL.RouteDetails(list, task.Route) + task.Date.ToShortDateString();

            //        break;
            //    case "C":
            //        list = GetCoushataPickupLocation(task.Route.Substring(0, 2));
            //        var getC = new Confirmation();
            //        confirm = "6" + getC.RouteDetails(list, task.Route) + task.Date.ToShortDateString();
            //        break;
            //    case "D":
            //        list = GetDeltaDownPickupLocation(task.Route.Substring(0, 2));
            //        var getD = new Confirmation();
            //        confirm = "1" + getD.RouteDetails(list, task.Route) + task.Date.ToShortDateString();
            //        break;
            //    case "G":
            //        list = GetGGNPickupLocation(task.Route.Substring(0, 2));
            //        var getG = new Confirmation();
            //        confirm = "9" + getG.RouteDetails(list, task.Route) + task.Date.ToShortDateString();
            //        break;

            //    case "H":
            //        list = GetHSPickupLocation(task.Route.Substring(0, 2));
            //        var getH = new Confirmation();
            //        confirm = "7" + getH.RouteDetails(list, task.Route) + task.Date.ToShortDateString();
            //        break;
            //    case "I":
            //        GetHSPickupLocation(task.Route.Substring(0, 2));
            //        var getI = new Confirmation();
            //        confirm = "2" + getI.RouteDetails(list, task.Route) + task.Date.ToShortDateString();
            //        break;
            //}

            //Have casino|time




            return travelDate;
        }

        public CustTaskModelBson EditTask(CustTaskModelBson task)
        {

            //string task1 = CreateConfirmation(task);

            var con = new SqlConnection();
            con = new SqlConnection(connectionString);
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.EditTask", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", task.Id);
                cmd.Parameters.AddWithValue("@Route", task.Route == null ? task.State : task.Route);
                cmd.Parameters.AddWithValue("@NumberofSeats", task.SeatsNumber);
                cmd.Parameters.AddWithValue("@TravelDate", task.Date);
                cmd.Parameters.AddWithValue("@FirstName", task.FirstName);
                cmd.Parameters.AddWithValue("@LastName", task.LastName);
                cmd.Parameters.AddWithValue("@Email", task.Email);
                cmd.Parameters.AddWithValue("@Phone", task.Phone);
                cmd.Parameters.AddWithValue("@Notes", task.Notes == null ? "" : task.Notes);
                cmd.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@PersonUpdate", task.PersonUpdate);
                cmd.Parameters.AddWithValue("@Confirmation", task.Confirmation);
                cmd.Parameters.AddWithValue("@Traveler1Name", task.Traveler1Name == null ? "" : task.Traveler1Name);
                cmd.Parameters.AddWithValue("@Traveler2Name", task.Traveler2Name == null ? "" : task.Traveler2Name);
                cmd.Parameters.AddWithValue("@Traveler3Name", task.Traveler3Name == null ? "" : task.Traveler3Name);
                cmd.Parameters.AddWithValue("@Traveler4Name", task.Traveler4Name == null ? "" : task.Traveler4Name);
                cmd.Parameters.AddWithValue("@Traveler5Name", task.Traveler5Name == null ? "" : task.Traveler5Name);
                cmd.Parameters.AddWithValue("@Traveler6Name", task.Traveler6Name == null ? "" : task.Traveler6Name);

                //cmd.Parameters.Add("@NewConfirmation", SqlDbType.BigInt).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                //var confirmationId = cmd.Parameters["@NewConfirmation"].Value;

                //task.Confirmation = (long)confirmationId;

                /*test sql
                [dbo].InsertTask @Route='LB-01', 
				@NumberofSeats = 5,
                @TravelDate = '2/25/2016 12:00:00 AM',
				@FirstName = 'Minh',
                @LastName = 'bui',
                @Email = 'minh.bui@he.com',
                @Phone = '34234',
                @Notes = 'test',
                @CreateDate = '2/24/2016 12:00:00 AM',
                @LastUpdate = '2/24/2016 12:00:00 AM',
                @PersonUpdate = 'system',
                @Confirmation = 8092242016
                */

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);
            }
            finally
            {
                con.Close();
            }


            return task;
        }


        public void ConfirmReservation(long confirmation)
        {

            var con = new SqlConnection(connectionString);
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.ConfirmReservation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Confirmation", confirmation);
                cmd.ExecuteNonQuery();

                   cmd.Dispose();

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);

            }
            finally
            {

                con.Close();
            }


        }

        // Creates a Task and inserts it into the collection in MongoDB.
        public CustTaskModelBson CreateTask(CustTaskModelBson task)
        {

            //string task1 = CreateConfirmation(task);

            var con = new SqlConnection();
            con = new SqlConnection(connectionString);
            try
            {

                var test = CreateConfirmation(task);

                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.InsertTask", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Route", task.Route == null ? task.State : task.Route);
                cmd.Parameters.AddWithValue("@NumberofSeats", task.SeatsNumber);
                cmd.Parameters.AddWithValue("@TravelDate", task.Date);
                cmd.Parameters.AddWithValue("@FirstName", task.FirstName);
                cmd.Parameters.AddWithValue("@LastName", task.LastName);
                cmd.Parameters.AddWithValue("@Email", task.Email);
                cmd.Parameters.AddWithValue("@Phone", task.Phone);
                cmd.Parameters.AddWithValue("@Notes", task.Notes == null ? "" : task.Notes);
                cmd.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@PersonUpdate", task.PersonUpdate);
                cmd.Parameters.AddWithValue("@Confirmation", CreateConfirmation(task));
                cmd.Parameters.AddWithValue("@Traveler1Name", task.Traveler1Name == null? "": task.Traveler1Name);
                cmd.Parameters.AddWithValue("@Traveler2Name", task.Traveler2Name == null ? "" : task.Traveler2Name);
                cmd.Parameters.AddWithValue("@Traveler3Name", task.Traveler3Name == null ? "" : task.Traveler3Name);
                cmd.Parameters.AddWithValue("@Traveler4Name", task.Traveler4Name == null ? "" : task.Traveler4Name);
                cmd.Parameters.AddWithValue("@Traveler5Name", task.Traveler5Name == null ? "" : task.Traveler5Name);
                cmd.Parameters.AddWithValue("@Traveler6Name", task.Traveler6Name == null ? "" : task.Traveler6Name);

                cmd.Parameters.Add("@NewConfirmation", SqlDbType.BigInt).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                var confirmationId = cmd.Parameters["@NewConfirmation"].Value;

                task.Confirmation = (long)confirmationId;

                /*test sql
                [dbo].InsertTask @Route='LB-01', 
				@NumberofSeats = 5,
                @TravelDate = '2/25/2016 12:00:00 AM',
				@FirstName = 'Minh',
                @LastName = 'bui',
                @Email = 'minh.bui@he.com',
                @Phone = '34234',
                @Notes = 'test',
                @CreateDate = '2/24/2016 12:00:00 AM',
                @LastUpdate = '2/24/2016 12:00:00 AM',
                @PersonUpdate = 'system',
                @Confirmation = 8092242016
                */

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);
            }
            finally
            {
                con.Close();
            }


            return task;
        }

        #region IDisposable

        public void Dispose()
        {
            //this.Dispose(true);
            GC.SuppressFinalize(this);
        }


        #endregion
        //private async Task<List<BsonDocument>> GetTasksCollection()
        //{
        //    var client = new MongoClient(connectionString);
        //    var database = client.GetDatabase("GreateLand");
        //    var collection = database.GetCollection<BsonDocument>("Task");
        //    //var filter = Builders<BsonDocument>.Filter.Eq("name", "test");
        //    var filter = new BsonDocument();

        //    var list = await collection.Find(filter).ToListAsync();


        //    return list;
        //}

        //private List<CustTaskModel> GetTasksCollectionForEdit()
        //{
        //    var client = new MongoClient(connectionString);
        //    var database = client.GetDatabase("GreatLand");
        //    var todoTaskCollection = database.GetCollection<CustTaskModel>("Tasks");
        //    return (List<CustTaskModel>)todoTaskCollection;
        //}

        // Creates a Task and inserts it into the collection in MongoDB.
        public void SaveBlockRoute(string routeID, string beginDate, string endDate, string active)
        {

            //string task1 = CreateConfirmation(task);

            var con = new SqlConnection();
            con = new SqlConnection(connectionString);
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.SaveBlockRoute", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Route", routeID);
                cmd.Parameters.AddWithValue("@BeginDate", Convert.ToDateTime(beginDate));
                cmd.Parameters.AddWithValue("@EndDate", Convert.ToDateTime(endDate));
                cmd.Parameters.AddWithValue("@Active", active);
                
                //cmd.Parameters.Add("@NewConfirmation", SqlDbType.BigInt).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                //var confirmationId = cmd.Parameters["@NewConfirmation"].Value;

                //task.Confirmation = (long)confirmationId;

                /*test sql
                [dbo].InsertTask @Route='LB-01', 
				@NumberofSeats = 5,
                @TravelDate = '2/25/2016 12:00:00 AM',
				@FirstName = 'Minh',
                @LastName = 'bui',
                @Email = 'minh.bui@he.com',
                @Phone = '34234',
                @Notes = 'test',
                @CreateDate = '2/24/2016 12:00:00 AM',
                @LastUpdate = '2/24/2016 12:00:00 AM',
                @PersonUpdate = 'system',
                @Confirmation = 8092242016
                */

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw new System.ArgumentOutOfRangeException("Error", ex);
            }
            finally
            {
                con.Close();
            }


            //return task;
        }

    }



}



