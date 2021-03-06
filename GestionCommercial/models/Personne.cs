using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercial.models
{
    abstract class Personne
    {
        private String nomcomplet;

        private String type;
        private int id;

        public string Nomcomplet { get => nomcomplet; set => nomcomplet = value; }
        public string Type { get => type; set => type = value; }
        public int Id { get => id; set => id = value; }

        public Personne()
        {
        }

        public Personne(string nomcomplet, string type, Commande commande) : this(nomcomplet)
        {
            this.Type = type;
          
        }

        public Personne(string nomcomplet)
        {
            this.Nomcomplet = nomcomplet;

        }

        protected Personne(int id)
        {
            this.id = id;
        }
    }
}
