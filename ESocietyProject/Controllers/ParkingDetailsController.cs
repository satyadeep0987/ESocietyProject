using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityLayer;
using DALEF;
using System.Web.Http.Cors;

namespace ESocietyManagement.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ParkingDetailsController : ApiController
    {
        ParkingDetailsDALEF ef = new ParkingDetailsDALEF();
        [HttpGet]
        public IEnumerable<ParkingDetails> Get()
        {
            return ef.GetParking();
        }

        [HttpGet]
        public ParkingDetails Get(int id)
        {
            return ef.GetByParkingId(id);
        }
        [HttpPost]
        public bool Post([FromBody] ParkingDetails pd)
        {
            return ef.PostParking(pd);
        }
        [HttpPut]
        public string Put(int id, [FromBody] ParkingDetails pd)
        {
            return ef.PutParking(id, pd);
        }
    }
}