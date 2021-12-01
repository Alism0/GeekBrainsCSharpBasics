using System;

namespace GeekBrainsCSharpBasics
{
    public class UnregisteredDataTypeException : Exception
    {
        private const string _message = "Незарегистрированный тип данных";

        public UnregisteredDataTypeException() : base(_message) { }
    }
}
