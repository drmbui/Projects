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
    public class DalCoushatta: IDalCoushatta
    {

        /// <summary>
        /// Get Coushatta pickup
        /// </summary>
        /// <param name="LocID"></param>
        /// <returns></returns>
        public List<Routes> GetCoushataPickupLocation(int LocID)
        {
            switch (LocID)
            {
                case 1:

                    return LookupData.Coushata_SWH;

                case 2:
                    
                    return LookupData.Coushata_SH;

                case 3:
                    return LookupData.Coushata_NWH;                    

                case 4:
                    return LookupData.Coushata_EastHouston;

                case 5:
                    return LookupData.Coushata_45North;

                case 6:

                    return LookupData.Coushata_Baytown;

                case 7:
                    return LookupData.Coushata_Beaumont;

              
                    
            }

            return LookupData.Coushata_SWH;
        }
        /// <summary>
        /// Get Coushata pickup based on ID
        /// </summary>
        /// <param name="LocID"></param>
        /// <returns></returns>
        public List<Routes> GetCoushataPickupLocation(string LocID)
        {


            switch (LocID)
            {
                case "CA":
                    return LookupData.Coushata_SH;

                case "CB":
                    return LookupData.Coushata_SWH;

                case "CC":
                    return LookupData.Coushata_NWH;

                case "CD":
                    return LookupData.Coushata_45North;

                case "CE":
                    return LookupData.Coushata_EastHouston;

                case "CF":
                    return LookupData.Coushata_Baytown;

                case "CG":
                    return LookupData.Coushata_Beaumont;



            }

            return LookupData.Coushata_SWH;
        }
    }
}
