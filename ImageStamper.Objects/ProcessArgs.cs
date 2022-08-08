using System.Drawing;

namespace ImageStamper.Objects;

public record ProcessArgs
{
    public ProcessArgs(Bitmap bitmap, Color color, bool backgroundFill, FontArgs fontArgs)
    {
        Bitmap = bitmap ?? throw new ArgumentNullException(nameof(bitmap));
        Color = color;
        BackgroundFill = backgroundFill;
        FontArgs = fontArgs ?? throw new ArgumentNullException(nameof(fontArgs));
    }

    public Bitmap Bitmap { get; set; }

    public Color Color { get; set; }

    public bool BackgroundFill { get; set; }

    public FontArgs FontArgs { get; set; }
}
