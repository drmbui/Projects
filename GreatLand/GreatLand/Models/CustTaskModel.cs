using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GreatLand.Models
{
    public class CustTaskModelBson
    {

        public long Id { get; set; }
    
        //[Required(ErrorMessage = "Please choose a Route")]
        [Display(Name ="Route")]
        public string Route { get; set; }


        [Required(ErrorMessage = "Required")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Required")]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Required")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

      
        [Required]
        [Display(Name = "Passenger Count")]
        public int SeatsNumber { get; set; }


        [Required(ErrorMessage = "Please choose the travel date")]
        [Display(Name = "Travel Date")]
        [DataType(DataType.Date)]
        [DateRange(ErrorMessage = "Must be within 7 days")]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }


        public DateTime CreatedDate { get; set; }


        public DateTime UpDate { get; set; }

       
        public string PersonUpdate { get; set; }


        public string Notes { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public long Confirmation { get; set; }

        [Required]
        [Display(Name = "Traveler 1")]
        public string Traveler1Name { get; set; }

        [Display(Name = "Traveler 2")]
        public string Traveler2Name { get; set; }

        [Display(Name = "Traveler 3")]
        public string Traveler3Name { get; set; }

        [Display(Name = "Traveler 4")]
        public string Traveler4Name { get; set; }

        [Display(Name = "Traveler 5")]
        public string Traveler5Name { get; set; }

        [Display(Name = "Traveler 6")]
        public string Traveler6Name { get; set; }

        [Display(Name = "Travel Disclosure")]
        public string TravelDisclosure { get; set; }

        public int Casino { get; set; }

    }
    public class CustTaskModel
    {


        public long Id { get; set; }


        [Required]
        [Display(Name = "Route")]
        public string Route { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required]
        public string FirstName { get; set; }


        [Required]
        public string Email { get; set; }


        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

 
        [Required]

        public int SeatsNumber { get; set; }


        [Display(Name = "Travel Date")]
        [DateRange(ErrorMessage = "Must be within 5 days")]
        [Required]
        public DateTime Date { get; set; }


        public DateTime CreatedDate { get; set; }


        public DateTime UpDate { get; set; }

        //[Required]
        public string PersonUpdate { get; set; }

      
        public string Notes { get; set; }

        public long Confirmation { get; set; }

        [Display(Name = "Traveler 1")]
        public string Traveler1Name { get; set; }

        [Display(Name = "Traveler 2")]
        public string Traveler2Name { get; set; }

        [Display(Name = "Traveler 3")]
        public string Traveler3Name { get; set; }

        [Display(Name = "Traveler 4")]
        public string Traveler4Name { get; set; }

        [Display(Name = "Traveler 5")]
        public string Traveler5Name { get; set; }

        [Display(Name = "Traveler 6")]
        public string Traveler6Name { get; set; }

        [Display(Name = "Travel Disclosure")]
        public string TravelDisclosure { get; set; }

        public CustTaskModel(string route,
                            string lastName,
                                string firstName,
                                string email,
                                string phone,
                                int seatsNumber,
                                DateTime date,
                                DateTime createdDate,
                                DateTime upDate,
                                string personUpdate,
                                string notes,
                                long confirmation,
                                string traveler1Name,
                                string traveler2Name,
                                string traveler3Name,
                                string traveler4Name,
                                string traveler5Name,
                                string traveler6Name,
                                string travelDisclosure)
        {
            this.Route = route;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Email = email;
            this.Phone = phone;
            this.SeatsNumber = seatsNumber;
            this.Date = date;
            this.CreatedDate = createdDate;
            this.UpDate = upDate;
            this.PersonUpdate = personUpdate;
            this.Notes = notes;
            this.Confirmation = confirmation;
            this.Traveler1Name = traveler1Name;
            this.Traveler2Name = traveler2Name;
            this.Traveler3Name = traveler3Name;
            this.Traveler4Name = traveler4Name;
            this.Traveler5Name = traveler5Name;
            this.Traveler6Name = traveler6Name;
            this.TravelDisclosure = travelDisclosure;
        }
    }

    public class DateRangeAttribute: ValidationAttribute
    {
 
        public override bool IsValid(object value)
        {
            DateTime date = DateTime.Parse(Convert.ToString(value));
            if (date >= DateTime.Today && date <= DateTime.Today.AddDays(7))
            {
                return true;
               
            }

            return false;
        }

       
    }

}