
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using IDatabase;

namespace DALEF
{
    public class SocietyDALEF : ISociety
    {
        ESocietyProjectEntities es = new ESocietyProjectEntities();
        public IEnumerable<Society> GetAllSociety()
        {
            try
            {
                var res = es.Society_Details.ToList();
                List<Society> sd = new List<Society>();
                foreach(var r in res)
                {
                    Society s = new Society();
                    s.Society_ID = r.Society_ID;
                    s.Society_Name = r.Society_Name;
                    s.Society_City = r.Society_City;
                    s.Society_Pincode = r.Society_Pincode;
                    s.Society_NoOffHouse = r.Society_NoOffHouse;

                    sd.Add(s);
                }
                return sd;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Society GetByIdSociety(string id)
        {
            try
            {
                Society s = new Society();
                var r = es.Society_Details.Where(x => x.Society_ID == id).SingleOrDefault();
                if (r != null)
                {
                    s.Society_ID = r.Society_ID;
                    s.Society_Name = r.Society_Name;
                    s.Society_City = r.Society_City;
                    s.Society_Pincode = r.Society_Pincode;
                    s.Society_NoOffHouse = r.Society_NoOffHouse;
                }
                else
                {
                    throw new Exception("invalid id");
                }

                return s;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PostSociety(Society s)
        {
            try
            {
                Society_Details sd = new Society_Details();
                sd.Society_ID = s.Society_ID;
                sd.Society_Name = s.Society_Name;
                sd.Society_City = s.Society_City;
                sd.Society_Pincode = s.Society_Pincode;
                sd.Society_NoOffHouse = s.Society_NoOffHouse;
                 es.Society_Details.Add(sd);
                var res = es.SaveChanges();
                if (res>0)
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

        public string PutSociety(string id, Society s)
        {

            try
            {
                var a = (from sd in es.Society_Details where sd.Society_ID == id select sd).SingleOrDefault();
                if(a==null)
                {
                    return "Invalid id";
                }
                else
                {

                    a.Society_Name = s.Society_Name;
                    a.Society_City = s.Society_City;
                    a.Society_Pincode = s.Society_Pincode;
                    a.Society_NoOffHouse = s.Society_NoOffHouse;

                    var res = es.SaveChanges();
                    if(res>0)
                    {
                        return "Data Updated";
                    }
                }
                return "Error in data Updating";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
