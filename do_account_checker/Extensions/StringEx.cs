using System;
using System.Text.RegularExpressions;

namespace do_account_checker.Extensions
{
    static class StringEx
    {
        public static string RegExp(this string value, string regex)
        {
            var result = string.Empty;
            var match = Regex.Match(value, regex, RegexOptions.Multiline);
            if (match.Groups.Count > 1)
            {
                result = match.Groups[1].Value;
            }
            return result;
        }

        public static string GetBetween(this string value, string start, string end)
        {
            var result = string.Empty;
            var length = start.Length;
            var startIndex = value.IndexOf(start, 0, StringComparison.Ordinal);
            var endIndex = value.IndexOf(end, startIndex + length, StringComparison.Ordinal);
            if (startIndex != -1 && endIndex != -1)
            {
                result = value.Substring(startIndex + length, endIndex - (startIndex + length));
            }
            return result;
        }
    }
}
