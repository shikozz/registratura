﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Registy.Base
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RegEntities : DbContext
    {
        public RegEntities()
            : base("name=RegEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AnalyzeNames> AnalyzeNames { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PersonRooms> PersonRooms { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<PersonSpecializations> PersonSpecializations { get; set; }
        public virtual DbSet<ProcedureNames> ProcedureNames { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Specializations> Specializations { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
