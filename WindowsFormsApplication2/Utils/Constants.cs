using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionEleve.Utils
{
    class Constants
    {
        public static List<String> AllMatieres()
        {
            return new List<string> { 
                "Mathematique",
                "Science",
                "Physique",
                "Informatique",
                "Arabe",
                "Francais",
                "Anglais",
            };
        }

        public static List<String> AllSections()
        {
            return new List<string> { 
                "Mathematique",
                "Science Experimental",
                "Science Technique",
                "Science Informatique",
                "Economie et Gestion",
                "Sport",
                "Lettre",
                "NO SECTION"
            };
        }

        public static List<String> AllNiveaux()
        {
            return new List<string> { 
                "BAC",
                "3eme",
                "2eme",
                "1ere",
            };
        }
    }
}
