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
   public class DalDeltaDown: IDalDeltaDown
    {
        /// <summary>
        /// Get DD pickup
        /// </summary>
        /// <param name="LocID"></param>
        /// <returns></returns>
        public List<Routes> GetDeltaDownPickupLocation(int LocID)
        {


            switch (LocID)
            {
                case 1:
                    return LookupData.DeltaDown_SWH;

                case 2:
                    return LookupData.DeltaDown_SH;

                case 3:
                    return LookupData.DeltaDown_EH;

                case 4:
                    return LookupData.DeltaDown_Baytown;

            }

            return LookupData.DeltaDown_SWH;
        }

        /// <summary>
        /// Get DD pickup based on ID
        /// </summary>
        /// <param name="LocID"></param>
        /// <returns></returns>
        public List<Routes> GetDeltaDownPickupLocation(string LocID)
        {


            switch (LocID)
            {
                case "DA":
                    return LookupData.DeltaDown_SWH;

                case "DB":
                    return LookupData.DeltaDown_SH;

                case "DC":
                    return LookupData.DeltaDown_EH;

                case "DD":
                    return LookupData.DeltaDown_Baytown;

            }

            return LookupData.DeltaDown_SWH;
        }
    }
}
