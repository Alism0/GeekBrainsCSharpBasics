using System;

namespace GeekBrainsCSharpBasics
{
    public static class FormulasHelper
    {
        public static double CalculateBodyMassIndex(double height, double weight) =>
            weight / Math.Pow(height / 100, 2);

        public static double CalculateTwoPointsDistance(Point point1, Point point2) =>
            Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));

        public static void Rearrangement(ref int value1, ref int value2)
        {
            value1 += value2;
            value2 = value1 - value2;
            value1 -= value2;
        }
    }
}
