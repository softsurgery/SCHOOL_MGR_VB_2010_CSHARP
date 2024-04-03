using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionEleve.Autre.AnneeScolaire
{
    class AnneeModel
    {
        public int ID_ANNEE { get; set; }
        public int ANNEE1 { get; set; }
        public int ANNEE2 { get; set; }

        public AnneeModel(int ID_ANNEE,int ANNEE1, int ANNEE2){
            this.ID_ANNEE = ID_ANNEE;
            this.ANNEE1 = ANNEE1;
            this.ANNEE2 = ANNEE2;
        }

    }
}
