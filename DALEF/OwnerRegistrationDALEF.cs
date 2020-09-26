using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using IDatabase;
using System.Web.Security;

namespace DALEF
{
    public class OwnerRegistrationDALEF : IOwnerRegistration
    {
        ESocietyProjectEntities es = new ESocietyProjectEntities();
       
        public IEnumerable<OwnerRegistration> GetOwner()
        {
            try
            {
                var res = es.Owner_Registration.ToList();
                List<OwnerRegistration> ad = new List<OwnerRegistration>();
                foreach (var r in res)
                {
                    OwnerRegistration a = new OwnerRegistration();
                    a.Owner_ID = r.Owner_ID;
                    a.Owner_UserName = r.Owner_UserName;
                    a.Owner_Password = r.Owner_Password;
                    a.Owener_Email = r.Owener_Email;
                    a.House_ID = r.House_ID;
                    a.Society_ID = r.Society_ID;
                    a.Owner_FirstName = r.Owner_FirstName;
                    a.Owner_Lastname = r.Owner_Lastname;
                    a.Owner_IDPROOF = r.Owner_IDPROOF;
                    a.Owner_Contact = r.Owner_Contact;
                    a.Owner_Occupation = r.Owner_Occupation;
                    a.Owner_NumberOfFamily =Convert.ToInt32(r.Owner_NumberOfFamily);



                    ad.Add(a);
                }
                return (ad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public OwnerRegistration GetByIdOwnerRegistration(int id)
        {
            try
            {
                OwnerRegistration a = new OwnerRegistration();
                var r = es.Owner_Registration.Where(x => x.Owner_ID == id).SingleOrDefault();
                if (r != null)
                {

                    a.Owner_ID = r.Owner_ID;
                    a.Owner_UserName = r.Owner_UserName;
                    a.Owner_Password = r.Owner_Password;
                    a.Owener_Email = r.Owener_Email;
                    a.House_ID = r.House_ID;
                    a.Society_ID = r.Society_ID;
                    a.Owner_FirstName = r.Owner_FirstName;
                    a.Owner_Lastname = r.Owner_Lastname;
                    a.Owner_IDPROOF = r.Owner_IDPROOF;
                    a.Owner_Contact =r.Owner_Contact;
                    a.Owner_Occupation = r.Owner_Occupation;
                    a.Owner_NumberOfFamily =Convert.ToInt32(r.Owner_NumberOfFamily);
                   
                }
                else
                {
                    throw new Exception("INVALID ID");
                }
                return a;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PostOwnerRegistration(OwnerRegistration o)
        {
            try
            {
                Owner_Registration a = new Owner_Registration();

                string s = Membership.GeneratePassword(8, 2).ToString();
                a.Owner_UserName = o.Owner_UserName;
                a.Owner_Password = s;
                a.Owener_Email = o.Owener_Email;
                a.House_ID = o.House_ID;
                a.Society_ID = o.Society_ID;
                a.Owner_FirstName = o.Owner_FirstName;
                a.Owner_Lastname = o.Owner_Lastname;
                a.Owner_IDPROOF = o.Owner_IDPROOF;
                a.Owner_Contact = o.Owner_Contact;
                a.Owner_Occupation = o.Owner_Occupation;
                a.Owner_NumberOfFamily = o.Owner_NumberOfFamily;
                es.Owner_Registration.Add(a);
                var res = es.SaveChanges();
                if (res >0)
                {
                    return true;
                }
                return false;



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string PutOwnerRegistration(int id, OwnerRegistration o)
        {
            try
            {

                var a = (from ad in es.Owner_Registration
                         where ad.Owner_ID == id
                         select ad).SingleOrDefault();
                if (a == null)
                {
                    return "INVALID ID";
                }
                else
                {
                 
                    a.Owner_UserName = o.Owner_UserName;
                    a.Owner_Password = o.Owner_Password;
                    a.Owener_Email = o.Owener_Email;
                    a.House_ID = o.House_ID;
                    a.Society_ID = o.Society_ID;
                    a.Owner_FirstName = o.Owner_FirstName;
                    a.Owner_Lastname = o.Owner_Lastname;
                    a.Owner_IDPROOF = o.Owner_IDPROOF;
                    a.Owner_Contact = o.Owner_Contact;
                    a.Owner_Occupation = o.Owner_Occupation;
                    a.Owner_NumberOfFamily =o.Owner_NumberOfFamily;



                    var res = es.SaveChanges();
                    if (res > 0)
                    {
                        return "DATA UPDATED SUCESSFULLY";
                    }
                }
                return "ERROR IN UPDATING";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
