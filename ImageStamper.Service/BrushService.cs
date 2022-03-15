using System.Drawing;

namespace ImageStamper.Service
{
    public class BrushService
    {
        public SolidBrush GetSolidBrush(string colorName) => 
            new(GetBrushColor(colorName));

        protected Color GetBrushColor(string colorName)
        {
            var brushColor = Color.FromName(colorName);
            if(brushColor.IsKnownColor) return brushColor;

            return colorName.Contains("#")
                ? ColorTranslator.FromHtml(colorName)
                : ColorTranslator.FromHtml($"#{colorName}");
        }
    }
}
