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
        public EleveShow()
        {
            InitializeComponent();
        }

        private void EleveShow_Load(object sender, EventArgs e)
        {
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.ReadOnly = true;
            dataGrid.AutoResizeColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form eleveAdd = new EleveAdd();
            eleveAdd.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
