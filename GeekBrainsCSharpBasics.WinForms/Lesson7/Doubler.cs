using System;
using System.Windows.Forms;

namespace GeekBrainsCSharpBasics.WinForms.Lesson7
{
    public partial class Doubler : Form
    {
        private const string GameName = "Удвоитель";

        private readonly DoublerGame _doublerGame;

        public Doubler()
        {
            InitializeComponent();
            _doublerGame = DoublerGame.Instance;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            _doublerGame.Reset();
            UpdateGameInfo();
            ShowComputerNumber();
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            _doublerGame.Add();
            UpdateGameInfo();
            CheckWin();
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            _doublerGame.Multiply();
            UpdateGameInfo();
            CheckWin();
        }

        private void CancelButton_Click(object sender, EventArgs e) =>
            CancelMove();

        private void GameToolStripMenuItem_Click(object sender, EventArgs e) =>
            ShowComputerNumber();

        private void UpdateGameInfo()
        {
            UserNumberLabel.Text = $"Текущее число: {_doublerGame.UserNumber}";
            MovesCountLabel.Text = $"Сделанных ходов: {_doublerGame.MovesCount}";
        }

        private void CheckWin()
        {
            switch (_doublerGame.Result)
            {
                case GameResult.Win:
                    MessageBox.Show("Поздравляем! Вы успешно завершили игру!", GameName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAnotherAttempt();
                    return;
                case GameResult.NotMinCountLose:
                case GameResult.MoreThenComputerNumber:
                    ShowLoseResult();
                    return;
            }
        }

        private void ShowLoseResult()
        {
            string message = _doublerGame.Result == GameResult.NotMinCountLose ? "Количество ходов превышено." : "Число больше искомого.";
            if (MessageBox.Show($"Вы проиграли! {message} \r\n Отменить последний ход?", GameName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CancelMove();
            }
            else
                ShowAnotherAttempt();
        }

        private void ShowAnotherAttempt()
        {
            if (MessageBox.Show("Желаете сыграть еще раз?", GameName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                Close();

            ResetGame();
            ShowComputerNumber();
        }

        private void ShowComputerNumber() =>
            MessageBox.Show($"Получите число: {_doublerGame.ComputerNumber}", GameName, MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void CancelMove()
        {
            _doublerGame.Cancel();
            UpdateGameInfo();
        }

        private void ResetGame()
        {
            _doublerGame.Reset();
            UpdateGameInfo();
        }
    }
}
