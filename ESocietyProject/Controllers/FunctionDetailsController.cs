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
    public class FunctionDetailsController : ApiController
    {
        FunctionDetailsDALEF fn = new FunctionDetailsDALEF();
        [HttpGet]
        public IEnumerable<FunctionDetails> Get()
        {
            return fn.GetFunctionDetails();
        }

        [HttpGet]
        public FunctionDetails Get(int id)
        {
            return fn.GetFunctionDetails(id);
        }

        [HttpPut]
        public string Put(int id,FunctionDetails fs)
        {
            return fn.PutFunctionDetails(fs, id);
        }

        [HttpPost]
        public bool Post(FunctionDetails fs)
        {
            return fn.PostFunctionDetails(fs);
        }
    }
}
