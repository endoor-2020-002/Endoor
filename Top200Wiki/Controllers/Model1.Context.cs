﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Top200Wiki.Controllers
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Top2000WikiEntities : DbContext
    {
        public Top2000WikiEntities()
            : base("name=Top2000WikiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Artiest> Artiests { get; set; }
        public virtual DbSet<Lijst> Lijsts { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<Top2000Jaar> Top2000Jaar { get; set; }
    }
}
