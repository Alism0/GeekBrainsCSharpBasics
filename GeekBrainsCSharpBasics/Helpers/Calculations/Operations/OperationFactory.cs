using System;

namespace GeekBrainsCSharpBasics
{
    public static class OperationFactory
    {
        private readonly static NumberRangeSumOperation _numberRangeSumOperation =
            new NumberRangeSumOperation((first, _) => Console.WriteLine(first));

        public static ITwoValuesOperation<int, int, int> NumberRangeSumOperation =>
            _numberRangeSumOperation;
    }
}
