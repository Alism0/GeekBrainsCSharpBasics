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
            do
            {
                Console.WriteLine($"Нажмите Enter для выхода из приложения");

                int currentLine = Console.CursorTop;
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                    Environment.Exit(0);

                Console.SetCursorPosition(0, currentLine);
            }
            while (true);
        }
    }
}
