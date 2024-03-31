using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionEleve.Eleve
{
    class EleveModel
    {
        public int ID_ELEVE { get; set; }
        public String NOM_COMPLET { get; set; }
        public String DATE_DE_NAISSANCE { get; set; }
        public String DATE_INSCRIPTION { get; set; }
        public int score { get; set; }

        public EleveModel(int ID_ELEVE, string NOM_COMPLET, string DATE_DE_NAISSANCE, string DATE_INSCRIPTION, int score)
        {
            this.ID_ELEVE = ID_ELEVE;
            this.NOM_COMPLET = NOM_COMPLET;
            this.DATE_DE_NAISSANCE = DATE_DE_NAISSANCE;
            this.DATE_INSCRIPTION = DATE_INSCRIPTION;
            this.score = score;
        }
    }
}
