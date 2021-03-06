using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercial.models
{
    class Commande
    {
        private int date;
        private int numero;
        private int total;
        private int id;
        private List<String> categorie;

        public Commande()
        {
        }

        public Commande(int date, int numero, int total,int id, List<string> categorie)
        {
            this.Id = id;
            this.Date = date;
            this.Numero = numero;
            this.Total = total;
            this.Categorie = categorie;
            
        }

        public int Date { get => date; set => date = value; }
        public int Numero { get => numero; set => numero = value; }
        public int Total { get => total; set => total = value; }
        public int Id { get => id; set => id = value; }
        public List<string> Categorie { get => categorie; set => categorie = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }



}
