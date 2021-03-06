using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercial.models
{
   public class Convert
    {
        public static string ListToString(List<String> profil)
        {
            string profilString = "";
            foreach(var elt in profil)
            {
                profilString += elt + ";";

            }
            return profilString;
        }

        public static List<String> StringToList(String profil)
        {
            List<String> lProfils = new List<string>();
            return profil.Split(';').ToList();

        }
    }
}
