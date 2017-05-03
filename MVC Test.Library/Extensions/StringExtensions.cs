using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Test.Library.Extensions
{
    public static class StringExtensions
    {
        public static string TrimEnd(this string value, string endValue)
        {
            if (value.EndsWith(endValue))
            {
                value = value.Remove(value.Length - endValue.Length, endValue.Length);
            }

            return value;
        }

        public static string TrimQuotes(this string input)
        {
            return input == null ? null : input.Trim('\'', '\"');
        }

        public static string TrimStart(this string value, string startValue)
        {
            if (value.StartsWith(startValue))
            {
                value = value.Remove(0, startValue.Length);
            }

            return value;
        }

        /// <summary>
        /// Substring at whole words only. returns the actual length that was taken as actualLength
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string SubStringSafe(this string source, int startIndex, int length = -1)
        {
            if (startIndex < 0)
            {
                return source;
            }

            if (length < 0)
            {
                return source.Substring(startIndex);
            }

            if (startIndex + length > source.Length)
            {
                return source;
            }

            return source.Substring(startIndex, length);

        }

    }
}
