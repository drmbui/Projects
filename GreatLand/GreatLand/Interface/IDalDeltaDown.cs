using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatLand.Models;

namespace GreatLand.Interface
{
    public interface IDalDeltaDown
    {

        List<Routes> GetDeltaDownPickupLocation(int LocID);

        List<Routes> GetDeltaDownPickupLocation(string LocID);
    }
}
