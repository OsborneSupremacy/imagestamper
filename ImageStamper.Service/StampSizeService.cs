using System.Drawing;

namespace ImageStamper.Service
{
    public class StampSizeService
    {
        public SizeF GetStampSize(
            Graphics imgGrphx,
            string text,
            Font font,
            double targetWidth
            )
        {
            int fontSize = 1; // in ems
            var size = imgGrphx.MeasureString(text, font);

            // keep increasing font until the stamp satisfies target size
            while (size.Width < targetWidth)
            {
                using var newfont = new Font(font.FontFamily, fontSize, FontStyle.Bold);
                size = imgGrphx.MeasureString(text, font);
            }

            return size;
        }
    }
}
