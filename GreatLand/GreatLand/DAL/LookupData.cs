using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using GreatLand;
using GreatLand.Models;

namespace GreatLand
{


    public static class LookupData
    {
        /////////////////////////////////////////////Isle Capri////////////////////////////////////////////////////////////////
        //Office|Gulfgate Woodridge|Uvalde|Baytown


        /// <summary>
        /// Southwest Houston
        /// </summary>
        public static List<Routes> IC_SWH
        {
            get
            {
                var IsleCapriRoute = new List<Routes>();


                //db.Route.insert({ Route: "IC-01",Day: "Everyday",Depart: "9:00 AM",ArriveCasino: "11:50 PM",DepartCasino: "5:00 PM",ReturnTime: "7:45 PM",YouPay: "$10",YouReceive: "$10 player credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                IsleCapriRoute.Add(new Routes("IA-01", "Everyday",         "9:00 AM",              "11:50 PM",               "5:00 PM",           "7:45 PM",        "$10", "$10 player credit", "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1,8,""));

                //db.Route.insert({ Route: "IC-02",Day: "Everyday",Depart: "8:30 PM",ArriveCasino: "11:20 PM",DepartCasino: "4:30 AM",ReturnTime: "7:15 AM",YouPay: "$10",YouReceive: "$10 player credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                IsleCapriRoute.Add(new Routes("IA-02", "Everyday",         "8:30 PM",              "11:20 PM",              "4:30 AM",            "7:15 AM",        "$10", "$10 player credit", "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1,9,""));

                return IsleCapriRoute;
            }
        }


        /// <summary>
        /// South Houston
        /// </summary>
        public static List<Routes> IC_SouthHouston
        {
            get
            {
                var IsleCapriRoute = new List<Routes>();

                //db.Route.insert({ Route: "IC-03",Day: "Everyday",Depart: "9:30 AM",ArriveCasino: "11:50 PM",DepartCasino: "5:00 PM",ReturnTime: "7:15 PM",YouPay: "$10",YouReceive: "$10 player credit", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                IsleCapriRoute.Add(new Routes("IB-01", "Everyday",         "9:30 AM",              "11:50 PM",              "5:00 PM",            "7:15 PM",        "$10", "$10 player credit", "South Houston", "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 8,""));

                //db.Route.insert({ Route: "IC-04",Day: "Everyday",Depart: "9:00 PM",ArriveCasino: "11:20 PM",DepartCasino: "4:30 AM",ReturnTime: "6:45 AM",YouPay: "$10",YouReceive: "$10 player credit", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                IsleCapriRoute.Add(new Routes("IB-02", "Everyday",         "9:00 PM",              "11:20 PM",              "4:30 AM",            "6:45 AM",        "$10", "$10 player credit", "South Houston", "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 9,""));



                return IsleCapriRoute;
            }
        }





        /// <summary>
        /// East Houston
        /// </summary>
        public static List<Routes> IC_EastHouston
        {
            get
            {
                var IsleCapriRoute = new List<Routes>();

                //db.Route.insert({ Route: "IC-05",Day: "Everyday",Depart: "9:45 AM",ArriveCasino: "11:50 PM",DepartCasino: "5:00 PM",ReturnTime: "7:00 PM",YouPay: "$10",YouReceive: "$10 player credit", DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                IsleCapriRoute.Add(new Routes("IC-01",        "Everyday",         "9:45 AM",             "11:50 PM",             "5:00 PM",            "7:00 PM", "$10", "$10 player credit", "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1,8,""));

                //db.Route.insert({ Route: "IC-06",Day: "Everyday",Depart: "9:20 PM",ArriveCasino: "11:20 PM",DepartCasino: "4:30 AM",ReturnTime: "6:30 AM",YouPay: "$10",YouReceive: "$10 player credit", DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                IsleCapriRoute.Add(new Routes("IC-02", "Everyday",         "9:20 PM",              "11:20 PM",             "4:30 AM",             "6:30 AM",        "$10", "$10 player credit", "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1,9,""));


                return IsleCapriRoute;
            }
        }


        /// <summary>
        /// Baytown
        /// </summary>
        public static List<Routes> IC_Baytown
        {
            get
            {
                var IsleCapriRoute = new List<Routes>();


                //db.Route.insert({ Route: "IC-07",Day: "Everyday",Depart: "10:00 AM",ArriveCasino: "11:50 AM",DepartCasino: "5:00 PM",ReturnTime: "6:45 PM",YouPay: "$10",YouReceive: "$10 player credit", DescriptionH: "Baytown", DescriptionD: "Toys R Us | 4815 I-10 E Freeway"})
                IsleCapriRoute.Add(new Routes("ID-01",        "Everyday",        "10:00 AM",              "11:50 AM",              "5:00 PM",            "6:45 PM", "$10", "$10 player credit", "Baytown", "Toys R Us | 4815 I-10 E Freeway", 1,8,""));


                //db.Route.insert({ Route: "IC-08",Day: "Everyday",Depart: "9:40 PM",ArriveCasino: "11:20 PM",DepartCasino: "4:30 AM",ReturnTime: "6:15 AM",YouPay: "$10",YouReceive: "$10 player credit", DescriptionH: "Baytown", DescriptionD: "Toys R Us | 4815 I-10 E Freeway"})
                IsleCapriRoute.Add(new Routes("ID-02", "Everyday",         "9:40 PM",              "11:20 PM",              "4:30 AM",            "6:15 AM", "$10", "$10 player credit", "Baytown", "Toys R Us | 4815 I-10 E Freeway", 1,9,""));



                return IsleCapriRoute;
            }
        }




        /////////////////////////////////////////////HorseShoe/////////////////////////////////////////////////////////////////


        /// <summary>
        /// South Houston
        /// </summary>
        public static List<Routes> HS_SouthHouston
        {
            get
            {
                var HorseShoeRoute = new List<Routes>();

                //db.Route.insert({ Route: "HB-01",Day: "Friday",Depart: "7:30 PM",ArriveCasino: "12:00 AM",DepartCasino: "5:30 PM",ReturnTime: "9:45 PM",YouPay: "$10",YouReceive: "-", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                HorseShoeRoute.Add(new Routes("HA-01", "Friday",         "7:30 PM",              "12:00 AM",              "5:30 PM",            "9:45 PM",        "$10", "-", "South Houston", "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1,12,""));

                //db.Route.insert({ Route: "HB-02",Day: "Sunday",Depart: "8:30 AM",ArriveCasino: "1:00 PM",DepartCasino: "6:30 PM",ReturnTime: "10:45 PM",YouPay: "$10",YouReceive: "-", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                HorseShoeRoute.Add(new Routes("HA-02", "Sunday",         "8:30 AM",              "1:00 PM",              "6:30 PM",            "10:45 PM",        "$10", "-", "South Houston", "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1,13,""));

                return HorseShoeRoute;
            }
        }


        /// <summary>
        /// Southwest Houston
        /// </summary>
        public static List<Routes> HS_SWH
        {
            get
            {
                var HorseShoeRoute = new List<Routes>();

                //db.Route.insert({ Route: "HB-03",Day: "Friday",Depart: "7:00 PM",ArriveCasino: "12:00 AM",DepartCasino: "5:30 PM",ReturnTime: "10:10 PM",YouPay: "$10",YouReceive: "-", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                HorseShoeRoute.Add(new Routes("HB-01", "Friday",         "7:00 PM",              "12:00 AM",              "5:30 PM",            "10:10 PM",        "$10", "-", "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1,12,""));

                //db.Route.insert({ Route: "HB-04",Day: "Sunday",Depart: "8:00 AM",ArriveCasino: "1:00 PM",DepartCasino: "6:30 PM",ReturnTime: "11:10 PM",YouPay: "$10",YouReceive: "-", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                HorseShoeRoute.Add(new Routes("HB-02", "Sunday",          "8:00 AM",             "1:00 PM",              "6:30 PM",            "11:10 PM",        "$10",            "-", "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1,13,""));


                return HorseShoeRoute;
            }
        }

