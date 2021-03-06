using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercial.models
{
    class Detail
    {
        private int qtecommande;

        private Article article;
        private Client client;

        public int Qtecommande { get => qtecommande; set => qtecommande = value; }
        public Article Article { get => article; set => article = value; }
        public Client Client { get => client; set => client = value; }

        public Detail()
        {
        }

        public Detail(int qtecommande, Article article, Client client)
        {
            this.qtecommande = qtecommande;
            this.article = article;
            this.client = client;
        }
    }

}
