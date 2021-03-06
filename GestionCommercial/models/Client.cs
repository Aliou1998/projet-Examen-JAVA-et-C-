using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercial.models
{
    class Client : Personne
    {
        private int tel;
        private String adresse;
        private Article article;
        private Commande commande;
        

        public Client()
        {
            Type = "Client";
        }

        public Client(int tel, string adresse)
        {
            
            this.Tel = tel;
            this.Adresse = adresse;
            Type = "Client";
        }

        public int Tel { get => tel; set => tel = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public Article Article { get => article; set => article = value; }
        public Commande Commande { get => commande; set => commande = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
