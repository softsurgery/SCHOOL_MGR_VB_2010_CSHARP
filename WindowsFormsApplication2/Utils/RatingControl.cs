using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GestionEleve.Utils
{
    public partial class RatingControl : UserControl
    {
        private int starNum;
        private PictureBox[] stars;

        public RatingControl(int starNum)
        {
            InitializeComponent();
            this.starNum = starNum;
            InitializeStars();
        }

        private void InitializeStars()
        {
            stars = new PictureBox[starNum];
            int starSize = 30;

            for (int i = 0; i < starNum; i++)
            {
                PictureBox star = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Tag = i,
                    Cursor = Cursors.Hand,
                };
                star.Load(Path.Combine(Directory.GetCurrentDirectory(), @"../../Data/star.png"));
                ResizeStar(star, starSize);
                stars[i] = star;
                Controls.Add(star);
                star.Location = new Point(i * starSize, 0);
            }
            this.Size = new Size(starNum * starSize, starSize);
        }

        private void ResizeStar(PictureBox star, int size)
        {
            if (star.Image != null)
            {
                int newSize = Math.Min(size, Math.Max(star.Image.Width, star.Image.Height));
                star.Size = new Size(newSize, newSize);
            }
        }

        private void RatingControl_Load(object sender, EventArgs e)
        {

        }
    }
}
