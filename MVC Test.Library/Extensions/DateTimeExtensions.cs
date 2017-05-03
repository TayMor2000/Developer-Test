using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Test.Library.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToDisplayDateTime(this DateTime source)
        {
            if (source.Date == DateTime.Today)
            {
                return source.ToString("HH:mm");
            }
            else if (source.Date > DateTime.Today.AddDays(-1))
            {
                return source.ToString("ddd HH:mm");
            }
            else
            {
                return source.ToString("dd/MMM/yy HH:mm");
            }
        }

        public static DateTime ConvertToTimeZone(this DateTime source, TimeZoneInfo destinationTimeZone)
        {
            var utcDateTime = DateTime.SpecifyKind(source, DateTimeKind.Utc);
            return TimeZoneInfo.ConvertTime(utcDateTime, TimeZoneInfo.Utc, destinationTimeZone);
        }

        public static DateTime? ConvertToTimeZone(this DateTime? source, TimeZoneInfo destinationTimeZone)
        {
            return source == null
                ? (DateTime?)null
                : source.Value.ConvertToTimeZone(destinationTimeZone);
        }

    }
}
