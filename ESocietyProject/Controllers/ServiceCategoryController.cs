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
    public class ServiceCategoryController : ApiController
    {
        ServiceCategoryDALEF ad = new ServiceCategoryDALEF();
        [HttpGet]
        public IEnumerable<ServiceCategory> Get()
        {
            return ad.GetServiceCategory();
        }
        [HttpGet]

        public ServiceCategory Get(int id)
        {
            return ad.GetByIdServiceCategory(id);
        }

        [HttpPost]
        public bool post([FromBody] ServiceCategory s)
        {
            return ad.PostServiceCategory(s);
        }
        [HttpPut]
        public string put(int id, [FromBody] ServiceCategory s)
        {
            return ad.putServiceCategory(id,s);
        }
    }
}

