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

namespace GestionEleve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            //open the usercontrol of eleveMain
            panel1.Controls.Clear();
            UserControl eleveShow = new EleveShow();
            panel1.Controls.Add(eleveShow);
            eleveShow.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //open the usercontrol of eleveMain
            panel1.Controls.Clear();
            UserControl instructeurMain = new InstructeurMain();
            panel1.Controls.Add(instructeurMain);
            instructeurMain.Show();
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
    }
}
