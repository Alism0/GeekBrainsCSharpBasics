using GeekBrainsCSharpBasics.InputDataLibrary;

namespace GeekBrainsCSharpBasics.Lesson1.Exercise1
{
    [InputDescription("Ввод данных о пользователе:\r\n")]
    public class Human : Person
    {
        [InputDescriptionProperty("Возраст: ", 2)]
        public int Age { get; set; }

        [InputDescriptionProperty("Рост: ", 3)]
        public int Height { get; set; }

        [InputDescriptionProperty("Вес: ", 4, "#.#")]
        public double Weight { get; set; }
    }
}
