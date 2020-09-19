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
        IEnumerable<NearbyServices> GetNearByServices();
        NearbyServices GetByNearByServiceId(int id);
        bool PostNearByServices(NearbyServices n);
        string PutNearByServices(int id, NearbyServices n);
    }
}
