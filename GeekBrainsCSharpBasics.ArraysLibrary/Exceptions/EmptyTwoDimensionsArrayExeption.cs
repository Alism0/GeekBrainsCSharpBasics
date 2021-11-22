using System;

namespace GeekBrainsCSharpBasics.ArraysLibrary
{
    public class EmptyTwoDimensionsArrayExeption : Exception
    {
        private const string _message = "Двумерный массив пуст";

        public EmptyTwoDimensionsArrayExeption() : base(_message) { }
    }
}
