namespace GeekBrainsCSharpBasics.Lesson3
{
    public class ComplexNumberInput : IInputData
    {
        [InputDescriptionProperty("Действительная часть: ", 0)]
        public int RealNumber { get; set; }

        [InputDescriptionProperty("Мнимая часть: ", 1)]
        public int ImaginaryNumber { get; set; }
    }
}
