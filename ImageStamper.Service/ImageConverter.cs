using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageStamper.Service;

public class ImageConverter
{
    public Graphics? BitmapToGraphics(Bitmap input)
    {
        try
        {
            var imgGrfx = Graphics.FromImage(input);
            imgGrfx.CompositingQuality = CompositingQuality.HighQuality;
            imgGrfx.SmoothingMode = SmoothingMode.HighQuality;
            imgGrfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            return imgGrfx;
        }
        catch (Exception)
        {
            return null;
        }
    }
}
