using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics.Lesson3
{
    public class ComplexNumberCalculator : Calculator<ComplexNumberWrapper, ComplexNumber>
    {
        protected override string OperationDescription => "Операции над комплексными числами";
        protected override Dictionary<ArithmeticOperation, ITwoValuesOperation<INumber<ComplexNumber>, INumber<ComplexNumber>, INumber<ComplexNumber>>> Operations =>
            new Dictionary<ArithmeticOperation, ITwoValuesOperation<INumber<ComplexNumber>, INumber<ComplexNumber>, INumber<ComplexNumber>>>
            {
                { ArithmeticOperation.Addition, new AdditionOperation<ComplexNumber>() },
                { ArithmeticOperation.Subtraction, new SubtractionOperation<ComplexNumber>() },
                { ArithmeticOperation.Multiplication, new MultiplicationOperation<ComplexNumber>() }
            };

        protected override INumber<ComplexNumber> InputNumber()
        {
            ComplexNumberInput complexNumberInput = new ComplexNumberInput();
            do
            {
                try
                {
                    complexNumberInput.InputData();
                    return new ComplexNumberWrapper(complexNumberInput.RealNumber, complexNumberInput.ImaginaryNumber);
                }
                catch (ArgumentException exeption)
                {
                    Console.WriteLine(exeption.Message);
                }
            } while (true);
        }
    }
}
