using GestionCommercial.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercial.dao
{
    class DaoPersonne : IDao<Personne>
 {
        private DaoSql sqlServer;

        public DaoPersonne()
        {
            sqlServer = new DaoSql();
        }

        public int Insert(Personne pers)
        {
            String sql = String.Format("INSERT INTO personne " +
                " (nom_complet,type, profil " +
                " tel, adresse, id_commande)" +
                "  VALUES ({0},{1},{2},{3},{4},{5})",
                pers.Nomcomplet, pers.Type, ((Client)pers).Adresse, ((Client)pers).Tel,
                models.Convert.ListToString(((User)pers).Profil), ((Client)pers).Commande.Id
                );

            return sqlServer.ExecuteUpdate(sql);
        }

        public Personne FindUserConnect(String login, String pwd)
        {
            Personne pers = null;
            String sql = String.Format("select * from personne " + 
                " where login= '{0}' and pwd= '{1}'",

                login,pwd);
            DataTable dt = sqlServer.ExecuteSelect(sql);

            foreach(DataRow row in dt.Rows) {
                String type = row.ItemArray[2].ToString().Trim();
                if (type.CompareTo("Client") == 0)
                {
                    pers = new Client()
                    {
                        Tel= int.Parse(row.ItemArray[4].ToString().Trim()),
                        Adresse= row.ItemArray[5].ToString().Trim()
                    };
                }
                if (type.CompareTo("User") == 0)
                {
                    pers = new User()
                    {
                      Profil= models.Convert.StringToList(row.ItemArray[3].ToString().Trim())
                    };
                   
                }

                pers.Id = int.Parse(row.ItemArray[0].ToString().Trim());
                pers.Nomcomplet = row.ItemArray[1].ToString().Trim();
            }


            return pers;
        }

        public List<Client> FindClient()
        {
            List<Client> lClients  = new List<Client>();
            String sql = string.Format("select * from personne where type = 'Client'");

            return lClients;
        }
    }

}
