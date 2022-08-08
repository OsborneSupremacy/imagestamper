using System.Drawing;

namespace ImageStamper.Objects;

public record TypeSettingsArgs : TypographyArgs
{
    public TypeSettingsArgs(
        TypographyArgs original,
        Brush brush,
        Coordinates coordinates,
        Font newFont
        ) : base(original)
    {
        Brush = brush;
        Coordinates = coordinates;
        Font = newFont;
    }

    public Brush Brush { get; set; }

    public Coordinates Coordinates { get; set; }
}
