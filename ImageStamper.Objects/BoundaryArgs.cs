using System.Drawing;

namespace ImageStamper.Objects;

public record BoundaryArgs
{
    public BoundaryArgs(SizeF imageSize, SizeF stampSize, float padPixels)
    {
        ImageSize = imageSize;
        StampSize = stampSize;
        PadPixels = padPixels;
    }

    public SizeF ImageSize { get; set; }

    public SizeF StampSize { get; set; }

    public float PadPixels { get; set; }
}
