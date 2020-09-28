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
    public class AuthController : ApiController
    {
        Auth a = new Auth();
        [HttpPost]
        public data AuthCheck([FromBody]InsertData d)
        {
            return a.CheckLogin(d);
        }
    }
}
