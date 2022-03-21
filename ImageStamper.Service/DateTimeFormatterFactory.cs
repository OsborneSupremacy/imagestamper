using System.Text;

namespace ImageStamper.Service
{
    public class DateTimeFormatterFactory
    {
        public Func<DateTime, string> Create(string dateFormat, bool includeTime, string timeFormat)
        {
            StringBuilder combinedFormat = new(dateFormat);
            if (includeTime && !string.IsNullOrWhiteSpace(timeFormat))
                combinedFormat.Append($" {timeFormat}");

            return (DateTime input) =>
            {
                return input.ToString(combinedFormat.ToString());
            };
        }
    }
}
