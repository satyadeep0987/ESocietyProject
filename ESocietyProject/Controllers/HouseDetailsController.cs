using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using EntityLayer;
using DALEF;

namespace ESocietyManagement.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class HouseDetailsController : ApiController
    {
        HouseDALEF hd = new HouseDALEF();

        [HttpGet]
        public IEnumerable<House> Get()
        {
            return hd.GetHouse();
        }

        [HttpGet]

        public House Get(string id)
        {
            return hd.GetByIdHouse(id);
        }

        [HttpPost]
        public bool post(House he)
        {
            return hd.PostHouse(he);
        }

        [HttpPut]
         public string put(string id,House h)
        {
            return hd.PutHouse(id,h);
        }
    }
}
