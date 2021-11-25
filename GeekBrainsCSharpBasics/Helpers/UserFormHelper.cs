using System;

namespace GeekBrainsCSharpBasics
{
    public static class UserFormHelper
    {
        private const int AuthenticationAttemptsCount = 3;

        public static void Login(IAccount loginData)
        {
            Console.WriteLine($"Форма авторизации{Environment.NewLine}");

            AuthenticationForm authenticationForm = new AuthenticationForm();
            int attemtsCount = 0;
            do
            {
                authenticationForm.InputData();
                if (authenticationForm.Equals(loginData))
                {
                    Console.WriteLine("Добро пожаловать, падаван!");
                    return;
                }

                attemtsCount++;
                if (attemtsCount < AuthenticationAttemptsCount)
                    Console.WriteLine($"Введен неверный логин/пароль. Осталось попыток: {AuthenticationAttemptsCount - attemtsCount}");
            } while (attemtsCount < AuthenticationAttemptsCount);

            Console.WriteLine("Превышено количество попыток входа");
        }

        public static void Registration()
        {
            Console.WriteLine($"Форма регистрации{Environment.NewLine}");

            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.InputData();

            Console.WriteLine($"Добро пожаловать, {registrationForm.Login}!");
        }
    }
}
