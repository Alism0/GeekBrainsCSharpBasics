using System;

namespace GeekBrainsCSharpBasics
{
    public class NotFoundMenuItemsException: Exception
    {
        private const string _message = "Элементы меню не найдены";

        public NotFoundMenuItemsException() : base(_message) { }
    }
}
