using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionEleve.Eleve
{
    public partial class EleveShow : UserControl
    {
        private EleveControlleur controller;

        public EleveShow(){
            InitializeComponent();

            //controller
            controller = new EleveControlleur();

        }

        private void EleveShow_Load(object sender, EventArgs e)
        {
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.ReadOnly = true;
            dataGrid.AutoResizeColumns();
            dataGrid.Columns[0].HeaderText = "Identifiant";
            dataGrid.Columns[1].HeaderText = "Nom Complet";
            dataGrid.Columns[2].HeaderText = "Date de Naissance";
            dataGrid.Columns[3].HeaderText = "Date d'Inscription";
            dataGrid.Columns[4].HeaderText = "Score";
            FetchAndDisplayData();
        }

        private void FetchAndDisplayData(){
            List<EleveModel> eleves = controller.GetAllEleves();
            dataGrid.DataSource = eleves;
        }

        public delegate void FetchAndDisplayDataDelegate();

        private void button1_Click(object sender, EventArgs e)
        {
            Form eleveAdd = new EleveAdd(FetchAndDisplayData);
            eleveAdd.Show();
            FetchAndDisplayData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
