using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GreatLand.Models;

namespace GreatLand.DAL
{
    public class Users
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public Users(string email,
                    string password)
        {
            this.Email = email;
            this.Password = password;
        }

        public List<Users> GreateLandEmployees
        {
            get
            {
                var empl = new List<Users>();


                empl.Add(new Users("dr@mbui.me","123"));
                empl.Add(new Users("jane@mbui.me", "123"));

            
                return empl;
            }
        }
    }

}