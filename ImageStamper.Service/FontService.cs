using System.Drawing;

namespace ImageStamper.Service
{
    public class FontService
    {
        public Font Get(string fontFamily) =>
            new(fontFamily, 1, FontStyle.Bold);
    }
}
