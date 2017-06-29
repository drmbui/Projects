using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatLand.Models;
using GreatLand.DAL;

namespace GreatLand.Interface
{
    public interface IDalLauberge
    {
        List<Routes> GetLaubergePickupLocation(int LocID);
        //List<Routes> GetLaubergePickupLocation(string LocID);

        List<Routes> GetLaubergePickupLocationDB(string route);
    }
}
