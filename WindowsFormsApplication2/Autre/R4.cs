using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionInstructeur.Instructeur;
using GestionEleve.Instructeur;
using GestionEleve.Utils;

namespace GestionEleve.Autre
{
    public partial class R4 : UserControl
    {
        private InstructeurController controller;
        public R4(String matiere)
        {
            InitializeComponent();
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.ReadOnly = true;
            dataGrid.AutoResizeColumns();
            dataGrid.Columns[0].HeaderText = "CIN";
            dataGrid.Columns[1].HeaderText = "Nom Complet";

            controller = new InstructeurController();
            List<InstructeurModel> resultat = controller.GetAllInstructeurs();
            resultat = resultat.Where(e => e.MATIERE == matiere).ToList();
            dataGrid.DataSource = resultat;
        }

        private void R4_Load(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
