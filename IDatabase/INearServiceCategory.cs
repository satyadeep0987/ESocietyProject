using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
namespace IDatabase
{
    public interface INearServiceCategory
    {
        IEnumerable<NearbyServicesCategory> GetNearServiceCategory();
        NearbyServicesCategory GetByNearServiceCategoryId(int id);
        bool PostNearServiceCategory(NearbyServicesCategory n);
        string PutNearServiceCategory(int id, NearbyServicesCategory n);
    }
}
