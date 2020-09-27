using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Cors;
using EntityLayer;
using DALEF;
using System.Web.Http;

namespace ESocietyWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AvailableSlotsController : ApiController
    {
        AvailableSlotsDALEF a = new AvailableSlotsDALEF();

        [HttpGet]
        public IEnumerable<AvailableSlots> Get()
        {
            return a.GetAvailableSlots();
        }
    }
}
