using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GreatLand.Models;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using SendGrid;

using System.Text;


namespace GreatLand.BusinessLogic
{
    public class BusinessLogic : BusinessLevel0
    {
        private Dal dal = new Dal();

        public new Boolean IsValidDate(DateTime travelDate)
        {
            return base.IsValidDate(travelDate);
        }

        public Boolean IsValidUser(LoginViewModel model)
        {
            return base.IsValidUser(model);
        }


        public void SendMail(string email, string name, string confirmation)
        {

            MailMessage mailMsg = new MailMessage();

            // To
            mailMsg.To.Add(new MailAddress(email, name));

            // From
            mailMsg.From = new MailAddress("info@greatlandtours.com", "GreatLand Tours");

            string subjectMessage = "Reservation confirmation" + " " + confirmation;
            string bodyMessage = "Please click on the following link to confirm this reservation " + " http://greatlandtours.azurewebsites.net/Confirm/Index/" + confirmation;


            // Subject and multipart/alternative Body
            mailMsg.Subject = subjectMessage;
            string text = bodyMessage;
            //string html = @"<p>html body</p>";
            mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(text, null, MediaTypeNames.Text.Plain));
            //mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Html));

            // Init SmtpClient and send
            SmtpClient smtpClient = new SmtpClient("smtp.sendgrid.net", Convert.ToInt32(587));
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("azure_0edd3311eded8b326c58f610fe86a388@azure.com", "March1968!");
            smtpClient.Credentials = credentials;

            smtpClient.Send(mailMsg);

            //// Create the email object first, then add the properties.
            //var myMessage = new SendGridMessage();

            //// Add the message properties.
            //myMessage.From = new MailAddress("dr@mbui.me");

            //// Add multiple addresses to the To field.
            //List<String> recipients = new List<String>
            //{
            //    @"dr@mbui.me"//,
            //    //@"Anna Lidman <anna@example.com>",
            //    //@"Peter Saddow <peter@example.com>"
            //};

            //myMessage.AddTo(recipients);

            //myMessage.Subject = "Testing the SendGrid Library";

            ////Add the HTML and Text bodies
            //myMessage.Html = "<p>Hello World!</p>";
            //myMessage.Text = "Hello World plain text!";

            //// Create credentials, specifying your user name and password.
            //var credentials = new NetworkCredential("azure_0edd3311eded8b326c58f610fe86a388@azure.com", "March1968!");

            //// Create an Web transport for sending email.
            //var transportWeb = new Web(credentials);

            //// Send the email, which returns an awaitable task.
            //transportWeb.DeliverAsync(myMessage);


        }

        public IEnumerable<SevenDays> Get7Days()
        {
            var day = new List<SevenDays>();
            var now = DateTime.Now.ToShortDateString();

            var n = DateTime.Now;
            var f = DateTime.Now.AddHours(12);

            //if now is greater than 12 hours from now
            if (n > f)
            {
                day.Add(new SevenDays(DateTime.Now.ToShortDateString() + " - " + DateTime.Now.DayOfWeek.ToString(), CalculateDayofWeek(DateTime.Now.DayOfWeek.ToString())));
                day.Add(new SevenDays(DateTime.Now.AddDays(1).ToShortDateString() + " - " + DateTime.Now.AddDays(1).DayOfWeek.ToString(), CalculateDayofWeek(DateTime.Now.AddDays(1).DayOfWeek.ToString())));
                day.Add(new SevenDays(DateTime.Now.AddDays(2).ToShortDateString() + " - " + DateTime.Now.AddDays(2).DayOfWeek.ToString(), CalculateDayofWeek(DateTime.Now.AddDays(2).DayOfWeek.ToString())));
                day.Add(new SevenDays(DateTime.Now.AddDays(3).ToShortDateString() + " - " + DateTime.Now.AddDays(3).DayOfWeek.ToString(), CalculateDayofWeek(DateTime.Now.AddDays(3).DayOfWeek.ToString())));
                day.Add(new SevenDays(DateTime.Now.AddDays(4).ToShortDateString() + " - " + DateTime.Now.AddDays(4).DayOfWeek.ToString(), CalculateDayofWeek(DateTime.Now.AddDays(4).DayOfWeek.ToString())));
                day.Add(new SevenDays(DateTime.Now.AddDays(5).ToShortDateString() + " - " + DateTime.Now.AddDays(5).DayOfWeek.ToString(), CalculateDayofWeek(DateTime.Now.AddDays(5).DayOfWeek.ToString())));
                day.Add(new SevenDays(DateTime.Now.AddDays(6).ToShortDateString() + " - " + DateTime.Now.AddDays(6).DayOfWeek.ToString(), CalculateDayofWeek(DateTime.Now.AddDays(6).DayOfWeek.ToString())));

            }
            else
            {
                day.Add(new SevenDays(DateTime.Now.AddDays(1).ToShortDateString() + " - " + DateTime.Now.AddDays(1).DayOfWeek.ToString(), CalculateDayofWeek(DateTime.Now.AddDays(1).DayOfWeek.ToString())));
                day.Add(new SevenDays(DateTime.Now.AddDays(2).ToShortDateString() + " - " + DateTime.Now.AddDays(2).DayOfWeek.ToString(), CalculateDayofWeek(DateTime.Now.AddDays(2).DayOfWeek.ToString())));
                day.Add(new SevenDays(DateTime.Now.AddDays(3).ToShortDateString() + " - " + DateTime.Now.AddDays(3).DayOfWeek.ToString(), CalculateDayofWeek(DateTime.Now.AddDays(3).DayOfWeek.ToString())));
                day.Add(new SevenDays(DateTime.Now.AddDays(4).ToShortDateString() + " - " + DateTime.Now.AddDays(4).DayOfWeek.ToString(), CalculateDayofWeek(DateTime.Now.AddDays(4).DayOfWeek.ToString())));
                day.Add(new SevenDays(DateTime.Now.AddDays(5).ToShortDateString() + " - " + DateTime.Now.AddDays(5).DayOfWeek.ToString(), CalculateDayofWeek(DateTime.Now.AddDays(5).DayOfWeek.ToString())));
                day.Add(new SevenDays(DateTime.Now.AddDays(6).ToShortDateString() + " - " + DateTime.Now.AddDays(6).DayOfWeek.ToString(), CalculateDayofWeek(DateTime.Now.AddDays(6).DayOfWeek.ToString())));
            }


            return day;
        }

