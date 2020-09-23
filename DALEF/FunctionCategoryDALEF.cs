using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using IDatabase;

namespace DALEF
{
    public class FunctionCategoryDALEF : IFunctionCategory
    {
        ESocietyProjectEntities es = new ESocietyProjectEntities();
        public FunctionCategory GetByIdFunctionCategory(int id)
        {
            try
            {
                FunctionCategory fn = new FunctionCategory();
                var r = es.Function_Category.Where(x => x.Function_Category_ID == id).SingleOrDefault();
                fn.Function_Category_ID = r.Function_Category_ID;
                fn.Function_Category = r.Function_Category1;
                return fn;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public IEnumerable<FunctionCategory> GetIFunctionCategory()
        {
            try
            {
                List<FunctionCategory> fc = new List<FunctionCategory>();
                var res = es.Function_Category.ToArray();
                foreach (var r in res)
                {
                    FunctionCategory fn = new FunctionCategory();
                    fn.Function_Category_ID = r.Function_Category_ID;
                    fn.Function_Category = r.Function_Category1;
                    fc.Add(fn);
                }
                return fc;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public bool PostFunctionCategory(FunctionCategory r)
        {

            try
            {
                Function_Category fn = new Function_Category();
               
                fn.Function_Category1 = r.Function_Category;
                es.Function_Category.Add(fn);
                var res = es.SaveChanges();
                if(res > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string PutFunctionCategory(int id, FunctionCategory f)
        {

            try
            {
                var fn = (from fc in es.Function_Category
                          where fc.Function_Category_ID == id
                          select fc).SingleOrDefault();
                if(fn == null)
                {
                    return "Id invalid";
                }
                else
                {
                    fn.Function_Category1 = f.Function_Category;
                    var res = es.SaveChanges();
                    if (res > 0)
                        return "Data Uploaded";
                }
                return "Error In Updating Data";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
