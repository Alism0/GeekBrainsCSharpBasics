using System;
using System.Collections.Generic;

namespace GeekBrainsCSharpBasics.Lesson3
{
    public abstract class Calculator<TNumberWrapper, TNumber>
        where TNumberWrapper : INumber<TNumber>
        where TNumber : struct
    {
        protected abstract string OperationDescription { get; }
        protected abstract Dictionary<ArithmeticOperation, ITwoValuesOperation<INumber<TNumber>, INumber<TNumber>, INumber<TNumber>>> Operations { get; }

        public void Calculate()
        {
            Console.WriteLine(OperationDescription);
            Console.WriteLine();

            Console.WriteLine("Введите 1-е число:");
            INumber<TNumber> firstNumber = InputNumber();

            Console.WriteLine("Введите 2-е число:");
            INumber<TNumber> secondNumber = InputNumber();

            Console.WriteLine("Выберите операцию:");
            ArithmeticOperation operation = ConsoleHelper.InputMenuItems(Operations.Keys);
            INumber<TNumber> operationResult = Operations[operation].Operation(firstNumber, secondNumber);

            Console.WriteLine();
            Console.WriteLine($"Результат: {operationResult}");
        }

        protected abstract INumber<TNumber> InputNumber();
    }
}
