using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercial.models
{
    class User: Personne
    {
        private String login;
        private String pwd;
        private List<String> profil;


        public User(): base()
        {
            Type = "User";
        }

        public User(string login, string pwd,String nomcomplet): base(nomcomplet)
        {
            this.Login = login;
            this.Pwd = pwd;
            Type = "User";
        }

        public string Login { get => login; set => login = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public List<string> Profil { get => profil; set => profil = value; }
    }
}
