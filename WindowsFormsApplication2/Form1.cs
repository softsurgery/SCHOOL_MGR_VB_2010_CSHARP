using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionEleve.Eleve;
using GestionEleve.Instructeur;
using GestionEleve.Autre;
using GestionEleve.Autre.AnneeScolaire;

namespace GestionEleve
{
    public partial class Form1 : Form
    {
        private String ANNEE_SCOLAIRE;
        private AnneeController annee_controller;

        public Form1()
        {
            annee_controller = new AnneeController();
            InitializeComponent();
            fetchAneees();
            showElevePanal();
           
        }

        private void fetchAneees(){
            annee.Items.Clear();
            annee.Items.Add("Sélectionnez...");
            annee.SelectedIndex = 0;
            annee.ForeColor = Color.Gray;
            annee.SelectedIndexChanged += annee_SelectedIndexChanged;
            List<AnneeModel> items = annee_controller.GetAllAnnee("");
            foreach (var item in items)
            {
                annee.Items.Add(item.ANNEE1 + "/" + item.ANNEE2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void windowTitle_Click(object sender, EventArgs e)
        {

        }

        private void eleveMenu_Click_1(object sender, EventArgs e)
        {
            showElevePanal();
        }

        private void showElevePanal(){
            panel1.Controls.Clear();
            UserControl eleveShow = new EleveShow();
            panel1.Controls.Add(eleveShow);
            eleveShow.Show();
        }

        private void instructeurMenu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl instructeurMain = new InstructeurMain();
            panel1.Controls.Add(instructeurMain);
            instructeurMain.Show();
        }

        private void autres_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl autreMain = new AutreShow();
            panel1.Controls.Add(autreMain);
            autreMain.Show();
        }

        private void parametre_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void annee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (annee.SelectedIndex == 0)
            {
                annee.ForeColor = Color.Gray;
            }
            else
            {
                annee.ForeColor = SystemColors.WindowText;
                ANNEE_SCOLAIRE = annee.Text;
            }
        }

        private void ajouter_annee_Click(object sender, EventArgs e){
            if (AnneeController.CheckYearlyFormat(annee.Text))
            {
                int year;
                int.TryParse(AnneeController.SubstringTillSlash(annee.Text), out year);
                AnneeModel annee_model = new AnneeModel(-1, year, year + 1);
                annee_controller.AddAnnee(annee_model);
               
                fetchAneees();
            }
            else{
                MessageBox.Show("Annee Invalide");
            }

        }

        private void effacer_Click(object sender, EventArgs e)
        {
            if (annee.SelectedIndex != 0)
            {
                int year;
                int.TryParse(AnneeController.SubstringTillSlash(annee.Text), out year);
                annee_controller.DeleteAnnee(year);
                fetchAneees();
            }
            else {
                MessageBox.Show("Aucune Annee est selectionnée");
            }

        }

        

        
    }
}
