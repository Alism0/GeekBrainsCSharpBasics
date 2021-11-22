using System;

namespace GeekBrainsCSharpBasics
{
    public struct ComplexNumber
    {
        public int RealNumber { get; }

        public int ImaginaryNumber { get; }

        public ComplexNumber(int realNumber) : this(realNumber, 0) { }

        public ComplexNumber (int realNumber, int imaginaryNumber)
        {
            RealNumber = realNumber;
            ImaginaryNumber = imaginaryNumber;
        }

        public static ComplexNumber operator +(ComplexNumber complexNumber) => 
            complexNumber;

        public static ComplexNumber operator -(ComplexNumber complexNumber) =>
            new ComplexNumber(-complexNumber.RealNumber, -complexNumber.ImaginaryNumber);

        public static ComplexNumber operator +(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber) =>
            new ComplexNumber(
                firstComplexNumber.RealNumber + secondComplexNumber.RealNumber,
                firstComplexNumber.ImaginaryNumber + secondComplexNumber.ImaginaryNumber
                );

        public static ComplexNumber operator -(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber) =>
            firstComplexNumber + (-secondComplexNumber);

        public static ComplexNumber operator *(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber) =>
            new ComplexNumber(
                firstComplexNumber.RealNumber * secondComplexNumber.RealNumber - firstComplexNumber.ImaginaryNumber * secondComplexNumber.ImaginaryNumber,
                firstComplexNumber.RealNumber * secondComplexNumber.ImaginaryNumber + firstComplexNumber.ImaginaryNumber * secondComplexNumber.RealNumber
                );

        public static ComplexNumber operator /(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber) =>
            throw new ArgumentException("На данном уровне моей эволюции сложнА получить второй корень квадрата комплексного числа ¯\\_(ツ)_/¯");
    }
}
