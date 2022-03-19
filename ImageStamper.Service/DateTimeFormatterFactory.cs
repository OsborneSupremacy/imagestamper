using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageStamper.Service
{
    public class DateTimeFormatterFactory
    {
        public Func<DateTime, DateTime, string> Create(string dateFormat, bool includeTime, string timeFormat)
        {
            StringBuilder combinedFormat = new(dateFormat);
            if(includeTime)
                combinedFormat.Append($" {timeFormat}");

            return (DateTime dateInput, DateTime timeInput) => {

                StringBuilder result = new(dateInput.ToString(dateFormat));

                if(includeTime && !string.IsNullOrWhiteSpace(timeFormat))
                {
                    result.Append(" ");
                    result.Append(timeInput.ToString(timeFormat));
                }

                return result.ToString();
            };
        }
    }
}
