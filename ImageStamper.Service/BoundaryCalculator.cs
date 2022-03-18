using ImageStamper.Objects;
using System.Drawing;

namespace ImageStamper.Service
{
    public class BoundaryCalculator
    {
        public Boundaries Calculate(
            SizeF imageSize,
            SizeF stampSize,
            float padPixels
            ) =>
            new()
            {
                Left = padPixels,
                XCenter = (imageSize.Width / 2) - (stampSize.Width / 2),
                Right = imageSize.Width - (stampSize.Width + padPixels),
                Top = padPixels,
                YCenter = (imageSize.Height / 2) - (stampSize.Height / 2),
                Bottom = imageSize.Height - (stampSize.Height + padPixels)
            };
    }
}
