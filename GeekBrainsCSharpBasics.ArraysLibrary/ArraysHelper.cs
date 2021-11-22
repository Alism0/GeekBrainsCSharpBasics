using System;

namespace GeekBrainsCSharpBasics.ArraysLibrary
{
    public static class ArraysHelper
    {
        public const int LowerBoundArrayValue = -10_000;
        public const int UpperBoundArrayValue = 10_001;

        private readonly static Random _numberGenerator = new Random();

        public static int[] CreateRandomValuesArray(int size) =>
            CreateRandomValuesArray(size, LowerBoundArrayValue, UpperBoundArrayValue);

        public static int[] CreateRandomValuesArray(int size, int minValue, int maxValue)
        {
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
                array[i] = _numberGenerator.Next(minValue, maxValue);

            return array;
        }

        public static int CountPairs(int[] array, Func<int, int, bool> predicate)
        {
            int count = 0;
            if (array.Length <= 1)
                return count;

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (predicate(array[i - 1], array[i]))
                    count++;
            }

            return count;
        }
    }
}
