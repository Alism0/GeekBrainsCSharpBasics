using GeekBrainsCSharpBasics.AbstractsLibrary;
using System;
using System.Linq;

namespace GeekBrainsCSharpBasics.ArraysLibrary
{
    public class CustomArray
    {
        public int[] Array { get; private set; }

        public int this[int index]
        {
            get => Array[index];
            set => Array[index] = value;
        }

        public CustomArray(int size) =>
            Array = new int[size];

        public CustomArray(int size, int step) : this(size)
        {
            if (step <= 0)
                throw new ArgumentException("Значение шага должно быть больше 0");

            FillByStep(step);
        }

        public CustomArray(IDataProvider<string[]> dataProvider) =>
            Array = dataProvider.Load().ConvertToIntegers();

        public int ElementsSum =>
            Array.Sum();

        public int MaxCount
        {
            get
            {
                int maxValue = Array.Max();
                return Array.Count(value => value == maxValue);
            }
        }

        public int[] Inverse() =>
            Array.Handle(value => -value).ToArray();

        public void Multi(int multiplier) =>
            Array = Array.Handle(value => value * multiplier).ToArray();

        private void FillByStep(int step)
        {
            int[] values = ArraysHelper.CreateRandomValuesArray(Array.Length / step);
            int count = 0;
            for (int i = 0; i < Array.Length - 1; i += step)
                this[i] = values[count++];
        }
    }
}
