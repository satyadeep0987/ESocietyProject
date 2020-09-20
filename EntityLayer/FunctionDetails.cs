using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class FunctionDetails
    {
        public int Function_ID { get; set; }
        public int? Function_Category_ID { get; set; }
        public int? Owner_ID { get; set; }
        public string Function_Date { get; set; }
        public string Function_Time { get; set; }
        public string Function_Duration { get; set; }
        public string Function_Details { get; set; }
        public int Function_Status { get; set; }  
    }
}
