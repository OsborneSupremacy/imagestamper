namespace ImageStamper.Service
{
    public class StampTextComposer
    {
        public string Compose(
            DateTime date,
            string dateFormat,
            bool includeTime,
            DateTime time,
            string timeFormat
            )
        {
            var dateString = date.ToString(dateFormat);
            if (includeTime && !string.IsNullOrWhiteSpace(timeFormat))
                return $"{dateString} {time.ToString(timeFormat)}";
            return dateString;
        }
    }
}
