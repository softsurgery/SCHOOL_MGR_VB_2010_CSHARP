using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GestionEleve.Utils
{
    class Transform
    {
        public static void SetRoundedBorder(Control control, int radius)
        {
            control.Region = new Region(GetRoundedRectangle(control.ClientRectangle, radius));
        }

        private static GraphicsPath GetRoundedRectangle(Rectangle rectangle, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rectangle.X, rectangle.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(rectangle.Right - radius * 2, rectangle.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(rectangle.Right - radius * 2, rectangle.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(rectangle.X, rectangle.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
