using System.Drawing;

namespace ImageStamper.Objects;

public record ProcessArgs
{
    public ProcessArgs(
        Bitmap bitmap,
        Color color,
        bool backgroundFill,
        Font font,
        string text,
        PositionConstants position,
        int percentOfImage
        )
    {
        Bitmap = bitmap ?? throw new ArgumentNullException(nameof(bitmap));
        Color = color;
        BackgroundFill = backgroundFill;
        Font = font ?? throw new ArgumentNullException(nameof(font));
        Text = text ?? throw new ArgumentNullException(nameof(text));
        Position = position;
        PercentOfImage = percentOfImage;
    }

    public Bitmap Bitmap { get; set; }

    public Color Color { get; set; }

    public bool BackgroundFill { get; set; }

    public Font Font { get; set; }

    public string Text { get; set; }

    public PositionConstants Position { get; set; }

    public int PercentOfImage { get; set; }
}
