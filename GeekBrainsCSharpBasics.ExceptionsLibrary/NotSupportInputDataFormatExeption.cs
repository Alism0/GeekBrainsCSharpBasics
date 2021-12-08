using System;

namespace GeekBrainsCSharpBasics.ExceptionsLibrary
{
    public class NotSupportInputDataFormatExeption : Exception
    {
        private const string _message = "Неподдерживаемый формат входных данных";

        public NotSupportInputDataFormatExeption() : base(_message) { }
    }
}
