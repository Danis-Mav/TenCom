﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TenCom.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TenComEntities : DbContext
    {
        public TenComEntities()
            : base("name=TenComEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EducationalInstitution> EducationalInstitution { get; set; }
        public virtual DbSet<Game> Game { get; set; }
        public virtual DbSet<Results> Results { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
