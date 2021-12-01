namespace GeekBrainsCSharpBasics.AbstractsLibrary
{
    public interface ITextParser<TResult> : IParser
    {
        TResult Parse(string data);
    }
}
