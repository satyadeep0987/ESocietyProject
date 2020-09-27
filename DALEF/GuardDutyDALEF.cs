using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using IDatabase;

namespace DALEF
{
    public class GuardDutyDALEF : IGuardDuty
    {
        ESocietyProjectEntities es = new ESocietyProjectEntities();

        public GuardDuty GetByIdVistor(int id)
        {
            try
            {
                GuardDuty g = new GuardDuty();

                var r = es.Guard_Duty.Where(i => i.Visitor_ID == id).SingleOrDefault();

                if (r != null)
                {
                    g.Visitor_ID = r.Visitor_ID;
                    g.Visitor_Name = r.Visitor_Name;
                    g.In_Datetime = r.In_Datetime;
                    g.Out_Datetime = r.Out_Datetime;
                    g.Details = r.Details;
                    g.House_ID = r.House_ID;
                    g.Require = (int)r.Require;
                }
                else
                {
                    throw new Exception("Invalid Visitor ID");
                }

                return g;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<GuardDuty> GetGuardDuty()
        {
            try
            {
                var res = es.Guard_Duty.ToList();

                List<GuardDuty> gd = new List<GuardDuty>();

                foreach (var r in res)
                {
                    GuardDuty g = new GuardDuty();

                    g.Visitor_ID = r.Visitor_ID;
                    g.Visitor_Name = r.Visitor_Name;
                    g.In_Datetime = r.In_Datetime;
                    g.Out_Datetime = r.Out_Datetime;
                    g.Details = r.Details;
                    g.House_ID = r.House_ID;
                    g.Require = (int)r.Require;

                    gd.Add(g);
                }
                return gd;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PostGuardDuty(GuardDuty g)
        {
            try
            {
                Guard_Duty gd = new Guard_Duty();

              
                gd.Visitor_Name = g.Visitor_Name;
                gd.In_Datetime = g.In_Datetime;
                gd.Out_Datetime = g.Out_Datetime;
                gd.Details = g.Details;
                gd.House_ID = g.House_ID;
                gd.Require = g.Require;

                es.Guard_Duty.Add(gd);
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

        public string PutGuardDuty(int id, GuardDuty g)
        {
            try
            {
                var gd = (from t in es.Guard_Duty
                          where t.Visitor_ID == id
                          select t).SingleOrDefault();
                if (g == null)
                {
                    return "Invalid Visitor ID";
                }
                else
                {
                   
                    gd.Visitor_Name = g.Visitor_Name;
                    gd.In_Datetime = g.In_Datetime;
                    gd.Out_Datetime = g.Out_Datetime;
                    gd.Details = g.Details;
                    gd.House_ID = g.House_ID;
                    gd.Require = g.Require;

                    var res = es.SaveChanges();
                    if (res > 0)
                    {
                        return "Data Updated Succesfully";
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
