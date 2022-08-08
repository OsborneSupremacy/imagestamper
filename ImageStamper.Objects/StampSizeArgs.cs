using System.Drawing;

namespace ImageStamper.Objects;

public record StampSizeArgs
{
    public StampSizeArgs(SizeF size, Graphics image, FontArgs fontArgs)
    {
        Size = size;
        Image = image ?? throw new ArgumentNullException(nameof(image));
        FontArgs = fontArgs ?? throw new ArgumentNullException(nameof(fontArgs));
    }

    public SizeF Size { get; set; }

    public Graphics Image { get; set; }

    public FontArgs FontArgs { get; set; }
}
