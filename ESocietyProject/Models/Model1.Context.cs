﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESocietyProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ESocietyProjectEntities : DbContext
    {
        public ESocietyProjectEntities()
            : base("name=ESocietyProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Additional_Facility_Details> Additional_Facility_Details { get; set; }
        public DbSet<AdminRegistration> AdminRegistrations { get; set; }
        public DbSet<Function_Category> Function_Category { get; set; }
        public DbSet<Function_Details> Function_Details { get; set; }
        public DbSet<Guard_Duty> Guard_Duty { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Nearby_Services> Nearby_Services { get; set; }
        public DbSet<Nearby_Services_Category> Nearby_Services_Category { get; set; }
        public DbSet<OwnerRegistration> OwnerRegistrations { get; set; }
        public DbSet<Parking_Details> Parking_Details { get; set; }
        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<Society> Societies { get; set; }
        public DbSet<User_Service_Details> User_Service_Details { get; set; }
    }
}
