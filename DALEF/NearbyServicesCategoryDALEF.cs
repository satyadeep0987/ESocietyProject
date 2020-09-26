using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using IDatabase;

namespace DALEF
{
    public class NearbyServicesCategoryDALEF : INearServiceCategory
    {
        ESocietyProjectEntities es = new ESocietyProjectEntities();

        public NearbyServicesCategory GetByNearServiceCategoryId(int id)
        {
            try
            {
                NearbyServicesCategory n = new NearbyServicesCategory();

                var r = (from t in es.Nearby_Services_Category
                         where t.Nearby_Services_Category_ID == id
                         select t).SingleOrDefault();

                if (r != null)
                {
                    n.Nearby_Services_Category_ID = r.Nearby_Services_Category_ID;
                    n.Nearby_Services_Category = r.Nearby_Services_Category1;
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

      

        public IEnumerable<NearbyServicesCategory> GetNearServiceCategory()
        {
            try
            {
                var res = es.Nearby_Services_Category.ToList();

                List<NearbyServicesCategory> nsc = new List<NearbyServicesCategory>();

                foreach (var r in res)
                {
                    NearbyServicesCategory n = new NearbyServicesCategory();

                    n.Nearby_Services_Category_ID = r.Nearby_Services_Category_ID;
                    n.Nearby_Services_Category = r.Nearby_Services_Category1;

                    nsc.Add(n);
                }
                return nsc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
     

        public bool PostNearServiceCategory(NearbyServicesCategory n)
        {
            try
            {
                Nearby_Services_Category nsc = new Nearby_Services_Category();

              
                nsc.Nearby_Services_Category1 = n.Nearby_Services_Category;

                es.Nearby_Services_Category.Add(nsc);
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

       

        public string PutNearServiceCategory(int id, NearbyServicesCategory nc)
        {
            try
            {
                var nsc = (from t in es.Nearby_Services_Category
                           where t.Nearby_Services_Category_ID == id
                           select t).SingleOrDefault();

                if (nsc == null)
                {
                    return "Invalid ID";

                }
                else
                {
                  
                    nsc.Nearby_Services_Category1 = nc.Nearby_Services_Category;

                    var res = es.SaveChanges();
                    if (res > 0)
                        return "Data Updated Successfully";
                    else
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

