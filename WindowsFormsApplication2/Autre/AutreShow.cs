using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionEleve.Utils;

namespace GestionEleve.Autre
{
    public partial class AutreShow : UserControl
    {
        public AutreShow()
        {
            InitializeComponent();
            //config
            List<string> niveaux = Constants.AllNiveaux();
            List<string> matieres = Constants.AllMatieres();
            List<string> sections = Constants.AllSections();

            niveau1.Items.Clear();
            niveau2.Items.Clear();

            niveau1.Items.Add("Sélectionnez...");
            niveau2.Items.Add("Sélectionnez...");

            niveau1.SelectedIndex = 0;
            niveau2.SelectedIndex = 0;

            foreach (var n in niveaux)
            {
                niveau1.Items.Add(n);
                niveau2.Items.Add(n);
            }

            matiere1.Items.Clear();
            matiere1.Items.Add("Sélectionnez...");
            matiere1.SelectedIndex = 0;

            foreach (var m in matieres)
            {
                matiere1.Items.Add(m);
            }

            section1.Items.Clear();
            section2.Items.Clear();

            section1.Items.Add("Sélectionnez...");
            section2.Items.Add("Sélectionnez...");

            section1.SelectedIndex = 0;
            section2.SelectedIndex = 0;

            foreach (var s in sections)
            {
                section1.Items.Add(s);
                section2.Items.Add(s);
            }

            annee1.Format = DateTimePickerFormat.Custom;
            annee1.CustomFormat = "yyyy";

            annee2.Format = DateTimePickerFormat.Custom;
            annee2.CustomFormat = "yyyy";

            annee1.ShowUpDown = true;
            annee2.ShowUpDown = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AutreShow_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void section1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exec1_Click(object sender, EventArgs e)
        {
            int year = 0;
            if (annee1.Text.Length >= 4 && int.TryParse(annee1.Text.Substring(0, 4), out year))
            {
                UserControl r1 = new R1(section1.Text, niveau1.Text, year);
                panel1.Controls.Clear();
                panel1.Controls.Add(r1);
                r1.Show();
            }
        }

        private void exec2_Click(object sender, EventArgs e)
        {
            int year = 0;
            if (annee2.Text.Length >= 4 && int.TryParse(annee2.Text.Substring(0, 4), out year))
            {
                UserControl r2 = new R2(year);
                panel1.Controls.Clear();
                panel1.Controls.Add(r2);
                r2.Show();
            }
        }

        private void exec4_Click(object sender, EventArgs e)
        {
            UserControl r3 = new R3(section2.Text,niveau2.Text);
            panel1.Controls.Clear();
            panel1.Controls.Add(r3);
            r3.Show();
        }

        private void niveau2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