        public IEnumerable<Seats> GetSeats()
        {
            var seat = new List<Seats>();
            
            seat.Add(new Seats("1","1"));
            seat.Add(new Seats("2", "2"));
            seat.Add(new Seats("3", "3"));
            seat.Add(new Seats("4", "4"));
            seat.Add(new Seats("5", "5"));
            seat.Add(new Seats("6", "6"));
            //seat.Add(new Seats("7", "7"));
            //seat.Add(new Seats("8", "8"));

            return seat;
        }

        public IEnumerable<BusRouteDepartureToday> GetBusRouteDepartureToday(int day, int casino)
        {
            //var route = new List<BusRouteDepartureToday>();
            //We check on the bus departure per given day

            
            return dal.GetBusRouteByDay(day, casino); ;
        }

        public IEnumerable<BusRouteDepartureToday> GetBusRouteOffice(int casino)
        {
            //var route = new List<BusRouteDepartureToday>();
            //We check on the bus departure per given day


            return dal.GetBusRouteOffice(casino); ;
        }


        public IEnumerable<Routes> GetBusRouteDepartureDetails(int loc, int casino)
        {
            //var route = new List<BusRouteDepartureToday>();
            //We check on the bus departure per given day


            return dal.GetBusRouteDepartureDetailsDB(loc, casino); ;
        }

        public int CalculateDayofWeek(string day)
        {
            int i = 0;
            if (day == "Monday")
            {
                i = 1;
            }
            if (day == "Tuesday")
            {
                i = 2;
            }
            if (day == "Wednesday")
            {
                i = 3;
            }
            if (day == "Thursday")
            {
                i = 4;
            }
            if (day == "Friday")
            {
                i = 5;
            }
            if (day == "Saturday")
            {
                i = 6;
            }
            if (day == "Sunday")
            {
                i = 7;
            }

            return i;
        }

        public DateTime CalculateDayofWeekByNumber(int day)
        {
            //string i = "";
            int daysUntil = 0;
            DateTime today = DateTime.Today;

            if (day == 1)
            {
                //i = "Monday";
                daysUntil = ((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7;
            }
            if (day == 2)
            {
                //i = "Tuesday";
                daysUntil = ((int)DayOfWeek.Tuesday - (int)today.DayOfWeek + 7) % 7;
            }
            if (day == 3)
            {
                //i = "Wednesday";
                daysUntil = ((int)DayOfWeek.Wednesday - (int)today.DayOfWeek + 7) % 7;
            }
            if (day == 4)
            {
               // i = "Thursday";
                daysUntil = ((int)DayOfWeek.Thursday - (int)today.DayOfWeek + 7) % 7;
            }
            if (day == 5)
            {
               // i = "Friday";
                daysUntil = ((int)DayOfWeek.Friday - (int)today.DayOfWeek + 7) % 7;
            }
            if (day == 6)
            {
                //i = "Saturday";
                daysUntil = ((int)DayOfWeek.Saturday- (int)today.DayOfWeek + 7) % 7;
            }
            if (day == 7)
            {
                //i = "Sunday";
                daysUntil = ((int)DayOfWeek.Sunday - (int)today.DayOfWeek + 7) % 7;
            }

            
            
            DateTime next = today.AddDays(daysUntil);

            return next;
        }

    }
}