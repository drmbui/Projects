using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreatLand;
using GreatLand.Models;

using System.Threading;
using System.Threading.Tasks;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace GreatLand.Controllers
{
    public class BaseController : Controller
    {
        private Dal dal = new Dal();
        private bool disposed = false;
        private BusinessLogic.BusinessLogic logic = new BusinessLogic.BusinessLogic();

      

     
    }
}
