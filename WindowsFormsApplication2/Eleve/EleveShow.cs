using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionEleve.Utils;
using System.IO;

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
        private String CLASSIFICATION = "";

        private int year;

        public EleveShow(){
            InitializeComponent();
            //controller
            controller = new EleveControlleur();
        }

        private void EleveShow_Load(object sender, EventArgs e)
        {
             //config
            photo.SizeMode = PictureBoxSizeMode.Zoom;
            Transform.SetRoundedBorder(photo, 50);
            photo.Load(@"../../Data/user.png");

            //config
            dob.Format = DateTimePickerFormat.Short;
            dob.ShowUpDown = false;

            dateINS.Format = DateTimePickerFormat.Short;
            dateINS.ShowUpDown = false;

            year = StaticMethods.ReadYearFromFile();
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.ReadOnly = true;
            dataGrid.AutoResizeColumns();
            dataGrid.Columns[0].HeaderText = "Identifiant";
            dataGrid.Columns[1].HeaderText = "Nom Complet";
            dataGrid.Columns[2].HeaderText = "Date de Naissance";
            dataGrid.Columns[3].HeaderText = "Date d'Inscription";
            dataGrid.Columns[4].HeaderText = "Score";
            dataGrid.Columns[5].HeaderText = "Classification";

            NS.Items.Add("Sélectionnez...");
            List<String> items = StaticMethods.getFileNames(@"..\..\Data\NS");
            foreach (var item in items)
            {
                NS.Items.Add(item);
            }
            FetchAndDisplayData();
            NS.SelectedIndex = 0;
            clear();
        }

        private void FetchAndDisplayData(){
            dataGrid.DataSource = controller.GetAllElevesByYear("",year);
        }


         //MessageBox.Show("Clicked value: " + cellValue.ToString());

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void recherche_TextChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = controller.GetAllElevesByYear(recherche.Text,year);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
              if (ID_ELEVE != -1 || draft.Text == "DRAFT")
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string selectedImagePath = openFileDialog.FileName;
                        string destinationPath = @"../../Data/PDPE/" + ID_ELEVE + ".png";
                        if (photo.Image != null)
                        {
                            photo.Image.Dispose();
                        }
                        if (File.Exists(destinationPath))
                        {
                            File.Delete(destinationPath);
                        }
                        File.Copy(selectedImagePath, destinationPath, true);
                        using (FileStream stream = new FileStream(destinationPath, FileMode.Open, FileAccess.Read))
                        {
                            photo.Image = Image.FromStream(stream);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
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
                String path = "../../Data/PDPE/" + ID_ELEVE + ".png";
                if (File.Exists(path))
                {
                    photo.Image = Image.FromFile(path);
                }
                else
                {
                    photo.Image = Image.FromFile("../../Data/user.png");
                }
                NOM_COMPLET = (String)clickedRow.Cells[1].Value;
                nomComplet.Text = (String)NOM_COMPLET;
                DATE_DE_NAISSANCE = (String)clickedRow.Cells[2].Value;
                dob.Text = (String)DATE_DE_NAISSANCE;
                DATE_DINSCRIPTION = (String)clickedRow.Cells[3].Value;
                dateINS.Text = (String)DATE_DINSCRIPTION;
                SCORE = (int)clickedRow.Cells[4].Value;
                CLASSIFICATION = (String)clickedRow.Cells[5].Value;
                NS.SelectedText = CLASSIFICATION;
                giveRate((int)SCORE);
                draft.ForeColor = colors.red;
                draft.Text = "ALTER";
            }

        }

        private void giveRate(int rate){
            stars.Controls.Clear();
            UserControl rating = new RatingControl(rate);
            stars.Controls.Add(rating);
            rating.Show();
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
                    string imagePath = "../../DATA/PDPE/" + ID_ELEVE + ".png";
                    if (File.Exists(imagePath))
                    {
                        photo.Image.Dispose();
                        File.Delete(imagePath);
                    }
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
                else if (NS.SelectedIndex == 0) Erreur.Text = "Le Niveau/Section doit etre definie";
                else
                {
                    EleveModel eleve = new EleveModel(ID_ELEVE, NOM_COMPLET, DATE_DE_NAISSANCE, DATE_DINSCRIPTION, SCORE, CLASSIFICATION);
                    if (ID_ELEVE != -1)
                    {
                        controller.ModifyEleve(eleve);
                        Erreur.ForeColor = colors.green;
                        Erreur.Text = "Modification Reussite";
                    }
                    else {
                        controller.AddEleve(eleve);
                        try
                        {
                            if (File.Exists("../../Data/PDPE/-1.png"))
                            {
                                File.Move("../../Data/PDPE/-1.png", "../../Data/PDPE/" + controller.GetMaxId() + ".png");
                            }
                            else
                            {
                                Console.WriteLine("File does not exist at the specified path.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error renaming file: " + ex.Message);
                        }
                        Erreur.ForeColor = colors.green;
                        Erreur.Text = "Ajout Reusssie";
                    }
                    FetchAndDisplayData();
                    clear();
                    draft.Text = "";
                };
            }
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            clear();
            draft.ForeColor = colors.green;
            draft.Text = "DRAFT";
        }

        private void clear(){
            ID_ELEVE = -1;
            nomComplet.Text = "";
            dateINS.Text = "";
            dob.Text = "";
            NS.SelectedIndex = 0;
            draft.Text = "";
            photo.Image = Image.FromFile("../../Data/user.png");
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
            CLASSIFICATION = NS.Text;
        }

        private void dataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void souscrire_Click(object sender, EventArgs e)
        {
            if (draft.Text == "ALTER")
            {
                controller.inscrire(ID_ELEVE, year+1);
                Erreur.ForeColor = colors.green;
                Erreur.Text = "L'eleve " + NOM_COMPLET + "est souscrire sous l'annee scolaire " + year + "/" + (year + 1);

            }
            else
            {
                MessageBox.Show("Aucun eleve est seclectionné");
            }
        }

        
    }
}
