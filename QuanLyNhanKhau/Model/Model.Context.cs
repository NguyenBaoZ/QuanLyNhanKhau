﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhanKhau.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyNhanKhauDBSchemaEntities : DbContext
    {
        public QuanLyNhanKhauDBSchemaEntities()
            : base("name=QuanLyNhanKhauDBSchemaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CitizenDetail> CitizenDetails { get; set; }
        public virtual DbSet<HouseholdBook> HouseholdBooks { get; set; }
        public virtual DbSet<HouseholdTranfer> HouseholdTranfers { get; set; }
        public virtual DbSet<TemporaryRequest> TemporaryRequests { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
