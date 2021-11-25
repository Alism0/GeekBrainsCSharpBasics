namespace GeekBrainsCSharpBasics.Lesson5
{
    public enum MessageOperation
    {
        [MenuDescription("Завершить работу с сообщением", 5)]
        Exit = 0,

        [MenuDescription("Вывести слова, содержащие не более заданного количества букв", 1)]
        PrintMessageWordsLessThenRestrictionLength = 1,

        [MenuDescription("Удалить слова, заканчивающиеся на заданный символ", 2)]
        RemoveEndingOnRestrictionCharacterMessageWords = 2,

        [MenuDescription("Вывести самое длинное слово", 3)]
        PrintMaxLengthMessageWord = 3,

        [MenuDescription("Вывести самые длинные слова", 4)]
        PrintMaxLengthMessageWords = 4
    }
}
