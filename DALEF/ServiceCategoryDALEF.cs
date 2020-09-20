using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using IDatabase;

namespace DALEF
{
    public class ServiceCategoryDALEF : IServiceCategory
    {
       
        ESocietyProjectEntities es = new ESocietyProjectEntities();

        public ServiceCategory GetByIdServiceCategory(int id)
        {
            try
            {
                ServiceCategory a = new ServiceCategory();
                var r = es.Service_Category.Where(x => x.Service_Category_ID == id).SingleOrDefault();
                if (r != null)
                {
                    a.Service_Category_ID = r.Service_Category_ID;
                    a.Service_Category = r.Service_Category1;
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


        public IEnumerable<ServiceCategory> GetServiceCategory()
        {
            try
            {
                var res = es.Service_Category.ToList();
                List<ServiceCategory> ad = new List<ServiceCategory>();
                foreach (var r in res)
                {
                    ServiceCategory a = new ServiceCategory();
                    a.Service_Category_ID = r.Service_Category_ID;
                    a.Service_Category = r.Service_Category1;
                    ad.Add(a);
                }
                return ad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool PostServiceCategory(ServiceCategory s)
        {
            try
            {
                Service_Category a = new Service_Category();
                a.Service_Category_ID = s.Service_Category_ID;
                a.Service_Category1 = s.Service_Category;
                var res = es.Service_Category.Add(a);
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


      

        public string putServiceCategory(int id, ServiceCategory s)
        {
            try
            {

                var a = (from ad in es.Service_Category
                         where ad.Service_Category_ID == id
                         select ad).SingleOrDefault();
                if (s == null)
                {
                    return "Invalid Id";
                }
                else
                {
                    a.Service_Category1 = s.Service_Category;

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


