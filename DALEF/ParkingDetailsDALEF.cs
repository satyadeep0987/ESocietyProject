using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using IDatabase;
namespace DALEF
{
   public class ParkingDetailsDALEF : IParkingDetails
    {
    
        ESocietyProjectEntities es = new ESocietyProjectEntities();
        public ParkingDetails GetByParkingId(int id)
        {
            try
            {
                ParkingDetails p = new ParkingDetails();
                var r = es.Parking_Details.Where(x => x.Parking_ID == id).SingleOrDefault();
                if (r != null)
                {
                    p.Parking_ID = r.Parking_ID;
                    p.Vechile_Number = r.Vechile_Number;
                    p.Visitor_ID = (int)r.Visitor_ID;

                }
                else
                {
                    throw new Exception("Invalid id");
                }
                return p;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string PutParking(int id, ParkingDetails pd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ParkingDetails> GetParking()
        {
            try
            {
                var res = es.Parking_Details.ToList();
                List<Parking_Details> pd = new List<Parking_Details>();
                foreach (var r in res)
                {
                    Parking_Details p = new Parking_Details();
                    p.Parking_ID = r.Parking_ID;
                    p.Vechile_Number = r.Vechile_Number;
                    p.Visitor_ID = r.Visitor_ID;
                    p.Slot_Id = r.Slot_Id;

                    pd.Add(p);
                }
                return (IEnumerable<ParkingDetails>)pd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PostParking(ParkingDetails p)
        {
            try
            {
                Parking_Details pd = new Parking_Details();
                pd.Parking_ID = p.Parking_ID;
                pd.Vechile_Number = p.Vechile_Number;
                pd.Visitor_ID = p.Visitor_ID;
                var res = es.Parking_Details.Add(pd);
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
           
        public string PutParking(ParkingDetails p, int id)
        {
                try
                {
                    var a = (from pd in es.Parking_Details where pd.Parking_ID == id select pd).SingleOrDefault();
                    if (p == null)
                    {
                        return "Invalid id";
                    }
                    else
                    {
                        a.Vechile_Number = p.Vechile_Number;
                        a.Visitor_ID = p.Visitor_ID;

                        var res = es.SaveChanges();
                        if (res > 0)
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
