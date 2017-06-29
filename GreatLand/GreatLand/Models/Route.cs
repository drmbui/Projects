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

    public class Routes
    {

        //[BsonId(IdGenerator = typeof(CombGuidGenerator))]
        public long Id { get; set; }


        //[BsonElement("Route")]
        [Required]
        [Display(Name = "Route")]
        public string Route { get; set; }

        //[BsonElement("Day")]
        [Required]
        public string Day { get; set; }

        //[BsonElement("Depart")]
        [Required]
        public string Depart { get; set; }

        //[BsonElement("ArriveCasino")]
        [Required]
        [Phone]
        [Display(Name = "Arrive Casino")]
        public string ArriveCasino { get; set; }

       // [BsonElement("DepartCasino")]
        [Required]

        public string DepartCasino { get; set; }

       // [BsonElement("ReturnTime")]
        [Required]
        public string ReturnTime { get; set; }

       // [BsonElement("YouPay")]
        public string YouPay { get; set; }

        //[BsonElement("YouReceive")]
        public string YouReceive { get; set; }

       // [BsonElement("DescriptionH")]
        public string DescriptionH { get; set; }

       // [BsonElement("DescriptionD")]
        public string DescriptionD { get; set; }

        public int SelectedParameter { get; set; }

        public int ManagerRouteNumber { get; set; }

        public DateTime Date { get;set; }

        public string ReservRedirectParam { get; set; }
        

        public Routes(string route,
                                string day,
                                string depart,
                                string arriveCasino,
                                string departCasino,
                                string returnTime,
                                string youPay,
                                string youReceive,
                                string descriptionH,
                                string descriptionD,
                                int selectedParameter,
                                int managerRouteNumber,
                                string reservRedirectParam)
        {
            this.Route = route;
            this.Day = day;
            this.Depart = depart;
            this.ArriveCasino = arriveCasino;
            this.DepartCasino = departCasino;
            this.ReturnTime = returnTime;
            this.YouPay = youPay;
            this.YouReceive = youReceive;
            this.DescriptionH = descriptionH;
            this.DescriptionD = descriptionD;
            this.SelectedParameter = selectedParameter;
            this.ManagerRouteNumber = managerRouteNumber;
            this.ReservRedirectParam = reservRedirectParam;
   

        }
    }
}