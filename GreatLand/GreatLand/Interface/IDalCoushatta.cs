using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatLand.Models;

namespace GreatLand.Interface
{
    public interface IDalCoushatta
    {
        List<Routes> GetCoushataPickupLocation(string LocID);

        List<Routes> GetCoushataPickupLocation(int LocID);
    }
}
