using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionEleve.Autre.AnneeScolaire
{
    class AnneeModel
    {
        public int ANNEE1 { get; set; }
        public int ANNEE2 { get; set; }

        public AnneeModel(int ANNEE1, int ANNEE2){
            this.ANNEE1 = ANNEE1;
            this.ANNEE2 = ANNEE2;
        }

    }
}
