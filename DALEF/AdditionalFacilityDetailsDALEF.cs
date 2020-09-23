using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using IDatabase;

namespace DALEF
{
    public class AdditionalFacilityDetailsDALEF : IAdditionalFacilityDetails
    {
        ESocietyProjectEntities es = new ESocietyProjectEntities();
        public IEnumerable<AdditionalFacilityDetails> GetAdditionalFacilityDetails()
        {
            try
            {
                var res = es.Additional_Facility_Details.ToList();
                List<AdditionalFacilityDetails> ad = new List<AdditionalFacilityDetails>();
                foreach(var r in res)
                {
                    AdditionalFacilityDetails a = new AdditionalFacilityDetails();
                    a.Facility_ID = r.Facility_ID;
                    a.Facility_Name = r.Facility_Name;
                    a.Facility_Contact = r.Facility_Contact;
                    a.Facility_Address = r.Facility_Address;
                    a.Facility_Availability = r.Facility_Availability;
                    a.Facility_Charges = r.Facility_Charges;

                    ad.Add(a);
                }
                return ad;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public AdditionalFacilityDetails GetByIdAdditionalFacilityDetails(int id)
        {
            try
            {
                AdditionalFacilityDetails a = new AdditionalFacilityDetails();
                var r = es.Additional_Facility_Details.Where(x => x.Facility_ID == id).SingleOrDefault();
                if(r != null)
                {
                    a.Facility_ID = r.Facility_ID;
                    a.Facility_Name = r.Facility_Name;
                    a.Facility_Contact = r.Facility_Contact;
                    a.Facility_Address = r.Facility_Address;
                    a.Facility_Availability = r.Facility_Availability;
                    a.Facility_Charges = r.Facility_Charges;
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

        public bool PostAdditionalFacilityDetails(AdditionalFacilityDetails r)
        {
            try
            {
                Additional_Facility_Details a = new Additional_Facility_Details();
               
                a.Facility_Name = r.Facility_Name;
                a.Facility_Contact = r.Facility_Contact;
                a.Facility_Address = r.Facility_Address;
                a.Facility_Availability = r.Facility_Availability;
                a.Facility_Charges = r.Facility_Charges;
                es.Additional_Facility_Details.Add(a);
                var res = es.SaveChanges();
                if(res > 0)
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

        public string PutAdditionalFacilityDetails(AdditionalFacilityDetails r, int id)
        {
            try
            {
                
                var a = (from ad in es.Additional_Facility_Details
                         where ad.Facility_ID == id
                         select ad).SingleOrDefault();
                if(r == null)
                {
                    return "Invalid Id";
                }
                else
                {
                    a.Facility_Name = r.Facility_Name;
                    a.Facility_Contact = r.Facility_Contact;
                    a.Facility_Address = r.Facility_Address;
                    a.Facility_Availability = r.Facility_Availability;
                    a.Facility_Charges = r.Facility_Charges;

                    var res = es.SaveChanges();
                    if(res > 0)
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
