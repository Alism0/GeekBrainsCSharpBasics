using System;

namespace GeekBrainsCSharpBasics.ExceptionsLibrary
{
    public class UnregisteredDataTypeException : Exception
    {
        private const string _message = "Незарегистрированный тип данных";

        public UnregisteredDataTypeException() : base(_message) { }
    }
}
