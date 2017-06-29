using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatLand.Models;

namespace GreatLand.BusinessLogic
{
    public abstract class BusinessLevel0
    {
        public Boolean IsValidDate(DateTime travelDate)
        {
            if (travelDate < DateTime.Today || travelDate > DateTime.Today.AddDays(7))
            {
                return false;
            }


            return true;
        }

        public Boolean IsValidUser(LoginViewModel model)
        {

            switch (model.Email)
            {
                case "admin@greatlandtours.com":
                    {
                        if (model.Password == "123")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case "tester1@greatlandtours.com":
                    {
                        if (model.Password == "123")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case "tester2@greatlandtours.com":
                    {
                        if (model.Password == "456")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case "tester3@greatlandtours.com":
                    {
                        if (model.Password == "789")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
             


                default:
                    return false;
            }



            return false;
        }

        


    }
}
