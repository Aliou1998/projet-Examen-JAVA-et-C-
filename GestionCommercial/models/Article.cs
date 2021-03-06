using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercial.models
{
    public class Article
    {
        private String reference;
        private String libelle;
      
        private int prix;
        private String stock;
        private String categorie;
        private int id;
        public Article()
        {
        }

        public Article(string reference, string libelle,  int prix, string stock, string categorie, int id)
        {
            this.Reference = reference;
            this.Libelle = libelle;
            
            this.Prix = prix;
            this.Stock = stock;
            this.Categorie = categorie;
            this.Id = id;
        }

        public string Reference { get => reference; set => reference = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        
        public int Prix { get => prix; set => prix = value; }
        public string Stock { get => stock; set => stock = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return Libelle;


        }
    }


}
