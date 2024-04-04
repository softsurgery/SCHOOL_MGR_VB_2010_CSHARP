using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionEleve.Eleve;

namespace GestionEleve.Autre
{
    public partial class R1 : UserControl
    {
        private EleveControlleur controller;

        public R1(String section,String niveau, int year)
        {
            InitializeComponent();
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.ReadOnly = true;
            dataGrid.AutoResizeColumns();
            dataGrid.Columns[0].HeaderText = "Identifiant";
            dataGrid.Columns[1].HeaderText = "Nom Complet";

            controller = new EleveControlleur();
            List<EleveModel> resultat = controller.GetAllElevesByYear("", year);
            resultat = resultat.Where(e => e.CLASSIFICATION ==  niveau + "-" + section).ToList();
            dataGrid.DataSource = resultat;
        }

        private void R1_Load(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
