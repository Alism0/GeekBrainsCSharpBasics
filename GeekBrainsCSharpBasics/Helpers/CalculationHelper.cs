using System;
using System.Collections.Generic;
using System.Linq;

namespace GeekBrainsCSharpBasics
{
    public static class CalculationHelper
    {
        public static double CalculateBodyMassIndex(double height, double weight) =>
            weight / Math.Pow(height / 100, 2);

        public static double CalculateWeightByBodyMassIndex(double height, double bodyMassIndex) =>
            bodyMassIndex * Math.Pow(height / 100, 2);

        public static double CalculateTwoPointsDistance(Point point1, Point point2) =>
            Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));

        public static void Rearrangement(ref int value1, ref int value2)
        {
            value1 += value2;
            value2 = value1 - value2;
            value1 -= value2;
        }

        public static int GetMinValue(params int[] values) =>
            values.Min();

        public static int[] GetDigits(int value)
        {
            value = Math.Abs(value);
            Stack<int> digits = new Stack<int>();
            do
            {
                digits.Push(value % 10);
                value /= 10;
            } while (value > 0);
            return digits.ToArray();
        }
    }
}
