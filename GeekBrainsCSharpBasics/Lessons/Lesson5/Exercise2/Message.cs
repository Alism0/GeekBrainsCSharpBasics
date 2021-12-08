using GeekBrainsCSharpBasics.ExtensionsLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeekBrainsCSharpBasics.Lesson5
{
    public static class Message
    {
        public static IEnumerable<string> GetWordsLessThenRestrictionLength(string message, int restrictionLength) =>
            message.GetMatchValues($"\\b[A-Za-zА-Яа-я]{{1,{restrictionLength}}}\\b");

        public static string RemoveEndingOnRestrictionCharacterWords(string message, char restrictionCharacter)
        {
            GetEndingOnRestrictionCharacterWords(message, restrictionCharacter).ToList()
                .ForEach(word => message = message.Replace(word, ""));

            return message;
        }

        public static string GetMaxLengthWord(string message) =>
            GetMaxLengthWords(message).FirstOrDefault();

        public static string GetMaxLengthWordsMessage(string message)
        {
            StringBuilder maxLengthWord = new StringBuilder();

            GetMaxLengthWords(message).ToList()
                .ForEach(word => maxLengthWord.Append(word));

            return maxLengthWord.ToString();
        }

        private static IEnumerable<string> GetEndingOnRestrictionCharacterWords(string message, char restrictionCharacter) =>
            message.GetWords().Where(word => word[word.Length - 1].Equals(restrictionCharacter));

        private static IEnumerable<string> GetMaxLengthWords(string message) =>
            message.GetWords()
            .GroupBy(group => group.Length)
            .OrderByDescending(group => group.Key)
            .First();
    }
}
