using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AdditionalFacilityDetails
    {
        public int Facility_ID { get; set; }    
        public string Facility_Name { get; set; }
        public string Facility_Address { get; set; }
        public long Facility_Contact { get; set; }
        public int Facility_Availability { get; set; }
        public long Facility_Charges { get; set; }
    } 
}
