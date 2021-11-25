namespace GeekBrainsCSharpBasics
{
    interface ITextParser<TResult>
    {
        TResult Parse(string data);
    }
}
