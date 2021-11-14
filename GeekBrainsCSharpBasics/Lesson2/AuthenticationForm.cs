using System;

namespace GeekBrainsCSharpBasics.Lesson2
{
    public class AuthenticationForm : IInputData, IEquatable<AuthenticationForm>
    {
        [InputDescriptionProperty("Введите логин: ", 0)]
        public string Login { get; set; }

        [InputDescriptionProperty("Введите пароль: ", 1)]
        public string Password { get; set; }

        public bool Equals(AuthenticationForm other) =>
            Login == other.Login && Password == other.Password;
    }
}
