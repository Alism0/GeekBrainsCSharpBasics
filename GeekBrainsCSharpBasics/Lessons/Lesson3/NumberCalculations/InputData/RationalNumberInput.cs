using GeekBrainsCSharpBasics.InputDataLibrary;

namespace GeekBrainsCSharpBasics.Lesson3
{
    public class RationalNumberInput : IInputData
    {
        [InputDescriptionProperty("Числитель: ", 0)]
        public int Numerator { get; set; }

        [InputDescriptionProperty("Знаменатель: ", 1)]
        public int Denumerator { get; set; }
    }
}
