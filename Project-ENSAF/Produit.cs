//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produit()
        {
            this.Produit_commande = new HashSet<Produit_commande>();
            this.Stock_Magazin = new HashSet<Stock_Magazin>();
            this.Vente_magazin = new HashSet<Vente_magazin>();
        }
    
        public int codeProduit { get; set; }
        public int idFournisseur { get; set; }
        public string libelle { get; set; }
        public decimal prixAchat { get; set; }
        public decimal prixVente { get; set; }
        public System.DateTime dateExpiration { get; set; }
        public byte[] img { get; set; }
        public string description { get; set; }
        public Nullable<int> dureeValidite_jour { get; set; }
    
        public virtual Fournisseur Fournisseur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produit_commande> Produit_commande { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock_Magazin> Stock_Magazin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vente_magazin> Vente_magazin { get; set; }
    }
}
