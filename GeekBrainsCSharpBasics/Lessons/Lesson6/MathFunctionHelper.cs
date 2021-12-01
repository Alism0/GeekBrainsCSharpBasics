using System;
using System.Collections.Generic;
using System.Linq;

namespace GeekBrainsCSharpBasics.Lesson6
{
    public static class MathFunctionHelper
    {
        private delegate double OneCoefficientOneVariableMathFunction(double xVariable, double aCoefficient);

        private readonly static Dictionary<MathFunction, OneCoefficientOneVariableMathFunction> MathFunctions =
            new Dictionary<MathFunction, OneCoefficientOneVariableMathFunction>() {
                { MathFunction.QuadraticFunction, (xVariable, aCoefficient) => aCoefficient * Math.Pow(xVariable, 2)},
                { MathFunction.SineFunction, (xVariable, aCoefficient) => aCoefficient * Math.Sin(xVariable)}
            };

        public static void PrintMathFunctionValues()
        {
            Console.WriteLine("Вывод значений функции с одной переменной");
            Console.WriteLine();
            if (!ConsoleManager.ReadKeyYesNoValue("Продолжить? (Y/N)"))
                return;

            List<(double xValue, double yValue)> values = GetFunctionValues();

            Console.WriteLine("Результаты вычисления функции:");
            PrintXYTable(values);
        }

        public static void PrintMathFunctionMinValue()
        {
            Console.WriteLine("Вывод минимального значения функции с одной переменной");
            Console.WriteLine();
            if (!ConsoleManager.ReadKeyYesNoValue("Продолжить? (Y/N)"))
                return;

            List<(double xValue, double yValue)> values = GetFunctionValues(true);

            DataHelper.SaveIntoFile(values.Select(value => value.yValue).ToArray(), PathConstants.BinDataFilePath);
            double[] yValues = DataHelper.LoadFromFile<double>(PathConstants.BinDataFilePath);

            FindMinValue(yValues, out double minValue);

            Console.WriteLine($"Минимальное значение вычислений функции: {minValue}");
        }

        private static List<(double xValue, double yValue)> GetFunctionValues(bool needIncrement = false)
        {
            OneCoefficientOneVariableMathFunction mathFunction = GetFunction();
            double aCoefficient = ConsoleManager.ReadlineValue<double>("Введите значение коэффициента 'a': ");
            double increment = needIncrement ? ConsoleManager.ReadlineValue<double>("Введите приращение 'x': ") : 1;

            Console.WriteLine();
            (double MinValue, double MaxValue) = ConsoleManager.ReadlineDoubleValuesRange();
            Console.WriteLine();

            List<(double xValue, double yValue)> values = new List<(double xValue, double yValue)>();
            for (double x = MinValue; x <= MaxValue; x += increment)
                values.Add((x, mathFunction(x, aCoefficient)));

            return values;
        }

        private static OneCoefficientOneVariableMathFunction GetFunction()
        {
            Console.WriteLine("Выберите функцию:");
            MathFunction mathFunctionKey = ConsoleManager.InputMenuItems(MathFunctions.Keys);

            return MathFunctions[mathFunctionKey];
        }

        private static void PrintXYTable(List<(double xValue, double yValue)> values)
        {
            Console.WriteLine("----- X ----- Y -----");
            foreach ((double xValue, double yValue) in values)
                Console.WriteLine($"| {xValue, 8:0.000} | {yValue, 8:0.000} |");

            Console.WriteLine("---------------------");
        }

        private static void FindMinValue(double[] values, out double minValue) =>
            minValue = values.Min();
    }
}
