using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GeekBrainsCSharpBasics.WinForms.Lesson8
{
    public partial class NotesLog : Form
    {
        private const string DateTimeFormat = "dd.MM.yy HH:mm:ss";

        private readonly FormFileProvider<List<LogNote>> _fileManager;

        private DataEngine<LogNote> dataEngine;

        private int Index => (int)LogNoteNumber.Value - 1;

        private string NewItemIndex => $"#{dataEngine.Count + 1}. ";

        public NotesLog()
        {
            InitializeComponent();
            _fileManager = new FormFileProvider<List<LogNote>>();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            dataEngine.Add(new LogNote(NewItemIndex, DateTime.Now));
            LogNoteNumber.Maximum = dataEngine.Count;
            LogNoteNumber.Value = dataEngine.Count;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            dataEngine.Remove(Index);
            ChangeValue();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            dataEngine[Index].Text = LogNoteText.Text;
            dataEngine[Index].DateTime = DateTime.Parse(LogNoteDateTime.Text);
        }

        private void QuestionNumber_ValueChanged(object sender, EventArgs e)
        {
            LogNoteText.Text = dataEngine[Index].Text;
            LogNoteDateTime.Text = dataEngine[Index].DateTime.ToString(DateTimeFormat);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataEngine = new DataEngine<LogNote>(_fileManager.New());
            ChangeValue();
            Init();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LogNote> logNotes = _fileManager.Open();
            if (logNotes == null)
                return;

            dataEngine = new DataEngine<LogNote>(logNotes);
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
            MessageBox.Show("Дневник заметок", AboutToolStripMenuItem.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void ChangeValue()
        {
            if (dataEngine.Count == 0)
            {
                dataEngine.Add(new LogNote(NewItemIndex, DateTime.Now));
                LogNoteNumber.Value = 1;
            }

            LogNoteNumber.Maximum = dataEngine.Count;
            LogNoteText.Text = dataEngine[Index].Text;
            LogNoteDateTime.Text = dataEngine[Index].DateTime.ToString(DateTimeFormat);
        }

        private void Init()
        {
            LogNoteText.Enabled = true;
            ControlPanel.Enabled = true;

            LogNoteNumber.Value = 1;
            LogNoteNumber.Minimum = 1;

            SaveAsToolStripMenuItem.Enabled = true;
            SaveToolStripMenuItem.Enabled = true;
        }
    }
}
