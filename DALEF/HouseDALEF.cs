using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using IDatabase;

namespace DALEF
{
    public class HouseDALEF : IHouse
    {
        ESocietyProjectEntities es = new ESocietyProjectEntities();
        public House GetByIdHouse(string id)
        {
            try
            {
                House a = new House();
                var r = es.House_Details.Where(x => x.House_ID == id).SingleOrDefault();
                if (r != null)
                {
                    a.House_ID = r.House_ID;
                    a.House_Size_BHK = r.House_Size_BHK;
                    a.House_Type = r.House_Type;
                }
                else
                {
                    throw new Exception("invalid Id");
                }
                return a;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    public IEnumerable<House> GetHouse()
        {
            try
            {
                var res = es.House_Details.ToList();
                List<House> ad = new List<House>();
                foreach (var r in res)
                {
                    House a = new House();
                    a.House_ID = r.House_ID;
                    a.House_Size_BHK = r.House_Size_BHK;
                    a.House_Type = r.House_Type;
     
                    ad.Add(a);
                }
                return ad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    

        public bool PostHouse(House h)
        {
            try
            {
                House_Details a = new House_Details();
                a.House_ID = h.House_ID;
                a.House_Size_BHK = h.House_Size_BHK;
                a.House_Type = h.House_Type;
                   es.House_Details.Add(a);
                    var res = es.SaveChanges();
                if (res > 0)
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


        public string PutHouse(string id, House h)
        {
            try
            {

                var a = (from hs in es.House_Details
                         where hs.House_ID == id
                         select hs).SingleOrDefault();
                if (a == null)
                {
                    return "Invalid Id";
                }
                else
                {
                    a.House_Size_BHK = h.House_Size_BHK;
                    a.House_Type = h.House_Type;
  
                    var res = es.SaveChanges();
                    if (res > 0)
                    {
                        return "Data Uploaded";
                    }
                }
                return "Error In data Updating";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    }

