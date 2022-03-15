using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageStamper.Service
{
    public class ImageConverter
    {
        public Graphics BitmapToGraphics(Bitmap bitmapIn)
        {
            var imgGrfx = Graphics.FromImage((Bitmap)bitmapIn.Clone());
            imgGrfx.CompositingQuality = CompositingQuality.HighQuality;
            imgGrfx.SmoothingMode = SmoothingMode.HighQuality;
            imgGrfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            return imgGrfx;
        }
    }
}
