using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
namespace IDatabase
{
    public interface IServiceCategory
    {
        IEnumerable<ServiceCategory> GetServiceCategory();



        ServiceCategory GetByIdServiceCategory(int id);



        bool PostServiceCategory(ServiceCategory s);



        string putServiceCategory(int id, ServiceCategory s);
    }
}
