using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace IDatabase
{
    public interface INearByServices
    {
        IEnumerable<NearbyServices> GetServices();
        NearbyServices GetByServiceId(int id);
        bool PostServices(NearbyServices n);
        string PutServices(int id, NearbyServices n);
    }
}
