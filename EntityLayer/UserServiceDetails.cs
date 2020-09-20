using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class UserServiceDetails
    {
        public int User_Id { get; set; }
        public int? Service_Category_ID { get; set; }
        public string User_Name { get; set; }
        public string User_Address { get; set; }
        public long User_Contact { get; set; }
        public string User_Availability { get; set; }
        public long User_Rate { get; set; }   

    }
}
