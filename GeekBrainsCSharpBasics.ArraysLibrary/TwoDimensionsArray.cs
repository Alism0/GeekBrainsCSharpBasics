using System;

namespace GeekBrainsCSharpBasics.ArraysLibrary
{
    public class TwoDimensionsArray
    {
        public int[,] Array { get; }

        public TwoDimensionsArray(int firstDimensionSize, int secondDimensionSize)
        {
            if (firstDimensionSize <= 0 || secondDimensionSize <= 0)
                throw new ArgumentException("Значние глубины двумерного массива должно быть больше 0");

            Array = new int[firstDimensionSize, secondDimensionSize];
            Fill();
        }

        public int Min => Array.HandleElements((value, result) => value < result ? value : result);

        public int Max => Array.HandleElements((value, result) => value > result ? value : result);

        public int ElementsSum() => Array.HandleElements((value, result) => value + result);

        public int SumElementsGreaterThanValue(int minValue)
        {
            if (Array.TryHandleElements((value, result) => value > minValue ? value + result : result, out int resultValue, out _))
                return resultValue;

            return 0;
        }

        public (int firstIndex, int secondIndex) GetMaxValueIndexes()
        {
            Array.TrySearchElements((value, result) => value > result, out int _, out (int firstIndex, int secondIndex) dimensionIndexes);
            return dimensionIndexes;
        }

        private void Fill()
        {
            int[] values = ArraysHelper.CreateRandomValuesArray(Array.Length);
            int count = 0;
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                    Array[i, j] = values[count++];
            }
        }
    }
}
