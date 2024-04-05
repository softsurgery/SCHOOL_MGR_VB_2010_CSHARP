using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionInstructeur.Instructeur;
using GestionEleve.Utils;

namespace GestionEleve.Instructeur
{
    public partial class InstructeurShow : UserControl
    {
        private InstructeurController controller;
        private int ID_INSTRUCTEUR = -1;
        private String CIN = "";
        private String NOM_COMPLET = "";
        private String DATE_DE_NAISSANCE = "";
        private int SCORE = 0;
        private String MATIERE = "";

        public InstructeurShow()
        {
            InitializeComponent();
            //controller
            controller = new InstructeurController();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InstructeurShow_Load(object sender, EventArgs e)
        {
            
                
            //config
            photo.SizeMode = PictureBoxSizeMode.Zoom;
            Transform.SetRoundedBorder(photo, 50);
            photo.Load(@"../../Data/user.png");

            //config
            dob.Format = DateTimePickerFormat.Short;
            dob.ShowUpDown = false;

            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.ReadOnly = true;
            dataGrid.Columns[0].HeaderText = "Identifiant";
            dataGrid.Columns[1].HeaderText = "CIN";
            dataGrid.Columns[2].HeaderText = "Nom Complet";
            dataGrid.Columns[3].HeaderText = "Date de Naissance";
            dataGrid.Columns[4].HeaderText = "Score";
            dataGrid.Columns[5].HeaderText = "Matiere";

            matiere1.Items.Add("Sélectionnez...");
            List<String> items = Constants.AllMatieres();
            foreach (var item in items)
            {
                matiere1.Items.Add(item);
            }
            FetchAndDisplayData();
            matiere1.SelectedIndex = 0;
            clear();
        }

        private void clear()
        {
            ID_INSTRUCTEUR = -1;
            nomComplet.Text = "";
            cin1.Text = "";
            dob.Text = "";
            matiere1.SelectedIndex = 0;
            draft.Text = "";
            giveRate(0);
        }

        private void giveRate(int rate){
            stars.Controls.Clear();
            UserControl rating = new RatingControl(rate);
            stars.Controls.Add(rating);
            rating.Show();
        }

        private void FetchAndDisplayData()
        {
            dataGrid.DataSource = controller.GetAllInstructeurs("");
        }

        private void matiere1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MATIERE = matiere1.SelectedItem.ToString();
        }

        private void dataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dataGrid.Rows[e.RowIndex];
                ID_INSTRUCTEUR = (int)clickedRow.Cells[0].Value;
                CIN = (String)clickedRow.Cells[1].Value;
                cin1.Text = (String)CIN;
                NOM_COMPLET = (String)clickedRow.Cells[2].Value;
                nomComplet.Text = (String)NOM_COMPLET;
                DATE_DE_NAISSANCE = (String)clickedRow.Cells[3].Value;
                dob.Text = (String)DATE_DE_NAISSANCE;
                SCORE = (int)clickedRow.Cells[4].Value;
                MATIERE = (string)clickedRow.Cells[5].Value;
                int index = matiere1.FindStringExact(MATIERE);
                if (index != -1)
                {
                    matiere1.SelectedIndex = index;
                }
                giveRate((int)SCORE);
                draft.ForeColor = colors.red;
                draft.Text = "ALTER";
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

        private void nouveau_Click(object sender, EventArgs e)
        {
            clear();
            draft.ForeColor = colors.green;
            draft.Text = "DRAFT";
        }

        private void recherche_TextChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = controller.GetAllInstructeurs(recherche.Text);
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            {
                Erreur.ForeColor = colors.red;
                int age = StaticMethods.CalculateDateDifferenceInYears(dob.Text, StaticMethods.GetTodayDate());
                if (cin1.Text == "" || !cin1.Text.All(char.IsDigit) || !(cin1.Text.Length == 8) ) Erreur.Text = "CIN est Incorrecte";
                else if (nomComplet.Text == "") Erreur.Text = "Le nom doit etre definie";
                else if (!nomComplet.Text.Contains(" ")) Erreur.Text = "le nom est incorrect";
                else if (age < 21) Erreur.Text = "La date est invalide";
                else if (matiere1.SelectedIndex == 0) Erreur.Text = "La matiere doit etre definie";
                else
                {
                    InstructeurModel instructeur = new InstructeurModel(ID_INSTRUCTEUR, CIN, NOM_COMPLET, DATE_DE_NAISSANCE, SCORE, MATIERE);
                    if (ID_INSTRUCTEUR != -1)
                    {
                        controller.ModifyInstructeur(instructeur);
                        Erreur.ForeColor = colors.green;
                        Erreur.Text = "Modification Reussite";
                    }
                    else
                    {
                        controller.AddInstructeur(instructeur);
                        Erreur.ForeColor = colors.green;
                        Erreur.Text = "Ajout Reusssie";
                    }
                    FetchAndDisplayData();
                    clear();
                    draft.Text = "";
                };
            }
        }

        private void cin1_TextChanged(object sender, EventArgs e)
        {
            CIN = cin1.Text;
        }

        private void nomComplet_TextChanged(object sender, EventArgs e)
        {
            NOM_COMPLET = nomComplet.Text;
        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {
            DATE_DE_NAISSANCE = dob.Text;
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (ID_INSTRUCTEUR == -1)
            {
                MessageBox.Show("Suppression Invalide");
            }
            else if (NOM_COMPLET != "")
            {
                DialogResult result = MessageBox.Show("Voulez vous supprimer l'eleve " + NOM_COMPLET, "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    controller.DeleteInstructeur(ID_INSTRUCTEUR);
                    clear();
                    FetchAndDisplayData();
                }
            }
        }
    }
}
