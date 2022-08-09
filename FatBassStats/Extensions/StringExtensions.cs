using System;

namespace com.FatBassStats.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns the word count for the supplied string value.
        /// NOTE: The string will be split using the default ' ', '\r', '\n' delimiters
        /// </summary>
        /// <param name="value">The string value to run the word count against</param>
        /// <returns>Int value of the total word count OR 0 if null or empty</returns>
        public static int WordCount(this string value) => value.WordCount(new[] { ' ', '\r', '\n' });

        /// <summary>
        /// Returns the word count for the supplied string value. 
        /// </summary>
        /// <param name="value">The string value to run the word count against</param>
        /// <param name="delimiters">Char array containing the delimiters to use when splitting the supplied value</param>
        /// <returns>Int value of the total word count OR 0 if null or empty</returns>
        public static int WordCount(this string value, char[] delimiters) =>
            string.IsNullOrEmpty(value)
                ? 0
                : value.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;

        /// <summary>
        /// Uri Escapes the string value.
        /// </summary>
        /// <param name="value">The string value to escape</param>
        /// <returns>A Uri.EscapeDataString value</returns>
        public static string UriEscapeDataString(this string value) => Uri.EscapeDataString(value);
    }
}
