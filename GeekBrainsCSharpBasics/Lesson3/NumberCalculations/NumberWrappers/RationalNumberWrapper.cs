namespace GeekBrainsCSharpBasics.Lesson3
{
    public class RationalNumberWrapper : INumber<RationalNumber>, INumberValue<double>
    {
        public RationalNumber Value { get; private set; }

        public double NumberValue => (double)Value.Numerator / Value.Denumerator;

        private RationalNumberWrapper() { }

        public RationalNumberWrapper(int realNumber) : this(realNumber, 1) { }

        public RationalNumberWrapper(int realNumber, int imaginaryNumber) =>
            Value = new RationalNumber(realNumber, imaginaryNumber);

        private RationalNumberWrapper(RationalNumber value) =>
            Value = value;

        public INumber<RationalNumber> Addition(INumber<RationalNumber> rationalNumber) =>
            new RationalNumberWrapper(CalculationHelper.SimplifyRationalNumber(Value + rationalNumber.Value));

        public INumber<RationalNumber> Subtraction(INumber<RationalNumber> rationalNumber) =>
            new RationalNumberWrapper(CalculationHelper.SimplifyRationalNumber(Value - rationalNumber.Value));

        public INumber<RationalNumber> Multiplication(INumber<RationalNumber> rationalNumber) =>
            new RationalNumberWrapper(CalculationHelper.SimplifyRationalNumber(Value * rationalNumber.Value));

        public INumber<RationalNumber> Division(INumber<RationalNumber> rationalNumber) =>
            new RationalNumberWrapper(CalculationHelper.SimplifyRationalNumber(Value / rationalNumber.Value));

        public override string ToString() =>
            NumberValue.ToString("0.00");
    }
}
