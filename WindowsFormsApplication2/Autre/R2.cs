using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionEleve.Eleve;
using GestionEleve.Utils;

namespace GestionEleve.Autre
{
    public partial class R2 : UserControl
    {
        private EleveControlleur controller;

        public R2(int year)
        {
            InitializeComponent();
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.ReadOnly = true;
            dataGrid.AutoResizeColumns();
            dataGrid.Columns[0].HeaderText = "Identifiant";
            dataGrid.Columns[1].HeaderText = "Nom Complet";

            controller = new EleveControlleur();
            List<EleveModel> resultat = controller.GetAllEleves();
            resultat = resultat.Where(e => StaticMethods.GetYearFromDate(e.DATE_DE_NAISSANCE) == year ).ToList();
            dataGrid.DataSource = resultat;
        }

        private void R2_Load(object sender, EventArgs e)
        {

        }
    }
}
