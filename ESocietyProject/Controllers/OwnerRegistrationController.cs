using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityLayer;
using DALEF;
using System.Web.Http.Cors;

namespace ESocietyProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class OwnerRegistrationController : ApiController
    {
        OwnerRegistrationDALEF ef = new OwnerRegistrationDALEF();
        [HttpGet]
        public IEnumerable<OwnerRegistration> Get()
        {
            return ef.GetOwner();
        }

        [HttpGet]
        public OwnerRegistration Get(int id)
        {
            return ef.GetByIdOwnerRegistration(id);
        }
        [HttpPost]
        public bool PostOwnerRegistration(OwnerRegistration o)
        {
            return ef.PostOwnerRegistration(o);
        }
        [HttpPut]
        public string PutOwnerRegistration(int id, OwnerRegistration o)
        {
            return ef.PutOwnerRegistration(id, o);
        }
    }
}