        /// <summary>
        /// 45 North Little York, Houston
        /// </summary>
        public static List<Routes> HS_45NLittleYork
        {
            get
            {
                var HorseShoeRoute = new List<Routes>();

                //db.Route.insert({ Route: "HB-05",Day: "Friday",Depart: "8:00 PM",ArriveCasino: "12:00 AM",DepartCasino: "5:30 PM",ReturnTime: "9:20 PM",YouPay: "$10",YouReceive: "-", DescriptionH: "45 North Little York", DescriptionD: "Whataburger | 444 W Little York Houston, TX 77076"})
                HorseShoeRoute.Add(new Routes("HC-01", "Friday",         "8:00 PM",              "12:00 AM",              "5:30 PM",            "9:20 PM",        "$10", "-", "45 North Little York", "Whataburger | 444 W Little York Houston, TX 77076", 1,12,""));

                //db.Route.insert({ Route: "HB-06",Day: "Sunday",Depart: "9:45 AM",ArriveCasino: "1:00 PM",DepartCasino: "6:30 PM",ReturnTime: "10:25 PM",YouPay: "$10",YouReceive: "-", DescriptionH: "45 North Little York", DescriptionD: "Whataburger | 444 W Little York Houston, TX 77076"})
                HorseShoeRoute.Add(new Routes("HC-02", "Sunday",         "9:45 AM",              "1:00 PM",              "6:30 PM",            "10:25 PM",        "$10", "-", "45 North Little York", "Whataburger | 444 W Little York Houston, TX 77076", 1,13,""));

                return HorseShoeRoute;
            }
        }

        /// <summary>
        /// Lufkin
        /// </summary>
        public static List<Routes> HS_Lufkin
        {
            get
            {
                var HorseShoeRoute = new List<Routes>();


                //db.Route.insert({ Route: "HB-07",Day: "Friday",Depart: "8:00 PM",ArriveCasino: "12:00 AM",DepartCasino: "5:30 PM",ReturnTime: "9:20 PM",YouPay: "$10",YouReceive: "-", DescriptionH: "Lufkin", DescriptionD: "WALMART | 2500 Daniel McCall Dr. | Pickup at Outback Steakhouse"})
                HorseShoeRoute.Add(new Routes("HD-01", "Friday", "8:00 PM", "12:00 AM", "5:30 PM", "9:20 PM", "$10", "-", "Lufkin", "WALMART | 2500 Daniel McCall Dr. | Pickup at Outback Steakhouse", 1,12,""));


                //db.Route.insert({ Route: "HB-08",Day: "Sunday",Depart: "11:00 AM",ArriveCasino: "1:00 PM",DepartCasino: "6:30 PM",ReturnTime: "8:35 PM",YouPay: "$10",YouReceive: "-", DescriptionH: "Lufkin", DescriptionD: "WALMART | 2500 Daniel McCall Dr. | Pickup at Outback Steakhouse"})
                HorseShoeRoute.Add(new Routes("HD-02", "Sunday",         "11:00 AM",              "1:00 PM",              "6:30 PM",            "8:35 PM", "$10", "-", "Lufkin", "WALMART | 2500 Daniel McCall Dr. | Pickup at Outback Steakhouse", 1,13,""));

                return HorseShoeRoute;
            }
        }


        /////////////////////////////////////////////Golden Nugget//////////////////////////////////////////////////////////////


