﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultilayerArchitecture.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudijeEntities : DbContext
    {
        public StudijeEntities()
            : base("name=StudijeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ispit> Ispit { get; set; }
        public virtual DbSet<IspitniRok> IspitniRok { get; set; }
        public virtual DbSet<Predmet> Predmet { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentIspit> StudentIspit { get; set; }
    }
}
