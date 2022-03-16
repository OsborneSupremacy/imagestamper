using ImageStamper.Objects;

namespace ImageStamper.Service
{
    public class BoundaryCalculator
    {
        public Boundaries Calculate(
            float imageWidth,
            float imageHeight,
            float stampWidth,
            float stampHeight,
            float padPixels
            ) =>
            new()
            {
                Left = padPixels,
                XCenter = (imageWidth / 2) - (stampWidth / 2),
                Right = imageWidth - (stampWidth + padPixels),
                Top = padPixels,
                YCenter = (imageHeight / 2) - (stampHeight / 2),
                Bottom = imageHeight - (stampHeight + padPixels)
            };
    }
}
