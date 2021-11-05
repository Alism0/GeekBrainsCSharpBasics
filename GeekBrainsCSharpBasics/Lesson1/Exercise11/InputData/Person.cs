namespace GeekBrainsCSharpBasics.Lesson1
{
    public class Person : IInputData
    {
        [InputDescriptionProperty("Имя: ", 0)]
        public string Name { get; set; }

        [InputDescriptionProperty("Фамилия: ", 1)]
        public string Surname { get; set; }
    }
}
