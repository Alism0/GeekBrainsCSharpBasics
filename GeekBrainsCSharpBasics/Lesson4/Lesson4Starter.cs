using GeekBrainsCSharpBasics.ArraysLibrary;
using System;
using System.Collections.Generic;
using System.IO;

namespace GeekBrainsCSharpBasics.Lesson4
{
    public sealed class Lesson4Starter : ExerciseStarter
    {
        private readonly static Lesson4Starter _starter = new Lesson4Starter();

        public static Lesson4Starter Instance => _starter;

        #region Функции запуска заданий

        protected override Dictionary<Exercise, Action> LessonExercises => new Dictionary<Exercise, Action>() {
            { Exercise.Exercise1, () => ExercisesHelper.CountPairs() },
            { Exercise.Exercise2, () => RunExercise2() },
            { Exercise.Exercise3, () => ArraysStarter.RunCustomArrayOperations() },
            { Exercise.Exercise4, () => RunExercise4() },
            { Exercise.Exercise5, () => ArraysStarter.RunTwoDimensionsArrayOperations() },
            { Exercise.Exit, () => ConsoleManager.CloseApplication() }
        };

        #endregion

        private Lesson4Starter()
        {
            int[] array = ArraysHelper.CreateRandomValuesArray(10, -10, 10);
            DataHelper.SaveIntoFile(array.ConvertToStrings(), DataHelper.ArrayFilePath);
        }

        private static void RunExercise2()
        {
            do
            {
                Console.Clear();
                try
                {
                    int[] array = DataHelper.LoadFromFile(DataHelper.ArrayFilePath).ConvertToIntegers();
                    ExercisesHelper.CountPairs(array);
                    return;
                }
                catch (FileNotFoundException exeption)
                {
                    Console.WriteLine(exeption.Message);
                }
                catch (NotNumberException exeption)
                {
                    Console.WriteLine(exeption.Message);
                }
            } while (ConsoleManager.ReadKeyYesNoValue("Попробовать еще раз? (Y/N): "));
        }

        private static void RunExercise4()
        {
            string[] loginData = DataHelper.LoadFromFile(DataHelper.LoginDataFilePath);
            if (loginData.Length == 2)
            {
                UserFormHelper.Login(new Account() { Login = loginData[0], Password = loginData[1] });
                return;
            }
            Console.WriteLine("Нет зарегестрированных пользователей!");
            Console.WriteLine("Задание будет завершено");
        }
    }
}
