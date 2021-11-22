namespace GeekBrainsCSharpBasics
{
    public interface INumber<TNumber> where TNumber : struct
    {
        TNumber Value { get; }

        INumber<TNumber> Addition(INumber<TNumber> complexNumber);

        INumber<TNumber> Subtraction(INumber<TNumber> complexNumber);

        INumber<TNumber> Multiplication(INumber<TNumber> complexNumber);

        INumber<TNumber> Division(INumber<TNumber> complexNumber);
    }
}
