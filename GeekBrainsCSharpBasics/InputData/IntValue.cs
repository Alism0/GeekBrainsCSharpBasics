namespace GeekBrainsCSharpBasics
{
    public class IntValue: IInputData
    {
        [InputDescriptionProperty()]
        public int Value { get; set; }
    }
}
