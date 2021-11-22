namespace GeekBrainsCSharpBasics
{
    public interface ITwoValuesOperation<TFirst, TSecond, TReturn>
    {
        TReturn Operation(TFirst first, TSecond second);
    }
}
