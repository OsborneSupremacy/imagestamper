using System.Drawing;

namespace ImageStamper.Objects;

public record TypographyArgs : FontArgs
{
    public TypographyArgs(
        Font font,
        string text,
        PositionConstants position,
        int percentOfImage
        ) : base(font, position, percentOfImage)
    {
        Text = text ?? throw new ArgumentNullException(nameof(text));
    }

    public TypographyArgs(
        FontArgs original,
        string text
        ) : base(original)
    {
        Text = text ?? throw new ArgumentNullException(nameof(text));
    }

    public string Text { get; set; }
}
