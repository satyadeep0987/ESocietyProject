using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using IDatabase;

namespace DALEF
{
    public class NearbyServicesDALEF : INearByServices
    {
        ESocietyProjectEntities es = new ESocietyProjectEntities();
        public NearbyServices GetByServiceId(int id)
        {
            try
            {
                NearbyServices n = new NearbyServices();

                var r = es.Nearby_Services.Where(i => i.Nearby_Services_ID == id).SingleOrDefault();

                if (r != null)
                {
                    n.Nearby_Services_ID = r.Nearby_Services_ID;
                    n.Nearby_Services_Category_ID = (int)r.Nearby_Services_Category_ID;
                    n.Nearby_Services_Name = r.Nearby_Services_Name;
                    n.Nearby_Services_Contact = r.Nearby_Services_Contact;
                    n.Nearby_Services_Address = r.Nearby_Services_Address;
                    n.Nearby_Services_Distance = (decimal)r.Nearby_Services_Distance;
                    n.Nearby_Services_Details = r.Nearby_Services_Details;
                }
                else
                {
                    throw new Exception("Invalid ID");
                }

                return n;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<NearbyServices> GetServices()
        {
            try
            {
                var res = es.Nearby_Services.ToList();

                List<NearbyServices> ns = new List<NearbyServices>();

                foreach (var r in res)
                {
                    NearbyServices n = new NearbyServices();

                    n.Nearby_Services_ID = r.Nearby_Services_ID;
                    n.Nearby_Services_Category_ID = (int)r.Nearby_Services_Category_ID;
                    n.Nearby_Services_Name = r.Nearby_Services_Name;
                    n.Nearby_Services_Contact = r.Nearby_Services_Contact;
                    n.Nearby_Services_Address = r.Nearby_Services_Address;
                    n.Nearby_Services_Distance = (decimal)r.Nearby_Services_Distance; 
                    n.Nearby_Services_Details = r.Nearby_Services_Details;

                    ns.Add(n);
                }
                return ns;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PostServices(NearbyServices ns)
        {
            try
            {
                Nearby_Services n = new Nearby_Services();

                n.Nearby_Services_ID = ns.Nearby_Services_ID;
                n.Nearby_Services_Category_ID = ns.Nearby_Services_Category_ID;
                n.Nearby_Services_Name = ns.Nearby_Services_Name;
                n.Nearby_Services_Contact = ns.Nearby_Services_Contact;
                n.Nearby_Services_Address = ns.Nearby_Services_Address;
                n.Nearby_Services_Distance = (float)ns.Nearby_Services_Distance;
                n.Nearby_Services_Details = ns.Nearby_Services_Details;

                var res = es.Nearby_Services.Add(n);

                if (res != null)
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

        public string PutServices(int id, NearbyServices ns)
        {
            try
            {
                var n = (from t in es.Nearby_Services
                         where t.Nearby_Services_ID == id
                         select t).SingleOrDefault();

                if (ns == null)
                {
                    return "Invalid ID";
                }
                else
                {
                    n.Nearby_Services_ID = ns.Nearby_Services_ID;
                    n.Nearby_Services_Category_ID = ns.Nearby_Services_Category_ID;
                    n.Nearby_Services_Name = ns.Nearby_Services_Name;
                    n.Nearby_Services_Contact = ns.Nearby_Services_Contact;
                    n.Nearby_Services_Address = ns.Nearby_Services_Address;
                    n.Nearby_Services_Distance = (float)ns.Nearby_Services_Distance;
                    n.Nearby_Services_Details = ns.Nearby_Services_Details;

                    var res = es.SaveChanges();
                    if (res > 0)
                    {
                        return "Data Updated Successfully";
                    }
                    return "Error in updation";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
