using GeekBrainsCSharpBasics.InputDataLibrary;

namespace GeekBrainsCSharpBasics
{
    public class InputValue<TValue> : IInputData
    {
        [InputDescriptionProperty()]
        public TValue Value { get; set; }
    }
}
