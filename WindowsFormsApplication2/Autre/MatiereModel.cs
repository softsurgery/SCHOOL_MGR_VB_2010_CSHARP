using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionEleve.Autre
{
    class MatiereModel
    {
        public String NOM { get; set; }
        public String COEFFICIENT { get; set; }

        public MatiereModel(String NOM, String COEFFICIENT)
        {
            this.NOM = NOM;
            this.COEFFICIENT = COEFFICIENT;
        }
    }
}
