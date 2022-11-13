namespace ImageStamper.Objects;

public record ProcessArgs
{
    public ProcessArgs(Bitmap bitmap, Color color, bool backgroundFill, TypographyArgs typographyArgs)
    {
        Bitmap = bitmap ?? throw new ArgumentNullException(nameof(bitmap));
        Color = color;
        BackgroundFill = backgroundFill;
        TypographyArgs = typographyArgs ?? throw new ArgumentNullException(nameof(typographyArgs));
    }

    public Bitmap Bitmap { get; set; }

    public Color Color { get; set; }

    public bool BackgroundFill { get; set; }

    public TypographyArgs TypographyArgs { get; set; }
}
