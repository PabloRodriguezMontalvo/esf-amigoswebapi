﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RedSocialWebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RedSocialEntities : DbContext
    {
        public RedSocialEntities()
            : base("name=RedSocialEntities")
        {
            Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Amigos> Amigos { get; set; }
        public virtual DbSet<MensajePrivado> MensajePrivado { get; set; }
        public virtual DbSet<MensajePublico> MensajePublico { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
