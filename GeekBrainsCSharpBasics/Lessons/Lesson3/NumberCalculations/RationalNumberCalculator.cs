using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics.Lesson3
{
    public class RationalNumberCalculator : Calculator<RationalNumberWrapper, RationalNumber>
    {
        protected override string OperationDescription => "Операции над рациональными числами";
        protected override Dictionary<ArithmeticOperation, ITwoValuesOperation<INumber<RationalNumber>, INumber<RationalNumber>, INumber<RationalNumber>>> Operations =>
            new Dictionary<ArithmeticOperation, ITwoValuesOperation<INumber<RationalNumber>, INumber<RationalNumber>, INumber<RationalNumber>>>
            {
                { ArithmeticOperation.Addition, new AdditionOperation<RationalNumber>() },
                { ArithmeticOperation.Subtraction, new SubtractionOperation<RationalNumber>() },
                { ArithmeticOperation.Multiplication, new MultiplicationOperation<RationalNumber>() },
                { ArithmeticOperation.Division, new DivisionOperation<RationalNumber>() }
            };

        protected override INumber<RationalNumber> InputNumber()
        {
            RationalNumberInput rationalNumberInput = new RationalNumberInput();
            do
            {
                try
                {
                    rationalNumberInput.InputData();
                    return new RationalNumberWrapper(rationalNumberInput.Numerator, rationalNumberInput.Denumerator);
                }
                catch (ArgumentException exeption)
                {
                    Console.WriteLine(exeption.Message);
                }
            } while (true);
        }
    }
}
