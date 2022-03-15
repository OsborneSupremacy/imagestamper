using ImageStamper.Objects;
using System.Drawing;

namespace ImageStamper.Service
{
    public class DrawingService
    {
        public Graphics DrawStamp(
            Graphics imgGrphx,
            Brush brush,
            Font font,
            string text,
            Coordinate coordinate
            )
        {
            imgGrphx.DrawString(text, font, brush, coordinate.X, coordinate.Y);
            return imgGrphx;
        }

        public Graphics DrawBackground(
            Graphics imgGrphx,
            Coordinate coordinate,
            float width,
            float height
            )
        {
            imgGrphx.FillRectangle(Brushes.Black, coordinate.X, coordinate.Y, width, height);
            return imgGrphx;
        }

    }
}
