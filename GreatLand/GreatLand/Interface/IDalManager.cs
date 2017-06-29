using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatLand.Models;
using GreatLand.DAL;

namespace GreatLand.Interface
{
    public interface IDalManager
    {

        List<ManagerView> GetManagerRoute();

        List<ManagerView> GetManagerRoute(int id);

    }
}
