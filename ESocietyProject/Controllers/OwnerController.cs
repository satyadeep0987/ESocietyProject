using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ESocietyProject.Models;
using System.Web.Http.Cors;


namespace ESocietyProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class OwnerController : ApiController
    {
        ESocietyProjectEntities Es = new ESocietyProjectEntities();

        [HttpGet]
        public IEnumerable<CustomOwner> get()
        {
            List<CustomOwner> owner = new List<CustomOwner>();
            var result = Es.OwnerRegistrations.ToList();
            //[[1,sdfhsof,sdfflihsd.sdfsdkf.sfvs,sdjs],[2,fcjsjlslc,dsjfs]]
            foreach(var r in result)
            {
                CustomOwner c = new CustomOwner();
                c.Owner_ID = r.Owner_ID;
                c.Owner_FirstName = r.Owner_FirstName;
                c.Owner_Lastname = r.Owner_Lastname;
                c.Owner_UserName = r.Owner_UserName;
                c.Owner_Password = r.Owner_Password;
                c.Owener_Email = r.Owener_Email;
                c.House_ID = r.House_ID;
                c.Society_Name = r.Society.Society_Name;
                c.Owner_IDPROOF = r.Owner_IDPROOF;
                c.Owner_Contact = r.Owner_Contact;
                c.Owner_Occupation = r.Owner_Occupation;
                c.Owner_NumberOfFamily = r.Owner_NumberOfFamily;


                owner.Add(c);
            }
            return owner;
        }

    }
}
