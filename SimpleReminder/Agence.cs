using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleReminder
{
    public class Agence
    {
        public string Nom { get; set; }
        public string Telephone { get; set; }
        public string NomContact { get; set; }

        public static bool Save(Agence agence)
        {

            return true;
        }

        public static List<Agence> GetAll()
        {
            List<Agence> listAgences = new List<Agence>();

            return listAgences;
        }
    }
}
