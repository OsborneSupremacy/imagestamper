namespace ImageStamper.Service;

public class StampSizeService
{
    public (SizeF, Font) GetStampSize(StampSizeArgs args)
    {
        var fontSize = 1;

        var (size, fontOut) = MeasureStampSize(args.Image, args.TypographyArgs.Text, args.TypographyArgs.Font, fontSize);

        var longestSide = args.Size.Height > args.Size.Width ? args.Size.Height : args.Size.Width;

        double targetWidth = longestSide * (args.TypographyArgs.PercentOfImage / 100.0);

        // keep increasing font until the stamp satisfies target size
        while (size.Width < targetWidth)
        {
            var fontTemp = fontOut;
            (size, fontOut) = MeasureStampSize(args.Image, args.TypographyArgs.Text, fontTemp, ++fontSize);
        }

        return (size, fontOut);
    }

    private (SizeF, Font) MeasureStampSize(Graphics imgGrphx, string text, Font font, int fontSize)
    {
        var newFont = new Font(font.FontFamily, fontSize, font.Style);
        return (imgGrphx.MeasureString(text, newFont), newFont);
    }
}
