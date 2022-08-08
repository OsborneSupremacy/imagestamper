using System.Drawing;

namespace ImageStamper.Objects;

public record StampSizeArgs
{
    public StampSizeArgs(SizeF size, Graphics image, TypographyArgs typographyArgs)
    {
        Size = size;
        Image = image ?? throw new ArgumentNullException(nameof(image));
        TypographyArgs = typographyArgs ?? throw new ArgumentNullException(nameof(typographyArgs));
    }

    public SizeF Size { get; set; }

    public Graphics Image { get; set; }

    public TypographyArgs TypographyArgs { get; set; }
}
