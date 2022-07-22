using System.Drawing;

namespace ImageStamper.Service
{
    public class StampSizeService
    {
        public (SizeF, Font) GetStampSize(
            SizeF imageSize,
            Graphics imgGrphx,
            string text,
            Font fontIn,
            int percentOfImage
            )
        {
            var fontSize = 1;

            var (size, fontOut) = MeasureStampSize(imgGrphx, text, fontIn, fontSize);

            var longestSide = imageSize.Height > imageSize.Width ? imageSize.Height : imageSize.Width;

            double targetWidth = longestSide * (percentOfImage / 100.0);

            // keep increasing font until the stamp satisfies target size
            while (size.Width < targetWidth)
            {
                var fontTemp = fontOut;
                (size, fontOut) = MeasureStampSize(imgGrphx, text, fontTemp, ++fontSize);
            }

            return (size, fontOut);
        }

        private (SizeF, Font) MeasureStampSize(Graphics imgGrphx, string text, Font font, int fontSize)
        {
            var newFont = new Font(font.FontFamily, fontSize, font.Style);
            return (imgGrphx.MeasureString(text, newFont), newFont);
        }
    }
}
