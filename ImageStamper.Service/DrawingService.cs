﻿using ImageStamper.Objects;
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
            Coordinates coordinates
            )
        {
            imgGrphx.DrawString(text, font, brush, coordinates.X, coordinates.Y);
            return imgGrphx;
        }

        public Graphics DrawBackground(
            Graphics imgGrphx,
            Coordinates coordinates,
            float width,
            float height
            )
        {
            imgGrphx.FillRectangle(Brushes.Black, coordinates.X, coordinates.Y, width, height);
            return imgGrphx;
        }

    }
}