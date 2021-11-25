namespace GeekBrainsCSharpBasics
{
    public class RegistrationForm : IInputData
    {
        [InputDescriptionProperty("Введите логин: ", Mask = "^[A-Za-z]{1}[A-Za-z\\d]{1,9}$")]
        public string Login { get; set; }
    }
}
