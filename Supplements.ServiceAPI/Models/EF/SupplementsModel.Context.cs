﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Supplements.ServiceAPI.Models.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SupplementContextEntities : DbContext
    {
        public SupplementContextEntities()
            : base("name=SupplementContextEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DoseResultDescription> DoseResultDescriptions { get; set; }
        public virtual DbSet<Dos> Doses { get; set; }
        public virtual DbSet<ResultDescription> ResultDescriptions { get; set; }
        public virtual DbSet<SupplementType> SupplementTypes { get; set; }
    }
}