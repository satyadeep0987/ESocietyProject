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

    public class GuardDutyController : ApiController
    {
        GuardDutyDALEF gd = new GuardDutyDALEF();

        [HttpGet]
        public IEnumerable<GuardDuty> Get()
        {
            return gd.GetGuardDuty();
        }

        [HttpGet]
        public GuardDuty Get(int id)
        {
            return gd.GetByIdVistor(id);
        }

        [HttpPost]
        public bool Post([FromBody] GuardDuty g)
        {
            return gd.PostGuardDuty(g);
        }

        [HttpPut]
        public string Put(int id,[FromBody] GuardDuty g)
        {
            return gd.PutGuardDuty(id, g); 
        }
    }
}
