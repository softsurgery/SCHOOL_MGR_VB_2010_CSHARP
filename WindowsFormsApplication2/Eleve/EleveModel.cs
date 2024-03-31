using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionEleve.Eleve
{
    class EleveModel
    {
        public int ID { get; set; }
        public String nomComplet { get; set; }
        public String dateNaissance { get; set; }
        public String dateInscription { get; set; }
        public int score { get; set; }
    }
}
