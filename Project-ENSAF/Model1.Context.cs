﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_ENSAF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbContext : DbContext
    {
        public dbContext()
            : base("name=dbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Fournisseur> Fournisseurs { get; set; }
        public virtual DbSet<Magazin> Magazins { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }
        public virtual DbSet<Produit_commande> Produit_commande { get; set; }
        public virtual DbSet<Stock_Magazin> Stock_Magazin { get; set; }
        public virtual DbSet<Vente_magazin> Vente_magazin { get; set; }
    }
}
