using GestionCommercial.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercial.dao
{
    public class DaoArticle : IDao<Article>
    {
        private DaoSql sqlServer;

        public DaoArticle()
        {
            sqlServer = new DaoSql();
        }

        public int Insert(Article article)
        {
            String sql = String.Format("INSERT INTO article " +
                " (reference, libelle, stock, prix,categorie) " +
                "  VALUES ('{0}', '{1}', '{2}', {3},'{4}')",
                article.Reference, article.Libelle, article.Stock,article.Prix,article.Categorie,article.Id);

            return sqlServer.ExecuteUpdate(sql);
        }

       public List<Article> FindAll()
        {
            List<Article> lArticles = new List<Article>();
            String sql = string.Format("select * from article");

            //pour remplir la liste 
            DataTable dt = sqlServer.ExecuteSelect(sql);
            foreach(DataRow row in dt.Rows)
            {
                Article article = new Article();
                article.Reference= (row.ItemArray[1].ToString().Trim());
                article.Libelle = (row.ItemArray[2].ToString().Trim());
                article.Stock= (row.ItemArray[3].ToString().Trim());
                article.Prix =int.Parse (row.ItemArray[4].ToString().Trim());
                article.Categorie = (row.ItemArray[5].ToString().Trim());
                //article.Id = int.Parse(row.ItemArray[6].ToString().Trim());

                lArticles.Add(article);

            }

            return lArticles;
        }
        
    }
}
