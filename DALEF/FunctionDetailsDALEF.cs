using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using IDatabase;

namespace DALEF
{
    public class FunctionDetailsDALEF : IFunctionDetails
    {
        ESocietyProjectEntities es = new ESocietyProjectEntities();
        public IEnumerable<FunctionDetails> GetFunctionDetails()
        {
            try
            {
                List<FunctionDetails> fn = new List<FunctionDetails>();
                var res = es.Function_Details.ToList();
                foreach (var r in res)
                {
                    FunctionDetails fs = new FunctionDetails();
                    fs.Function_ID = r.Function_ID;
                    fs.Function_Category_ID = r.Function_Category_ID;
                    fs.Owner_ID = r.Owner_ID;
                    fs.Function_Date = r.Function_Date;
                    fs.Function_Details = r.Function_Details1;
                    fs.Function_Time = r.Function_Time;
                    fs.Function_Duration = r.Function_Duration;
                    fs.Function_Status = r.Function_Status;
                    fn.Add(fs);

                }
                return fn;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public FunctionDetails GetFunctionDetails(int id)
        {
            try
            {
                var r = es.Function_Details.Where(x => x.Function_ID == id).SingleOrDefault();
                FunctionDetails fs = new FunctionDetails();
                if(r != null)
                {
                    fs.Function_ID = r.Function_ID;
                    fs.Function_Category_ID = r.Function_Category_ID;
                    fs.Owner_ID = r.Owner_ID;
                    fs.Function_Date = r.Function_Date;
                    fs.Function_Details = r.Function_Details1;
                    fs.Function_Time = r.Function_Time;
                    fs.Function_Duration = r.Function_Duration;
                    fs.Function_Status = r.Function_Status;
                }
                else
                {
                    throw new Exception("Invalid Id");
                }
               

                return fs;
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool PostFunctionDetails(FunctionDetails r)
        {
            try
            {
                Function_Details fs = new Function_Details();

                fs.Function_Category_ID = r.Function_Category_ID;
                fs.Owner_ID = r.Owner_ID;
                fs.Function_Date = r.Function_Date;
                fs.Function_Details1 = r.Function_Details;
                fs.Function_Time = r.Function_Time;
                fs.Function_Duration = r.Function_Duration;
                fs.Function_Status = r.Function_Status;

                es.Function_Details.Add(fs);
                var res = es.SaveChanges();
                if (res > 0)
                {
                    return true;
                }
                else
                    return false;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string PutFunctionDetails(FunctionDetails r, int id)
        {
            try
            {
                var fs = (from f in es.Function_Details
                         where f.Function_ID == id
                         select f).SingleOrDefault();
                if (r == null)
                {
                    return "ID Invalid";
                }
                else
                {
                    fs.Function_Category_ID = r.Function_Category_ID;
                    fs.Owner_ID = r.Owner_ID;
                    fs.Function_Date = r.Function_Date;
                    fs.Function_Details1 = r.Function_Details;
                    fs.Function_Time = r.Function_Time;
                    fs.Function_Duration = r.Function_Duration;
                    fs.Function_Status = r.Function_Status;

                    var res = es.SaveChanges();

                  if(res >0 )
                    {
                        return "Data Updated";
                    }
                }
                return "Error In Inserting the data";
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
