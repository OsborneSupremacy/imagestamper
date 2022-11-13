namespace ImageStamper.Objects;

public record FontArgs
{
    public FontArgs(
        Font font,
        PositionConstants position,
        int percentOfImage) 
    {
        Font = font ?? throw new ArgumentNullException(nameof(font));
        PercentOfImage = percentOfImage;
        Position = position;
    }

    public Font Font { get; set; }

    public int PercentOfImage { get; set; }

    public PositionConstants Position { get; set; }
}
