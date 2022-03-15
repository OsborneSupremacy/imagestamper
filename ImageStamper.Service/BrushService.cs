using System.Drawing;

namespace ImageStamper.Service
{
    public class BrushService
    {
        public SolidBrush GetSolidBrush(string colorName) => 
            new(GetBrushColor(colorName));

        protected Color GetBrushColor(string colorName) =>
            TryGetKnownColor(colorName) ?? GetColorFromHtml(colorName);

        protected Color? TryGetKnownColor(string colorName)
        {
            var color = Color.FromName(colorName);
            return color.IsKnownColor ? color : null;
        }

        protected Color GetColorFromHtml(string colorName) =>
            colorName.Contains("#")
                ? ColorTranslator.FromHtml(colorName)
                : ColorTranslator.FromHtml($"#{colorName}");
    }
}
