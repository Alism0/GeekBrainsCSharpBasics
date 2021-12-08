using System;

namespace GeekBrainsCSharpBasics.WinForms.Lesson7
{
    public class NumberDetectiveGame
    {
        private const int MaxNumberValue = 100;

        private readonly static Random _random = new Random();

        public static NumberDetectiveGame Instance => new NumberDetectiveGame();

        public int ComputerNumber { get; private set; }
        public int UserNumber { get; private set; }
        public int MovesCount { get; private set; }
        public GameResult Result => GetGameResult();

        private NumberDetectiveGame() => Reset();

        public void Set(int userNumber)
        {
            UserNumber = userNumber;
            AddMoveCount();
        }

        public void Reset()
        {
            UserNumber = 0;
            MovesCount = 0;
            ComputerNumber = NextComputerNumber();
        }

        private GameResult GetGameResult()
        {
            if (UserNumber == ComputerNumber)
                return GameResult.Win;

            return UserNumber < ComputerNumber ? GameResult.LessThenComputerNumber : GameResult.MoreThenComputerNumber;
        }

        private void AddMoveCount() => ++MovesCount;

        private int NextComputerNumber() => _random.Next(MaxNumberValue);
    }
}
