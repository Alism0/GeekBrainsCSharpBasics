namespace GeekBrainsCSharpBasics.Lesson3
{
    public class DivisionOperation<TNumber> : ITwoValuesOperation<INumber<TNumber>, INumber<TNumber>, INumber<TNumber>>
        where TNumber : struct
    {
        public INumber<TNumber> Operation(INumber<TNumber> first, INumber<TNumber> second) =>
            first.Division(second);
    }
}
