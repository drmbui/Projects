using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace GreatLand.Models
{
 
    public class ManagerView
    {

        public long Id { get; set; }

        [Required]
        public string Casino { get; set; }

        [Required]
        public string Route { get; set; }

        [Required]
        public string DepartTime { get; set; }

        [Required]
        public string DayOfTheWeek { get; set; }

        [Required]
        public string PickUpLocations { get; set; }

        [Required]
        public int RouteNumber { get; set; }
        
        [Required]
        public Boolean Active { get; set; }

 

   
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartVoidDate { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndVoidDate { get; set; }

        public ManagerView( string id,
                            string casino,
                         string route,
                         string departTime,
                         string dayOfTheWeek,
                         string pickUpLocations,
                         int routeNumber,
                         string active,
                         string startVoidDate,
                         string endVoidDate)
        {
            this.Id = Convert.ToInt64(id);
            this.Casino = casino;
            this.Route = route;
            this.DepartTime = departTime;
            this.DayOfTheWeek = dayOfTheWeek;
            this.PickUpLocations = pickUpLocations;
            this.RouteNumber = routeNumber;
            this.Active = Convert.ToBoolean(active);
            this.StartVoidDate = Convert.ToDateTime(startVoidDate);
            this.EndVoidDate = Convert.ToDateTime(endVoidDate);


        }
    }
}
