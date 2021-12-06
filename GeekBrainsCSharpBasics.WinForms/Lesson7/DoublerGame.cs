using System;
using System.Collections.Generic;
using System.Linq;

namespace GeekBrainsCSharpBasics.WinForms.Lesson7
{
    public class DoublerGame
    {
        private const int MaxNumberValue = 50;

        private readonly static Random _random = new Random();
        private readonly Stack<int> Moves = new Stack<int>();
        private int MinCount;

        public static DoublerGame Instance => new DoublerGame();

        public int ComputerNumber { get; private set; }
        public int UserNumber { get; private set; }
        public int MovesCount { get; private set; }
        public GameResult Result => GetGameResult();

        private DoublerGame() => Reset();

        public void Add() => MakeMove(AddUserNumber());

        public void Multiply() => MakeMove(MultiplyUserNumber());

        public void Reset()
        {
            UserNumber = 0;
            ComputerNumber = NextComputerNumber();
            MovesCount = 0;
            Moves.Clear();
            SetMinCount();
        }

        public void Cancel()
        {
            if (Moves.Any())
                Moves.Pop();

            UserNumber = Moves.Any() ? Moves.Peek() : 0;
            SubtractMoveCount();
        }

        private void MakeMove(int number)
        {
            Moves.Push(number);
            AddMoveCount();
        }

        private int NextComputerNumber() => _random.Next(MaxNumberValue);

        private int AddUserNumber() => ++UserNumber;

        private int MultiplyUserNumber() => UserNumber *= 2;

        private void AddMoveCount() => ++MovesCount;

        private void SubtractMoveCount()
        {
            if (MovesCount > 0)
                --MovesCount;
        }

        private GameResult GetGameResult()
        {
            if (UserNumber == ComputerNumber)
                return MinCount == MovesCount ? GameResult.Win : GameResult.NotMinCountLose;

            if (UserNumber > ComputerNumber)
                return GameResult.MoreThenComputerNumber;

            return GameResult.None;
        }

        private void SetMinCount()
        {
            int value = ComputerNumber;
            MinCount = 0;
            while (value != 0)
            {
                if (value % 2 != 0)
                    value--;
                else
                    value /= 2;
                MinCount++;
            }
        }
    }
}
