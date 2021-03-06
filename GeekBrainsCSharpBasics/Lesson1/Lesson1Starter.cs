using GeekBrainsCSharpBasics.Lesson1.Exercise1;
using GeekBrainsCSharpBasics.Lesson1.Exercise2;
using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics.Lesson1
{
    public sealed class Lesson1Starter : ExerciseStarter
    {
        #region Функции запуска заданий

        protected override Dictionary<Exercises, Action> Exercises => new Dictionary<Exercises, Action>() {
            { GeekBrainsCSharpBasics.Exercises.Exercise1, () => RunExercise1() },
            { GeekBrainsCSharpBasics.Exercises.Exercise2, () => RunExercise2() },
            { GeekBrainsCSharpBasics.Exercises.Exercise3, () => RunExercise3() },
            { GeekBrainsCSharpBasics.Exercises.Exercise4, () => RunExercise4() },
            { GeekBrainsCSharpBasics.Exercises.Exercise5, () => RunExercise5() }
        };

        #endregion

        private static void RunExercise1()
        {
            Console.WriteLine("Выберите тип анкеты:");
            ConsoleHelper.PrintEnumContent(typeof(OutputConcatenationKinds));

            int outputConcatenationKind = default;
            outputConcatenationKind = outputConcatenationKind.InputEnum<OutputConcatenationKinds>();

            Console.Clear();
            UserFormService userFormService = new UserFormService();

            userFormService.RunUserForm((OutputConcatenationKinds)outputConcatenationKind);
        }

        private static void RunExercise2() =>
            Console.WriteLine($"{Environment.NewLine}ИМТ равен: {HumanMeasurementsHelper.GetBodyMassIndex():#.##}{Environment.NewLine}");

        private static void RunExercise3()
        {
            Console.WriteLine("Расчет расстояния между 2 точками");
            Console.WriteLine();

            Console.WriteLine("Введите координаты первой точки:");
            Point point1 = new Point();
            point1.InputData();

            Console.WriteLine("Введите координаты второй точки:");
            Point point2 = new Point();
            point2.InputData();

            double distance = FormulasHelper.CalculateTwoPointsDistance(point1, point2);

            Console.WriteLine();
            Console.WriteLine($"Расстояние между точками: {distance:#.##}");
            Console.WriteLine();
        }

        private static void RunExercise4()
        {
            Console.WriteLine("Перестановка чисел местами");
            Console.WriteLine();

            Console.WriteLine("Введите первое число: ");
            int intValue1 = ConsoleHelper.ReadlineIntValue();
            Console.WriteLine("Введите второе число: ");
            int intValue2 = ConsoleHelper.ReadlineIntValue();

            FormulasHelper.Rearrangement(ref intValue1, ref intValue2);

            Console.WriteLine();
            Console.WriteLine($"Результат перстановки");
            Console.WriteLine();
            Console.WriteLine($"Значение первого числа равно: {intValue1}");
            Console.WriteLine($"Значение второго числа равно: {intValue2}");
            Console.WriteLine();
        }

        private static void RunExercise5()
        {
            ConsoleHelper.PrintByCenter(MyPersonDataConstants.Name);
            ConsoleHelper.PrintByCenter(MyPersonDataConstants.Surname);
            ConsoleHelper.PrintByCenter(MyPersonDataConstants.City);

            ConsoleHelper.PauseAndClear();
        }
    }
}
