using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GeekBrainsCSharpBasics.WinForms.Lesson8
{
    public partial class Questions : Form
    {
        private readonly FormFileProvider<List<Question>> _fileManager;

        private DataEngine<Question> dataEngine;

        private int Index => (int)QuestionNumber.Value - 1;

        private string NewItemIndex => $"#{dataEngine.Count + 1}. ";

        public Questions()
        {
            InitializeComponent();
            _fileManager = new FormFileProvider<List<Question>>();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            dataEngine.Add(new Question(NewItemIndex, false));
            QuestionNumber.Maximum = dataEngine.Count;
            QuestionNumber.Value = dataEngine.Count;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            dataEngine.Remove(Index);
            ChangeValue();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            dataEngine[Index].Text = QuestionText.Text;
            dataEngine[Index].Answer = QuestionAnswer.Checked;
        }

        private void QuestionNumber_ValueChanged(object sender, EventArgs e)
        {
            QuestionText.Text = dataEngine[Index].Text;
            QuestionAnswer.Checked = dataEngine[Index].Answer;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataEngine = new DataEngine<Question>(_fileManager.New());
            ChangeValue();
            Init();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Question> questions = _fileManager.Open();
            if (questions == null)
                return;

            dataEngine = new DataEngine<Question>(questions);
            Init();
            ChangeValue();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) =>
            _fileManager.Save(dataEngine.Select(question => question).ToList());

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) =>
            _fileManager.SaveAs(dataEngine.Select(question => question).ToList());

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) =>
            Close();

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) =>
            MessageBox.Show("Программа для сохранения вопросов", AboutToolStripMenuItem.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void ChangeValue()
        {
            if (dataEngine.Count == 0)
            {
                dataEngine.Add(new Question(NewItemIndex, false));
                QuestionNumber.Value = 1;
            }

            QuestionNumber.Maximum = dataEngine.Count;
            QuestionText.Text = dataEngine[Index].Text;
            QuestionAnswer.Checked = dataEngine[Index].Answer;
        }

        private void Init()
        {
            QuestionText.Enabled = true;
            ControlPanel.Enabled = true;

            QuestionNumber.Value = 1;
            QuestionNumber.Minimum = 1;

            SaveAsToolStripMenuItem.Enabled = true;
            SaveToolStripMenuItem.Enabled = true;
        }
    }
}
