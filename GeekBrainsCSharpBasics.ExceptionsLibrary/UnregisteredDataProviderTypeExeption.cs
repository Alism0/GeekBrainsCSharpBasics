using System;

namespace GeekBrainsCSharpBasics.ExceptionsLibrary
{
    public class UnregisteredDataProviderTypeExeption : Exception
    {
        private const string _message = "Незарегистрированный тип поставщика данных";

        public UnregisteredDataProviderTypeExeption() : base(_message) { }
    }
}
