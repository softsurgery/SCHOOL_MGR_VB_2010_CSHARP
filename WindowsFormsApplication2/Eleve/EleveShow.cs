using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionEleve.Utils;

namespace GestionEleve.Eleve
{
    public partial class EleveShow : UserControl
    {
        private EleveControlleur controller;
        private int ID_ELEVE = -1;
        private String NOM_COMPLET = "";
        private String DATE_DE_NAISSANCE = "";
        private String DATE_DINSCRIPTION = "";
        private int SCORE = 0;

        public EleveShow(){
            InitializeComponent();

            //controller
            controller = new EleveControlleur();

            //config
            photo.SizeMode = PictureBoxSizeMode.Zoom;
            Transform.SetRoundedBorder(photo, 30);
            photo.Load("C:\\user.png");

            //config
            dob.Format = DateTimePickerFormat.Short;
            dob.ShowUpDown = false;

            dateINS.Format = DateTimePickerFormat.Short;
            dateINS.ShowUpDown = false;
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

            List<String> items = StaticMethods.getFileNames(@"..\..\Data\NS");
            foreach (var item in items)
            {
                NS.Items.Add(item);
            }
        }

        private void FetchAndDisplayData(){
            dataGrid.DataSource = controller.GetAllEleves();
        }


         //MessageBox.Show("Clicked value: " + cellValue.ToString());

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void recherche_TextChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = controller.GetAllEleves(recherche.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void stars_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stars_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0){
                DataGridViewRow clickedRow = dataGrid.Rows[e.RowIndex];
                ID_ELEVE = (int)clickedRow.Cells[0].Value;
                NOM_COMPLET = (String)clickedRow.Cells[1].Value;
                nomComplet.Text = (String)NOM_COMPLET;
                DATE_DE_NAISSANCE = (String)clickedRow.Cells[2].Value;
                dob.Text = (String)DATE_DE_NAISSANCE;
                DATE_DINSCRIPTION = (String)clickedRow.Cells[3].Value;
                dateINS.Text = (String)DATE_DINSCRIPTION;
                SCORE = (int)clickedRow.Cells[4].Value;
                giveRate((int)SCORE);
            }

        }

        private void giveRate(int rate){
            UserControl rating = new RatingControl(rate);
                stars.Controls.Clear();
                stars.Controls.Add(rating);
                rating.Show();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (ID_ELEVE == -1)
            {
                MessageBox.Show("Suppression Invalide");
            }
            else if (NOM_COMPLET != ""){
                DialogResult result = MessageBox.Show("Voulez vous supprimer l'eleve " + NOM_COMPLET, "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes){
                    controller.DeleteEleve(ID_ELEVE);
                    clear();
                    FetchAndDisplayData();
                }
            }
          
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (SCORE < 5)
            {
                SCORE++;
                giveRate(SCORE);
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (SCORE > 0)
            {
                SCORE--;
                giveRate(SCORE);
            }
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            
            {
                Erreur.ForeColor = colors.red;
                int age = StaticMethods.CalculateDateDifferenceInYears(dob.Text, StaticMethods.GetTodayDate());
                int insdiff = StaticMethods.CalculateDateDifferenceInYears(dateINS.Text, StaticMethods.GetTodayDate());

                if (nomComplet.Text == "") Erreur.Text = "Le nom doit etre definie";
                else if (!nomComplet.Text.Contains(" ")) Erreur.Text = "le nom est incorrect";
                else if (age < 14) Erreur.Text = "La date est invalide";
                else if (age - insdiff < 14) Erreur.Text = "La date est invalide";
                else
                {
                    EleveModel eleve = new EleveModel(ID_ELEVE, NOM_COMPLET, DATE_DE_NAISSANCE, DATE_DINSCRIPTION, SCORE);
                    if (ID_ELEVE != -1)
                    {
                        controller.ModifyEleve(eleve);
                        Erreur.ForeColor = colors.green;
                        Erreur.Text = "Modification Reussite";
                    }
                    else {
                        controller.AddEleve(eleve);
                        Erreur.ForeColor = colors.green;
                        Erreur.Text = "Ajout Reusssie";
                    }
                   FetchAndDisplayData();
                };
            }
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear(){
            ID_ELEVE = -1;
            nomComplet.Text = "";
            dateINS.Text = "";
            dob.Text = "";
            giveRate(0);
        }

        private void nomComplet_TextChanged(object sender, EventArgs e)
        {
            NOM_COMPLET = nomComplet.Text;
        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {
            DATE_DE_NAISSANCE = dob.Text;
        }

        private void dateINS_ValueChanged(object sender, EventArgs e)
        {
            DATE_DINSCRIPTION = dateINS.Text;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
