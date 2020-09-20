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
    public class FunctionCategoryController : ApiController
    {
        FunctionCategoryDALEF fc = new FunctionCategoryDALEF();

        [HttpGet]
        public IEnumerable<FunctionCategory> Get()
        {
            return fc.GetIFunctionCategory();
        }

        [HttpGet]
        public FunctionCategory Get(int id)
        {
            return fc.GetByIdFunctionCategory(id);
        }

        [HttpPost]
        public bool post([FromBody]FunctionCategory fd)
        {
            return fc.PostFunctionCategory(fd);
        }

        [HttpPut]
        public string put(int id,FunctionCategory fd)
        {
            return fc.PutFunctionCategory(id, fd);
        }


    }
}