        /// <summary>
        /// Southwest Houston
        /// </summary>
        public static List<Routes> GN_SWH
        {
            get
            {
                var GoldenNuggetRoute = new List<Routes>();


                //db.Route.insert({ Route: "GN-06",Day: "Everyday",Depart: "9:00 AM",ArriveCasino: "11:50 PM",DepartCasino: "5:00 PM",ReturnTime: "7:45 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})-----bad********************BAD AFTER THIS ROUTE FIX*****************
                GoldenNuggetRoute.Add(new Routes("GA-01", "Everyday",      "9:00 AM",              "11:50 PM",              "5:00 PM",             "7:45 PM",       "$10",            "$5 player credit or $10 meal credit",               "Southwest Houston",               "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));

                //db.Route.insert({ Route: "GN-07",Day: "Everyday",Depart: "11:00 AM",ArriveCasino: "1:45 PM",DepartCasino: "6:45 PM",ReturnTime: "9:20 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                GoldenNuggetRoute.Add(new Routes("GA-02", "Everyday",      "11:00 AM",              "1:45 PM",              "6:45 PM",            "7:20 PM",        "$10",            "$5 player credit or $10 meal credit",                "Southwest Houston",              "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));


                //db.Route.insert({ Route: "GN-08",Day: "Everyday",Depart: "1:00 PM",ArriveCasino: "3:40 PM",DepartCasino: "8:45 PM",ReturnTime: "11:10 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                GoldenNuggetRoute.Add(new Routes("GA-03", "Everyday",       "1:00 PM",             "3:40 PM",              "8:45 PM",            "11:10 PM",        "$10",            "$5 player credit or $10 meal credit", "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,"")); ;


                //db.Route.insert({ Route: "GN-09",Day: "Everyday",Depart: "4:00 PM",ArriveCasino: "6:30 PM",DepartCasino: "11:30 PM",ReturnTime: "2:00 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                GoldenNuggetRoute.Add(new Routes("GA-04", "Everyday",      "4:00 PM",              "6:30 PM",              "11:30 PM",            "2:00 AM",        "$10",            "$5 player credit or $10 meal credit", "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));

                //db.Route.insert({ Route: "GN-10",Day: "Everyday",Depart: "6:30 PM",ArriveCasino: "9:30 PM",DepartCasino: "3:00 AM",ReturnTime: "5:45 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                GoldenNuggetRoute.Add(new Routes("GA-05", "Everyday",      "6:30 PM",              "9:30 PM",              "3:00 AM",             "5:45 AM",       "$10", "$5 player credit or $10 meal credit", "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));

                //db.Route.insert({ Route: "GN-11",Day: "Everyday",Depart: "8:30 PM",ArriveCasino: "11:15 PM",DepartCasino: "4:30 AM",ReturnTime: "7:00 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                GoldenNuggetRoute.Add(new Routes("GA-06", "Everyday",      "8:30 PM",              "11:15 PM",              "4:30 AM",            "7:00 AM",        "$10", "$5 player credit or $10 meal credit", "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));


                //db.Route.insert({ Route: "GN-12",Day: "Everyday",Depart: "11:00 PM",ArriveCasino: "1:45 AM",DepartCasino: "7:00 AM",ReturnTime: "9:40 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                GoldenNuggetRoute.Add(new Routes("GA-07", "Everyday",       "11:00 PM",             "1:45 AM",              "7:00 AM",            "9:40 AM",        "$10", "$5 player credit or $10 meal credit", "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));



                return GoldenNuggetRoute;
            }
        }


        /// <summary>
        /// South Houston
        /// </summary>
        public static List<Routes> GN_SouthHouston
        {
            get
            {
                var GoldenNuggetRoute = new List<Routes>();


                //db.Route.insert({ Route: "GN-01",Day: "Everyday",Depart: "9:20 AM",ArriveCasino: "11:50 PM",DepartCasino: "5:00 PM",ReturnTime: "7:15 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                GoldenNuggetRoute.Add(new Routes("GB-01", "Everyday",       "9:20 AM",             "11:50 PM",              "5:00 PM",            "7:15 PM",        "$10", "$5 player credit or $10 meal credit", "South Houston", "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 3,""));


                //db.Route.insert({ Route: "GN-02",Day: "Everyday",Depart: "11:30 AM",ArriveCasino: "1:45 PM",DepartCasino: "6:45 PM",ReturnTime: "8:55 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                GoldenNuggetRoute.Add(new Routes("GB-02", "Everyday",       "11:30 AM",             "1:45 PM",              "6:45 PM",            "8:55 PM", "$10", "$5 player credit or $10 meal credit", "South Houston", "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 3,""));


                //db.Route.insert({ Route: "GN-03",Day: "Everyday",Depart: "7:00 PM",ArriveCasino: "9:20 PM",DepartCasino: "3:00 AM",ReturnTime: "5:15 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                GoldenNuggetRoute.Add(new Routes("GB-03", "Everyday",      "7:00 PM",              "9:20 PM",              "3:00 AM",            "5:15 AM",        "$10", "$5 player credit or $10 meal credit", "South Houston", "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 3,""));


                //db.Route.insert({ Route: "GN-04",Day: "Everyday",Depart: "9:00 PM",ArriveCasino: "11:15 PM",DepartCasino: "4:30 AM",ReturnTime: "6:45 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                GoldenNuggetRoute.Add(new Routes("GB-04", "Everyday",      "9:00 PM",              "11:15 PM",              "4:30 AM",            "6:45 AM",        "$10", "$5 player credit or $10 meal credit", "South Houston", "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 3,""));


                //db.Route.insert({ Route: "GN-05",Day: "Fri,Sat,Sun",Depart: "11:30 PM",ArriveCasino: "1:45 AM",DepartCasino: "7:00 AM",ReturnTime: "9:15 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                GoldenNuggetRoute.Add(new Routes("GB-05", "Fri,Sat,Sun",       "11:30 PM",             "1:45 AM",              "7:00 AM",            "9:15 AM", "$10",                   "$5 player credit or $10 meal credit", "South Houston", "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 3,""));


                return GoldenNuggetRoute;
            }
        }


        /// <summary>
        /// East Houston
        /// </summary>
        public static List<Routes> GN_EastHouston
        {
            get
            {
                var GoldenNuggetRoute = new List<Routes>();


                //db.Route.insert({ Route: "GN-13",Day: "Everyday",Depart: "9:45 AM",ArriveCasino: "11:50 PM",DepartCasino: "5:00 PM",ReturnTime: "7:00 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                GoldenNuggetRoute.Add(new Routes("GC-01",         "Everyday",        "9:45 AM",             "11:50 PM",              "5:00 PM",            "7:00 PM",        "$10", "$5 player credit or $10 meal credit", "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 3,""));

                //db.Route.insert({ Route: "GN-14",Day: "Everyday",Depart: "11:50 AM",ArriveCasino: "1:45 PM",DepartCasino: "6:45 PM",ReturnTime: "8:40 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                GoldenNuggetRoute.Add(new Routes("GC-02","Everyday",       "11:50 AM",              "1:45 PM",              "6:45 PM",            "8:40 PM",        "$10", "$5 player credit or $10 meal credit", "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 3,""));

                //db.Route.insert({ Route: "GN-15",Day: "Everyday",Depart: "1:40 PM",ArriveCasino: "3:40 PM",DepartCasino: "8:45 PM",ReturnTime: "10:40 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit",  DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                GoldenNuggetRoute.Add(new Routes("GC-03", "Everyday",      "1:40 PM",              "3:40 PM",              "8:45 PM",            "10:40 PM",        "$10", "$5 player credit or $10 meal credit", "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 3,""));

                //db.Route.insert({ Route: "GN-16",Day: "Everyday",Depart: "7:20 PM",ArriveCasino: "9:20 PM",DepartCasino: "3:00 AM",ReturnTime: "5:00 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit",  DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                GoldenNuggetRoute.Add(new Routes("GC-04", "Everyday",      "7:20 PM",              "9:20 PM",              "3:00 AM",            "5:00 AM",        "$10", "$5 player credit or $10 meal credit", "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 3,""));

                //db.Route.insert({ Route: "GN-17",Day: "Everyday",Depart: "9:20 PM",ArriveCasino: "11:15 PM",DepartCasino: "4:30 AM",ReturnTime: "6:30 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                GoldenNuggetRoute.Add(new Routes("GC-05", "Everyday",      "9:20 PM",              "11:15 PM",              "4:30 AM",            "6:30 AM",        "$10", "$5 player credit or $10 meal credit", "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 3,""));
                
                //db.Route.insert({ Route: "GN-18",Day: "Fri,Sat,Sun",Depart: "11:50 PM",ArriveCasino: "1:45 AM",DepartCasino: "7:00 AM",ReturnTime: "9:00 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit",  DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                GoldenNuggetRoute.Add(new Routes("GC-06", "Everyday",      "11:50 PM",                 "1:45 AM",              "7:00 AM",            "9:00 AM", "$10",     "$5 player credit or $10 meal credit", "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 3,""));


                return GoldenNuggetRoute;
            }
        }


        /// <summary>
        /// Pearland Houston
        /// </summary>
        public static List<Routes> GN_PearlandHouston
        {
            get
            {
                var GoldenNuggetRoute = new List<Routes>();


                //db.Route.insert({ Route: "PL-01",Day: "Fri,Sat,Sun",Depart: "9:25 AM",ArriveCasino: "11:50 PM",DepartCasino: "5:00 PM",ReturnTime: "7:25 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Pearland Houston", DescriptionD: "Beltway 8 @ Pearland Parkway | Target | 8503 South Sam Houston Pkwy E Houston, TX 77075"})
                GoldenNuggetRoute.Add(new Routes("GD-01", "Fri,Sat,Sun",     "9:25 AM",              "11:50 PM",              "5:00 PM",              "7:25 PM", "$10", "$5 player credit or $10 meal credit", "Pearland Houston", "Beltway 8 @ Pearland Parkway | Target | 8503 South Sam Houston Pkwy E Houston, TX 77075", 1, 3,""));

                //db.Route.insert({ Route: "PL-02",Day: "Fri,Sat",Depart: "9:00 PM",ArriveCasino: "11:15 PM",DepartCasino: "4:30 AM",ReturnTime: "6:40 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Pearland Houston", DescriptionD: "Beltway 8 @ Pearland Parkway | Target | 8503 South Sam Houston Pkwy E Houston, TX 77075"})
                GoldenNuggetRoute.Add(new Routes("GD-02", "Fri,Sat",      "9:00 PM",              "11:15 PM",              "4:30 AM",            "6:40 AM", "$10", "$5 player credit or $10 meal credit", "Pearland Houston", "Beltway 8 @ Pearland Parkway | Target | 8503 South Sam Houston Pkwy E Houston, TX 77075", 1, 3,""));

                return GoldenNuggetRoute;
            }
        }

        /// <summary>
        /// Pasadena Houston
        /// </summary>
        public static List<Routes> GN_PasadenaHouston
        {
            get
            {
                var GoldenNuggetRoute = new List<Routes>();


                //db.Route.insert({ Route: "PS-01",Day: "Fri,Sat,Sun",Depart: "9:40 AM",ArriveCasino: "11:50 AM",DepartCasino: "5:00 PM",ReturnTime: "7:10 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Pasadena", DescriptionD: "Pep Boys | 5445 Fairmond Pkwy Houston, TX 77505"})
                GoldenNuggetRoute.Add(new Routes("GE-01", "Fri,Sat,Sun",      "9:40 AM",              "11:50 AM",              "5:00 PM",           "7:10 PM", "$10", "$5 player credit or $10 meal credit", "Pasadena", "Pep Boys | 5445 Fairmond Pkwy Houston, TX 77505", 1, 3,""));

                //db.Route.insert({ Route: "PS-02",Day: "Fri,Sat",Depart: "9:15 PM",ArriveCasino: "11:15 PM",DepartCasino: "4:30 AM",ReturnTime: "6:30 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Pasadena", DescriptionD: "Pep Boys | 5445 Fairmond Pkwy Houston, TX 77505"})
                GoldenNuggetRoute.Add(new Routes("GE-02", "Fri,Sat",      "9:15 PM",              "11:15 PM",              "4:30 AM",            "6:30 AM",        "$10", "$5 player credit or $10 meal credit", "Pasadena", "Pep Boys | 5445 Fairmond Pkwy Houston, TX 77505", 1, 3,""));



                return GoldenNuggetRoute;
            }
        }

        /// <summary>
        /// Northwest Houston
        /// </summary>
        public static List<Routes> GN_NorthwestHouston
        {
            get
            {
                var GoldenNuggetRoute = new List<Routes>();

                //db.Route.insert({ Route: "NW-01",Day: "Fri,Sat,Sun",Depart: "9:40 AM",ArriveCasino: "11:50 AM",DepartCasino: "5:00 PM",ReturnTime: "7:10 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Northwest Houston", DescriptionD: "290 @ FWY @ Hollister | Whataburger | 13270 Northwest Frwy Houston, TX 77040"})
                GoldenNuggetRoute.Add(new Routes("GF-01", "Fri,Sat,Sun",      "9:40 AM",              "11:50 AM",              "5:00 PM",            "7:10 PM",        "$10", "$5 player credit or $10 meal credit", "Northwest Houston", "290 @ FWY @ Hollister | Whataburger | 13270 Northwest Frwy Houston, TX 77040", 1, 3,""));

                //db.Route.insert({ Route: "NW-02",Day: "Fri,Sat",Depart: "7:45 PM",ArriveCasino: "11:15 PM",DepartCasino: "4:30 AM",ReturnTime: "7:30 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Northwest Houston", DescriptionD: "290 @ FWY @ Hollister | Whataburger | 13270 Northwest Frwy Houston, TX 77040"})
                GoldenNuggetRoute.Add(new Routes("GF-02", "Fri,Sat",      "7:45 PM",               "11:15 PM",             "4:30 AM",            "7:30 AM",        "$10", "$5 player credit or $10 meal credit", "Northwest Houston", "290 @ FWY @ Hollister | Whataburger | 13270 Northwest Frwy Houston, TX 77040", 1, 3,""));




                return GoldenNuggetRoute;
            }
        }

        /// <summary>
        /// 45 North Little York, Houston
        /// </summary>
        public static List<Routes> GN_45NLittleYork
        {
            get
            {
                var GoldenNuggetRoute = new List<Routes>();


                //db.Route.insert({ Route: "GN-19",Day: "Fri,Sat,Sun",Depart: "8:30 AM",ArriveCasino: "11:50 AM",DepartCasino: "5:00 PM",ReturnTime: "7:40 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "45 North Little York", DescriptionD: "Whataburger | 444 W Little York Houston, TX 77076"})
                GoldenNuggetRoute.Add(new Routes("GG-01", "Fri,Sat,Sun",      "8:30 AM",              "11:50 AM",              "5:00 PM",             "7:40 PM", "$10", "$5 player credit or $10 meal credit", "45 North Little York", "Whataburger | 444 W Little York Houston, TX 77076", 1, 3,""));


                //db.Route.insert({ Route: "GN-20",Day: "Fri,Sat",Depart: "8:20 PM",ArriveCasino: "11:15 PM",DepartCasino: "4:30 AM",ReturnTime: "7:10 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "45 North Little York", DescriptionD: "Whataburger | 444 W Little York Houston, TX 77076"})
                GoldenNuggetRoute.Add(new Routes("GG-02", "Fri,Sat",      "8:30 PM",              "11:15 PM",              "4:30 AM",            "7:10 AM",        "$10", "$5 player credit or $10 meal credit", "45 North Little York", "Whataburger | 444 W Little York Houston, TX 77076", 1, 3,""));


                return GoldenNuggetRoute;
            }
        }

        /// <summary>
        /// Baytown
        /// </summary>
        public static List<Routes> GN_Baytown
        {
            get
            {
                var GoldenNuggetRoute = new List<Routes>();

                //db.Route.insert({ Route: "BT-01",Day: "Everyday",Depart: "10:00 AM",ArriveCasino: "11:50 AM",DepartCasino: "5:00 PM",ReturnTime: "6:50 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Baytown", DescriptionD: "Toys R Us | 4815 I-10 E Freeway"})
                GoldenNuggetRoute.Add(new Routes("GH-01", "Everyday",      "10:00 AM",               "11:50 AM",            "5:00 PM",             "6:50 PM", "$10", "$5 player credit or $10 meal credit", "Baytown", "Toys R Us | 4815 I-10 E Freeway", 1, 3,""));

                //db.Route.insert({ Route: "BT-02",Day: "Fri,Sat",Depart: "9:45 PM",ArriveCasino: "11:15 PM",DepartCasino: "4:30 AM",ReturnTime: "6:15 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Baytown", DescriptionD: "Toys R Us | 4815 I-10 E Freeway"})
                GoldenNuggetRoute.Add(new Routes("GH-02", "Fri,Sat",     "9:45 PM",               "11:15 PM",              "4:30 AM",            "6:15 AM", "$10", "$5 player credit or $10 meal credit", "Baytown", "Toys R Us | 4815 I-10 E Freeway", 1, 3,""));

                return GoldenNuggetRoute;
            }
        }




        /////////////////////////////////////////////Delta Downs////////////////////////////////////////////////////////////////


        /// <summary>
        /// Southwest Houston
        /// </summary>
        public static List<Routes> DeltaDown_SWH
        {
            get
            {
                var DeltaDownRoute = new List<Routes>();


                //db.Route.insert({ Route: "CH-01",Day: "Wednesday",Depart: "9:00 AM",ArriveCasino: "11:25 AM",DepartCasino: "4:30 PM",ReturnTime: "7:00 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                DeltaDownRoute.Add(new Routes("DA-01", "Wednesday", "9:00 AM", "11:25 AM", "4:30 PM", "7:00 PM", "$10", "$5 player credit or $10 meal credit", "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));

                //db.Route.insert({ Route: "CH-02",Day: "Thursday",Depart: "9:00 AM",ArriveCasino: "11:25 AM",DepartCasino: "4:30 PM",ReturnTime: "7:00 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                DeltaDownRoute.Add(new Routes("DA-02", "Thursday",         "9:00 AM",              "11:25 AM",              "4:30 PM",            "7:00 PM",        "$10",           "$5 player credit or $10 meal credit",                "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));


                //db.Route.insert({ Route: "CH-03",Day: "Sunday",Depart: "10:30 AM",ArriveCasino: "12:50 PM",DepartCasino: "6:00 PM",ReturnTime: "8:20 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                DeltaDownRoute.Add(new Routes("DA-03", "Sunday",          "10:30 AM",             "12:50 PM",              "6:00 PM",            "8:20 PM",         "$10", "$5 player credit or $10 meal credit", "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));


                return DeltaDownRoute;
            }
        }

        /// <summary>
        /// South Houston
        /// </summary>
        public static List<Routes> DeltaDown_SH
        {
            get
            {
                var DeltaDownRoute = new List<Routes>();

                //db.Route.insert({ Route: "CI-01",Day: "Wednesday",Depart: "9:30 AM",ArriveCasino: "11:25 AM",DepartCasino: "4:30 PM",ReturnTime: "6:30 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                DeltaDownRoute.Add(new Routes("DB-01",  "Wednesday",        "9:30 AM",              "11:25 AM",              "4:30 PM",            "6:30 PM",        "$10",             "$5 player credit or $10 meal credit", "South Houston", "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 3,""));

                //db.Route.insert({ Route: "CI-02",Day: "Thursday",Depart: "9:30 AM",ArriveCasino: "11:25 AM",DepartCasino: "4:30 PM",ReturnTime: "6:30 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                DeltaDownRoute.Add(new Routes("DB-02",  "Thursday",        "9:30 AM",             "11:25 AM",                "4:30 PM",           "6:30 PM",        "$10",            "$5 player credit or $10 meal credit", "South Houston", "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 3,""));

                //db.Route.insert({ Route: "CI-03",Day: "Sunday",Depart: "11:00 AM",ArriveCasino: "12:50 PM",DepartCasino: "6:00 PM",ReturnTime: "7:55 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                DeltaDownRoute.Add(new Routes("DB-03",  "Sunday",        "11:00 AM",               "12:50 PM",             "6:00 PM",            "7:55 PM",         "$10",           "$5 player credit or $10 meal credit", "South Houston", "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 3,""));


                return DeltaDownRoute;
            }
        }

        /// <summary>
        /// East Houston
        /// </summary>
        public static List<Routes> DeltaDown_EH
        {
            get
            {
                var DeltaDownRoute = new List<Routes>();


                //db.Route.insert({ Route: "CJ-01",Day: "Wednesday",Depart: "9:45 AM",ArriveCasino: "11:25 AM",DepartCasino: "4:30 PM",ReturnTime: "6:15 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                DeltaDownRoute.Add(new Routes("DC-01", "Wednesday", "9:45 AM", "11:25 AM", "4:30 PM", "6:15 PM", "$10", "$5 player credit or $10 meal credit", "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1,3,""));

                //db.Route.insert({ Route: "CJ-02",Day: "Thursday",Depart: "9:45 AM",ArriveCasino: "11:25 AM",DepartCasino: "4:30 PM",ReturnTime: "6:15 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                DeltaDownRoute.Add(new Routes("DC-02", "Thursday",         "9:45 AM",              "11:25 AM",              "4:30 PM",            "6:15 PM",        "$10",             "$5 player credit or $10 meal credit", "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 3,""));


                //db.Route.insert({ Route: "CJ-03",Day: "Sunday",Depart: "11:20 AM",ArriveCasino: "12:50 PM",DepartCasino: "6:00 PM",ReturnTime: "7:40 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit",  DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                DeltaDownRoute.Add(new Routes("DC-03", "Sunday",         "11:20 AM",              "12:50 PM",              "6:00 PM",            "7:40 PM",        "$10",            "$5 player credit or $10 meal credit",                "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 3,""));


                return DeltaDownRoute;
            }
        }



        /// <summary>
        /// Baytown
        /// </summary>
        public static List<Routes> DeltaDown_Baytown
        {
            get
            {
                var DeltaDownRoute = new List<Routes>();



                //db.Route.insert({ Route: "BA-01",Day: "Wednesday",Depart: "10:00 AM",ArriveCasino: "11:25 AM",DepartCasino: "4:30 PM",ReturnTime: "6:00 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Baytown", DescriptionD: "Toys R Us | 4815 I-10 E Freeway @ Garth Rd"})
                DeltaDownRoute.Add(new Routes("DD-01", "Wednesday", "10:00 AM", "11:25 AM", "4:30 PM", "6:00 PM", "$10", "$5 player credit or $10 meal credit", "Baytown", "Toys R Us | 4815 I-10 E Freeway @ Garth Rd", 1,3,""));

                //db.Route.insert({ Route: "BA-02",Day: "Thursday",Depart: "10:00 AM",ArriveCasino: "11:25 AM",DepartCasino: "4:30 PM",ReturnTime: "6:00 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Baytown", DescriptionD: "Toys R Us | 4815 I-10 E Freeway @ Garth Rd"})
                DeltaDownRoute.Add(new Routes("DD-02", "Thursday",         "10:00 AM",              "11:25 AM",              "4:30 PM",             "6:00 PM",       "$10",            "$5 player credit or $10 meal credit", "Baytown", "Toys R Us | 4815 I-10 E Freeway @ Garth Rd", 1, 3,""));

                //db.Route.insert({ Route: "BA-03",Day: "Sunday",Depart: "11:45 AM",ArriveCasino: "12:50 PM",DepartCasino: "6:00 PM",ReturnTime: "7:25 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Baytown", DescriptionD: "Toys R Us | 4815 I-10 E Freeway @ Garth Rd"})
                DeltaDownRoute.Add(new Routes("DD-03",  "Sunday",        "11:45 AM",              "12:50 PM",              "6:00 PM",            "7:25 PM",        "$10",             "$5 player credit or $10 meal credit", "Baytown", "Toys R Us | 4815 I-10 E Freeway @ Garth Rd", 1, 3,""));


                return DeltaDownRoute;
            }
        }



        ////////////////////////////////////////////Coushata/////////////////////////////////////////////////////////////////////
    

          /// <summary>
        /// South Houston
        /// </summary>
        public static List<Routes> Coushata_SH
{
    get
    {
        var CoushataRoute = new List<Routes>();


                //db.Route.insert({ Route: "CA-01",Day: "Everyday",Depart: "9:15 AM",ArriveCasino: "12:00 PM",DepartCasino: "5:00 PM",ReturnTime: "7:50 PM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                CoushataRoute.Add(new Routes("CA-01",   "Everyday",        "9:15 AM",              "12:00 PM",              "5:00 PM",            "7:50 PM",        "$10",            "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", "South Houston", "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 3,""));

                //db.Route.insert({ Route: "CA-02",Day: "Everyday",Depart: "6:40 PM",ArriveCasino: "9:40 PM",DepartCasino: "2:45 AM",ReturnTime: "5:40 AM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                CoushataRoute.Add(new Routes("CA-02",   "Everyday",        "6:40 PM",              "9:40 PM",              "2:45 AM",            "5:40 AM",        "$10",            "$10 Casino Free play Sunday night through Friday Morning - Except Holidays",               "South Houston",                "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 3,""));


                //db.Route.insert({ Route: "CA-03",Day: "Everyday",Depart: "8:40 PM",ArriveCasino: "11:30 PM",DepartCasino: "4:30 AM",ReturnTime: "7:20 AM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                CoushataRoute.Add(new Routes("CA-03",   "Everyday",        "8:40 PM",               "11:30 PM",             "4:30 AM",            "7:20 AM",        "$10",            "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", "South Houston",                             "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 3,""));


                //db.Route.insert({ Route: "CA-04",Day: "Wed to Sun",Depart: "11:00 PM",ArriveCasino: "2:00 AM",DepartCasino: "7:00 AM",ReturnTime: "9:45 AM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                CoushataRoute.Add(new Routes("CA-04",   "Wed to Sun",        "11:00 PM",              "2:00 AM",              "7:00 AM",            "9:45 AM",        "$10",            "$10 Casino Free play Sunday night through Friday Morning - Except Holidays",                "South Houston",              "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 3,""));




                return CoushataRoute;
    }
}


        /// <summary>
        /// Southwest Houston
        /// </summary>
        public static List<Routes> Coushata_SWH
        {
            get
            {
                var CoushataRoute = new List<Routes>();

                //db.Route.insert({ Route: "CB-01",Day: "Everyday",Depart: "8:45 AM",ArriveCasino: "12:00 PM",DepartCasino: "5:00 PM",ReturnTime: "8:15 PM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                CoushataRoute.Add(new Routes("CB-01",    "Everyday",       "8:45 AM",              "12:00 PM",              "5:00 PM",            "8:15 PM",        "$10",             "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));


                //db.Route.insert({ Route: "CB-02",Day: "Everyday",Depart: "6:00 PM",ArriveCasino: "9:40 PM",DepartCasino: "2:45 AM",ReturnTime: "6:10 AM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                CoushataRoute.Add(new Routes("CB-02",   "Everyday",        "6:00 PM",              "9:40 PM",              "2:45 AM",            "6:10 AM",        "$10",            "$10 Casino Free play Sunday night through Friday Morning - Except Holidays",                "Southwest Houston",               "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));


                //db.Route.insert({ Route: "CB-03",Day: "Everyday",Depart: "8:00 PM",ArriveCasino: "11:30 PM",DepartCasino: "4:30 AM",ReturnTime: "7:50 AM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                CoushataRoute.Add(new Routes("CB-03",   "Everyday",        "8:00 PM",              "11:30 PM",              "4:30 AM",            "7:50 AM",        "$10",            "$10 Casino Free play Sunday night through Friday Morning - Except Holidays",               "Southwest Houston",               "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));


                //db.Route.insert({ Route: "CB-04",Day: "Everyday",Depart: "10:30 PM",ArriveCasino: "2:00 AM",DepartCasino: "7:00 AM",ReturnTime: "10:15 AM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                CoushataRoute.Add(new Routes("CB-04",   "Everyday",        "10:30 PM",              "2:00 AM",              "7:00 AM",            "10:15 AM",        "$10",             "$10 Casino Free play Sunday night through Friday Morning - Except Holidays",              "Southwest Houston",               "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));


     
                return CoushataRoute;
            }
        }


        /// <summary>
        /// Northwest Houston
        /// </summary>
        public static List<Routes> Coushata_NWH
        {
            get
            {
                var CoushataRoute = new List<Routes>();


                //db.Route.insert({ Route: "CC-01",Day: "Tue,Fri,Sat,Sun",Depart: "8:00 AM",ArriveCasino: "11:50 AM",DepartCasino: "5:00 PM",ReturnTime: "8:20 PM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "Northwest Houston", DescriptionD: "290 @ FWY @ Hollister | Whataburger | 13270 Northwest Frwy Houston, TX 77040"})
                CoushataRoute.Add(new Routes("CC-01", "Tue,Fri,Sat,Sun", "8:00 AM", "11:50 AM", "5:00 PM", "8:20 PM", "$10", "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", "Northwest Houston", "290 @ FWY @ Hollister | Whataburger | 13270 Northwest Frwy Houston, TX 77040", 1, 3,""));


                //db.Route.insert({ Route: "CC-02",Day: "Fri,Sat",Depart: "7:30 PM",ArriveCasino: "11:30 PM",DepartCasino: "4:30 AM",ReturnTime: "7:50 AM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "Northwest Houston", DescriptionD: "290 @ FWY @ Hollister | Whataburger | 13270 Northwest Frwy Houston, TX 77040"})
                CoushataRoute.Add(new Routes("CC-02",   "Fri,Sat",        "7:30 PM",              "11:30 PM",              "4:30 AM",            "7:50 AM",        "$10",            "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", "Northwest Houston", "290 @ FWY @ Hollister | Whataburger | 13270 Northwest Frwy Houston, TX 77040", 1, 3,""));
                

                return CoushataRoute;
            }
        }


        /// <summary>
        /// 45 North Little York, Houston
        /// </summary>
        public static List<Routes> Coushata_45North
        {
            get
            {
                var CoushataRoute = new List<Routes>();


                //db.Route.insert({ Route: "CD-01",Day: "Tue,Fri,Sat,Sun",Depart: "8:30 AM",ArriveCasino: "11:50 AM",DepartCasino: "5:00 PM",ReturnTime: "8:00 PM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "45 North Little York", DescriptionD: "Whataburger | 444 W Little York Houston, TX 77076"})
                CoushataRoute.Add(new Routes("CD-01", "Tue,Fri,Sat,Sun", "8:30 AM", "11:50 AM", "5:00 PM", "8:00 PM", "$10", "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", "45 North Little York", "Whataburger | 444 W Little York Houston, TX 77076", 1, 3,""));

                //db.Route.insert({ Route: "CD-02",Day: "Fri,Sat",Depart: "8:00 PM",ArriveCasino: "11:30 PM",DepartCasino: "4:30 AM",ReturnTime: "7:30 AM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "45 North Little York", DescriptionD: "Whataburger | 444 W Little York Houston, TX 77076"})
                CoushataRoute.Add(new Routes("CC-02",   "Fri,Sat",        "8:00 PM",              "11:30 PM",             "4:30 AM",             "7:30 AM",        "$10",            "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", "45 North Little York", "Whataburger | 444 W Little York Houston, TX 77076", 1, 3,""));

                return CoushataRoute;
            }
        }


        /// <summary>
        /// East Houston
        /// </summary>
        public static List<Routes> Coushata_EastHouston
        {
            get
            {
                var CoushataRoute = new List<Routes>();


                //db.Route.insert({ Route: "CE-01",Day: "Everyday",Depart: "9:30 AM",ArriveCasino: "12:00 PM",DepartCasino: "5:00 PM",ReturnTime: "7:35 PM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                CoushataRoute.Add(new Routes("CE-01", "Everyday", "9:30 AM", "12:00 PM", "5:00 PM", "7:35 PM", "$10", "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 3,""));

                //db.Route.insert({ Route: "CE-02",Day: "Everyday",Depart: "7:00 PM",ArriveCasino: "9:40 PM",DepartCasino: "2:45 AM",ReturnTime: "5:25 AM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                CoushataRoute.Add(new Routes("CE-02", "Everyday",          "7:00 PM",              "9:40 PM",              "2:45 AM",            "5:25 AM",        "$10",            "$10 Casino Free play Sunday night through Friday Morning - Except Holidays",               "East Houston",               "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 3,""));

                //db.Route.insert({ Route: "CE-03",Day: "Everyday",Depart: "9:00 PM",ArriveCasino: "11:30 PM",DepartCasino: "4:30 AM",ReturnTime: "7:05 AM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays",  DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                CoushataRoute.Add(new Routes("CE-03", "Everyday",          "9:00 PM",              "11:30 PM",              "4:30 AM",            "7:05 AM",        "$10",             "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 3,""));

                //db.Route.insert({ Route: "CE-04",Day: "Everyday",Depart: "11:15 PM",ArriveCasino: "2:00 AM",DepartCasino: "7:00 AM",ReturnTime: "9:30 AM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays",  DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                  CoushataRoute.Add(new Routes("CE-04", "Everyday",        "11:15 PM",              "2:00 AM",              "7:00 AM",            "9:30 AM",        "$10",            "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 3,""));

                return CoushataRoute;
            }
        }


        /// <summary>
        /// Baytown
        /// </summary>
        public static List<Routes> Coushata_Baytown
        {
            get
            {
                var CoushataRoute = new List<Routes>();


                //db.Route.insert({ Route: "CF-01",Day: "Everyday",Depart: "9:45 AM",ArriveCasino: "11:50 AM",DepartCasino: "5:00 PM",ReturnTime: "7:20 PM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "Baytown", DescriptionD: "Toys R Us | 4815 I-10 E Freeway"})
                CoushataRoute.Add(new Routes("CF-01",   "Everyday",        "9:45 AM",              "11:50 AM",              "5:00 PM",            "7:20 PM",        "$10",            "$10 Casino Free play Sunday night through Friday Morning - Except Holidays",               "Baytown", "Toys R Us | 4815 I-10 E Freeway", 1, 3,""));


                //db.Route.insert({ Route: "CF-02",Day: "Everyday",Depart: "9:15 PM",ArriveCasino: "11:30 PM",DepartCasino: "4:30 AM",ReturnTime: "6:50 AM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "Baytown", DescriptionD: "Toys R Us | 4815 I-10 E Freeway"})
                CoushataRoute.Add(new Routes("CF-02", "Everyday",          "9:15 AM",              "11:30 PM",              "4:30 AM",             "6:50 AM",       "$10",            "$10 Casino Free play Sunday night through Friday Morning - Except Holidays",               "Baytown",               "Toys R Us | 4815 I-10 E Freeway", 1, 3,""));


                return CoushataRoute;
            }
        }


        /// <summary>
        /// Beaumont
        /// </summary>
        public static List<Routes> Coushata_Beaumont
        {
            get
            {
                var CoushataRoute = new List<Routes>();



                //db.Route.insert({ Route: "CG-01",Day: "Everyday",Depart: "10:30 AM",ArriveCasino: "12:00 PM",DepartCasino: "5:00 PM",ReturnTime: "6:30 PM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", DescriptionH: "Beaumont", DescriptionD: "I-10 East @ 11th St. | Market Basket | 2255 N 11th St Beaumont, TX 77703"})
                CoushataRoute.Add(new Routes("CG-01", "Everyday", "10:30 AM", "12:00 PM", "5:00 PM", "6:30 PM", "$10", "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", "Beaumont", "I-10 East @ 11th St. | Market Basket | 2255 N 11th St Beaumont, TX 77703", 1, 3,""));
                
                //db.Route.insert({ Route: "CG-02",Day: "Everyday",Depart: "8:15 PM",ArriveCasino: "9:40 PM",DepartCasino: "2:45 AM",ReturnTime: "4:15 AM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays",  DescriptionH: "Beaumont", DescriptionD: "I-10 East @ 11th St. | Market Basket | 2255 N 11th St Beaumont, TX 77703"})
                CoushataRoute.Add(new Routes("CG-02",   "Everyday",        "8:15 PM",              "9:40 PM",              "2:45 AM",            "4:15 AM",         "$10",           "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", "Beaumont", "I-10 East @ 11th St. | Market Basket | 2255 N 11th St Beaumont, TX 77703", 1, 3,""));

                //db.Route.insert({ Route: "CG-03",Day: "Fri,Sat",Depart: "10:00 PM",ArriveCasino: "11:30 PM",DepartCasino: "4:30 AM",ReturnTime: "6:00 AM",YouPay: "$10",YouReceive: "$10 Casino Free play Sunday night through Friday Morning - Except Holidays",  DescriptionH: "Beaumont", DescriptionD: "I-10 East @ 11th St. | Market Basket | 2255 N 11th St Beaumont, TX 77703"})
                CoushataRoute.Add(new Routes("CG-03",   "Fri,Sat",        "10:00 PM",              "11:30 PM",              "4:30 AM",            "6:00 AM",        "$10", "$10 Casino Free play Sunday night through Friday Morning - Except Holidays", "Beaumont", "I-10 East @ 11th St. | Market Basket | 2255 N 11th St Beaumont, TX 77703", 1, 3,""));

                return CoushataRoute;
            }
        }



        ////////////////////////////////////////////LauBerge/////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Southwest Houston
        /// </summary>
        public static List<Routes> Laub_SWH
        {
            get
            {
                var LauRoute = new List<Routes>();

                //db.Route.insert({ Route: "LA-01",Day: "Everyday",Depart: "9:00 AM",ArriveCasino: "11:50 PM",DepartCasino: "5:00 PM",ReturnTime: "7:45 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH:"Southwest Houston", DescriptionD:"Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                LauRoute.Add(new Routes("LA-01", "Everyday", "9:00 AM", "11:50 PM", "5:00 PM", "7:45 PM", "$10", "$5 player credit or $10 meal credit", "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));

                //db.Route.insert({ Route: "LA-02",Day: "Everyday",Depart: "11:00 AM",ArriveCasino: "1:45 PM",DepartCasino: "6:45 PM",ReturnTime: "9:20 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                LauRoute.Add(new Routes(   "LA-02",     "Everyday",         "11:00 AM",              "1:45 PM",             "6:45 PM",            "9:20 PM",        "$10",            "$5 player credit or $10 meal credit",              "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));

                //db.Route.insert({ Route: "LA-03",Day: "Everyday",Depart: "1:00 PM",ArriveCasino: "3:40 PM",DepartCasino: "8:45 PM",ReturnTime: "11:10 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                LauRoute.Add(new Routes(   "LA-03",     "Everyday",       "1:00 PM",              "3:40 PM",              "8:45 PM",             "11:10 PM",        "$10",            "$5 player credit or $10 meal credit",              "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));

                //db.Route.insert({ Route: "LA-04",Day: "Everyday",Depart: "4:00 PM",ArriveCasino: "6:30 PM",DepartCasino: "11:30 PM",ReturnTime: "2:00 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                LauRoute.Add(new Routes(   "LA-04",     "Everyday",        "4:00 PM",              "6:30 PM",              "11:30 PM",            "2:00 AM",         "$10", "$5 player credit or $10 meal credit",                         "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));

                //db.Route.insert({ Route: "LA-05",Day: "Everyday",Depart: "6:30 PM",ArriveCasino: "9:30 PM",DepartCasino: "3:00 AM",ReturnTime: "5:45 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                LauRoute.Add(new Routes(   "LA-05",     "Everyday",         "6:30 PM",             "9:30 PM",              "3:00 AM",            "5:45 AM",        "$10",            "$5 player credit or $10 meal credit",               "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));

                //db.Route.insert({ Route: "LA-06",Day: "Everyday",Depart: "8:30 PM",ArriveCasino: "11:20 PM",DepartCasino: "4:30 AM",ReturnTime: "7:15 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                LauRoute.Add(new Routes(   "LA-06",     "Everyday",        "8:30 PM",              "11:20 PM",              "4:30 AM",            "7:15 AM",        "$10",            "$5 player credit or $10 meal credit",               "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));

                //db.Route.insert({ Route: "LA-07",Day: "Everyday",Depart: "11:00 PM",ArriveCasino: "1:45 AM",DepartCasino: "7:00 AM",ReturnTime: "9:40 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Southwest Houston", DescriptionD: "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart"})
                LauRoute.Add(new Routes(   "LA-07",     "Everyday",        "11:00 PM",              "1:45 AM",              "7:00 AM",            "9:40 AM",        "$10",            "$5 player credit or $10 meal credit",               "Southwest Houston", "Greatland Office | 8800 W. Sam Houston Pkwy S. | Beltway 8 feeder between Beechnut/Bissonet | @ Foodtown next to Walmart", 1, 3,""));


                return LauRoute;
            }
        }


        /// <summary>
        /// South Houston
        /// </summary>
        public static List<Routes> Laub_SouthHouston
        {
            get
            {
                var LauRoute = new List<Routes>();
                //db.Route.insert({ Route: "LB-01",Day: "Everyday",Depart: "9:20 AM",ArriveCasino: "11:50 PM",DepartCasino: "5:00 PM",ReturnTime: "7:15 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                LauRoute.Add(new Routes(   "LB-01",     "Everyday",        "9:20 AM",              "11:50 PM",              "5:00 PM",            "7:15 PM",        "$10",            "$5 player credit or $10 meal credit",               "South Houston",               "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 14,""));

                //db.Route.insert({ Route: "LB-02",Day: "Everyday",Depart: "11:30 AM",ArriveCasino: "1:45 PM",DepartCasino: "6:45 PM",ReturnTime: "8:55 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                LauRoute.Add(new Routes(   "LB-02",     "Everyday",        "11:30 AM",              "1:45 PM",              "6:45 PM",            "8:55 PM",         "$10",           "$5 player credit or $10 meal credit",               "South Houston",               "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 14,""));

                //db.Route.insert({ Route: "LB-03",Day: "Everyday",Depart: "7:00 PM",ArriveCasino: "9:20 PM",DepartCasino: "3:00 AM",ReturnTime: "5:15 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                LauRoute.Add(new Routes(   "LB-03",     "Everyday",        "7:00 PM",              "9:20 PM",              "3:00 PM",            "5:15 AM",        "$10",             "$5 player credit or $10 meal credit",              "South Houston",               "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 14,""));

                //db.Route.insert({ Route: "LB-04",Day: "Everyday",Depart: "9:00 PM",ArriveCasino: "11:15 PM",DepartCasino: "4:30 AM",ReturnTime: "6:45 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                LauRoute.Add(new Routes(   "LB-04",     "Everyday",        "9:00 PM",              "11:15 PM",              "4:30 AM",            "6:45 AM",         "$10",           "$5 player credit or $10 meal credit", "South Houston", "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 14,""));

                //db.Route.insert({ Route: "LB-05",Day: "Fri,Sat,Sun",Depart: "11:30 PM",ArriveCasino: "1:45 AM",DepartCasino: "7:00 AM",ReturnTime: "9:15 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "South Houston", DescriptionD: "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087"})
                LauRoute.Add(new Routes(   "LB-05",     "Fri,Sat,Sun",        "11:30 PM",              "1:45 AM",              "7:00 AM",             "9:15 AM",      "$10",             "$5 player credit or $10 meal credit",               "South Houston",               "45 South @ Woodridge | Gulfgate Mall | Parking lot behind WENDY's | 2928 Woodridge Dr. Houston, TX 77087", 1, 14,""));


                return LauRoute;
            }
        }


        /// <summary>
        /// East Houston
        /// </summary>
        public static List<Routes> Laub_EastHouston
        {
            get
            {
                var LauRoute = new List<Routes>();
                //db.Route.insert({ Route: "LC-01",Day: "Everyday",Depart: "9:45 AM",ArriveCasino: "11:50 PM",DepartCasino: "5:00 PM",ReturnTime: "7:00 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                LauRoute.Add(new Routes(   "LC-01",     "Everyday",       "9:45 AM",               "11:50 PM",              "5:00 PM",            "7:00 PM",         "$10",           "$5 player credit or $10 meal credit",              "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 12,""));

                //db.Route.insert({ Route: "LC-02",Day: "Everyday",Depart: "11:50 AM",ArriveCasino: "1:45 PM",DepartCasino: "6:45 PM",ReturnTime: "8:40 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                LauRoute.Add(new Routes(   "LC-02",     "Everyday",        "11:50 AM",              "1:45 PM",              "6:45 PM",            "8:40 PM",        "$10",            "$5 player credit or $10 meal credit",               "East Houston",               "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 12,""));

                //db.Route.insert({ Route: "LC-03",Day: "Everyday",Depart: "1:40 PM",ArriveCasino: "3:40 PM",DepartCasino: "8:45 PM",ReturnTime: "10:40 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit",  DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                LauRoute.Add(new Routes(   "LC-03", "    Everyday",        "1:40 PM",              "3:40 PM",              "8:45 PM",            "10:40 PM",        "$10",            "$5 player credit or $10 meal credit",                 "East Houston",              "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 12,""));

                //db.Route.insert({ Route: "LC-04",Day: "Everyday",Depart: "7:20 PM",ArriveCasino: "9:20 PM",DepartCasino: "3:00 AM",ReturnTime: "5:00 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit",  DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                LauRoute.Add(new Routes(   "LC-04",     "Everyday",        "7:20 PM",              "9:20 PM",              "3:00 AM",             "5:00 AM",        "$10", "$5 player credit or $10 meal credit", "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 12,""));

                //db.Route.insert({ Route: "LC-05",Day: "Everyday",Depart: "9:20 PM",ArriveCasino: "11:15 PM",DepartCasino: "4:30 AM",ReturnTime: "6:30 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                LauRoute.Add(new Routes(   "LC-05",     "Everyday",        "9:20 PM",              "11:15 PM",              "4:30 AM",            "6:30 AM",        "$10",            "$5 player credit or $10 meal credit",                "East Houston",               "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 12,""));

                //db.Route.insert({ Route: "LC-06",Day: "Fri,Sat,Sun",Depart: "11:50 PM",ArriveCasino: "1:45 AM",DepartCasino: "7:00 AM",ReturnTime: "9:00 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit",  DescriptionH: "East Houston", DescriptionD: "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015"})
                LauRoute.Add(new Routes(   "LC-06",     "Fri,Sat,Sun",        "11:50 PM",              "1:45 AM",              "7:00 AM",            "9:00 AM",         "$10", "$5 player credit or $10 meal credit", "East Houston", "I-10 East @ Uvalde | Whataburger | 13550 East Freeway Houston, TX 77015", 1, 12,""));


                return LauRoute;
            }
        }


        /// <summary>
        /// Pearland Houston
        /// </summary>
        public static List<Routes> Laub_PearlandHouston
        {
            get
            {
                var LauRoute = new List<Routes>();
                //db.Route.insert({ Route: "LD-01",Day: "Fri,Sat,Sun",Depart: "9:25 AM",ArriveCasino: "11:50 PM",DepartCasino: "5:00 PM",ReturnTime: "7:25 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Pearland Houston", DescriptionD: "Beltway 8 @ Pearland Parkway | Target | 8503 South Sam Houston Pkwy E Houston, TX 77075"})
                LauRoute.Add(new Routes(   "LD-01",     "Fri,Sat,Sun",        "9:25 AM",              "11:50 PM",              "5:00 PM",            "7:25 PM",        "$10",            "$5 player credit or $10 meal credit", "Pearland Houston", "Beltway 8 @ Pearland Parkway | Target | 8503 South Sam Houston Pkwy E Houston, TX 77075", 1, 3,""));

                //db.Route.insert({ Route: "LD-02",Day: "Fri,Sat",Depart: "9:00 PM",ArriveCasino: "11:15 PM",DepartCasino: "4:30 AM",ReturnTime: "6:40 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Pearland Houston", DescriptionD: "Beltway 8 @ Pearland Parkway | Target | 8503 South Sam Houston Pkwy E Houston, TX 77075"})
                LauRoute.Add(new Routes(   "LD-02",     "Fri,Sat",        "9:00 PM",              "11:15 PM",              "4:30 AM",            "6:40 AM",        "$10",            "$5 player credit or $10 meal credit",               "Pearland Houston",               "Beltway 8 @ Pearland Parkway | Target | 8503 South Sam Houston Pkwy E Houston, TX 77075", 1, 3,""));
                
                return LauRoute;
            }
        }

        /// <summary>
        /// Pasadena Houston
        /// </summary>
        public static List<Routes> Laub_PasadenaHouston
        {
            get
            {
                var LauRoute = new List<Routes>();
                //db.Route.insert({ Route: "LE-01",Day: "Fri,Sat,Sun",Depart: "9:40 AM",ArriveCasino: "11:50 AM",DepartCasino: "5:00 PM",ReturnTime: "7:10 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Pasadena", DescriptionD: "Pep Boys | 5445 Fairmond Pkwy Houston, TX 77505"})
                LauRoute.Add(new Routes("LE-01", "Fri,Sat,Sun", "9:40 AM", "11:50 AM", "5:00 PM", "7:10 PM", "$10", "$5 player credit or $10 meal credit", "Pasadena", "Pep Boys | 5445 Fairmond Pkwy Houston, TX 77505", 1, 3,""));


                //db.Route.insert({ Route: "LE-02",Day: "Fri,Sat",Depart: "9:15 PM",ArriveCasino: "11:15 PM",DepartCasino: "4:30 AM",ReturnTime: "6:30 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Pasadena", DescriptionD: "Pep Boys | 5445 Fairmond Pkwy Houston, TX 77505"})
                LauRoute.Add(new Routes(   "LE-02",     "Fri,Sat",        "9:15 PM",              "11:15 PM",              "4:30 AM",            "6:30 AM",        "$10",            "$5 player credit or $10 meal credit",                "Pasadena",               "Pep Boys | 5445 Fairmond Pkwy Houston, TX 77505", 1, 3,""));

                return LauRoute;
            }
        }


        /// <summary>
        /// Northwest Houston
        /// </summary>
        public static List<Routes> Laub_NorthwestHouston
        {
            get
            {
                var LauRoute = new List<Routes>();

                //db.Route.insert({ Route: "LF-01",Day: "Fri,Sat,Sun",Depart: "8:00 AM",ArriveCasino: "11:50 AM",DepartCasino: "5:00 PM",ReturnTime: "8:00 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Northwest Houston", DescriptionD: "290 @ FWY @ Hollister | Whataburger | 13270 Northwest Frwy Houston, TX 77040"})
                LauRoute.Add(new Routes(   "LF-01",     "Fri,Sat,Sun",        "8:00 AM",              "11:50 AM",              "5:00 PM",            "8:00 PM",        "$10",            "$5 player credit or $10 meal credit",               "Northwest Houston", "290 @ FWY @ Hollister | Whataburger | 13270 Northwest Frwy Houston, TX 77040", 1, 3,""));

                //db.Route.insert({ Route: "LF-02",Day: "Fri,Sat",Depart: "7:45 PM",ArriveCasino: "11:15 PM",DepartCasino: "4:30 AM",ReturnTime: "7:30 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Northwest Houston", DescriptionD: "290 @ FWY @ Hollister | Whataburger | 13270 Northwest Frwy Houston, TX 77040"})
                LauRoute.Add(new Routes(   "LF-02",     "Fri,Sat",        "7:45 PM",              "11:15 PM",              "4:30 AM",            "7:30 AM",        "$10",            "$5 player credit or $10 meal credit",               "Northwest Houston",               "290 @ FWY @ Hollister | Whataburger | 13270 Northwest Frwy Houston, TX 77040", 1, 3,""));


                return LauRoute;
            }
        }

        /// <summary>
        /// 45 North Little York, Houston
        /// </summary>
        public static List<Routes> Laub_45NLittleYork
        {
            get
            {
                var LauRoute = new List<Routes>();

                //db.Route.insert({ Route: "LG-01",Day: "Fri,Sat,Sun",Depart: "8:30 AM",ArriveCasino: "11:50 AM",DepartCasino: "5:00 PM",ReturnTime: "7:40 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "45 North Little York", DescriptionD: "Whataburger | 444 W Little York Houston, TX 77076"})
                LauRoute.Add(new Routes(   "LG-01",     "Fri,Sat,Sun",        "8:30 AM",              "11:50 AM",              "5:00 PM",            "7:40 PM",        "$10",            "$5 player credit or $10 meal credit",               "45 North Little York",               "Whataburger | 444 W Little York Houston, TX 77076", 1, 3,""));


                //db.Route.insert({ Route: "LG-02",Day: "Fri,Sat",Depart: "8:20 PM",ArriveCasino: "11:15 PM",DepartCasino: "4:30 AM",ReturnTime: "7:10 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "45 North Little York", DescriptionD: "Whataburger | 444 W Little York Houston, TX 77076"})
                LauRoute.Add(new Routes(   "LG-02",     "Fri,Sat",        "8:20 PM",              "11:15 PM",              "4:30 AM",            "7:10 AM",        "$10",            "$5 player credit or $10 meal credit",               "45 North Little York",                "Whataburger | 444 W Little York Houston, TX 77076", 1, 3,""));


                return LauRoute;
            }
        }

        /// <summary>
        /// Baytown
        /// </summary>
        public static List<Routes> Laub_Baytown
        {
            get
            {
                var LauRoute = new List<Routes>();

                //db.Route.insert({ Route: "LH-01",Day: "Everyday",Depart: "10:00 AM",ArriveCasino: "11:50 AM",DepartCasino: "5:00 PM",ReturnTime: "6:50 PM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Baytown", DescriptionD: "Toys R Us | 4815 I-10 E Freeway"})
                LauRoute.Add(new Routes(   "LH-01",     "Everyday",        "10:00 AM",              "11:50 AM",              "5:00 PM",            "6:50 PM",        "$10",             "$5 player credit or $10 meal credit",              "Baytown",               "Toys R Us | 4815 I-10 E Freeway", 1, 12,""));

                //db.Route.insert({ Route: "LH-02",Day: "Fri,Sat",Depart: "9:45 PM",ArriveCasino: "11:15 PM",DepartCasino: "4:30 AM",ReturnTime: "5:15 AM",YouPay: "$10",YouReceive: "$5 player credit or $10 meal credit", DescriptionH: "Baytown", DescriptionD: "Toys R Us | 4815 I-10 E Freeway"})
                LauRoute.Add(new Routes(   "LH-02",     "Fri,Sat",        "9:45 PM",              "11:15 PM",              "4:30 AM",            "5:15 AM",         "$10",           "$5 player credit or $10 meal credit",               "Baytown",               "Toys R Us | 4815 I-10 E Freeway", 1, 12,""));

                return LauRoute;
            }
        }

     
    }
}