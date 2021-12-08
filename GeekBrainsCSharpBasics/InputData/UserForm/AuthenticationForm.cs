using GeekBrainsCSharpBasics.InputDataLibrary;
using System;

namespace GeekBrainsCSharpBasics
{
    public class AuthenticationForm : IInputData, IEquatable<IAccount>, IAccount
    {
        [InputDescriptionProperty("Введите логин: ", 0)]
        public string Login { get; set; }

        [InputDescriptionProperty("Введите пароль: ", 1)]
        public string Password { get; set; }

        public bool Equals(IAccount other) =>
            Login == other.Login && Password == other.Password;
    }
}
