using GeekBrainsCSharpBasics.ArraysLibrary;
using System;
using System.Collections.Generic;
using System.IO;

namespace GeekBrainsCSharpBasics.Lesson5
{
    public sealed class Lesson5Starter : ExerciseStarter
    {
        private readonly static Lesson5Starter _starter = new Lesson5Starter();

        public static Lesson5Starter Instance => _starter;

        #region Функции запуска заданий

        protected override Dictionary<Exercise, Action> LessonExercises => new Dictionary<Exercise, Action>() {
            { Exercise.Exercise1, () => UserFormHelper.Registration() },
            { Exercise.Exercise2, () => MessageHelper.RunMessageOperations() },
            { Exercise.Exercise3, () => RunExercise3() },
            { Exercise.Exercise4, () => StudentGradeExecutor.CongratulateWorstScoreWinners() },
            { Exercise.Exit, () => ConsoleManager.CloseApplication() }
        };

        #endregion

        private Lesson5Starter()
        {
            int[] array = ArraysHelper.CreateRandomValuesArray(10, -10, 10);
            DataHelper.SaveIntoFile(array.ConvertToStrings(), DataHelper.ArrayFilePath);
        }

        private static void RunExercise3()
        {
            Console.WriteLine("Сравнение перестановок строк");
            Console.WriteLine();

            Console.WriteLine("Введите 1-ую строку:");
            string firstValue = Console.ReadLine();
            Console.WriteLine("Введите 2-ую строку:");
            string secondValue = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Результат:");
            Console.WriteLine(firstValue.ComparePermutations(secondValue) ? "Перестановки равны" : "Перестановки не равны");
        }
    }
}
