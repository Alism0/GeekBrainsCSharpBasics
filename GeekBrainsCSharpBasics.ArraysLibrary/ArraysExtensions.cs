using System;
using System.Collections.Generic;
using System.Linq;

namespace GeekBrainsCSharpBasics.ArraysLibrary
{
    public static class ArraysExtensions
    {
        public static TElement[] IncreaseSize<TElement>(this TElement[] array)
        {
            TElement[] buffer = new TElement[array.Length * 2];
            Array.Copy(array, buffer, array.Length);

            return buffer;
        }

        public static int[] ConvertToIntegers(this string[] values) =>
            values.Handle((value) => {
                if (int.TryParse(value, out int intValue))
                    return intValue;
                else
                    throw new NotNumberException();
            }).ToArray();

        public static string[] ConvertToStrings<TElement>(this TElement[] values) =>
            values.Handle(value => value.ToString()).ToArray();

        public static IEnumerable<TReturn> Handle<TElement, TReturn>(this IEnumerable<TElement> values, Func<TElement, TReturn> handler) =>
            values.Select(value => handler(value)).ToArray();


        public static TElement HandleElements<TElement>(this TElement[,] twoDimensionsArray, Func<TElement, TElement, TElement> handler)
        {
            twoDimensionsArray.TryHandleElements(handler, out TElement elementResult, out (int, int) dimensionIndexes);
            return elementResult;
        }

        public static bool TryHandleElements<TElement>(this TElement[,] twoDimensionsArray, Func<TElement, TElement, TElement> handler, out TElement resultElement, out (int firstIndex, int secondIndex) dimensionIndexes)
        {
            if (twoDimensionsArray.Length == 0)
                throw new EmptyTwoDimensionsArrayExeption();

            bool handleResult = false;
            dimensionIndexes = (0, 0);
            resultElement = twoDimensionsArray[0, 0];
            for (int i = 0; i < twoDimensionsArray.GetLength(0); i++)
            {
                for (int j = i == 0 ? 1 : 0; j < twoDimensionsArray.GetLength(0); j++)
                {
                    resultElement = handler(twoDimensionsArray[i, j], resultElement);
                    dimensionIndexes = (i, j);
                    handleResult = true;
                }
            }

            return handleResult;
        }

        public static bool TrySearchElements<TElement>(this TElement[,] twoDimensionsArray, Func<TElement, TElement, bool> handler, out TElement resultElement, out (int firstIndex, int secondIndex) dimensionIndexes)
        {
            if (twoDimensionsArray.Length == 0)
                throw new EmptyTwoDimensionsArrayExeption();

            bool handleResult = false;
            dimensionIndexes = (0, 0);
            resultElement = twoDimensionsArray[0, 0];
            for (int i = 0; i < twoDimensionsArray.GetLength(0); i++)
            {
                for (int j = i == 0 ? 1 : 0; j < twoDimensionsArray.GetLength(0); j++)
                {
                    if (!handler(twoDimensionsArray[i, j], resultElement))
                        continue;

                    resultElement = twoDimensionsArray[i, j];
                    dimensionIndexes = (i, j);
                    handleResult = true;
                }
            }

            return handleResult;
        }

        public static List<List<int>> GetDimensions(this int[,] twoDimensionsArray)
        {

            List<List<int>> dimensions = new List<List<int>>();
            for (int i = 0; i < twoDimensionsArray.GetLength(0); i++)
            {
                List<int> dimension = new List<int>();
                for (int j = 0; j < twoDimensionsArray.GetLength(1); j++)
                    dimension.Add(twoDimensionsArray[i, j]);

                dimensions.Add(dimension);
            }

            return dimensions;
        }
    }
}
