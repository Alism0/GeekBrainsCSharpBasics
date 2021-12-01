namespace GeekBrainsCSharpBasics.Lesson3
{
    public class ComplexNumberWrapper : INumber<ComplexNumber>
    {
        public ComplexNumber Value { get; private set; }

        private ComplexNumberWrapper() { }

        public ComplexNumberWrapper(int realNumber) : this(realNumber, 0) { }

        public ComplexNumberWrapper(int realNumber, int imaginaryNumber) =>
            Value = new ComplexNumber(realNumber, imaginaryNumber);

        private ComplexNumberWrapper(ComplexNumber value) =>
            Value = value;

        public INumber<ComplexNumber> Addition(INumber<ComplexNumber> complexNumber) =>
            new ComplexNumberWrapper(Value + complexNumber.Value);

        public INumber<ComplexNumber> Subtraction(INumber<ComplexNumber> complexNumber) =>
            new ComplexNumberWrapper(Value - complexNumber.Value);

        public INumber<ComplexNumber> Multiplication(INumber<ComplexNumber> complexNumber) =>
            new ComplexNumberWrapper(Value * complexNumber.Value);

        public INumber<ComplexNumber> Division(INumber<ComplexNumber> complexNumber) =>
            new ComplexNumberWrapper(Value / complexNumber.Value);

        public override string ToString() =>
            FormatHelper.FormatComplexNumber(Value);
    }
}
