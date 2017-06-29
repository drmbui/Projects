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
    public class MainReportModel
    {
        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartSearchDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndSearchDate { get; set; }

        
        public string Reservation_Route { get; set; }
        public string Reservation_NumberofSeats { get; set; }
        public string Reservation_TravelDate { get; set; }
        public string Reservation_FirstName { get; set; }

        public string Reservation_LastName { get; set; }

        public string Reservation_Email { get; set; }

        public string Reservation_Phone { get; set; }

        public string Reservation_Notes { get; set; }

        public string Reservation_CreateDate { get; set; }

        public string Reservation_LastUpdate { get; set; }

        public string Reservation_PersonUpdate { get; set; }

        public string Reservation_Cancel { get; set; }

        public string Reservation_Confirmation { get; set; }

        public string Reservation_Traveler1Name { get; set; }

        public string Reservation_Traveler2Name { get; set; }

        public string Reservation_Traveler3Name { get; set; }

        public string Reservation_Traveler4Name { get; set; }

        public string Reservation_Traveler5Name { get; set; }

        public string Reservation_TravelDisclosure { get; set; }

        public string RoutePickupDay_Route { get; set; }

        public string RoutePickupDay_Active { get; set; }


        public MainReportModel(DateTime StartSearchDate,
            DateTime EndSearchDate,
            string Reservation_Route,
            string Reservation_NumberofSeats,
            string Reservation_TravelDate,
            string Reservation_FirstName,
            string Reservation_LastName,
            string Reservation_Email,
            string Reservation_Phone,
            string Reservation_Notes,
            string Reservation_CreateDate,
            string Reservation_LastUpdate,
            string Reservation_PersonUpdate,
            string Reservation_Cancel,
            string Reservation_Confirmation,
            string Reservation_Traveler1Name,
            string Reservation_Traveler2Name,
            string Reservation_Traveler3Name,
            string Reservation_Traveler4Name,
            string Reservation_Traveler5Name,
            string Reservation_TravelDisclosure,
            string RoutePickupDay_Route,
            string RoutePickupDay_Active)
        {
            this.StartSearchDate = StartSearchDate;
            this.EndSearchDate = EndSearchDate;
            this.Reservation_Route = Reservation_Route;
            this.Reservation_NumberofSeats = Reservation_NumberofSeats;
            this.Reservation_TravelDate = Reservation_TravelDate;
            this.Reservation_FirstName = Reservation_FirstName;

            this.Reservation_LastName = Reservation_LastName;

            this.Reservation_Email = Reservation_Email;

            this.Reservation_Phone = Reservation_Phone;

            this.Reservation_Notes = Reservation_Notes;

            this.Reservation_CreateDate = Reservation_CreateDate;

            this.Reservation_LastUpdate = Reservation_LastUpdate;

            this.Reservation_PersonUpdate = Reservation_PersonUpdate;

            this.Reservation_Cancel = Reservation_Cancel;

            this.Reservation_Confirmation = Reservation_Confirmation;

            this.Reservation_Traveler1Name = Reservation_Traveler1Name;

            this.Reservation_Traveler2Name = Reservation_Traveler2Name;

            this.Reservation_Traveler3Name = Reservation_Traveler3Name;

            this.Reservation_Traveler4Name = Reservation_Traveler4Name;

            this.Reservation_Traveler5Name = Reservation_Traveler5Name;

            this.Reservation_TravelDisclosure = Reservation_TravelDisclosure;

            this.RoutePickupDay_Route = RoutePickupDay_Route;

            this.RoutePickupDay_Active = RoutePickupDay_Active;


        }
    }
}
