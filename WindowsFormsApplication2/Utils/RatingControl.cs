using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            int starSize = 30; // Size of the PictureBox

            for (int i = 0; i < starNum; i++)
            {
                PictureBox star = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.Zoom, // Ensure that the image is centered within the PictureBox
                    Tag = i,
                    Cursor = Cursors.Hand,
                };

                star.Load("C://star.png"); // Load the star image
                ResizeStar(star, starSize); // Resize the star image

                stars[i] = star;
                Controls.Add(star);

                // Position the stars horizontally
                star.Location = new Point(i * starSize, 0);
            }

            // Set the size of the UserControl based on the number of stars
            this.Size = new Size(starNum * starSize, starSize);
        }

        private void ResizeStar(PictureBox star, int size)
        {
            if (star.Image != null)
            {
                // Calculate the new size for the image
                int newSize = Math.Min(size, Math.Max(star.Image.Width, star.Image.Height));
                star.Size = new Size(newSize, newSize);
            }
        }

        private void RatingControl_Load(object sender, EventArgs e)
        {

        }
    }
}
