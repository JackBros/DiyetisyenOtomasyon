﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiyetProgrami.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DiyetDbEntities : DbContext
    {
        public DiyetDbEntities()
            : base("name=DiyetDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BesinlerTbl> BesinlerTbl { get; set; }
        public virtual DbSet<BesinTipTbl> BesinTipTbl { get; set; }
        public virtual DbSet<DiyetisyenTbl> DiyetisyenTbl { get; set; }
        public virtual DbSet<KisiDetay> KisiDetay { get; set; }
        public virtual DbSet<KisiTbl> KisiTbl { get; set; }
        public virtual DbSet<OgunTbl> OgunTbl { get; set; }
    }
}
