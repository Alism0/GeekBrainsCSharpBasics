using System;
using System.Collections.Generic;
using System.Linq;

namespace GeekBrainsCSharpBasics.Lesson2
{
    public sealed class Lesson2Starter : ExerciseStarter
    {
        private const int NumberCount = 3;
        private const int AuthenticationAttemptsCount = 3;
        private const int MinGoodNumber = 0;
        private const int MaxGoodNumber = 1_000_000_000;

        private readonly static Lesson2Starter _starter = new Lesson2Starter();

        private readonly static AuthenticationForm _authenticationForm = new AuthenticationForm
        {
            Login = "root",
            Password = "GeekBrains"
        };

        public static Lesson2Starter Instance => _starter;

        #region Функции запуска заданий

        protected override Dictionary<Exercise, Action> LessonExercises => new Dictionary<Exercise, Action>() {
            { Exercise.Exercise1, () => RunExercise1() },
            { Exercise.Exercise2, () => RunExercise2() },
            { Exercise.Exercise3, () => ExercisesHelper.GetPositiveOddNumbersSum() },
            { Exercise.Exercise4, () => RunExercise4() },
            { Exercise.Exercise5, () => RunExercise5() },
            { Exercise.Exercise6, () => RunExercise6() },
            { Exercise.Exercise7, () => RunExercise7() },
            { Exercise.Exit, () => ConsoleHelper.CloseApplication() }
        };

        #endregion

        private Lesson2Starter() { }

        private static void RunExercise1()
        {
            Console.WriteLine($"Получение минимального значения из трех введеных чисел{Environment.NewLine}");
            Console.WriteLine($"Введите {NumberCount} числа:");

            List<int> numbers = new List<int>(NumberCount);
            for (int i = 1; i <= NumberCount; i++)
            {
                Console.WriteLine($"Введите {i}-ое число:");
                numbers.Add(ConsoleHelper.ReadlineIntValue());
            }
            Console.WriteLine($"Минимальное значение из трех чисел: {CalculationHelper.GetMinValue(numbers.ToArray())}");
        }

        private static void RunExercise2()
        {
            Console.WriteLine($"Подсчет количества цифр в числе{Environment.NewLine}");

            Console.WriteLine($"Введите число:");
            int number = ConsoleHelper.ReadlineIntValue();

            Console.WriteLine($"Количество цифр в числе {number}: {CalculationHelper.GetDigits(number).Length}");
        }

        private static void RunExercise4()
        {
            Console.WriteLine($"Форма авторизации{Environment.NewLine}");

            AuthenticationForm authenticationForm = new AuthenticationForm();
            int attemtsCount = 0;
            do
            {
                authenticationForm.InputData();
                if (authenticationForm.Equals(_authenticationForm))
                {
                    Console.WriteLine("Добро пожаловать, падаван!");
                    return;
                }

                attemtsCount++;
                if (attemtsCount < AuthenticationAttemptsCount)
                    Console.WriteLine($"Введен неверный логин/пароль. Осталось попыток: {AuthenticationAttemptsCount - attemtsCount}");
            } while (attemtsCount < AuthenticationAttemptsCount);

            Console.WriteLine("Превышено количество попыток входа");
        }

        private static void RunExercise5()
        {
            Console.WriteLine("Анализ ИМТ");
            BodyMassIndexAnalysisInfo bodyMassIndexInfo = HumanMeasurementsHelper.GetBodyMassIndexAnalysisInfo();

            Console.WriteLine($"ИМТ равен: {bodyMassIndexInfo.BodyMassIndex:#.##}");
            Console.WriteLine($"Результаты анализа:{Environment.NewLine}{bodyMassIndexInfo.AnalysisResult}");
        }

        private static void RunExercise6()
        {
            Console.WriteLine($"Подсчет \"хороших\" чисел от {MinGoodNumber} до {MaxGoodNumber}");
            Stopwatch stopwatch = Stopwatch.GetStopwatch();

            if (!ConsoleHelper.ReadKeyYesNoValue("Запустить подсчет? (Y/N): "))
            {
                Console.WriteLine("Подсчет \"хороших\" чисел отменен");
                return;
            }


            Console.WriteLine("Идет подсчет \"хороших\" чисел. Подождите");

            int goodNumbersCount = 0;

            stopwatch.Start();
            int sum;
            for (int i = MinGoodNumber; i < MaxGoodNumber; i++)
            {
                int[] digits = CalculationHelper.GetDigits(i);
                sum = digits.Sum();
                if (sum != 0 && i % sum == 0)
                    goodNumbersCount++;
            }
            string totalSeconds = stopwatch.Stop();

            Console.WriteLine($"Подсчет завершен. Количество \"хороших\" чисел: {goodNumbersCount}");
            Console.WriteLine($"Прошло времени: {totalSeconds} сек");
        }

        private static void RunExercise7()
        {
            Console.WriteLine($"Рекурсивный подсчет суммы чисел в диапазоне{Environment.NewLine}");

            Console.WriteLine("Введите значение первой границы: ");
            int firstRangeBorder = ConsoleHelper.ReadlineIntValue();
            Console.WriteLine("Введите значение второй границы: ");
            int secondRangeBorder = ConsoleHelper.ReadlineIntValue();

            if (firstRangeBorder > secondRangeBorder)
                CalculationHelper.Rearrangement(ref firstRangeBorder, ref secondRangeBorder);

            Console.WriteLine($"Вывод значений чисел в диапазоне от {firstRangeBorder} до {secondRangeBorder}"); ;

            int numberRangeSum = OperationFactory.NumberRangeSumOperation.Operation(firstRangeBorder, secondRangeBorder);
            Console.WriteLine($"Сумма чисел в диапазоне: {numberRangeSum}");
        }
    }
}
