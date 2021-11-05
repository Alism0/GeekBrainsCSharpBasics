using GeekBrainsCSharpBasics.Lesson1.Exercise1;
using System;

namespace GeekBrainsCSharpBasics.Lesson1
{
    public static class Lesson1Starter
    {
        #region Задание 1

        /// <summary>
        /// Запускает задание 1
        /// </summary>
        public static void RunExercise1()
        {
            Console.WriteLine("Выберите тип анкеты:");
            PrintOutputType(OutputConcatenationKinds.Concatenation);
            PrintOutputType(OutputConcatenationKinds.Format);
            PrintOutputType(OutputConcatenationKinds.Interpolation);

            int outputConcatenationKind = default;
            outputConcatenationKind = outputConcatenationKind.InputValue();

            while (!Enum.IsDefined(typeof(OutputConcatenationKinds), outputConcatenationKind))
            {
                Console.WriteLine("Незарегистрированный тип анкеты");
                outputConcatenationKind = outputConcatenationKind.InputValue();
            }

            Console.Clear();
            UserFormService userFormService = new UserFormService();

            userFormService.RunUserForm((OutputConcatenationKinds)outputConcatenationKind);
        }

        #endregion

        #region Вспомогательные методы

        private static void PrintOutputType(OutputConcatenationKinds outputType) =>
            Console.WriteLine($"{(int)outputType}. {outputType}");

        #endregion
    }
}
