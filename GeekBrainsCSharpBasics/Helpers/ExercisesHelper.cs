using System;

namespace GeekBrainsCSharpBasics
{
    public static class ExercisesHelper
    {
        public static void GetPositiveOddNumbersSum()
        {
            Console.WriteLine($"Подсчет суммы положительных нечетных чисел");
            Console.WriteLine($"(для прерывания ввода чисел введите 0){Environment.NewLine}");

            int positiveOddNumbersSum = 0;

            int number;
            do
            {
                Console.WriteLine("Введите число:");
                number = ConsoleHelper.ReadlineIntValue();
                if (number > 0 && number % 2 != 0)
                    positiveOddNumbersSum += number;

            } while (number != 0);

            Console.WriteLine($"Сумма введенных положительных нечетных чисел: {positiveOddNumbersSum}");
        }
    }
}
