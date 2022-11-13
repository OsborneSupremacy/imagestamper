namespace ImageStamper.Service;

public class BoundaryCalculator
{
    public Boundaries Calculate(BoundaryArgs args) =>
        new()
        {
            Left = args.PadPixels,
            XCenter = (args.ImageSize.Width / 2) - (args.StampSize.Width / 2),
            Right = args.ImageSize.Width - (args.StampSize.Width + args.PadPixels),
            Top = args.PadPixels,
            YCenter = (args.ImageSize.Height / 2) - (args.StampSize.Height / 2),
            Bottom = args.ImageSize.Height - (args.StampSize.Height + args.PadPixels)
        };
}
