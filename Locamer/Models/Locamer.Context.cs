﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Locamer.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LocamerEntities : DbContext
    {
        public LocamerEntities()
            : base("name=LocamerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<info_option> info_option { get; set; }
        public virtual DbSet<mobile_home> mobile_home { get; set; }
        public virtual DbSet<option> option { get; set; }
        public virtual DbSet<Sejour> Sejour { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tarif> tarif { get; set; }
        public virtual DbSet<type_sejour> type_sejour { get; set; }
    }
}
