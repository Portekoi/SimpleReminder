using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleReminder
{
    public class Rappel
    {
        public DateTime DateHeure { get; set; }
        public Agence Agence { get; set; }
        public string NumDossier { get; set; }
        public float Montant { get; set; }
        public string NomClient { get; set; }
    }
}
