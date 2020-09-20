using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class OwnerRegistration
    {
        public int Owner_ID { get; set; }
        public string Owner_UserName { get; set; }
        public string Owner_Password { get; set; }
        public string Owener_Email { get; set; }
        public string House_ID { get; set; }
        public string Society_ID { get; set; }
        public string Owner_FirstName { get; set; }
        public string Owner_Lastname { get; set; }
        public string Owner_IDPROOF { get; set; }
        public long Owner_Contact { get; set; }
        public string Owner_Occupation { get; set; }
        public int Owner_NumberOfFamily { get; set; }
    }
}
