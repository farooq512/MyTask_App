﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AU_Tasks_App.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AU_TasksEntities : DbContext
    {
        public AU_TasksEntities()
            : base("name=AU_TasksEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AU_TASK> AU_TASK { get; set; }
        public virtual DbSet<DEPARTMENT> DEPARTMENT { get; set; }
        public virtual DbSet<PROJECT> PROJECT { get; set; }
        public virtual DbSet<STAFF_ATTENDENCE> STAFF_ATTENDENCE { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TASK_DETAIL> TASK_DETAIL { get; set; }
        public virtual DbSet<TASK_RELEASE_NOTE> TASK_RELEASE_NOTE { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }
    }
}
