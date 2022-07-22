using System.Drawing;
using ImageStamper.Objects;

namespace ImageStamper.Service
{
    public class DrawingService
    {
        public Graphics DrawStamp(
            Graphics imgGrphx,
            Brush brush,
            Font font,
            string text,
            Coordinates coordinates
            )
        {
            imgGrphx.DrawString(text, font, brush, coordinates.X, coordinates.Y);
            return imgGrphx;
        }

        public Graphics DrawBackground(
            Graphics imgGrphx,
            Coordinates coordinates,
            SizeF size
            )
        {
            imgGrphx.FillRectangle(Brushes.Black, coordinates.X, coordinates.Y, size.Width, size.Height);
            return imgGrphx;
        }

    }
}
