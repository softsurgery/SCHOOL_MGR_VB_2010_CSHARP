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

        public EleveModel(int id, string nomComplet, string dateNaissance, string dateInscription, int score)
        {
            this.ID = id;
            this.nomComplet = nomComplet;
            this.dateNaissance = dateNaissance;
            this.dateInscription = dateInscription;
            this.score = score;
        }
    }
}
