using System;

namespace GeekBrainsCSharpBasics
{
    public static class ConsoleHelper
    {
        public static void Pause()
        {
            int currentLine = Console.CursorTop;
            Console.ReadKey();
            Console.SetCursorPosition(0, currentLine);
        }

        public static void PauseAndClear()
        {
            Pause();
            Console.Clear();
        }

        public static void CloseApplication()
        {
            if (ReadKeyYesNoValue("Закрыть приложение? (Y/N): "))
                Environment.Exit(0);
        }

        public static bool ReadKeyEnter(string message)
        {
            do
            {
                Console.WriteLine(message);
                int currentLine = Console.CursorTop;
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                    return true;

                Console.SetCursorPosition(0, currentLine);
            }
            while (true);
        }

        public static void PrintEnumContent(this Type enumType)
        {
            Array enumValues = Enum.GetValues(enumType);

            foreach (object enumValue in enumValues)
            {
                PrintItem((int)enumValue, enumValue.ToString());
            }
        }

        public static void PrintItem(int number, string description) =>
            Console.WriteLine($"{number}. {description}");

        public static int ReadlineIntValue()
        {
            IntValue value = new IntValue();
            value.InputData();
            return value.Value;
        }

        public static bool ReadKeyYesNoValue(string message)
        {
            Console.Write(message);
            int currentLine = Console.CursorTop;
            do
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Y:
                        Console.WriteLine();
                        return true;
                    case ConsoleKey.N:
                        Console.WriteLine();
                        return false;
                    default:
                        Console.SetCursorPosition(0, currentLine);
                        break;
                }
            }
            while (true);
        }

        public static void PrintByCenter(string value)
        {
            Console.SetCursorPosition((Console.WindowWidth - value.Length) / 2, Console.CursorTop);
            Console.WriteLine(value);
        }
    }
}
