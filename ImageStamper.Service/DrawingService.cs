using System.Drawing;
using ImageStamper.Objects;

namespace ImageStamper.Service;

public class DrawingService
{
    public Graphics DrawStamp(
        Graphics imgGrphx,
        TypeSettingsArgs args
        )
    {
        imgGrphx.DrawString(args.Text, args.Font, args.Brush, args.Coordinates.X, args.Coordinates.Y);
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
