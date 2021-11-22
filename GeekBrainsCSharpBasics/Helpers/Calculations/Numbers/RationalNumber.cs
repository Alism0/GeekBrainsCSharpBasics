using System;

namespace GeekBrainsCSharpBasics
{
    public struct RationalNumber
    {
        private int _denumerator;

        public int Numerator { get; }

        public int Denumerator
        {
            get => _denumerator;
            private set => _denumerator = value != 0
                ? value
                : throw new ArgumentException("Знаменатель не может быть равен 0");
        }

        public RationalNumber(int numerator) : this (numerator, 1) { }

        public RationalNumber(int numerator, int denumerator)
        {
            Numerator = numerator;
            _denumerator = denumerator != 0
                ? denumerator
                : throw new ArgumentException("Знаменатель не может быть равен 0");
        }

        public static RationalNumber operator +(RationalNumber rationalNumber) =>
            rationalNumber;

        public static RationalNumber operator -(RationalNumber rationalNumber) =>
            new RationalNumber(-rationalNumber.Numerator, rationalNumber.Denumerator);

        public static RationalNumber operator +(RationalNumber firstRationalNumber, RationalNumber secondRationalNumber) =>
            new RationalNumber(
                firstRationalNumber.Numerator * secondRationalNumber.Denumerator + secondRationalNumber.Numerator * firstRationalNumber.Denumerator,
                firstRationalNumber.Denumerator * secondRationalNumber.Denumerator
                );

        public static RationalNumber operator -(RationalNumber firstRationalNumber, RationalNumber secondRationalNumber) =>
            firstRationalNumber + (-secondRationalNumber);

        public static RationalNumber operator *(RationalNumber firstRationalNumber, RationalNumber secondRationalNumber) =>
            new RationalNumber(
                firstRationalNumber.Numerator * secondRationalNumber.Numerator,
                firstRationalNumber.Denumerator * secondRationalNumber.Denumerator
                );

        public static RationalNumber operator /(RationalNumber firstRationalNumber, RationalNumber secondRationalNumber) =>
            new RationalNumber(
                firstRationalNumber.Numerator * secondRationalNumber.Denumerator,
                firstRationalNumber.Denumerator * secondRationalNumber.Numerator
                );
    }
}
