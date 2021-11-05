using System;

namespace GeekBrainsCSharpBasics.Lesson1.Exercise1
{
    public class UserFormService
    {
        private const string PrintOutputTemplate = "{0}{1}{2}{3}{4}";

        public void RunUserForm(OutputConcatenationKinds concatenationKind)
        {
            Human human = new Human();

            SetFontColorByConcatenationKind(concatenationKind);
            human.PrintDescription();
            human.InputData();

            Console.WriteLine();
            Console.WriteLine($"Вывод данных о пользователе:");

            switch (concatenationKind)
            {
                case OutputConcatenationKinds.Concatenation:
                    PrintConcatenationOutput(human);
                    break;
                case OutputConcatenationKinds.Format:
                    PrintFormatOutput(human);
                    break;
                default:
                    PrintInterpolationOutput(human);
                    break;
            }

            ConsoleHelper.PauseAndClear();
            Console.ResetColor();
        }

        private static void PrintConcatenationOutput(Human human) =>
            Console.WriteLine(human.Name + human.Surname + human.Age.ToString() + human.Height.ToString() + human.Weight.ToString("#.#"));

        private static void PrintFormatOutput(Human human) =>
            Console.WriteLine(PrintOutputTemplate, human.Name, human.Surname, human.Age.ToString(), human.Height.ToString(), human.Weight.ToString("#.#"));

        private static void PrintInterpolationOutput(Human human)
        {
            string name = $"{human.FormatPropertyValue(nameof(human.Name))}{Environment.NewLine}";
            string surname = $"{human.FormatPropertyValue(nameof(human.Surname))}{Environment.NewLine}";
            string age = $"{human.FormatPropertyValue(nameof(human.Age))}{Environment.NewLine}";
            string height = $"{human.FormatPropertyValue(nameof(human.Height))}{Environment.NewLine}";
            string weight = $"{human.FormatPropertyValue(nameof(human.Weight))}";

            Console.WriteLine($"{name}{surname}{age}{height}{weight}");
        }

        private static void SetFontColorByConcatenationKind(OutputConcatenationKinds concatenationKind)
        {
            switch (concatenationKind)
            {
                case OutputConcatenationKinds.Interpolation:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
            }
        }
    }
}
