using System;

namespace GeekBrainsCSharpBasics.Lesson1
{
    public static class Lesson1Helper
    {
        public static void RunExercise1()
        {
            Console.WriteLine("Выберите тип анкеты:");
            PrintOutputType(Lesson11OutputTypes.Concatenation);
            PrintOutputType(Lesson11OutputTypes.Format);
            PrintOutputType(Lesson11OutputTypes.Interpolation);

            int outputChoice = default;
            outputChoice = outputChoice.InputValue();

            while (!Enum.IsDefined(typeof(Lesson11OutputTypes), outputChoice))
            {
                Console.WriteLine("Незарегестрированный тип анкеты");
                outputChoice = outputChoice.InputValue();
            }

            Console.Clear();
            UserFormService userFormService = new UserFormService();

            userFormService.RunUserForm((Lesson11OutputTypes)outputChoice);
        }

        private static void PrintOutputType(Lesson11OutputTypes outputType) =>
            Console.WriteLine($"{(int)outputType}. {outputType}");
    }
}
