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

namespace GreatLand.DAL
{
    public class DalLauberge: IDalLauberge
    {

        private bool disposed = false;

        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Active"].ToString();
        /// <summary>
        /// Get Lauberge pickup
        /// </summary>
        /// <param name="LocID"></param>
        /// <returns></returns>
        public List<Routes> GetLaubergePickupLocation(int LocID)
        {
            switch (LocID)
            {
                case 1:
                    return LookupData.Laub_SouthHouston;

                case 2:
                    return LookupData.Laub_SWH;

                case 3:
                    return LookupData.Laub_EastHouston;

                case 4:
                    return LookupData.Laub_PearlandHouston;

                case 5:
                    return LookupData.Laub_PasadenaHouston;

                case 6:
                    return LookupData.Laub_NorthwestHouston;

                case 7:
                    return LookupData.Laub_45NLittleYork;

                case 8:
                    return LookupData.Laub_Baytown;

            }

            return LookupData.Laub_SWH;
        }

        /// <summary>
        /// Get Lauberge pickup based on ID
        /// </summary>
        /// <param name="LocID"></param>
        /// <returns></returns>
        //public List<Routes> GetLaubergePickupLocation(string LocID)
        //{


        //    switch (LocID)
        //    {
        //        case "LB":
        //            return LookupData.Laub_SouthHouston;

        //        case "LA":
        //            return LookupData.Laub_SWH;

        //        case "LC":
        //            return LookupData.Laub_EastHouston;

        //        case "LD":
        //            return LookupData.Laub_PearlandHouston;

        //        case "LE":
        //            return LookupData.Laub_PasadenaHouston;

        //        case "LF":
        //            return LookupData.Laub_NorthwestHouston;

        //        case "LG":
        //            return LookupData.Laub_45NLittleYork;

        //        case "LH":
        //            return LookupData.Laub_Baytown;

        //    }

        //    return LookupData.Laub_SWH;
        //}

        public List<Routes> GetPickupLocationDB(int selectedListItem, int casino)
        {

            var r = new List<Routes>();
            var con = new SqlConnection(connectionString);
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetBusRouteDepartureDetailsByRouteDBCasino", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SelectedListItem", selectedListItem);
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

        public List<Routes> GetLaubergePickupLocationDB(string LocID)
        {

            var r = new List<Routes>();
            var con = new SqlConnection(connectionString);
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetBusRouteDepartureDetailsByRouteDB", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Route", LocID);

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
    }
}
