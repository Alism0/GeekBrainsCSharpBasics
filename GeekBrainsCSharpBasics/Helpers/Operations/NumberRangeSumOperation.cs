using System;

namespace GeekBrainsCSharpBasics
{
    public class NumberRangeSumOperation : ITwoValuesOperation<int, int, int>
    {
        private readonly Action<int, int> _logger;

        public NumberRangeSumOperation(Action<int, int> logger)
        {
            _logger = logger;
        }

        public int Operation(int minRangeValue, int maxRangeValue)
        {
            int sum = 0;
            _logger(minRangeValue, maxRangeValue);
            if (minRangeValue < maxRangeValue)
                sum = Operation(minRangeValue + 1, maxRangeValue);

            return sum + minRangeValue;
        }
    }
}
