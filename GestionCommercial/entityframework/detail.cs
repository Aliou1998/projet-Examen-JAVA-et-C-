//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionCommercial.entityframework
{
    using System;
    using System.Collections.Generic;
    
    public partial class detail
    {
        public int client_id { get; set; }
        public int qtecommandee { get; set; }
        public int commande_id { get; set; }
        public int article_id { get; set; }
    
        public virtual article article { get; set; }
        public virtual personne personne { get; set; }
    }
}
