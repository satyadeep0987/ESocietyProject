using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityLayer;
using DALEF;
using System.Web.Http.Cors;

namespace ESocietyWebAPI.Controllers
{
    [EnableCors(origins: "*", methods: "*", headers: "*")]

    public class NearbyServicesCategoryController : ApiController
    {
        NearbyServicesCategoryDALEF nsc = new NearbyServicesCategoryDALEF();

        public IEnumerable<NearbyServicesCategory> Get()
        {
            return nsc.GetNearServiceCategory();
        }

        public NearbyServicesCategory Get(int id)
        {
            return nsc.GetByNearServiceCategoryId(id);
        }

        public bool Post([FromBody] NearbyServicesCategory n)
        {
            return nsc.PostNearServiceCategory(n);
        }

        public string Put([FromBody] NearbyServicesCategory n, int id)
        {
            return nsc.PutNearServiceCategory(id, n);
        }
    }
}
