//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Service_Details
    {
        public int User_Id { get; set; }
        public Nullable<int> Service_Category_ID { get; set; }
        public string User_Name { get; set; }
        public string User_Address { get; set; }
        public long User_Contact { get; set; }
        public string User_Availavility { get; set; }
        public long User_Rate { get; set; }
    
        public virtual ServiceCategory ServiceCategory { get; set; }
    }
}
