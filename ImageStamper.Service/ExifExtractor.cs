using System.Text;
using System.Drawing;

namespace ImageStamper.Service
{
    public class ExifExtractor
    {
        private const int _imageDatePropId = 36867;

        public async Task<DateTime?> ExtractDateAsync(string filePath)
        {
            var fileBytes = await File.ReadAllBytesAsync(filePath);

            using MemoryStream fileMs = new(fileBytes);
            using Image targetImage = Image.FromStream(fileMs);

            var propItem = targetImage.GetPropertyItem(_imageDatePropId);

            if (propItem?.Value == null) return null;

            string dateString = Encoding.UTF8.GetString(propItem.Value);

            int divider = dateString.IndexOf(" ");

            if(divider == -1) return null;

            string secondHalf = dateString[divider..];
            string firstHalf = dateString[..10]
                .Replace(":", "-");

            return DateTime.TryParse($"{firstHalf}{secondHalf}", out var dateOut) ? dateOut : null;
        }
    }
}
