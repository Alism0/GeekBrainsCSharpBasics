using GeekBrainsCSharpBasics.ExtensionsLibrary;
using GeekBrainsCSharpBasics.InputDataLibrary;
using System;

namespace GeekBrainsCSharpBasics.Lesson5
{
    public static class MessageHelper
    {
        public static void RunMessageOperations()
        {
            Console.WriteLine("Работа с сообщением");
            Console.WriteLine();
            Console.WriteLine("Введите сообщение:");
            string message = Console.ReadLine();
            Console.WriteLine();

            bool isCompletion = false;
            string result = null;
            do
            {
                Console.Write("Доступные операции:");
                Console.WriteLine();

                MessageOperation operation = ConsoleManager.InputMenuItems(EnumExtensions.GetValuesWithAttribute<MessageOperation, MenuDescriptionAttribute>());
                Console.WriteLine();

                switch (operation)
                {
                    case MessageOperation.PrintMessageWordsLessThenRestrictionLength:
                        int restrictionLength = ConsoleManager.ReadlineNonZeroPositiveIntValue("Введите количество букв: ");
                        result = string.Join(" ", Message.GetWordsLessThenRestrictionLength(message, restrictionLength));
                        break;
                    case MessageOperation.RemoveEndingOnRestrictionCharacterMessageWords:
                        char restrictionLetter = ConsoleManager.ReadKeyLetter("Введите букву: ");
                        result = Message.RemoveEndingOnRestrictionCharacterWords(message, restrictionLetter);
                        break;
                    case MessageOperation.PrintMaxLengthMessageWord:
                        result = Message.GetMaxLengthWord(message);
                        Console.WriteLine();
                        break;
                    case MessageOperation.PrintMaxLengthMessageWords:
                        result = Message.GetMaxLengthWordsMessage(message);
                        break;
                    default:
                        if (ConsoleManager.ReadKeyYesNoValue("Завершить работу с сообщением?: (Y/N) "))
                            isCompletion = true;
                        break;
                }
                if (!isCompletion)
                {
                    Console.WriteLine();
                    Console.WriteLine("Результат операции: ");
                    Console.WriteLine(result);
                    Console.WriteLine();
                    Console.WriteLine($"Сообщение: {message}");
                    Console.WriteLine();
                }
            } while (!isCompletion);
        }
    }
}
