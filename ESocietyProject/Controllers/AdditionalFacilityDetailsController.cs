using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using EntityLayer;
using DALEF;


namespace ESocietyProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AdditionalFacilityDetailsController : ApiController
    {
        AdditionalFacilityDetailsDALEF ad = new AdditionalFacilityDetailsDALEF();
        [HttpGet]
        public IEnumerable<AdditionalFacilityDetails> Get()
        {
            return ad.GetAdditionalFacilityDetails();
        }
        [HttpGet]
        public AdditionalFacilityDetails Get(int id)
        {
            return ad.GetByIdAdditionalFacilityDetails(id);
        }
        [HttpPost]
        public bool Post([FromBody]AdditionalFacilityDetails data)
        {
            return ad.PostAdditionalFacilityDetails(data);
        }
       [HttpPut]
       public string Put(int id,AdditionalFacilityDetails data)
        {
            return ad.PutAdditionalFacilityDetails(data, id);
        }
    }
}
