using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class NearbyServices
    {
        public int Nearby_Services_ID { get; set; }
        public int Nearby_Services_Category_ID { get; set; }
        public string Nearby_Services_Name { get; set; }
        public long Nearby_Services_Contact { get; set; }
        public string Nearby_Services_Address { get; set; }
        public decimal Nearby_Services_Distance { get; set; } // ?????
        public string Nearby_Services_Details { get; set; }  
    }
}
