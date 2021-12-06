using System;
using System.Windows.Forms;

namespace GeekBrainsCSharpBasics.WinForms.Lesson7
{
    public partial class NumberDetective : Form
    {
        private const string GameName = "Угадай число";

        private readonly NumberDetectiveGame _numberDetectiveGame;

        public NumberDetective()
        {
            _numberDetectiveGame = NumberDetectiveGame.Instance;
            InitializeComponent();
        }

        private void EnterNumberButton_Click(object sender, EventArgs e)
        {
            IntInputForm inputForm = new IntInputForm();

            inputForm.OnEnterKeyPress += OnEnterNumberInput;
            inputForm.Show(this);
        }

        private void OnEnterNumberInput(object sender, EventArgs e)
        {
            _numberDetectiveGame.Set((int)sender);
            CheckWin();
        }

        private void NewGameButton_Click(object sender, EventArgs e) =>
            _numberDetectiveGame.Reset();

        private void CheckWin()
        {
            switch (_numberDetectiveGame.Result)
            {
                case GameResult.Win:
                    MessageBox.Show($"Поздравляем! Вы успешно завершили игру! Ваш счет: {_numberDetectiveGame.MovesCount}", GameName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAnotherAttempt();
                    return;
                case GameResult.MoreThenComputerNumber:
                    MessageBox.Show("Искомое число меньше", GameName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                case GameResult.LessThenComputerNumber:
                    MessageBox.Show("Искомое число больше", GameName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }
        }

        private void ShowAnotherAttempt()
        {
            if (MessageBox.Show("Желаете сыграть еще раз?", GameName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                Close();

            _numberDetectiveGame.Reset();
        }
    }
}
