using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GeekBrainsCSharpBasics.ExtensionsLibrary
{
    public static class StringExtensions
    {
        private static readonly string[] DefaultSeparators = { ",", ".", "!", "?", ";", ":", " " };

        public static string OrderCharacters(this string value) =>
            new string(value.ToCharArray().OrderBy(character => character).ToArray());

        public static bool ComparePermutations(this string firstValue, string secondValue) =>
            firstValue.Length == secondValue.Length && firstValue.OrderCharacters() == secondValue.OrderCharacters();

        public static bool IsMatch(this string value, string pattern)
        {
            Regex regex = new Regex(pattern);
            return regex.IsMatch(value);
        }

        public static IEnumerable<string> GetMatchValues(this string value, string pattern)
        {
            List<string> values = new List<string>();
            foreach (Match match in GetMatchesCollection(value, pattern))
                values.Add(match.Value);

            return values;
        }

        public static IEnumerable<string> GetAllMatchGroupValues(this string value, string pattern)
        {
            List<string> values = new List<string>();
            foreach (Match match in GetMatchesCollection(value, pattern))
                for (int i = 1; i < match.Groups.Count; i++)
                    values.Add(match.Groups[i].Value);

            return values;
        }

        public static IEnumerable<string> GetWords(this string value) =>
            value.Split(DefaultSeparators, StringSplitOptions.RemoveEmptyEntries);

        private static MatchCollection GetMatchesCollection(string value, string pattern)
        {
            Regex regex = new Regex(pattern);
            return regex.Matches(value);
        }
    }
}
