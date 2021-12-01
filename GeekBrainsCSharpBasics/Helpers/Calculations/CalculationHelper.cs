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

        public static void Rearrangement<TValue>(ref TValue firstValue, ref TValue secondValue)
        {
            TValue tempValue = firstValue;
            firstValue = secondValue;
            secondValue = tempValue;
        }

        public static void SortRanges(ref int minValue, ref int maxValue)
        {
            if (minValue > maxValue)
                Rearrangement(ref minValue, ref maxValue);
        }

        public static void SortRanges(ref double minValue, ref double maxValue)
        {
            if (minValue > maxValue)
                Rearrangement(ref minValue, ref maxValue);
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

        public static RationalNumber SimplifyRationalNumber(RationalNumber rationalNumber)
        {
            int gcdValue = GetGreatestCommonDivisor(rationalNumber.Numerator, rationalNumber.Denumerator);
            if (gcdValue != 1)
                return new RationalNumber(rationalNumber.Numerator / gcdValue, rationalNumber.Denumerator / gcdValue);

            return rationalNumber;
        }

        public static int GetGreatestCommonDivisor(int firstValue, int secondValue)
        {
            firstValue = Math.Abs(firstValue);
            secondValue = Math.Abs(secondValue);

            while (firstValue != 0 && secondValue != 0)
            {
                if (firstValue > secondValue)
                    firstValue %= secondValue;
                else
                    secondValue %= firstValue;
            }

            return firstValue | secondValue;
        }
    }
}
