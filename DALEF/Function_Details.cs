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
    
    public partial class Function_Details
    {
        public int Function_ID { get; set; }
        public Nullable<int> Function_Category_ID { get; set; }
        public Nullable<int> Owner_ID { get; set; }
        public string Function_Date { get; set; }
        public string Function_Time { get; set; }
        public string Function_Duration { get; set; }
        public string Function_Details1 { get; set; }
        public int Function_Status { get; set; }
    
        public virtual Function_Category Function_Category { get; set; }
        public virtual OwnerRegistration OwnerRegistration { get; set; }
    }
}