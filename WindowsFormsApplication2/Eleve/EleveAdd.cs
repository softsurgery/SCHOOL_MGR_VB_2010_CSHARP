using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionEleve.Utils;

namespace GestionEleve.Eleve
{
    public partial class EleveAdd : Form{
        private EleveControlleur controller;
        private GestionEleve.Eleve.EleveShow.FetchAndDisplayDataDelegate fetchAndDisplayDataDelegate;

        public EleveAdd(GestionEleve.Eleve.EleveShow.FetchAndDisplayDataDelegate fetchAndDisplayDataDelegate)
        {
            InitializeComponent();
            this.fetchAndDisplayDataDelegate = fetchAndDisplayDataDelegate;

            //controller
            controller = new EleveControlleur();
            
            //config
            dob.Format = DateTimePickerFormat.Short;
            dob.ShowUpDown = false;

            dateInscription.Format = DateTimePickerFormat.Short;
            dateInscription.ShowUpDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ajouter_Click_1(object sender, EventArgs e)
        {
            if (nomComplet.Text == "") nomCompletErreur.Text = "Le nom doit etre definie";
            else if (!nomComplet.Text.Contains(" ")) nomCompletErreur.Text = "le nom est incorrect";
            else{
                nomCompletErreur.ForeColor = colors.green;
                nomCompletErreur.Text = "OK";
            };

            int age = StaticMethods.CalculateDateDifferenceInYears(dob.Text,StaticMethods.GetTodayDate());
            if (age < 14) dateDeNaissanceErreur.Text = "La date est invalide";
            else{
                dateDeNaissanceErreur.ForeColor = colors.green;
                dateDeNaissanceErreur.Text = "OK";
            };

            int insdiff = StaticMethods.CalculateDateDifferenceInYears(dateInscription.Text,StaticMethods.GetTodayDate());
            if (age - insdiff < 14) dateDinscriptionErreur.Text = "La date est invalide";
            else{
                dateDinscriptionErreur.ForeColor = colors.green;
                dateDinscriptionErreur.Text = "OK";
            };

            //DATABASE
            if (nomCompletErreur.Text == "OK" &&
                dateDeNaissanceErreur.Text == "OK" &&
                dateDinscriptionErreur.Text == "OK"){
                EleveModel eleve = new EleveModel(-1,nomComplet.Text,dob.Text,dateInscription.Text,10);
                controller.AddEleve(eleve);
                fetchAndDisplayDataDelegate();
                Console.WriteLine("Added Eleve Succesfully");
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EleveAdd_Load(object sender, EventArgs e)
        {

        }

        private void nomComplet_TextChanged(object sender, EventArgs e)
        {

        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void dateInscription_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
