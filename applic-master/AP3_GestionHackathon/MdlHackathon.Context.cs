﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AP3_GestionHackathon
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class hackathonEntities : DbContext
    {
        public hackathonEntities()
            : base("name=hackathonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADMINISTRATEUR> ADMINISTRATEUR { get; set; }
        public virtual DbSet<EQUIPE> EQUIPE { get; set; }
        public virtual DbSet<HACKATHON> HACKATHON { get; set; }
        public virtual DbSet<INSCRIRE> INSCRIRE { get; set; }
        public virtual DbSet<MEMBRE> MEMBRE { get; set; }
        public virtual DbSet<ORGANISATEUR> ORGANISATEUR { get; set; }
        public virtual DbSet<TOKEN> TOKEN { get; set; }
        public virtual DbSet<ARCHIVAGE> ARCHIVAGE { get; set; }
    }
}