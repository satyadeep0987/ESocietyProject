using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using DALEF;
using EntityLayer;

namespace ESocietyWebAPI.Controllers
{
    [EnableCors(origins: "*", methods: "*", headers: "*")]

    public class NearbyServicesController : ApiController
    {
        NearbyServicesDALEF ns = new NearbyServicesDALEF();

        public IEnumerable<NearbyServices> Get()
        {
            return ns.GetServices();
        }

        public NearbyServices Get(int id)
        {
            return ns.GetByServiceId(id);
        }

        public bool Post([FromBody] NearbyServices n)
        {
            return ns.PostServices(n);
        }

        public string Put(int id, [FromBody] NearbyServices n)
        {
            return ns.PutServices(id, n);
        }
    }
}
