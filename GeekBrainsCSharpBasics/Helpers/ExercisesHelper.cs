﻿using GeekBrainsCSharpBasics.ArraysLibrary;
using System;

namespace GeekBrainsCSharpBasics
{
    public static class ExercisesHelper
    {
        private const int ArraySize = 20;
        private const int PairDivisor = 3;
        private const int AuthenticationAttemptsCount = 3;

        public static void GetPositiveOddNumbersSum()
        {
            Console.WriteLine($"Подсчет суммы положительных нечетных чисел");
            Console.WriteLine($"(для прерывания ввода чисел введите 0){Environment.NewLine}");

            int positiveOddNumbersSum = 0;

            int number;
            do
            {
                Console.WriteLine("Введите число:");
                number = ConsoleManager.ReadlineIntValue();
                if (number > 0 && number % 2 != 0)
                    positiveOddNumbersSum += number;

            } while (number != 0);

            Console.WriteLine($"Сумма введенных положительных нечетных чисел: {positiveOddNumbersSum}");
        }

        public static void CountPairs()
        {
            int[] array = ArraysHelper.CreateRandomValuesArray(ArraySize, ArraysHelper.LowerBoundArrayValue, ArraysHelper.UpperBoundArrayValue);
            CountPairs(array);
        }

        public static int CountPairs(int[] array)
        {
            Console.WriteLine("Вывод количества пар");
            Console.WriteLine();

            ConsoleManager.PrintValues(array);

            int pairsCount = ArraysHelper.CountPairs(array, (value, nextValue) =>
                value % PairDivisor == 0 && nextValue % PairDivisor != 0 || value % PairDivisor != 0 && nextValue % PairDivisor == 0
            );

            Console.WriteLine($"Количество пар: {pairsCount}");
            return pairsCount;
        }

        public static void Login(IAccount loginData)
        {
            Console.WriteLine($"Форма авторизации{Environment.NewLine}");

            AuthenticationForm authenticationForm = new AuthenticationForm();
            int attemtsCount = 0;
            do
            {
                authenticationForm.InputData();
                if (authenticationForm.Equals(loginData))
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
    }
}
