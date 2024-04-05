using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionEleve.Instructeur
{
    class InstructeurModel
    {
        public int ID_INSTRUCTEUR { get; set; }
        public String CIN { get; set; }
        public String NOM_COMPLET { get; set; }
        public String DATE_DE_NAISSANCE { get; set; }
        public int SCORE { get; set; }
        public String MATIERE { get; set; }

        public InstructeurModel(int idInstructeur, string cin, string nomComplet, string dateDeNaissance, int score, string matiere)
        {
            this.ID_INSTRUCTEUR = idInstructeur;
            this.CIN = cin;
            this.NOM_COMPLET = nomComplet;
            this.DATE_DE_NAISSANCE = dateDeNaissance;
            this.SCORE = score;
            this.MATIERE = matiere;
        }
 
    }
}
