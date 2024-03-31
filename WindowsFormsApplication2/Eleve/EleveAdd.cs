using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionEleve.Eleve
{
    public partial class EleveAdd : Form{
        private EleveControlleur controller;

        public EleveAdd()
        {
            InitializeComponent();
            controller = new EleveControlleur();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine(dob.Text);
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
            Console.WriteLine(dob.Text);
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
    }
}
