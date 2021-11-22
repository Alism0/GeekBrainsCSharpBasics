namespace GeekBrainsCSharpBasics
{
    public interface INumberValue<TValue> where TValue : struct
    {
        TValue NumberValue { get; }
    }
}
