using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class GuardDuty
    {
        public int Visitor_ID { get; set; }
        public string Visitor_Name { get; set; }
        public string In_Datetime { get; set; }
        public string Out_Datetime { get; set; }
        public string Details { get; set; }
        public string House_ID { get; set; }
        public int Require { get; set; }
    }  
}
