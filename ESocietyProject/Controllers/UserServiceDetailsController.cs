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
    public class UserServiceDetailsController : ApiController
    {
        UserServiceDetailsDALEF us = new UserServiceDetailsDALEF();
        [HttpGet]
        public IEnumerable<UserServiceDetails> Get()
        {
            return us.GetAllUserServiceDetails();
        }
        [HttpGet]
        public UserServiceDetails Get(int id)
        {
            return us.GetByIdUserServiceDetails(id);
        }
        [HttpPost]
        public bool post([FromBody]UserServiceDetails u)
        {
            return us.PostUserServiceDetails(u);
        }
        [HttpPut]
        public string put(int id, [FromBody]UserServiceDetails u)
        {
            return us.PutUserServiceDetails(id, u);
        }
    }
}
