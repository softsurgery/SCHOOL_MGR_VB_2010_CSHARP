using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GestionEleve.Autre
{
    public partial class R3 : UserControl
    {
        public R3(string section, string niveau)
        {
            InitializeComponent();
            List<MatiereModel> matieres = new List<MatiereModel>();
            string filePath = "../../Data/NS/" + niveau + "-" + section;
            
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split('-');
                string nom = parts[0].Trim();
                string coefficient = parts[1].Trim();
                Console.Write(nom+"-");
                Console.Write(coefficient+"\n");
                MatiereModel matiere = new MatiereModel(nom, coefficient);
                matieres.Add(matiere);
            }

       
            dataGrid.DataSource = matieres;
        }


        private void R3_Load(object sender, EventArgs e)
        {

        }
    }
}
