using System;

namespace GeekBrainsCSharpBasics.Lesson1
{
    public class UserFormService
    {
        private const string PrintOutputTemplate = "{0}{1}{2}{3}{4}";

        public void RunUserForm(Lesson11OutputTypes outputTypes)
        {
            Human human = new Human();

            SetColorByOutputType(outputTypes);

            human.InputData();

            Console.WriteLine();
            Console.WriteLine($"Вывод данных о пользователе:");

            switch (outputTypes)
            {
                case Lesson11OutputTypes.Concatenation:
                    PrintConcatenationOutput(human);
                    break;
                case Lesson11OutputTypes.Format:
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
            string name = $"{human.GetValueWithDescription(nameof(human.Name))}{Environment.NewLine}";
            string surname = $"{human.GetValueWithDescription(nameof(human.Surname))}{Environment.NewLine}";
            string age = $"{human.GetValueWithDescription(nameof(human.Age))}{Environment.NewLine}";
            string height = $"{human.GetValueWithDescription(nameof(human.Height))}{Environment.NewLine}";
            string weight = $"{human.GetValueWithDescription(nameof(human.Weight))}";

            Console.WriteLine($"{name}{surname}{age}{height}{weight}");
        }

        private static void SetColorByOutputType(Lesson11OutputTypes outputTypes)
        {
            switch (outputTypes)
            {
                case Lesson11OutputTypes.Interpolation:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
            }
        }
    }
}
