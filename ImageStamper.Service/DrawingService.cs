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
        TypeSettingsArgs args
        )
    {
        imgGrphx.FillRectangle(Brushes.Black, args.Coordinates.X, args.Coordinates.Y, args.StampSize.Width, args.StampSize.Height);
        return imgGrphx;
    }

}
