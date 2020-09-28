using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DALEF
{
    public class data
    {
        public bool msg { get; set; }
        public int id { get; set; }
        public string username { get; set; }
    }

    public class InsertData
    {
        public string uname { get; set; }
        public string pass { get; set; }
        public string type { get; set; }
    }

    public class Auth
    {
        ESocietyProjectEntities es = new ESocietyProjectEntities();
        

        public data CheckLogin(InsertData i)
        {
            data d = new data();
            try
            {
                if (string.Equals(i.type,"Admin"))
                {
                    var res = es.AdminRegistrations.Where(x => x.Admin_Name == i.uname && x.Admin_Password == i.pass).SingleOrDefault();
                    if(res == null)
                    {
                        d.msg = false;
                        
                    }
                    else
                    {
                        d.msg = true;
                        d.id = res.Admin_ID;
                        d.username = res.Admin_Name;
                    }
                    return d;
                }
                if (string.Equals(i.type,"User"))
                {
                    var res = es.Owner_Registration.Where(x => x.Owner_UserName == i.uname && x.Owner_Password == i.pass).SingleOrDefault();
                    if (res == null)
                    {
                        d.msg = false;

                    }
                    else
                    {
                        d.msg = true;
                        d.id = res.Owner_ID;
                        d.username = res.Owner_FirstName +" "+res.Owner_Lastname;
                    }
                    return d;
                }
                else
                {
                    d.msg = false;
                    return d;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
