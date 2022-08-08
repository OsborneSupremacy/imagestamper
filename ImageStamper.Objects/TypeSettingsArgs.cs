using System.Drawing;

namespace ImageStamper.Objects;

public record TypeSettingsArgs : TypographyArgs
{
    public TypeSettingsArgs(
        TypographyArgs original,
        Brush brush,
        Coordinates coordinates,
        Font newFont,
        SizeF stampSize
        ) : base(original)
    {
        Brush = brush;
        Coordinates = coordinates;
        Font = newFont;
        StampSize = stampSize;
    }

    public Brush Brush { get; set; }

    public Coordinates Coordinates { get; set; }

    public SizeF StampSize { get; set; }
}
