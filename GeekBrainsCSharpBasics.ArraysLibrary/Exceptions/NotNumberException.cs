using System;

namespace GeekBrainsCSharpBasics.ArraysLibrary
{
    public class NotNumberException : Exception
    {
        private const string _message = "Элемент не является числом";

        public NotNumberException() : base(_message) { }
    }
}
