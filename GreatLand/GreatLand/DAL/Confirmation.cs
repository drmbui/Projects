using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatLand.Models;

namespace GreatLand.DAL
{
    public class Confirmation
    {
        public string RouteDetails(List<Routes> route, string originalRoute)
        {
            string routeDetails = null;
            var r0 = route.Where(r => r.Route == originalRoute);
            var depart = from r1 in r0 select new { r1.Depart };
            foreach(var v in depart)
            {
                routeDetails = v.Depart.ToString();
                routeDetails = Military(routeDetails);
                return routeDetails;
            }
            return routeDetails;
            
        }

        

        public string Military(string time)
        {
            //seach for PM
            string pm = "PM";
            string militaryConverted = "";
            if (System.Text.RegularExpressions.Regex.IsMatch(time,pm))
            {
                switch (time.Substring(0,2))
                {
                    case "1:":
                        militaryConverted = "13";
                    break;
                    case "2:":
                        militaryConverted = "14";
                        break;
                    case "3:":
                        militaryConverted = "15";
                        break;
                    case "4:":
                        militaryConverted = "16";
                        break;
                    case "5:":
                        militaryConverted = "17";
                        break;
                    case "6:":
                        militaryConverted = "18";
                        break;
                    case "7:":
                        militaryConverted = "19";
                        break;
                    case "8:":
                        militaryConverted = "20";
                        break;
                    case "9:":
                        militaryConverted = "21";
                        break;
                    case "10":
                        militaryConverted = "22";
                        break;
                    case "11":
                        militaryConverted = "23";
                        break;
                    case "12":
                        militaryConverted = "24";
                    break;
                }
            }
            else
            {
                switch (time.Substring(0, 2))
                {
                    case "1:":
                        militaryConverted = "01";
                        break;
                    case "2:":
                        militaryConverted = "02";
                        break;
                    case "3:":
                        militaryConverted = "03";
                        break;
                    case "4:":
                        militaryConverted = "04";
                        break;
                    case "5:":
                        militaryConverted = "05";
                        break;
                    case "6:":
                        militaryConverted = "06";
                        break;
                    case "7:":
                        militaryConverted = "07";
                        break;
                    case "8:":
                        militaryConverted = "08";
                        break;
                    case "9:":
                        militaryConverted = "09";
                        break;
                    case "10":
                        militaryConverted = "10";
                        break;
                    case "11":
                        militaryConverted = "11";
                        break;
                    case "12":
                        militaryConverted = "12";
                        break;
                }
            }

            return militaryConverted;
        }

 
    }
}
