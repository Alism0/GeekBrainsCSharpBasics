namespace GeekBrainsCSharpBasics.Lesson1.Exercise2
{
    [InputDescription("Для расчета ИМТ введите данные:\r\n")]
    public class HumanMeasurements: IInputData
    {
        [InputDescriptionProperty("Рост: ", 0)]
        public int Height { get; set; }

        [InputDescriptionProperty("Вес: ", 1)]
        public double Weight { get; set; }
    }
}
