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
    public class DalManager : IDalManager
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Active"].ToString();

        public List<ManagerView> GetManagerRoute(int id)
        {

            var route = new List<ManagerView>();
            var con = new SqlConnection(connectionString);
            try
            {

                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetManagerRouteByID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);

                SqlDataReader myReader = null;

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string test = myReader["Routes1"].ToString();
                    route.Add(new ManagerView(myReader["ID"].ToString(),
                                                    myReader["Casino"].ToString(),
                                                    myReader["Routes1"].ToString(),
                                                        myReader["DepartTime"].ToString(),
                                                        myReader["DayOfTheWeek"].ToString(),
                                                        myReader["PickUpLocations"].ToString(),
                                                        Convert.ToInt16(myReader["RouteNumber"].ToString()),
                                                        myReader["Active"].ToString(),
                                                        myReader["StartVoidDate"].ToString(),
                                                        myReader["EndVoidDate"].ToString()));


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



            return route;
        }
        public List<ManagerView> GetManagerRoute()
        {

            var route = new List<ManagerView>();
            var con = new SqlConnection(connectionString);
            try
            {

                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("dbo.GetManagerRoute", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Route", location.TrimEnd());

                SqlDataReader myReader = null;

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string test = myReader["Routes1"].ToString();
                    route.Add(new ManagerView(myReader["ID"].ToString(),
                                                    myReader["Casino"].ToString(),
                                                    myReader["Routes1"].ToString(),
                                                        myReader["DepartTime"].ToString(),
                                                        myReader["DayOfTheWeek"].ToString(),
                                                        myReader["PickUpLocations"].ToString(),
                                                        Convert.ToInt16(myReader["RouteNumber"].ToString()),
                                                        myReader["Active"].ToString(),
                                                        myReader["StartVoidDate"].ToString(),
                                                        myReader["EndVoidDate"].ToString()));


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



            return route;
        }
    }
}
